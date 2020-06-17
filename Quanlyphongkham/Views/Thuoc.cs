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
    public partial class Thuoc : DevExpress.XtraEditors.XtraForm
    {
        public Thuoc()
        {
            InitializeComponent();
        }

        private void Thuoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyPhongKhamDataSet4.DonThuoc' table. You can move, or remove it, as needed.
            this.donThuocTableAdapter.Fill(this.quanLyPhongKhamDataSet4.DonThuoc);
            // TODO: This line of code loads data into the 'quanLyPhongKhamDataSet.DonThuoc' table. You can move, or remove it, as needed.
         
           


        }

        private void btnAddNV_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P35PM5F\SQLEXPRESS;Initial Catalog=QuanLyPhongKham;Integrated Security=True");
            string ID = txtIdThuoc.Text;
            if (ID == "")
            {
                MessageBox.Show("Moi nhap ID");
                txtIdThuoc.Select();
            }
            else
            {
                string[] data = new string[6];
                data[0] = txtIdThuoc.Text;
                data[1] = txtTenThuoc.Text;
                data[2] = txtSoLuong.Text;
                data[3] = txtLieuDung.Text;
                data[4] = txtGhiChu.Text;
                data[5] = txtDonGia.Text;

                con.Open();
                SqlTuongTac s = new SqlTuongTac();
                s.insert(data, 3);
                con.Close();
                MessageBox.Show("Record Insert Successfully!");
                this.donThuocTableAdapter.Fill(this.quanLyPhongKhamDataSet4.DonThuoc);
            }
        }

        private void btnUpdateNV_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P35PM5F\SQLEXPRESS;Initial Catalog=QuanLyPhongKham;Integrated Security=True");
            string ID = txtIdThuoc.Text;
            if (ID == "")
            {
                MessageBox.Show("Mời nhập ID");
                txtIdThuoc.Select();
            }
            else
            {
                con.Open();
                string sel = "select *from DonThuoc where ID='" + ID + "'";
                SqlCommand cmd = new SqlCommand(sel, con);
                SqlDataReader dt = cmd.ExecuteReader();
                if (dt.Read() == true)
                {
                    SqlTuongTac s = new SqlTuongTac();

                    if (txtTenThuoc.Text != "")
                        s.update("@tenThuoc", txtTenThuoc.Text, 3, ID);
                    if (txtSoLuong.Text != "")
                        s.update("@soLuong", txtSoLuong.Text, 3, ID);
                    if (txtLieuDung.Text != "")
                        s.update("@lieuDung", txtLieuDung.Text, 3, ID);
                    if (txtGhiChu.Text != "")
                        s.update("@ghiChu", txtGhiChu.Text, 3, ID);
                    if (txtDonGia.Text != "")
                        s.update("@donGia", txtDonGia.Text, 3, ID);
                   
                }
                con.Close();
                MessageBox.Show("Record Update Successfully!");
                this.donThuocTableAdapter.Fill(this.quanLyPhongKhamDataSet4.DonThuoc);
            }
        }

        private void btnDelNV_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P35PM5F\SQLEXPRESS;Initial Catalog=QuanLyPhongKham;Integrated Security=True");
            string ID = txtIdThuoc.Text;
            if (ID == "")
            {
                MessageBox.Show("Mời nhập ID");
                txtIdThuoc.Select();
            }
            else
            {
                con.Open();
                SqlTuongTac s = new SqlTuongTac();
                s.del(ID, 3);
                con.Close();
                MessageBox.Show("Record Delete Successfully!");
                this.donThuocTableAdapter.Fill(this.quanLyPhongKhamDataSet4.DonThuoc);
            }
        }
    }
}