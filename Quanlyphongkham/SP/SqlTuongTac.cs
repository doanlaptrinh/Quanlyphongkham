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
                    d = "Thuoc";
                    break;
                case 4:
                    d = "KhamBenh";
                    break;
                case 5:
                    d = "DoanhThu";
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
            switch(sql)
            {
                case "@hoTen":
                    cm = cm+ "HoTen=@hoTen";
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
                    cmd.Parameters.AddWithValue ("ID", data[4]);
                    cmd.Parameters.AddWithValue("HoTen", data[8]);
                    cmd.Parameters.AddWithValue("GioiTinh", data[3]);
                    cmd.Parameters.AddWithValue("NgaySinh", data[0]);
                    cmd.Parameters.AddWithValue("QueQuan", data[5]);
                  
                    cmd.Parameters.AddWithValue("SoDienThoai", data[6]);
              
                    
                    cmd.Parameters.AddWithValue("Email", data[2]);
                    cmd.Parameters.AddWithValue("ChucVu", data[7]);
                   
                     cmd.Parameters.AddWithValue("PhanQuyen", data[1]);
                 
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
