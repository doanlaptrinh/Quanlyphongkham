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

namespace Quanlyphongkham.Views
{
    public partial class BenhAn : DevExpress.XtraEditors.XtraForm
    {
        public BenhAn()
        {
            InitializeComponent();
        }

        private void BenhAn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyPhongKhamDataSet10.KiemTra' table. You can move, or remove it, as needed.
            this.kiemTraTableAdapter.Fill(this.quanLyPhongKhamDataSet10.KiemTra);
            // TODO: This line of code loads data into the 'quanLyPhongKhamDataSet9.DonThuoc' table. You can move, or remove it, as needed.
            this.donThuocTableAdapter.Fill(this.quanLyPhongKhamDataSet9.DonThuoc);
            // TODO: This line of code loads data into the 'quanLyPhongKhamDataSet8.KiemTra' table. You can move, or remove it, as needed.
        
            // TODO: This line of code loads data into the 'quanLyPhongKhamDataSet7.LichSuKham' table. You can move, or remove it, as needed.
            this.lichSuKhamTableAdapter.Fill(this.quanLyPhongKhamDataSet7.LichSuKham);

        }
    }
}