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
    class BLLopHoc
    {
        public DataTable LayLopHocTable()
        {
            Data.DoAn_QLSVEntities1 qlSV = new Data.DoAn_QLSVEntities1();


            var lopHoc = from p in qlSV.Lops
                     select p;

            DataTable tb = new DataTable();
            tb.Columns.Add("namHoc");
            tb.Columns.Add("msLop");
            tb.Columns.Add("siSo");
            tb.Columns.Add("tenKhoa");
            var siSo = from p in qlSV.SinhViens
                       group p by p.msLop into g
                       select new { maLop = g.Key, siSo = g.Count() };
            

            foreach (var i in lopHoc)
            {
                foreach(var l in siSo)
                    if(i.msKhoa==l.maLop)
                    {
                        i.siSo = l.siSo;
                    }
                tb.Rows.Add(i.NamHoc, i.maLop, i.siSo, i.Khoa.tenKhoa);
            }

            return tb;




        }
        public void Them(string ten, String tuoi, String gt, string Khoa)
        {

            Data.DoAn_QLSVEntities1 qlSV = new Data.DoAn_QLSVEntities1();
            int ms = qlSV.GiaoViens.Max(x => x.msGV);
            int msKhoaTemp = (from a in qlSV.Khoas
                              where a.tenKhoa == Khoa
                              select a.maKhoa).FirstOrDefault();
            Data.GiaoVien gv = new Data.GiaoVien { msGV = ms + 1, hoTen = ten, tuoi = int.Parse(tuoi), gioiTinh = gt, msKhoa = msKhoaTemp };
            qlSV.GiaoViens.Add(gv);
            qlSV.SaveChanges();

        }
        public void Xoa(string msGiaoVien)
        {
            int ms = Int32.Parse(msGiaoVien);
            Data.DoAn_QLSVEntities1 qlSV = new Data.DoAn_QLSVEntities1();
            var gv = (from a in qlSV.GiaoViens
                      where a.msGV == ms
                      select a).FirstOrDefault();

            qlSV.GiaoViens.Attach(gv);
            qlSV.GiaoViens.Remove(gv);
            qlSV.SaveChanges();

        }
        public void CapNhat(string msGv, string hoTen, string tuoi, string tenKhoa, string gt)
        {
            Data.DoAn_QLSVEntities1 qlSV = new Data.DoAn_QLSVEntities1();
            int ms = int.Parse(msGv);
            var msKhoa = (from a in qlSV.Khoas
                          where a.tenKhoa == tenKhoa
                          select a.maKhoa).FirstOrDefault();
            var gv = (from a in qlSV.GiaoViens
                      where a.msGV == ms
                      select a).SingleOrDefault();
            if (gv != null)
            {
                gv.msGV = int.Parse(msGv);
                gv.hoTen = hoTen;
                gv.msKhoa = msKhoa;
                gv.gioiTinh = gt;
                gv.tuoi = int.Parse(tuoi);
                qlSV.SaveChanges();
            }

        }
    }
}
