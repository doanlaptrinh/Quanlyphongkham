using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Quanlyphongkham.Views
{
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            this.nhanVienTableAdapter.Fill(this.quanLyPhongKhamDataSet2.NhanVien);
        }
        private void btnAddnv_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P35PM5F\SQLEXPRESS;Initial Catalog=QuanLyPhongKham;Integrated Security=True");
            string ID = txtID.Text;
            if (ID == "")
            {
                MessageBox.Show("Moi nhap ID");
                txtID.Select();
            }
            else
            {
                string[] data = new string[9];
                data[0] = txtBorn.Text;
                data[1] = txtDecen.Text;
                data[2] = txtEmail.Text;
                data[3] = txtGender.Text;
                data[4] = txtID.Text;
                data[5] = txtNativeLane.Text;
                data[6] = txtNPhone.Text;
                data[7] = txtPosition.Text;
                data[8] = txtTen.Text;
                con.Open();
                SqlTuongTac s = new SqlTuongTac();
                s.insert(data, 1);
                con.Close();
                MessageBox.Show("Record Insert Successfully!");
                this.nhanVienTableAdapter.Fill(this.quanLyPhongKhamDataSet2.NhanVien);
            }
        }    
private void btnUpdateNV_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P35PM5F\SQLEXPRESS;Initial Catalog=QuanLyPhongKham;Integrated Security=True");
            string ID = txtID.Text;
            if(ID=="")
            {
                MessageBox.Show("Mời nhập ID");
                txtID.Select();
            }
            else
            {
                con.Open();
                string sel = "select *from NhanVien where ID='" + ID + "' ";
                SqlCommand cmd = new SqlCommand(sel, con);
                SqlDataReader dt = cmd.ExecuteReader();
                if (dt.Read() == true)
                {
                    SqlTuongTac s = new SqlTuongTac();
                    if (txtTen.Text!="")
                        s.update("@hoTen", txtTen.Text, 1,ID);
                    if (txtGender.Text != "")
                        s.update("@gioiTinh", txtGender.Text, 1, ID);
                    if (txtBorn.Text != "")
                        s.update("@ngaySinh", txtBorn.Text, 1, ID);
                    if (txtNativeLane.Text != "")
                        s.update("@queQuan", txtNativeLane.Text, 1, ID);
                    if (txtNPhone.Text != "")
                        s.update("@soDienThoai", txtNPhone.Text, 1, ID);
                    if (txtEmail.Text != "")
                        s.update("@email", txtEmail.Text, 1, ID);
                    if (txtPosition.Text != "")
                        s.update("@chucVu", txtPosition.Text, 1, ID);
                    if (txtDecen.Text != "")
                        s.update("@phanQuyen", txtDecen.Text, 1, ID);
                }
                con.Close();
                MessageBox.Show("Record Update Successfully!");
                this.nhanVienTableAdapter.Fill(this.quanLyPhongKhamDataSet2.NhanVien);
            }
        }
        private void btnDelNV_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P35PM5F\SQLEXPRESS;Initial Catalog=QuanLyPhongKham;Integrated Security=True");
            string ID = txtID.Text;
            if (ID == "")
            {
                MessageBox.Show("Mời nhập ID");
                txtID.Select();
            }
            else
            {
                con.Open();
                SqlTuongTac s = new SqlTuongTac();
                s.del(ID, 1);
                con.Close();
                MessageBox.Show("Record Delete Successfully!");
                this.nhanVienTableAdapter.Fill(this.quanLyPhongKhamDataSet2.NhanVien);
            }
        }
    }
}