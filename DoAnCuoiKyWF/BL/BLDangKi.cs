using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKyWF.BL
{
    class BLDangKi
    {
        public void ThemDangKi(int msSV,int msMonHoc,DateTime tgDangKi,DateTime tgKetThucMon)
        {
            try
            {
                Data.DoAn_QLSVEntities1 qlSV = new Data.DoAn_QLSVEntities1();


                Data.DangKy dk = new Data.DangKy { msSinhVien = msSV, msMon = msMonHoc, NgayDangKy = tgDangKi, NgayKetThucMon = tgKetThucMon };
                qlSV.DangKies.Add(dk);
                qlSV.SaveChanges();
                MessageBox.Show("Thành Công");
            }
            catch
            {
                MessageBox.Show("Thất Bại");
            }
         
        }
    }
}
