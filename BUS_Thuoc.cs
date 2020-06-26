using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_Thuoc
    {
        DAL_Thuoc dal_Thuoc = new DAL_Thuoc();
        public bool ThemThuoc(DTO_Thuoc thuoc)
        {

            return dal_Thuoc.ThemThuoc(thuoc);
        }
    }
}
