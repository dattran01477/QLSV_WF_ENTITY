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
    class BlKetQua
    {
        public List<BL.KetQua> LayKetQua(int ms)
        {
            Data.DoAn_QLSVEntities1 qlSV = new Data.DoAn_QLSVEntities1();
            var kq = (from p in qlSV.KetQuas
                      where p.msSinhVien == ms
                      select new BL.KetQua
                      {
                          MsSV = p.msSinhVien,
                          Diem = p.Diem,
                          MsMon = p.msMon,
                          TenSinhVien = p.SinhVien.hoTen,
                          TenMonHoc = p.MonHoc.tenMonHoc,
                          NamHoc = p.NamHoc.tenNamHoc
                          
                      });
            List<BL.KetQua> kq1 = new List<KetQua>();
         
          
            kq1.AddRange(kq.ToList());
            foreach (var a in kq1)
            {
                if (a.Diem >= 5 && a.Diem <= 10)
                {
                    a.QuaMon = true;
                }
                else
                    if (a.Diem < 5)
                {
                    a.QuaMon = false;
                }
            }

            return kq1;
        }
        public DataTable LayKetQuaDatatable(int ms)
        {
            Data.DoAn_QLSVEntities1 qlSV = new Data.DoAn_QLSVEntities1();
            var a = (from p in qlSV.SinhViens
                     where p.mssv == ms
                     select p.KetQuas).SingleOrDefault().ToList();
            DataTable tb = new DataTable();
            tb.Columns.Add("tenMonHoc");
            tb.Columns.Add("diem");

            foreach(var b in a)
            {
                tb.Rows.Add(b.MonHoc.tenMonHoc, b.Diem);
            }
            return tb;

        }
        public void ThemDiem(string msSinhVien,string msMonTemp,int diem,string msNamHoc)
        {
            Data.DoAn_QLSVEntities1 qlSV = new Data.DoAn_QLSVEntities1();
            Data.KetQua kq = new Data.KetQua();
            int ms = int.Parse(msSinhVien);
            int msMon = int.Parse(msMonTemp);
          
            bool isDangKy = false;
    

            

            var dsMonDkCuaSinhVien = from a in qlSV.DangKies
                                     group a by a.msSinhVien into g
                                     select new { msSV = g.Key, soMonDk = g.Count(),dsMonDK=g };

            var dsMonDkCua1Sv = (from b in dsMonDkCuaSinhVien
                                where b.msSV == ms
                                select b.dsMonDK).FirstOrDefault();



            foreach(var a in dsMonDkCua1Sv)
            {
                if(a.msMon==msMon)
                {
                    isDangKy =true;
                    
                    break;
                } 
            }

            if(isDangKy)
            {
                var a = (from b in qlSV.KetQuas
                         where b.msMon == msMon && b.msSinhVien == ms
                         select b).FirstOrDefault();

                if(a==null)
                {
                    kq.msSinhVien = ms;
                    kq.msMon = msMon;
                    kq.Diem = diem;
                    kq.msNamHoc = msNamHoc;
                    qlSV.KetQuas.Add(kq);
                    qlSV.SaveChanges();
                    MessageBox.Show("Thanh Cong");
                }
                else
                {
                    MessageBox.Show("Diem Da Ton Tai");
                }
            }
            else
            {
                MessageBox.Show("Chua Dang Ki Mon Hoc");
            }
           


        }
        public double? TinhDiemTB(int msSV)
        {
            Data.DoAn_QLSVEntities1 qlSV = new Data.DoAn_QLSVEntities1();
            var a = (from b in qlSV.SinhViens
                     where b.mssv == msSV
                     select b).SingleOrDefault();
            double? dTB = a.KetQuas.Average(x => x.Diem);

            return dTB;
        }
    }
}
