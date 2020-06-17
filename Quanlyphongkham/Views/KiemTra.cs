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
    public partial class KiemTra : DevExpress.XtraEditors.XtraForm
    {
        public KiemTra()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
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
                string[] data = new string[3];
                data[0] = txtID.Text;
                data[1] = txtTenKiemTra.Text;
                data[2] = txtDonGia.Text;
                con.Open();
                SqlTuongTac s = new SqlTuongTac();
                s.insert(data, 6);
                con.Close();
                MessageBox.Show("Record Insert Successfully!");
                this.kiemTraTableAdapter.Fill(this.quanLyPhongKhamDataSet2.KiemTra);
            }
        }

        private void frmKiemTra_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyPhongKhamDataSet2.KiemTra' table. You can move, or remove it, as needed.
            this.kiemTraTableAdapter.Fill(this.quanLyPhongKhamDataSet2.KiemTra);

        }

        private void btnSua_Click(object sender, EventArgs e)
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
                string sel = "select *from KiemTra where ID='" + ID + "'";
                SqlCommand cmd = new SqlCommand(sel, con);
                SqlDataReader dt = cmd.ExecuteReader();
                if (dt.Read() == true)
                {
                    SqlTuongTac s = new SqlTuongTac();

                    if (txtTenKiemTra.Text != "")
                        s.update("@kiemTra", txtTenKiemTra.Text, 6, ID);
                    if (txtDonGia.Text != "")
                        s.update("@hoaDon", txtDonGia.Text, 6, ID);
                }
                con.Close();
                MessageBox.Show("Record Update Successfully!");
                this.kiemTraTableAdapter.Fill(this.quanLyPhongKhamDataSet2.KiemTra);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
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
                s.del(ID, 6);
                con.Close();
                MessageBox.Show("Record Delete Successfully!");
                this.kiemTraTableAdapter.Fill(this.quanLyPhongKhamDataSet2.KiemTra);
            }
        }
    }
}