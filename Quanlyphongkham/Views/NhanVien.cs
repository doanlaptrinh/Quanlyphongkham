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
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            SqlConnection conect = new SqlConnection();
            conect.ConnectionString = @"Data Source=DESKTOP-P35PM5F\SQLEXPRESS;Initial Catalog=QuanLyPhongKham;Integrated Security=True";
            conect.Open();

            String sql = "SELECT * FROM NhanVien";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conect);
            da.Fill(ds);
            dgvNhanVien.DataSource = ds.Tables[0];
            dgvNhanVien.Refresh();
        }
    }
}