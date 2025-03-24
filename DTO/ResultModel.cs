using Microsoft.ML.Data;

namespace DTO
{
    public class ResultModel
    {
        [ColumnName("PredictedLabel")]
        public uint PredictedLabel { get; set; }
    }
}
