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
            // TODO: This line of code loads data into the 'quanLyPhongKhamDataSet.BenhNhan' table. You can move, or remove it, as needed.
            this.benhNhanTableAdapter.Fill(this.quanLyPhongKhamDataSet.BenhNhan);


        }

        private void btnAddpatient_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P35PM5F\SQLEXPRESS;Initial Catalog=QuanLyPhongKham;Integrated Security=True");
            string ID = txtIDpatient.Text;
            if (ID == "")
            {
                MessageBox.Show("Moi nhap ID");
                txtIDpatient.Select();
            }
            else
            {
                string[] data = new string[8];
                data[0] = txtIDpatient.Text;
                data[1] = txtNamepatient.Text;
                data[2] = txtGenderpatient.Text;
                data[3] = txtBornpatient.Text;
                data[4] = txtAddresspatient.Text;
                data[5] = txtPhonepatient.Text;
                data[6] = txtJobpatient.Text;
                data[7] = txtNotepatient.Text;

                con.Open();
                SqlTuongTac s = new SqlTuongTac();
                s.insert(data, 2);
                con.Close();
                MessageBox.Show("Record Insert Successfully!");
                this.benhNhanTableAdapter.Fill(this.quanLyPhongKhamDataSet.BenhNhan);
            }
        }

        private void btnDelpatient_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P35PM5F\SQLEXPRESS;Initial Catalog=QuanLyPhongKham;Integrated Security=True");
            string ID = txtIDpatient.Text;
            if (ID == "")
            {
                MessageBox.Show("Mời nhập ID");
                txtIDpatient.Select();
            }
            else
            {
                con.Open();
                SqlTuongTac s = new SqlTuongTac();
                s.del(ID, 2);
                con.Close();
                MessageBox.Show("Record Delete Successfully!");
                this.benhNhanTableAdapter.Fill(this.quanLyPhongKhamDataSet.BenhNhan);
            }
        }

        private void btnUpdatepatient_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P35PM5F\SQLEXPRESS;Initial Catalog=QuanLyPhongKham;Integrated Security=True");
            string ID = txtIDpatient.Text;
            if (ID == "")
            {
                MessageBox.Show("Mời nhập ID");
                txtIDpatient.Select();
            }
            else
            {
                con.Open();
                string sel = "select *from BenhNhan where ID='" + ID + "' ";
                SqlCommand cmd = new SqlCommand(sel, con);
                SqlDataReader dt = cmd.ExecuteReader();
                if (dt.Read() == true)
                {
                    SqlTuongTac s = new SqlTuongTac();
                    if (txtNamepatient.Text != "")
                        s.update("@tenBenhNhan", txtNamepatient.Text, 2, ID);
                    if (txtGenderpatient.Text != "")
                        s.update("@gioiTinh", txtGenderpatient.Text, 2, ID);
                    if (txtBornpatient.Text != "")
                        s.update("@ngaySinh", txtBornpatient.Text, 2, ID);
                    if (txtAddresspatient.Text != "")
                        s.update("@diaChi", txtAddresspatient.Text, 2, ID);
                    if (txtPhonepatient.Text != "")
                        s.update("@dienThoai", txtPhonepatient.Text, 2, ID);
                    if (txtJobpatient.Text != "")
                        s.update("@ngheNghiep", txtJobpatient.Text, 2, ID);
                    if (txtNotepatient.Text != "")
                        s.update("@ghiChu", txtNotepatient.Text, 2, ID);
                }
                con.Close();
                MessageBox.Show("Record Update Successfully!");
                this.benhNhanTableAdapter.Fill(this.quanLyPhongKhamDataSet.BenhNhan);
        }   }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}