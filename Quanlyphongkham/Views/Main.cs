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
using Quanlyphongkham.Views;
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

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

             
            Views.frmNhanVien myForm = new Views.frmNhanVien();
            if (Application.OpenForms["frmNhanVien"] != null)
            {
            //    //you can use closing or hiding Method
               Application.OpenForms["frmNhanVien"].Close();
            //    //Application.OpenForms["My_Form_Name"].Hide();
            }
            myForm.TopLevel = false;
            myForm.AutoScroll = false;
            xtraTabPage2.Controls.Add(myForm);
            xtraTabPage2.PageVisible = true;
            xtraTabPage2.Show();
            EnterFullScreenMode(myForm);
            myForm.Show();
        }

        private void btnBenhNhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Views.frmBenhNhan myForm = new Views.frmBenhNhan();
            
            if (Application.OpenForms["frmBenhNhan"] != null)
            {
                //    //you can use closing or hiding Method
                Application.OpenForms["frmBenhNhan"].Close();
                //    //Application.OpenForms["My_Form_Name"].Hide();
            }
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            xtraTabPage3.Controls.Add(myForm);
            xtraTabPage3.PageVisible = true;
            xtraTabPage3.Show();
            EnterFullScreenMode(myForm);
            myForm.Show();
        }
        public void EnterFullScreenMode(Form targetForm)
        {
            targetForm.WindowState = FormWindowState.Normal;
            targetForm.FormBorderStyle = FormBorderStyle.None;
            targetForm.WindowState = FormWindowState.Maximized;
            }

        private void btnThuoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Views.Thuoc myForm = new Views.Thuoc();
            if (Application.OpenForms["Thuoc"] != null)
            {
                //    //you can use closing or hiding Method
                Application.OpenForms["Thuoc"].Close();
                //    //Application.OpenForms["My_Form_Name"].Hide();
            }
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            xtraTabPage4.Controls.Add(myForm);
            xtraTabPage4.PageVisible = true;
            xtraTabPage4.Show();
            EnterFullScreenMode(myForm);
            myForm.Show();
        }


       

        private void btnKhamBenh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Views.BenhAn myForm = new Views.BenhAn();
            if (Application.OpenForms["BenhAn"] != null)
            {
                //    //you can use closing or hiding Method
                Application.OpenForms["BenhAn"].Close();
                //    //Application.OpenForms["My_Form_Name"].Hide();
            }
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            xtraTabPage5.Controls.Add(myForm);
            xtraTabPage5.PageVisible = true;
            xtraTabPage5.Show();
            EnterFullScreenMode(myForm);
            myForm.Show();
        }

        private void btnDoanhThu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Views.Doanhthu myForm = new Views.Doanhthu();
            if (Application.OpenForms["Doanhthu"] != null)
            {
                //    //you can use closing or hiding Method
                Application.OpenForms["Doanhthu"].Close();
                //    //Application.OpenForms["My_Form_Name"].Hide();
            }
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            xtraTabPage6.Controls.Add(myForm);
            xtraTabPage6.PageVisible = true;
            xtraTabPage6.Show();
            EnterFullScreenMode(myForm);
            myForm.Show();
        }
        public void Call()
        {
            this.btnNhanVien.Enabled = true;
            btnNhanVien.Enabled = true;
            btnNhanVien.Refresh();
            btnNhanVien.Reset();
            
        }
        void oFrm2_evtFrm()
        {
            btnNhanVien.Enabled = true;
        }
        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ribbonStatusBar7_Click(object sender, EventArgs e)
        {

        }
        private void gridControl6_Click(object sender, EventArgs e)
        {

        }
        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

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

        private void frmMain_AutoSizeChanged(object sender, EventArgs e)
        {
            
            
        }

        private void frmMain_MaximumSizeChanged(object sender, EventArgs e)
        {
            
        }

        private void btnKiemTra_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Views.KiemTra myForm = new Views.KiemTra();
            if (Application.OpenForms["KiemTra"] != null)
            {
                //    //you can use closing or hiding Method
                Application.OpenForms["KiemTra"].Close();
                //    //Application.OpenForms["My_Form_Name"].Hide();
            }
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            xtraTabPage7.Controls.Add(myForm);
            xtraTabPage7.PageVisible = true;
            xtraTabPage7.Show();
            EnterFullScreenMode(myForm);
            myForm.Show();
        }
    }

}

  



