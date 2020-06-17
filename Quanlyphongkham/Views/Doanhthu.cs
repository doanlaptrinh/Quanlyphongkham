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
    public partial class Doanhthu : DevExpress.XtraEditors.XtraForm
    {
        public Doanhthu()
        {
            InitializeComponent();
        }

        private void Doanhthu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyPhongKhamDataSet.DoanhThu' table. You can move, or remove it, as needed.
            this.doanhThuTableAdapter.Fill(this.quanLyPhongKhamDataSet.DoanhThu);
            // TODO: This line of code loads data into the 'quanLyPhongKhamDataSet11.DoanhThu' table. You can move, or remove it, as needed.


        }
    }
}