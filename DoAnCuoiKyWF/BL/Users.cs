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
        public DataTable DanhSachChuaCoTk(string gvOrSV)
        {
            Data.DoAn_QLSVEntities1 qlSV = new Data.DoAn_QLSVEntities1();
            DataTable tb = new DataTable();
            //var ds = from a in qlSV.GiaoViens
            //         from b in qlSV.user_pass
            //         where a.msGV == b.msTK
            //         select
            if (gvOrSV=="GV")
            {
                var q = from c in qlSV.GiaoViens
                        join p in qlSV.user_pass on c.msGV equals p.msTK into ps
                        from p in ps.DefaultIfEmpty()
                        select new { GiaoVien = c, UserPass = p == null ? 0 : p.msTK };

                var ds = from t in q
                         where t.UserPass == 0
                         select t.GiaoVien;



                tb.Columns.Add("msGV");
                tb.Columns.Add("tenGV");
                tb.Columns.Add("tenKhoa");

                foreach (var a in ds)
                {
                    tb.Rows.Add(a.msGV, a.hoTen);
                }
            }
            else
            if(gvOrSV=="SV")
            {
                var q = from c in qlSV.SinhViens
                        join p in qlSV.user_pass on c.mssv equals p.msTK into ps
                        from p in ps.DefaultIfEmpty()
                        select new { SinhVien = c, UserPass = p == null ? 0 : p.msTK };

                var ds = from t in q
                         where t.UserPass == 0
                         select t.SinhVien;



                tb.Columns.Add("msSV");
                tb.Columns.Add("tenSV");
                tb.Columns.Add("tenKhoa");

                foreach (var a in ds)
                {
                    tb.Rows.Add(a.mssv, a.hoTen);
                }
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
            else
                if (chucVu == "SV")
            {
                try
                {
                    int ms = int.Parse(id);

                    Data.user_pass sv = new Data.user_pass { msTK = ms, password = ms.ToString() };
                    Data.ChucVu cv = new Data.ChucVu { mstk = ms, ChucVu1 = "SV" };
                    qlSV.user_pass.Add(sv);
                    qlSV.ChucVus.Add(cv);
                    qlSV.SaveChanges();
                }
                catch (EntitySqlException e)
                {
                    MessageBox.Show(e.Message);
                }

            }

        }
        public string TimTenTaiKhoan(int msTk,string chucVu)
        {
            Data.DoAn_QLSVEntities1 qlSV = new Data.DoAn_QLSVEntities1();
            string ten=null;
            if (chucVu=="SV")
            {
                 ten = (from a in qlSV.SinhViens
                              where a.mssv == msTk
                              select a.hoTen).FirstOrDefault();
            }
            if (chucVu == "GV")
            {
                 ten = (from a in qlSV.GiaoViens
                              where a.msGV == msTk
                              select a.hoTen).FirstOrDefault();
            }
            if(chucVu=="AD")
            {
                ten = "Thằng ADMIN Nè!!";
            }
            return ten;
        }
    }
}
