using BUL;
using System;
using System.Windows.Forms;
namespace GUI
{
    public partial class frm_DuDoan : Form
    {
        DuDoanBUL duDoanBUL = new DuDoanBUL();
        public frm_DuDoan()
        {
            InitializeComponent();
        }

        private void frm_DuDoan_Load(object sender, System.EventArgs e)
        {
        }
        private void btn_Predict_Click(object sender, System.EventArgs e)
        {
            //// Kiểm tra đầu vào
            //if (!int.TryParse(txtTuoi.Text, out int tuoi) || string.IsNullOrWhiteSpace(txtLoaiPhim.Text))
            //{
            //    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
            //    return;
            //}

            //// Tạo input model
            //InputModel input = new InputModel
            //{
            //    Tuoi = tuoi,
            //    TenLoaiPhim = txtLoaiPhim.Text
            //};

            //try
            //{
            //    // Gọi dự đoán bất đồng bộ
            //    List<string> predictedMovies = await duDoanBUL.PredictMoviesByGenreAsync(input);

            //    // Kiểm tra và hiển thị kết quả
            //    if (predictedMovies == null || !predictedMovies.Any())
            //    {
            //        MessageBox.Show("Không tìm thấy phim phù hợp.");
            //        dgv_tranning.DataSource = null;
            //    }
            //    else
            //    {
            //        dgv_tranning.DataSource = predictedMovies
            //            .Select(movie => new { PhimYeuThich = movie }) // Hiển thị danh sách phim
            //            .ToList();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            //}
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //List<InputModel> movieData = duDoanBUL.GetMovieData();
            //dgv_tranning.DataSource = movieData;
        }
    }
}
