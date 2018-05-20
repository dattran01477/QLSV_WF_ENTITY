using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKyWF.BL
{
     public class KQDanhSachMonHocCuaSV
    {
        int msMon;
        int msSV;
        string tenSinhVien;
        Boolean quaMon;
        Nullable<double> diem;



        public Nullable<double> Diem { get => diem; set => diem = value; }
        public int MsSV { get => msSV; set => msSV = value; }
        public int MsMon { get => msMon; set => msMon = value; }
        public bool QuaMon { get => quaMon; set => quaMon = value; }
        public string TenSinhVien { get => tenSinhVien; set => tenSinhVien = value; }
    }
}
