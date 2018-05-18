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
    class BLKhoa
    {
        public BLKhoa()
        {
        }
        public IQueryable<Data.Khoa> LayDanhSachKhoa()
        {
            Data.DoAn_QLSVEntities1 qlSv = new Data.DoAn_QLSVEntities1();
            var khoa = from p in qlSv.Khoas
                       select p;
            return khoa;
        }
        public DataTable LayDanhSachKhoaDatatable()
        {
            Data.DoAn_QLSVEntities1 qlSv = new Data.DoAn_QLSVEntities1();
            var khoa = from p in qlSv.Khoas
                       select p;
            DataTable temp = new DataTable();
            temp.Columns.Add("msKhoa");
            temp.Columns.Add("tenKhoa");
            temp.Columns.Add("diaDiem");

            foreach(var i in khoa)
            {
                temp.Rows.Add(i.maKhoa, i.tenKhoa, i.diaDiem);
            }
            return temp;

        }
        public void Them(string ten, string diadiemTemp)
        {

            Data.DoAn_QLSVEntities1 qlSV = new Data.DoAn_QLSVEntities1();
            int ms = qlSV.Khoas.Max(x => x.maKhoa);
            
            Data.Khoa khoa = new Data.Khoa { maKhoa = ms + 1, tenKhoa = ten, diaDiem=diadiemTemp };
            qlSV.Khoas.Add(khoa);
            qlSV.SaveChanges();

        }
        public void Xoa(string msKhoa)
        {
            int ms = Int32.Parse(msKhoa);
            Data.DoAn_QLSVEntities1 qlSV = new Data.DoAn_QLSVEntities1();
            var khoa = (from a in qlSV.Khoas
                      where a.maKhoa == ms
                      select a).FirstOrDefault();

            qlSV.Khoas.Attach(khoa);
            qlSV.Khoas.Remove(khoa);
            qlSV.SaveChanges();

        }
        public void CapNhat(string msKhoa, string ten, string diadiemtemp)
        {
            Data.DoAn_QLSVEntities1 qlSV = new Data.DoAn_QLSVEntities1();
            int ms = int.Parse(msKhoa);
          
            var khoa = (from a in qlSV.Khoas
                      where a.maKhoa == ms
                      select a).SingleOrDefault();
            if (khoa != null)
            {
                khoa.maKhoa = ms;
                khoa.tenKhoa = ten;
                khoa.diaDiem = diadiemtemp;
                qlSV.SaveChanges();
            }

        }
        public Data.Khoa Tim(string tenKhoa)
        {
            Data.DoAn_QLSVEntities1 qlSV = new Data.DoAn_QLSVEntities1();
            var khoa = (from c in qlSV.Khoas
                        where c.tenKhoa == tenKhoa
                        select c).SingleOrDefault();
            return khoa;
        }

        public DataTable LayDanhSachGVKhoa(string tenKhoa)
        {
            Data.DoAn_QLSVEntities1 qlSV = new Data.DoAn_QLSVEntities1();
            var msKhoa = (from c in qlSV.Khoas
                        where c.tenKhoa == tenKhoa
                        select c.maKhoa).SingleOrDefault();
            var gv = from c in qlSV.GiaoViens
                     where c.msKhoa == msKhoa
                     select c;

            DataTable tb = new DataTable();
            tb.Columns.Add("MSGV");
            tb.Columns.Add("tenGV");

            foreach(var i in gv)
            {
                tb.Rows.Add(i.msGV, i.hoTen);
            }
            return tb;
            
        }
        public DataTable LayDanhSachMonHocKhoa(string tenKhoa)
        {
            Data.DoAn_QLSVEntities1 qlSV = new Data.DoAn_QLSVEntities1();
            var msKhoa = (from c in qlSV.Khoas
                          where c.tenKhoa == tenKhoa
                          select c.maKhoa).SingleOrDefault();
            var gv = from c in qlSV.MonHocs
                     where c.msKhoa == msKhoa
                     select c;

            DataTable tb = new DataTable();
            tb.Columns.Add("msMonHoc");
            tb.Columns.Add("tenMonHoc");

            foreach (var i in gv)
            {
                tb.Rows.Add(i.msMon, i.tenMonHoc);
            }
            return tb;

        }


    }
    
}
