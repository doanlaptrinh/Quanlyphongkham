using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAL
{
    public class DAL_DangNhap : DBConnect
    {
        public DataTable getThanhVien()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NguoiDung", _conn);
            DataTable dtThanhvien = new DataTable();
            da.Fill(dtThanhvien);
            return dtThanhvien;
        }
        public bool ktThanhVien(DTO_DangNhap tv)
        {
            try
            {
                
                _conn.Open();
                string sql = "select *from NguoiDung where TaiKhoan=@0";
                sql = "select *from NguoiDung where MatKhau=@1";
                SqlCommand cmd = new SqlCommand(sql, _conn);
                cmd.Parameters.AddWithValue("@0", tv.nguoiDung_taiKhoan);
                cmd.Parameters.AddWithValue("@1", tv.nguoiDung_matKhau);

                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    return true;                
                }

                else
                {
                    return false;
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }
        }

        /// <summary>
        /// Sửa thành viên
        /// </summary>
        /// <param name="tv"></param>
        /// <returns></returns>
        //public bool suaThanhVien(DTO_DangNhap tv)
        //{
        //    try
        //    {
        //        // Ket noi
        //        _conn.Open();

        //        // Query string
        //        string SQL = string.Format("UPDATE THANHVIEN SET TV_NAME = '{0}', TV_PHONE = '{1}', TV_EMAIL = '{2}' WHERE TV_ID = {3}", tv.THANHVIEN_NAME, tv.THANHVIEN_PHONE, tv.THANHVIEN_EMAIL, tv.THANHVIEN_ID);

        //        // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
        //        SqlCommand cmd = new SqlCommand(SQL, _conn);

        //        // Query và kiểm tra
        //        if (cmd.ExecuteNonQuery() > 0)
        //            return true;

        //    }
        //    catch (Exception e)
        //    {

        //    }
        //    finally
        //    {
        //        // Dong ket noi
        //        _conn.Close();
        //    }

        //    return false;
        //}

        ///// <summary>
        ///// Xóa thành viên
        ///// </summary>
        ///// <param name="tv"></param>
        ///// <returns></returns>
        //public bool xoaThanhVien(int TV_ID)
        //{
        //    try
        //    {
        //        // Ket noi
        //        _conn.Open();

        //        // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
        //        string SQL = string.Format("DELETE FROM THANHVIEN WHERE TV_ID = {0})", TV_ID);

        //        // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
        //        SqlCommand cmd = new SqlCommand(SQL, _conn);

        //        // Query và kiểm tra
        //        if (cmd.ExecuteNonQuery() > 0)
        //            return true;

        //    }
        //    catch (Exception e)
        //    {

        //    }
        //    finally
        //    {
        //        // Dong ket noi
        //        _conn.Close();
        //    }

        //    return false;
        //}
    }
}
