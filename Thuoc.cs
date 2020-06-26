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
using BUS;
using DTO;
namespace GUI
{
    public partial class Thuoc : DevExpress.XtraEditors.XtraForm
    {
        BUS_Thuoc bus_Thuoc = new BUS_Thuoc();
        public Thuoc()
        {
            InitializeComponent();
        }

        private void Thuoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyPhongKhamDataSet.DonThuoc' table. You can move, or remove it, as needed.
            this.donThuocTableAdapter.Fill(this.quanLyPhongKhamDataSet.DonThuoc);


        }

        private void btnAddNV_Click(object sender, EventArgs e)
        {
            if (txtIdThuoc.Text != "")
            {
                if (txtDonGia.Text == "")
                {
                    txtDonGia.Text = "0";
                }
                DTO_Thuoc th = new DTO_Thuoc(Convert.ToInt32(txtIdThuoc.Text), txtTenThuoc.Text, txtSoLuong.Text, txtLieuDung.Text,Convert.ToInt32(txtDonGia.Text), txtGhiChu.Text);
                if (bus_Thuoc.ThemThuoc(th))
                {
                    MessageBox.Show("Thêm thành công");
                    this.donThuocTableAdapter.Fill(this.quanLyPhongKhamDataSet.DonThuoc);

                }
                else
                {
                    MessageBox.Show("Thêm ko thành công");
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập ID");
            }
        }
    }
    
}