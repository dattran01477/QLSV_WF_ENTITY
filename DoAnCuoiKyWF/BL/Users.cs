using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data;
using System.Linq;

namespace DoAnCuoiKyWF.BL
{
    class Users
    {
        public DataTable DanhSachChuaCoTk()
        {
            Data.DoAn_QLSVEntities1 qlSV = new Data.DoAn_QLSVEntities1();
            //var ds = from a in qlSV.GiaoViens
            //         from b in qlSV.user_pass
            //         where a.msGV == b.msTK
            //         select
            var q = from c in qlSV.GiaoViens
                    join p in qlSV.user_pass on c.msGV equals p.msTK into ps
                    from p in ps.DefaultIfEmpty()
                    select new { GiaoVien = c, UserPass = p == null ? 0 : p.msTK };

            var ds = from t in q
                     where t.UserPass == 0
                     select t.GiaoVien;

            DataTable tb = new DataTable();

            tb.Columns.Add("msGV");
            tb.Columns.Add("tenGV");
            tb.Columns.Add("tenKhoa");

            foreach(var a in ds)
            {
                tb.Rows.Add(a.msGV, a.hoTen);
            }

            return tb;

        }
        public void CapPhatTaiKhoan(string id,string chucVu)
        {
            
            Data.DoAn_QLSVEntities1 qlSV = new Data.DoAn_QLSVEntities1();
            if(chucVu=="GV")
            {
                try
                {
                    int ms = int.Parse(id);

                    Data.user_pass gv = new Data.user_pass { msTK = ms, password = ms.ToString() };
                    Data.ChucVu cv = new Data.ChucVu { mstk = ms, ChucVu1 = "GV" };
                    qlSV.user_pass.Add(gv);
                    qlSV.ChucVus.Add(cv);
                    qlSV.SaveChanges();
                }
                catch(EntitySqlException e)
                {
                    MessageBox.Show(e.Message);
                }
               
            }

        }
    }
}
