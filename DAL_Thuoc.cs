using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Thuoc:DBConnect
    {
        public bool ThemThuoc(DTO_Thuoc th)
        {

            try
            {
                _conn.Open();
                // Create List Sql Parameter
                string cm = "insert into DonThuoc values(@ID,@TenThuoc,@SoLuong,@LieuDung,@DonGia,@GhiChu)";

                SqlCommand cmd;
                cmd = new SqlCommand(cm, _conn);
                cmd.Parameters.AddWithValue("@ID", th.thuoc_id);
                cmd.Parameters.AddWithValue("@TenThuoc", th.thuoc_tenthuoc);
                cmd.Parameters.AddWithValue("@SoLuong", th.thuoc_soLuong);
                cmd.Parameters.AddWithValue("@LieuDung", th.thuoc_lieuDung);
                cmd.Parameters.AddWithValue("@DonGia", th.thuoc_donGia);
                cmd.Parameters.AddWithValue("@GhiChu", th.thuoc_ghiChu);
                

                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _conn.Close();
            }
            return false;

        }
    }
}
