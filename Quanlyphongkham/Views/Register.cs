using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Configuration;

namespace Quanlyphongkham.Views
{
    public partial class frmRegister : DevExpress.XtraEditors.XtraForm
    {
        public frmRegister()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P35PM5F\SQLEXPRESS;Initial Catalog=QuanLyPhongKham;Integrated Security=True");
       
        private void frmRegister_Load(object sender, EventArgs e)
        {
            //string conString = ConfigurationManager.ConnectionStrings["QLUser"].ConnectionString.ToString();
            //con = new SqlConnection(conString);
            //con.Open();
            skins();
        }
        
        private void btnOK_Click(object sender, EventArgs e)
        {

            con.Open();
            string tk = txtUser.Text;
            string mk = txtPass.Text;
            if (check(tk)==false||check(mk)==false)
            {
                MessageBox.Show("Nhập lại mật khẩu không khớp!", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            if (mk != txtRePass.Text)
            {
                MessageBox.Show("Nhập lại mật khẩu không khớp!", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtRePass.Text = "";
            }
            else
            {
               
                string sql = "select *from NguoiDung where TaiKhoan='" + tk + "' ";
                SqlCommand cmdd = new SqlCommand(sql, con);
                SqlDataReader dta = cmdd.ExecuteReader();
                if (dta.Read() == true )
                {
                    if (MessageBox.Show("Đăng ký thất bại!", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
                        dta.Close();
                    cmdd.Cancel();
                    con.Close();
                }
                else if (txtUser.Text!=" "||txtPass.Text!=" "||txtRePass.Text!=" ")
                    { 
                    dta.Close();
                    cmdd.Cancel();
                    string sqlInsert = " INSERT INTO NguoiDung VALUES (@TaiKhoan,@MatKhau)";
                    SqlCommand cmd = new SqlCommand(sqlInsert, con);
                    cmd.Parameters.AddWithValue("TaiKhoan", txtUser.Text);
                    cmd.Parameters.AddWithValue("MatKhau", txtRePass.Text);
                    
                    cmd.ExecuteNonQuery();
                    if (MessageBox.Show("Đăng ký thành công!", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        this.Hide();
                        frmLogin lg = new frmLogin();
                        lg.ShowDialog();
                        this.Close();
                    }
                }
                
            }
            con.Close();
        }
        public void skins()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Valentine";
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void txtPass_EditValueChanged(object sender, EventArgs e)
        {

        }
        private bool check(string s)
        {
            for(int i=0;i<s.Length;i++)
            {
                if ((s[i] >= 'a' && s[i] <= 'z') || (s[i] >= '0' && s[i] <= '9'))
                {
                    continue;
                }
                else
                    return false;
                
            }
            return true;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn hủy bỏ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                frmLogin lg = new frmLogin();
                lg.ShowDialog();
                this.Close();
            }
        }
    }
}