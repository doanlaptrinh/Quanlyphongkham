using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Quanlyphongkham.Views
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        static string id;

        public static string Id { get => id; }

        public void skins()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Valentine";
        }
        private bool checkquyen(string id)
        {
          
                if (id=="1")
                {
                   return true;
                }
            return false;
            
          
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            SqlConnection conect = new SqlConnection(@"Data Source=DESKTOP-P35PM5F\SQLEXPRESS;Initial Catalog=QuanLyPhongKham;Integrated Security=True");
            //try
            //{
                conect.Open();

                string tk = txtUser.Text;
                string mk = txtPass.Text;
                string sql = "select *from NguoiDung where TaiKhoan=@0"; 
                sql = "select *from NguoiDung where MatKhau=@1";
                SqlCommand cmd = new SqlCommand(sql, conect);
                cmd.Parameters.AddWithValue("@0", txtUser.Text);
                cmd.Parameters.AddWithValue("@1", txtPass.Text);
                
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    id = dta[2].ToString();
                    this.Hide();
                    frmMain Main= new frmMain();
                    SqlDataAdapter da = new SqlDataAdapter();

                    Main.ShowDialog();
                    this.Close();
                }

               else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
                conect.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn hủy bỏ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegister Register = new frmRegister();
            Register.ShowDialog();
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
            skins();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPass_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK.PerformClick();
            }
        }
    }
}