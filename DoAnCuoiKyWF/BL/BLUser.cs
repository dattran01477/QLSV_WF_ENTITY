using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKyWF.BL
{
    class BLUser
    {
        public Boolean KiemTraDanhTinh(string User,string pass,string chucVu,string err)
        {
            Data.DoAn_QLSVEntities1 qlSV = new Data.DoAn_QLSVEntities1();
             
                if (chucVu == "SV")
                {
                int ms = int.Parse(User);
                var a = from b in qlSV.ChucVus
                            where b.ChucVu1 == "SV"
                            select b.mstk;
                    var t = (from c in a
                             join b in qlSV.user_pass on c equals b.msTK
                             where b.msTK == ms
                             select b).SingleOrDefault();
                    if (t != null)
                    {
                        if (t.password == pass)
                            return true;
                    }
                }
                if (chucVu == "GV")
                {
                int ms = int.Parse(User);

                    var a = from b in qlSV.ChucVus
                            where b.ChucVu1 == chucVu
                            select b.mstk;
                var t = (from c in a
                         join b in qlSV.user_pass on c equals b.msTK
                         where b.msTK == ms
                             select b).SingleOrDefault();
                    if(t!=null)
                    {
                        if (t.password == pass)
                            return true;
                    }

                }
                if (chucVu == "AD")
                {
                int ms = int.Parse(User);
                var a = from b in qlSV.ChucVus
                            where b.ChucVu1 == "AD"
                            select b.mstk;
                    var t = (from c in a
                             join b in qlSV.user_pass on c equals b.msTK
                             where b.msTK == ms
                             select b).SingleOrDefault();
                    if (t != null)
                    {
                        if (t.password == pass)
                            return true;
                    }
                }
                
            
            

            return false;

            
            
            
        }
    }
}
