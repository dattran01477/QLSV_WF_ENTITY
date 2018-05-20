using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DoAnCuoiKyWF.BL
{
    class BLPhanCong
    {
        public void PhanCong(int msGV,int msMon)
        {
            
            Data.DoAn_QLSVEntities1 qlSV = new Data.DoAn_QLSVEntities1();
            try
            {
                var a = (from t in qlSV.GiaoViens
                         where t.msGV == msGV
                         select t).SingleOrDefault();
                var b = (from r in qlSV.MonHocs
                         where r.msMon == msMon
                         select r).SingleOrDefault();
                
                if(b==null)
                {
                    MessageBox.Show("Không Tồn Tại Môn Học");
                }
                else
                {
                    a.MonHocs.Add(b);
                    qlSV.SaveChanges();
                    MessageBox.Show("Thành Công");
                }
               
            }
            catch
            {
                MessageBox.Show("Môn học đã được đăng kí , vui lòng chọn lại");
            }
          
            
        }
    }
}
