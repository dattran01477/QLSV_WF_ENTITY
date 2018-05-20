using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKyWF.BL
{
    class KetQua
    {
        int msMon;
        string tenMonHoc;
        string namHoc;
        int msSV;
        string tenSinhVien;
        Boolean quaMon;
        Nullable<double> diem;

        public void pass(Nullable<double> diem)
        {
            if(diem>=5&&diem<=10)
            {
                quaMon = true;
            }
            else
            if(diem<5)
            {
                quaMon = false;
            }
        }

        public Nullable<double> Diem { get => diem; set => diem = value; }
        public int MsSV { get => msSV; set => msSV = value; }
        public int MsMon { get => msMon; set => msMon = value; }
        public bool QuaMon { get => quaMon; set => quaMon = value; }
        public string TenSinhVien { get => tenSinhVien; set => tenSinhVien = value; }
        public string TenMonHoc { get => tenMonHoc; set => tenMonHoc = value; }
        public string NamHoc { get => namHoc; set => namHoc = value; }
    }
}
