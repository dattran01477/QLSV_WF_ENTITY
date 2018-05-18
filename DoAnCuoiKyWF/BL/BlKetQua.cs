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
        public DataTable LayKetQua()
        {
            Data.DoAn_QLSVEntities1 qlSV = new Data.DoAn_QLSVEntities1();
            var gv = from p in qlSV.KetQuas
                     select p;

            DataTable tb = new DataTable();
            tb.Columns.Add("msMon");
            tb.Columns.Add("msSinhVien");

            tb.Columns.Add("Diem");

          

            foreach (var i in gv)
            {
                tb.Rows.Add(i.msMon,i.msSinhVien,i.Diem);
            }

            return tb;




        }
        public void ThemDiem(string msSinhVien,string msMonTemp,int diem)
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

                if(a.Diem==null)
                {
                    kq.msSinhVien = ms;
                    kq.msMon = msMon;
                    kq.Diem = diem;
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
    }
}
