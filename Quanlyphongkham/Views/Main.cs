using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Quanlyphongkham
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();

        }



        private void skins()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Valentine";
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyPhongKhamDataSet5.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.quanLyPhongKhamDataSet5.NhanVien);
            // TODO: This line of code loads data into the 'quanLyPhongKhamDataSet4.NhanVien' table. You can move, or remove it, as needed.
            // this.nhanVienTableAdapter.Fill(this.quanLyPhongKhamDataSet4.NhanVien);
            gridControl8.Visible = false;
            skins();

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có muốn thoát ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
            Views.frmLogin lg = new Views.frmLogin();
            lg.ShowDialog();
            this.Close();
        }

        private void gridControl6_Click(object sender, EventArgs e)
        {

        }

        private void barNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Views.frmNhanVien myForm = new Views.frmNhanVien();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            xtraTabPage2.Controls.Add(myForm);
            xtraTabPage2.PageVisible = true;
            xtraTabPage2.Show();
            myForm.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Views.frmBenhNhan myForm = new Views.frmBenhNhan();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            xtraTabPage3.Controls.Add(myForm);
            xtraTabPage3.PageVisible = true;
            xtraTabPage3.Show();

            myForm.Show();
        }
        private bool checkquyen(string id)
        {

            if (id == "1")
            {
                return true;
            }
            return false;


        }

        private void btnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {




            if (checkquyen(Views.frmLogin.Id) == true)
            {
                Views.frmRegister dk = new Views.frmRegister();
                dk.ShowDialog();

            }
            else
            {
                MessageBox.Show("Khong co quyen truy cap");
            }
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnThuoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Views.Thuoc myForm = new Views.Thuoc();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            xtraTabPage4.Controls.Add(myForm);
            xtraTabPage4.PageVisible = true;
            xtraTabPage4.Show();
            myForm.Show();
        }

        private void tabHienthi_Click(object sender, EventArgs e)
        {

        }



        private void gridControl7_Click(object sender, EventArgs e)
        {

        }

        private void gridControl7_Click_1(object sender, EventArgs e)
        {

        }

        private void btnKhamBenh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Views.BenhAn myForm = new Views.BenhAn();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            xtraTabPage5.Controls.Add(myForm);
            xtraTabPage5.PageVisible = true;
            xtraTabPage5.Show();
            myForm.Show();
        }

        private void btnDoanhThu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Views.Doanhthu myForm = new Views.Doanhthu();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            xtraTabPage6.Controls.Add(myForm);
            xtraTabPage6.PageVisible = true;
            xtraTabPage6.Show();
            myForm.Show();
        }

        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ribbonStatusBar7_Click(object sender, EventArgs e)
        {

        }
    }

}

  



