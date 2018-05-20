using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DoAnCuoiKyWF
{
    public partial class DangKyMonHoc : DevExpress.XtraEditors.XtraForm
    {
        List<Data.DangKy> dangKy = new List<Data.DangKy>();
        List<Data.MonHoc> dsMonHocCuaKhoa = new List<Data.MonHoc>();
        int msSV;
        string msNamHoc;

        public int MsSV { get => msSV; set => msSV = value; }
        public string MsNamHoc { get => msNamHoc; set => msNamHoc = value; }

        public DangKyMonHoc()
        {
            InitializeComponent();
        }
        public DangKyMonHoc(int msSV,string msNamHoc)
        {
            InitializeComponent();
            this.MsSV = msSV;
            this.MsNamHoc = msNamHoc;
        }

        private void DangKyMonHoc_Load(object sender, EventArgs e)
        {
            lsDSDuKienDangKi.View = View.Details;
            lsDSDuKienDangKi.Items.Clear();
            lsDSDuKienDangKi.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lsDSDuKienDangKi.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            BL.BLKhoa khoa = new BL.BLKhoa();
            var tenKhoa = from p in khoa.LayDanhSachKhoa()
                          select p.tenKhoa;
            foreach (var i in tenKhoa)
            {
                cmbTenKhoa.Items.Add(i);
            }
        }

        private void cmbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbTenKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            BL.BLKhoa khoa = new BL.BLKhoa();
            var tenMonHoc = from a in khoa.LayDanhSachMonHocKhoaList(cmbTenKhoa.Text)
                            select a;
            dsMonHocCuaKhoa = tenMonHoc.ToList();
            cmbMonHoc.Items.Clear();
            foreach (var i in tenMonHoc)
            {
              cmbMonHoc.Items.Add(i.tenMonHoc);
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bool isThem = true;
            
            foreach(ListViewItem a in lsDSDuKienDangKi.Items)
            {
                if(a.Text==cmbMonHoc.Text)
                {
                    isThem = false;
                    MessageBox.Show("Đã Chọn Môn, Vui Lòng Chọn Lại!");
                    break;
                }
            }
            if(isThem==true)
            lsDSDuKienDangKi.Items.Add(cmbMonHoc.Text);    
        }
        private void ReLoadLSV()
        {

        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            //Data.DangKy dk = new Data.DangKy();
            //int msMon;
            //var a = dsMonHocCuaKhoa.FirstOrDefault(x => x.tenMonHoc == cmbMonHoc.Text);
            //msMon = a.msMon;


            //dk.msMon = msMon;
            //dk.msSinhVien = msSV;
            //dk.NgayDangKy = DateTime.Now;
            //dk.NgayKetThucMon = DateTime.Now.AddDays(150);
            BL.BLMonHoc monHoc = new BL.BLMonHoc();
            BL.BLDangKi dangKi = new BL.BLDangKi();
            foreach (ListViewItem a in lsDSDuKienDangKi.Items )
            {
                dangKi.ThemDangKi(MsSV, monHoc.MSMonHoc(a.Text ), DateTime.Now, DateTime.Now.AddDays(150));
            }
        }
    }
}