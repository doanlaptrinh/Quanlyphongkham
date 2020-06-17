using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Quanlyphongkham.Views
{
    class SqlTuongTac
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P35PM5F\SQLEXPRESS;Initial Catalog=QuanLyPhongKham;Integrated Security=True");
        string cm = "";
        private string checkTable(int Table)
        {
            string d = "";
            switch(Table)
            {
                case 1:
                    d = "NhanVien";
                    break;
                case 2:
                    d = "BenhNhan";
                    break;
                case 3:
                    d = "DonThuoc";
                    break;
                case 4:
                    d = "KhamBenh";
                    break;
                case 5:
                    d = "DoanhThu";
                    break;
                case 6:
                    d = "KiemTra";
                    break;
            }
            return d;
        }
        public void selectID(string data,int ID)
        {
            con.Open();
            string sel = "select *from NhanVien where ID='" + ID + "' ";
            SqlCommand cmd = new SqlCommand(sel, con);
            SqlDataReader dt = cmd.ExecuteReader();
            if (dt.Read() == true)
            {
                SqlTuongTac s = new SqlTuongTac();
      
            }
            con.Close();
        }
        public void update(string sql,string data,int Table,string ID)
        {
            
            cm = "";
            cm = "update "+checkTable(Table)+" set ";
            switch (Table)
            {
                case 1:
                    switch (sql)
                    {
                        case "@hoTen":
                            cm = cm + "HoTen=@hoTen";
                            break;
                        case "@gioiTinh":
                            cm = cm + "GioiTinh=@gioiTinh";
                            break;
                        case "@ngaySinh":
                            cm = cm + "NgaySinh=@ngaySinh";
                            break;
                        case "@queQuan":
                            cm = cm + "QueQuan=@queQuan";
                            break;
                        case "@soDienThoai":
                            cm = cm + "SoDienThoai=@soDienThoai";
                            break;
                        case "@email":
                            cm = cm + "Email=@email";
                            break;
                        case "@chucVu":
                            cm = cm + "ChucVu=@chucVu";
                            break;
                        case "@phanQuyen":
                            cm = cm + "PhanQuyen=@phanQuyen";
                            break;
                    }
                    break;
                case 2:
                    switch (sql)
                    {
                        case "@tenBenhNhan":
                            cm = cm + "TenBenhNhan=@tenBenhNhan";
                            break;
                        case "@gioiTinh":
                            cm = cm + "GioiTinh=@gioiTinh";
                            break;
                        case "@ngaySinh":
                            cm = cm + "NgaySinh=@ngaySinh";
                            break;
                        case "@diaChi":
                            cm = cm + "DiaChi=@diaChi";
                            break;
                        case "@dienThoai":
                            cm = cm + "DienThoai=@dienThoai";
                            break;
                        case "@ngheNghiep":
                            cm = cm + "NgheNghiep=@ngheNghiep";
                            break;
                        case "@ghiChu":
                            cm = cm + "GhiChu=@ghiChu";
                            break;
                    }
                    break;
                case 3:
                    switch (sql)
                    {

                        case "@tenThuoc":
                            cm = cm + "TenThuoc=@tenThuoc";
                            break;
                        case "@soLuong":
                            cm = cm + "SoLUong=@soLuong";
                            break;
                        case "@lieuDung":
                            cm = cm + "LieuDung=@lieuDung";
                            break;
                        case "@donGia":
                            cm = cm + "DonGia=@donGia";
                            break;
                        case "@ghiChu":
                            cm = cm + "GhiChu=@ghiChu";
                            break;
                        
                    }
                    break;
                case 6:
                            switch (sql)
                            {
                                
                                case "@kiemTra":
                                    cm = cm + "KiemTra=@kiemTra";
                                    break;
                                case "@hoaDon":
                                    cm = cm + "HoaDon=@hoaDon";
                                    break;
                            }
                    break;
            }
            con.Open();
            cm = cm+" where ID = @id";
            SqlCommand cmd = new SqlCommand(cm, con);
            cmd.Parameters.AddWithValue(sql, data);
            cmd.Parameters.AddWithValue("@id", ID);
            cmd.ExecuteNonQuery();
            cm = "";
            con.Close();
        }
        public void insert(string []data, int Table)
        {
            cm = "";
            cm = "insert into " + checkTable(Table) + " values  ";
            SqlCommand cmd;
            switch (Table)
            {
                case 1:
                    con.Open();
                    if (data[1] == "")
                        data[1] = "0";
                    if (data[6] == "")
                        data[6] = "0";
                    cm =cm+ "(@ID,@HoTen,@GioiTinh,@NgaySinh,@QueQuan,@SoDienThoai,@Email,@ChucVu,@PhanQuyen)";
                    cmd = new SqlCommand(cm, con);
                    cmd.Parameters.AddWithValue("@ID", data[4]);
                    cmd.Parameters.AddWithValue("@HoTen", data[8]);
                    cmd.Parameters.AddWithValue("@GioiTinh", data[3]);
                    cmd.Parameters.AddWithValue("@NgaySinh", data[0]);
                    cmd.Parameters.AddWithValue("@QueQuan", data[5]);
                    cmd.Parameters.AddWithValue("@SoDienThoai", data[6]);
                    cmd.Parameters.AddWithValue("@Email", data[2]);
                    cmd.Parameters.AddWithValue("@ChucVu", data[7]);
                    cmd.Parameters.AddWithValue("@PhanQuyen", data[1]);
                    cmd.ExecuteNonQuery();
                    break;
                case 2:
                    con.Open();
                    if (data[5] == "")
                        data[5] = "0";
                    cm = cm + "(@ID,@TenBenhNhan,@GioiTinh,@NgaySinh,@DiaChi,@DienThoai,@NgheNghiep,@GhiChu)";
                    cmd = new SqlCommand(cm, con);
                    cmd.Parameters.AddWithValue("@ID", data[0]);
                    cmd.Parameters.AddWithValue("@TenBenhNhan", data[1]);
                    cmd.Parameters.AddWithValue("@GioiTinh", data[2]);
                    cmd.Parameters.AddWithValue("@NgaySinh", data[3]);
                    cmd.Parameters.AddWithValue("@DiaChi", data[4]);
                    cmd.Parameters.AddWithValue("@DienThoai", data[5]);
                    cmd.Parameters.AddWithValue("@NgheNghiep", data[6]);
                    cmd.Parameters.AddWithValue("@GhiChu", data[7]);
                    cmd.ExecuteNonQuery();
                    break;
                case 3:
                    con.Open();
                    if (data[4] == "")
                        data[4] = "0";
                    cm = cm + "(@ID,@TenThuoc,@SoLuong,@LieuDung,@DonGia,@GhiChu)";
                    cmd = new SqlCommand(cm, con);
                    cmd.Parameters.AddWithValue("@ID", data[0]);
                    cmd.Parameters.AddWithValue("@TenThuoc", data[1]);
                    cmd.Parameters.AddWithValue("@SoLuong", data[2]);
                    cmd.Parameters.AddWithValue("@LieuDung", data[3]);
                    cmd.Parameters.AddWithValue("@DonGia", data[4]);
                    cmd.Parameters.AddWithValue("@GhiChu", data[5]);
                    cmd.ExecuteNonQuery();
                    break;
                case 6:
                    con.Open();
                    cm = cm + "(@ID,@KiemTra,@HoaDon)";
                    cmd = new SqlCommand(cm, con);
                    cmd.Parameters.AddWithValue("@ID", data[0]);
                    cmd.Parameters.AddWithValue("@KiemTra", data[1]);
                    cmd.Parameters.AddWithValue("@HoaDon", data[2]);
                    cmd.ExecuteNonQuery();
                    break;
            }

            cm = "";
            con.Close();
        }
        public void del(string ID, int Table)
        {
            cm = "";
            cm = "delete " + checkTable(Table);
            con.Open();
            cm = cm + " where ID = @id";
            SqlCommand cmd = new SqlCommand(cm, con);
            cmd.Parameters.AddWithValue("@id", ID);
            cmd.ExecuteNonQuery();
            cm = "";
            con.Close();
        }


    }

}
