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

namespace Quanlyphongkham.Views
{
    public partial class frmBenhNhan : DevExpress.XtraEditors.XtraForm
    {
        public frmBenhNhan()
        {
            InitializeComponent();
        }

        private void BenhNhan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyPhongKhamDataSet6.BenhNhan' table. You can move, or remove it, as needed.
            this.benhNhanTableAdapter.Fill(this.quanLyPhongKhamDataSet6.BenhNhan);

        }

        private void btnAddpatient_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P35PM5F\SQLEXPRESS;Initial Catalog=QuanLyPhongKham;Integrated Security=True");
            con.Open();
            string ID = txtIDpatient.Text;
            string sql = "select *from BenhNhan where ID='" + ID + "' ";
            SqlCommand cmdd = new SqlCommand(sql, con);
            SqlDataReader dta = cmdd.ExecuteReader();
            if(txtIDpatient.Text=="")
            {
                MessageBox.Show("Chưa nhập ID", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Question);
                dta.Close();
            }
            else if (dta.Read() == true)
            {
                MessageBox.Show("ID đã tồn tại!", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Question);
                dta.Close();
            }
            else
            {
                dta.Close();
                string sqlADDpatient = "insert into BenhNhan values (@ID,@TenBenhNhan,@NgaySinh,@GioiTinh,@DienThoai,@DiaChi,@NgheNghiep,@GhiChu)";

                SqlCommand cmd = new SqlCommand(sqlADDpatient, con);
               
                cmd.Parameters.AddWithValue("ID", txtIDpatient.Text);
                cmd.Parameters.AddWithValue("TenBenhNhan", txtNamepatient.Text);
                cmd.Parameters.AddWithValue("GioiTinh", txtNotepatient.Text);
                cmd.Parameters.AddWithValue("NgaySinh", txtBornpatient.Text);
                cmd.Parameters.AddWithValue("Diachi", txtGenderpatient.Text);
                cmd.Parameters.AddWithValue("DienThoai", txtJobpatient.Text);
                cmd.Parameters.AddWithValue("NgheNghiep", txtAddresspatient.Text);
                cmd.Parameters.AddWithValue("GhiChu", txtPhonepatient.Text);
                cmdd.Cancel();     
                cmd.ExecuteNonQuery();
                this.Hide();
                Views.frmBenhNhan myForm = new Views.frmBenhNhan();
                myForm.Show();
                con.Close();

            }
            cmdd.Cancel();
            con.Close();
        }

        private void btnDelpatient_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P35PM5F\SQLEXPRESS;Initial Catalog=QuanLyPhongKham;Integrated Security=True");
            string ID = txtIDpatient.Text;
            if (Convert.ToInt32(ID) != 0)
            {
                SqlCommand cmd = new SqlCommand("delete BenhNhan where ID=@id", con);
                con.Open();          
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                this.Hide();
                Views.frmBenhNhan myForm = new Views.frmBenhNhan();             
                myForm.Show();

            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
            con.Close();
        }
    }
}