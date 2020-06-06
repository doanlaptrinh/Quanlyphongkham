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
    public partial class Thuoc : DevExpress.XtraEditors.XtraForm
    {
        public Thuoc()
        {
            InitializeComponent();
        }

        private void Thuoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyPhongKhamDataSet3.Thuoc' table. You can move, or remove it, as needed.
            this.thuocTableAdapter.Fill(this.quanLyPhongKhamDataSet3.Thuoc);

        }
    }
}