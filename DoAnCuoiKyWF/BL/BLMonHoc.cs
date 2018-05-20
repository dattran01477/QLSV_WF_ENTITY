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
    class BLMonHoc
    {
        public DataTable LayGiaoVien()
        {
            Data.DoAn_QLSVEntities1 qlSV = new Data.DoAn_QLSVEntities1();

            var gv = from p in qlSV.MonHocs
                     join c in qlSV.Khoas on p.msKhoa equals c.maKhoa
                     select new
                     {
                         tenMonHoc = p.tenMonHoc,
                         msMonHoc = p.msMon,
                         Khoa = c.tenKhoa
                     };
            //var gv = from p in qlSV.GiaoViens
            //         select p;

            DataTable tb = new DataTable();
            tb.Columns.Add("msMonHoc");
            tb.Columns.Add("tenMonHoc");
            tb.Columns.Add("tenKhoa");




            foreach (var i in gv)
            {
                tb.Rows.Add(i.msMonHoc,i.tenMonHoc,i.Khoa);
            }

            return tb;




        }
        public int MSMonHoc(string ten)
        {
            Data.DoAn_QLSVEntities1 qlSV = new Data.DoAn_QLSVEntities1();
            var a = (from b in qlSV.MonHocs
                     where b.tenMonHoc == ten
                     select b.msMon).FirstOrDefault();

            return a;
        }
        public void Them(string ten,string Khoa)
        {

            Data.DoAn_QLSVEntities1 qlSV = new Data.DoAn_QLSVEntities1();
            int ms = qlSV.MonHocs.Max(x => x.msMon);
            int msKhoaTemp = (from a in qlSV.Khoas
                              where a.tenKhoa == Khoa
                              select a.maKhoa).FirstOrDefault();
            Data.MonHoc mh = new Data.MonHoc { msMon=ms+1,tenMonHoc=ten,msKhoa=msKhoaTemp };
            qlSV.MonHocs.Add(mh);
            qlSV.SaveChanges();

        }
        public void Xoa(string msMonHoc)
        {
            int ms = Int32.Parse(msMonHoc);
            Data.DoAn_QLSVEntities1 qlSV = new Data.DoAn_QLSVEntities1();
            var mh = (from a in qlSV.MonHocs
                      where a.msMon == ms
                      select a).FirstOrDefault();

            qlSV.MonHocs.Attach(mh);
            qlSV.MonHocs.Remove(mh);
            qlSV.SaveChanges();

        }
        public void CapNhat(string msMH,string tenMonHoc, string tenKhoa)
        {
            Data.DoAn_QLSVEntities1 qlSV = new Data.DoAn_QLSVEntities1();
            int ms = int.Parse(msMH);

            var msKhoa = (from a in qlSV.Khoas
                          where a.tenKhoa == tenKhoa
                          select a.maKhoa).FirstOrDefault();

            var gv = (from a in qlSV.MonHocs
                      where a.msMon == ms
                      select a).SingleOrDefault();


            if (gv != null)
            {
                gv.msMon = int.Parse(msMH);
                gv.tenMonHoc = tenMonHoc;
                gv.msKhoa = msKhoa;
               
                qlSV.SaveChanges();
            }

        }
    }
}
