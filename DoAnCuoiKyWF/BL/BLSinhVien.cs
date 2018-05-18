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
    class BLSinhVien
    {
        public DataTable LaySinhVien()
        {
            Data.DoAn_QLSVEntities1 qlSV = new Data.DoAn_QLSVEntities1();

            var gv = from p in qlSV.SinhViens
                     join c in qlSV.Khoas on p.msKhoa equals c.maKhoa
                     select new
                     {
                         hoTen = p.hoTen,
                         gioiTinh = p.gioiTinh,
                         tuoi = p.tuoi,
                         msSV = p.mssv,
                         Khoa = c.tenKhoa,
                         diaChi=p.diaChi
                     };
            //var gv = from p in qlSV.GiaoViens
            //         select p;

            DataTable tb = new DataTable();
            tb.Columns.Add("hoTen");
            tb.Columns.Add("gioiTinh");
            tb.Columns.Add("tuoi");
            tb.Columns.Add("msSV");
            tb.Columns.Add("khoa");
            tb.Columns.Add("diaChi");



            if(gv!=null)
            foreach (var i in gv)
            {
                tb.Rows.Add(i.hoTen, i.gioiTinh, i.tuoi, i.msSV, i.Khoa,i.diaChi);
            }

            return tb;




        }
        public void Them(string ten, String tuoi, String gt, string Khoa,string diaChiTemp)
        {

            Data.DoAn_QLSVEntities1 qlSV = new Data.DoAn_QLSVEntities1();
            int ms = qlSV.SinhViens.Max(x => x.mssv);
            int msKhoaTemp = (from a in qlSV.Khoas
                              where a.tenKhoa == Khoa
                              select a.maKhoa).FirstOrDefault();
            Data.SinhVien sv = new Data.SinhVien {  mssv  = ms + 1, hoTen = ten, tuoi = int.Parse(tuoi), gioiTinh = gt, msKhoa = msKhoaTemp,diaChi=diaChiTemp };
            qlSV.SinhViens.Add(sv);
            qlSV.SaveChanges();

        }
        public void Xoa(string msSinhVien)
        {
            int ms = Int32.Parse(msSinhVien);
            Data.DoAn_QLSVEntities1 qlSV = new Data.DoAn_QLSVEntities1();
            var sv = (from a in qlSV.SinhViens
                      where a.mssv == ms
                      select a).FirstOrDefault();

            qlSV.SinhViens.Attach(sv);
            qlSV.SinhViens.Remove(sv);
            qlSV.SaveChanges();

        }
        public void CapNhat(string msGv, string hoTen, string tuoi, string tenKhoa, string gt,string diaChiTemp)
        {
            Data.DoAn_QLSVEntities1 qlSV = new Data.DoAn_QLSVEntities1();
            int ms = int.Parse(msGv);
            var msKhoa = (from a in qlSV.Khoas
                          where a.tenKhoa == tenKhoa
                          select a.maKhoa).FirstOrDefault();
            var sv = (from a in qlSV.SinhViens
                      where a.mssv == ms
                      select a).FirstOrDefault();
            if (sv != null)
            {
                sv.mssv = int.Parse(msGv);
                sv.hoTen = hoTen;
                sv.msKhoa = msKhoa;
                sv.gioiTinh = gt;
                sv.tuoi = int.Parse(tuoi);
                sv.diaChi = diaChiTemp;

                qlSV.SaveChanges();
            }

        }

    }
}

