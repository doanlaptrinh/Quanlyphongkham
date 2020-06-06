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
        
       
        private void frmRegister_Load(object sender, EventArgs e)
        {
            
            skins();
        }
        
        private void btnOK_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P35PM5F\SQLEXPRESS;Initial Catalog=QuanLyPhongKham;Integrated Security=True");
            string tk = txtUser.Text;
            string mk = txtPass.Text;
          
            if (check(tk)==false||check(mk)==false)
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không sử dụng kí tự đặc biệt!", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (mk != txtRePass.Text)
            {
                MessageBox.Show("Nhập lại mật khẩu không khớp!", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtRePass.Text = "";
            }
            else
            {
                
                con.Open();
                string sql = "select *from NguoiDung where TaiKhoan='" + tk + "' ";
                SqlCommand cmdd = new SqlCommand(sql, con);
                SqlDataReader dta = cmdd.ExecuteReader();
                if (dta.Read() == true )
                {
                    if (MessageBox.Show("Tên đăng nhập đã có!", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
                        dta.Close();
                    cmdd.Cancel();
                    con.Close();
                }
                else if (txtUser.Text != " " || txtPass.Text != " " || txtRePass.Text != " " || txtPhanQuyen.Text != " ")
                {
                    dta.Close();
                    cmdd.Cancel();
                    string sqlInsert = " INSERT INTO NguoiDung VALUES (@TaiKhoan,@MatKhau,@PhanQuyen)";
                    SqlCommand cmd = new SqlCommand(sqlInsert, con);
                    cmd.Parameters.AddWithValue("TaiKhoan", txtUser.Text);
                    cmd.Parameters.AddWithValue("MatKhau", txtRePass.Text);
                    cmd.Parameters.AddWithValue("PhanQuyen", txtPhanQuyen.Text);
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