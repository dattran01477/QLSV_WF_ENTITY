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
    class BLGiaoVien
    {
        
        public BLGiaoVien()
        {
           
        }
        public DataTable LayGiaoVien()
        {
            Data.DoAn_QLSVEntities1 qlSV = new Data.DoAn_QLSVEntities1();

            var gv = from p in qlSV.GiaoViens
                     join c in qlSV.Khoas on p.msKhoa equals c.maKhoa
                     select new
                     {
                         hoTen = p.hoTen,
                         gioiTinh = p.gioiTinh,
                         tuoi = p.tuoi,
                         msGV = p.msGV,
                         Khoa = c.tenKhoa
                     };
            //var gv = from p in qlSV.GiaoViens
            //         select p;

            DataTable tb = new DataTable();
            tb.Columns.Add("hoTen");
            tb.Columns.Add("gioiTinh");
            tb.Columns.Add("tuoi");
            tb.Columns.Add("msGV");
            tb.Columns.Add("khoa");




            foreach (var i in gv)
            {
                tb.Rows.Add(i.hoTen, i.gioiTinh, i.tuoi, i.msGV,i.Khoa);
            }

            return tb;
             



        }
        public void Them(string ten,String tuoi,String gt,string Khoa)
        {
           
            Data.DoAn_QLSVEntities1 qlSV = new Data.DoAn_QLSVEntities1();
            int ms = qlSV.GiaoViens.Max(x => x.msGV);
            int msKhoaTemp = (from a in qlSV.Khoas
                         where a.tenKhoa == Khoa
                         select a.maKhoa).FirstOrDefault();
            Data.GiaoVien gv = new Data.GiaoVien { msGV = ms + 1, hoTen=ten,tuoi=int.Parse(tuoi),gioiTinh=gt,msKhoa=msKhoaTemp};
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
        public void CapNhat(string msGv,string hoTen,string tuoi, string tenKhoa,string gt)
        {
            Data.DoAn_QLSVEntities1 qlSV = new Data.DoAn_QLSVEntities1();
            int ms = int.Parse(msGv);
            var msKhoa = (from a in qlSV.Khoas
                           where a.tenKhoa == tenKhoa
                           select a.maKhoa).FirstOrDefault();
            var gv = (from a in qlSV.GiaoViens
                      where a.msGV == ms
                      select a).SingleOrDefault(); 
            if(gv!=null)
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
