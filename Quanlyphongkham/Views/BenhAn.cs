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
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils.Menu;


namespace Quanlyphongkham.Views
{
    public partial class BenhAn : DevExpress.XtraEditors.XtraForm
    {
        public enum GridMultiSelectMode { };

        public virtual GridMultiSelectMode MultiSelectMode { get; set; }
        public BenhAn()
        {
            InitializeComponent();
        }

        private void BenhAn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyPhongKhamDataSet3.PhieuDonThuoc' table. You can move, or remove it, as needed.
            this.phieuDonThuocTableAdapter.Fill(this.quanLyPhongKhamDataSet3.PhieuDonThuoc);
            // TODO: This line of code loads data into the 'quanLyPhongKhamDataSet1.PhieuKiemTra' table. You can move, or remove it, as needed.
            this.phieuKiemTraTableAdapter.Fill(this.quanLyPhongKhamDataSet1.PhieuKiemTra);
            // TODO: This line of code loads data into the 'quanLyPhongKhamDataSet.DonThuoc' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'quanLyPhongKhamDataSet.LichSuKham' table. You can move, or remove it, as needed.
            this.lichSuKhamTableAdapter.Fill(this.quanLyPhongKhamDataSet.LichSuKham);



        }

        private void gridControl4_Click(object sender, EventArgs e)
        {

        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P35PM5F\SQLEXPRESS;Initial Catalog=QuanLyPhongKham;Integrated Security=True");
            string ID = txtGetIDBenhNhan.Text;
            if (ID == "")
            {
                MessageBox.Show("Mời nhập ID");
                txtGetIDBenhNhan.Select();
            }
            else
            {
                con.Open();
                string sel = "";
                SqlCommand cmd = new SqlCommand(sel, con);
                sel = "insert into LichSuKham(IDBenhNhan,TenBenhNhan,NgayKham) values(@iD,(select TenBenhNhan from BenhNhan Where ID=@iD),getdate())";
                cmd = new SqlCommand(sel, con);
                cmd.Parameters.AddWithValue("@iD", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                this.lichSuKhamTableAdapter.Fill(this.quanLyPhongKhamDataSet.LichSuKham);


            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            var rowH = gridView1.FocusedRowHandle; //(rowH ở đây là nó sẽ xác định được bạn đang ở dòng nào)
            var rowHv = gridView1.GetRowCellValue(rowH, gridView1.Columns["ID"]);// (rowHv là giá trị của Id)
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P35PM5F\SQLEXPRESS;Initial Catalog=QuanLyPhongKham;Integrated Security=True");
            string ID = Convert.ToString(rowHv);
            con.Open();
            string cm = "Delete LichSuKham where ID =@id";
            SqlCommand cmd = new SqlCommand(cm, con);
            cmd.Parameters.AddWithValue("@id", ID);
            cmd.ExecuteNonQuery();
            con.Close();
            this.lichSuKhamTableAdapter.Fill(this.quanLyPhongKhamDataSet.LichSuKham);

        }

        private void gridControl1_EmbeddedNavigator_Click(object sender, EventArgs e)
        {
        }

        private void btnThemKiemTra_Click(object sender, EventArgs e)
        {
            string ID=cbIdKiemTra.Text;
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P35PM5F\SQLEXPRESS;Initial Catalog=QuanLyPhongKham;Integrated Security=True");
            if (cbIdKiemTra.Text == "")
            {
                MessageBox.Show("Mời nhập ID");
                cbIdKiemTra.Select();
            }
            else
            {
                con.Open();
                string sel = "";
                SqlCommand cmd = new SqlCommand(sel, con);
                sel = "insert into PhieuKiemTra(LoaiKiemTra,GiaTien) values((select KiemTra from KiemTra Where KiemTra=@ID),(select HoaDon from KiemTra Where KiemTra=@ID))";
                cmd = new SqlCommand(sel, con);
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                this.phieuKiemTraTableAdapter.Fill(this.quanLyPhongKhamDataSet1.PhieuKiemTra);

            }
        }

        private void btnXoaKiemTra_Click(object sender, EventArgs e)
        {
            var rowH = gridView2.FocusedRowHandle; //(rowH ở đây là nó sẽ xác định được bạn đang ở dòng nào)
            var rowHv = gridView2.GetRowCellValue(rowH, gridView2.Columns["STT"]);// (rowHv là giá trị của Id)
            if (Convert.ToString(rowHv) != "")
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P35PM5F\SQLEXPRESS;Initial Catalog=QuanLyPhongKham;Integrated Security=True");
                string STT = Convert.ToString(rowHv);
                con.Open();
                string cm = "Delete PhieuKiemTra where STT =@STT";
                SqlCommand cmd = new SqlCommand(cm, con);
                cmd.Parameters.AddWithValue("@STT", STT);
                cmd.ExecuteNonQuery();
                con.Close();
                this.phieuKiemTraTableAdapter.Fill(this.quanLyPhongKhamDataSet1.PhieuKiemTra);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn vào hàng cần xóa");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThemThuoc_Click(object sender, EventArgs e)
        {
            string ID = cbIdThuoc.Text;
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P35PM5F\SQLEXPRESS;Initial Catalog=QuanLyPhongKham;Integrated Security=True");
            if (cbIdThuoc.Text == "")
            {
                MessageBox.Show("Mời nhập ID");
                cbIdKiemTra.Select();
            }
            else
            {
                con.Open();
                string sel = "";
                SqlCommand cmd = new SqlCommand(sel, con);
                sel = "insert into PhieuDonThuoc(TenThuoc,SoLuong,LieuDung,GhiChu,DonGia) values((select TenThuoc from DonThuoc Where TenThuoc=@ID),@SoLuong,(select LieuDung from DonThuoc Where TenThuoc=@ID),(select GhiChu from DonThuoc Where TenThuoc=@ID),((select DonGia from DonThuoc Where TenThuoc=@ID)*@SoLuong))";
                cmd = new SqlCommand(sel, con);
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@SoLuong", txtSlThuoc.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                this.phieuDonThuocTableAdapter.Fill(this.quanLyPhongKhamDataSet3.PhieuDonThuoc);

            }
        }

        private void gridControl2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnXoaDonThuoc_Click(object sender, EventArgs e)
        {
            
            var rowH = gridView3.FocusedRowHandle; //(rowH ở đây là nó sẽ xác định được bạn đang ở dòng nào)
            var rowHv = gridView3.GetRowCellValue(rowH, gridView2.Columns["STT"]);// (rowHv là giá trị của Id)
            if (Convert.ToString(rowHv) !="")
            {
                         SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P35PM5F\SQLEXPRESS;Initial Catalog=QuanLyPhongKham;Integrated Security=True");
                string STT = Convert.ToString(rowHv);
                con.Open();
                string cm = "Delete PhieuDonThuoc where STT =@STT";
                SqlCommand cmd = new SqlCommand(cm, con);
                cmd.Parameters.AddWithValue("@STT", STT);
                cmd.ExecuteNonQuery();
                con.Close();
                this.phieuDonThuocTableAdapter.Fill(this.quanLyPhongKhamDataSet3.PhieuDonThuoc);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn vào hàng cần xóa");
            }
        }
    }
}