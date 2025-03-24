using DAL;
using DTO;
using Microsoft.ML;
using Microsoft.ML.Data;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace BUL
{
    public class DuDoanBUL
    {

        private readonly DuDoanDAL _duDoanDAL;
        private readonly MLContext _mlContext;
        private ITransformer _model;


        public DuDoanBUL()
        {
            _duDoanDAL = new DuDoanDAL();
            _mlContext = new MLContext();

        }

        public List<InputModel> LoadData(List<InputModel> movieData, int takeCount = 5)
        {
            return movieData.Take(takeCount).ToList();
        }

        public async Task TrainModelAsync(List<InputModel> trainingData, string modelPath)
        {
            // Tải dữ liệu
            IDataView dataView = _mlContext.Data.LoadFromEnumerable(trainingData);

            // Xây dựng pipeline
            EstimatorChain<ClusteringPredictionTransformer<Microsoft.ML.Trainers.KMeansModelParameters>> pipeline = _mlContext.Transforms.Conversion.MapValueToKey("Label", nameof(InputModel.TenPhim))
                .Append(_mlContext.Transforms.Categorical.OneHotEncoding(nameof(InputModel.TenLoaiPhim)))
                .Append(_mlContext.Transforms.Concatenate("Features", nameof(InputModel.Tuoi), nameof(InputModel.TenLoaiPhim)))
                .Append(_mlContext.Clustering.Trainers.KMeans("Features", numberOfClusters: 1));

            // Huấn luyện mô hình
            _model = pipeline.Fit(dataView);

            // Lưu mô hình
            await Task.Run(() => _mlContext.Model.Save(_model, dataView.Schema, modelPath));
        }

        public string PredictMovie(InputModel input, string modelPath, Dictionary<uint, string> labelMapping)
        {
            // Nạp lại mô hình nếu chưa có
            if (_model == null && File.Exists(modelPath))
            {
                using (FileStream stream = new FileStream(modelPath, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    _model = _mlContext.Model.Load(stream, out _);
                }
            }

            // Tạo engine dự đoán
            PredictionEngine<InputModel, ResultModel> predictionEngine = _mlContext.Model.CreatePredictionEngine<InputModel, ResultModel>(_model);
            ResultModel prediction = predictionEngine.Predict(input);

            // Dùng labelMapping để ánh xạ PredictedLabel -> TenPhim
            return ConvertPredictedLabelToString(prediction.PredictedLabel, labelMapping);
        }

        private string ConvertPredictedLabelToString(uint predictedLabel, Dictionary<uint, string> labelMapping)
        {
            return labelMapping.TryGetValue(predictedLabel, out string movieName)
                ? movieName
                : "Unknown Movie";
        }
    }
}
