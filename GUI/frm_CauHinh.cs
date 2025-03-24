using BUL;
using DTO;
using System.Data;
using System.Data.Sql;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_CauHinh : Form
    {
        ConfigBUL bul = new ConfigBUL();
        public Form Pre;

        public frm_CauHinh()
        {
            InitializeComponent();
            //Không thay đổi kích thước form
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public void saveConfig(string server, string user, string pass, string dbname)
        {
            ConfigDTO dto = new ConfigDTO() { Servername = server, Username = user, Password = pass, Database = dbname };
            bul.SaveConfig(dto);
        }

        public DataTable getServername()
        {
            DataTable dt = new DataTable();
            dt = SqlDataSourceEnumerator.Instance.GetDataSources();
            return dt;
        }

        public DataTable getDatabase(string server, string user, string pass)
        {
            ConfigDTO dto = new ConfigDTO();
            dto.Servername = server;
            dto.Username = user;
            dto.Password = pass;
            dto.Database = string.Empty;
            return bul.getDatabase(dto);
        }



        private void btn_Huy_Click(object sender, System.EventArgs e)
        {
            //Form form = new frm_DangNhap();
            //form.Show();
            //this.Hide();
            this.Close();
            this.Pre.Show();
        }

        private void btn_Luu_Click(object sender, System.EventArgs e)
        {
            saveConfig(cbo_Servername.Text, txt_Username.Text, txt_Password.Text, cbo_Databasename.Text);
            MessageBox.Show("Lưu cấu hình thành công");
            this.Close();
            this.Pre.Show();
        }

        private void cbo_Servername_DropDown(object sender, System.EventArgs e)
        {
            cbo_Servername.DataSource = getServername();
            cbo_Servername.DisplayMember = "Servername";
        }

        private void cbo_Databasename_DropDown(object sender, System.EventArgs e)
        {
            DataTable kq = getDatabase(cbo_Servername.Text, txt_Username.Text, txt_Password.Text);
            if (kq != null)
            {
                cbo_Databasename.DataSource = kq;
                cbo_Databasename.DisplayMember = "name";
            }
            else
            {
                MessageBox.Show("Kết nối không thành công");
            }
        }

        private void frm_CauHinh_Load(object sender, System.EventArgs e)
        {

        }
    }
}
