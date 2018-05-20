using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using DevExpress;

namespace DoAnCuoiKyWF
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private string chucVu = null;
        private bool kt = false;
        private bool isDangNhap=false;
        private int msTk;
        private string msNamHoc = null;
        public bool Kt { get => kt; set => kt = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public int MsTk { get => msTk; set => msTk = value; }
        public string MsNamHoc { get => msNamHoc; set => msNamHoc = value; }

        public Form1()
        {
            InitializeComponent();
        }
        public Form1(string chucVu)
        {
            PhanQuyen(chucVu);
        }

        private void btnKhaiBaoNamHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            Form frm = kiemtraform(typeof(NamHoc));
            if (frm == null)
            {
                NamHoc namHoc = new NamHoc();
                namHoc.MdiParent = this;
                namHoc.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnDanhSachLopHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            Form frm = kiemtraform(typeof(LopHoc));
            if (frm == null)
            {
                LopHoc lopHoc = new LopHoc();
                lopHoc.MdiParent = this;
                lopHoc.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnHoSoKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            Form frm = kiemtraform(typeof(Khoa));
            if (frm == null)
            {
                Khoa khoa = new Khoa();
                khoa.MdiParent = this;
                khoa.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnHoSoGiaoVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            Form frm = kiemtraform(typeof(GiaoVien));
            if (frm == null)
            {
                GiaoVien giaoVien = new GiaoVien();
                giaoVien.MdiParent = this;
                giaoVien.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnXemDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnNhapDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            Form frm = kiemtraform(typeof(NhapDiem));
            if (frm == null)
            {
                NhapDiem nhapDiem = new NhapDiem(MsNamHoc);
                nhapDiem.MdiParent = this;
                nhapDiem.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnThemSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

         
            Form frm = kiemtraform(typeof(HocSinh));
            if (frm == null)
            {
                HocSinh hocSinh = new HocSinh();
                hocSinh.MdiParent = this;
                hocSinh.Show();
            }
            else
            {
                frm.Activate();
            }

        }
        private void CapNhatForm()
        {
            if(isDangNhap)
            {
                ///show form học sinh
                HocSinh hocSinh = new HocSinh();
                hocSinh.MdiParent = this;
                hocSinh.Show();

                ///show form nhập điểm
                NhapDiem nhapDiem = new NhapDiem(MsNamHoc);
                nhapDiem.MdiParent = this;
                nhapDiem.Show();

                ///show form giao viên
                GiaoVien giaoVien = new GiaoVien();
                giaoVien.MdiParent = this;
                giaoVien.Show();

                /// show form khóa học
                Khoa khoa = new Khoa();
                khoa.MdiParent = this;
                khoa.Show();

                /// show form lớp học
                LopHoc lopHoc = new LopHoc();
                lopHoc.MdiParent = this;
                lopHoc.Show();

                /// show form năm học
                NamHoc namHoc = new NamHoc();
                namHoc.MdiParent = this;
                namHoc.Show();

               
               

               
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnDangKiMonHoc.Enabled = false;
            btnCapNhatTaiKhoanGV.Enabled = false;
            btnDanhSachLopHoc.Enabled = false;
            btnHoSoGiaoVien.Enabled = false;
            btnHoSoKhoa.Enabled = false;
            btnKhaiBaoNamHoc.Enabled = false;
            btnNhapDiem.Enabled = false;
            btnPhanLopSinhVien.Enabled = false;
            btnThemSinhVien.Enabled = false;
            btnXuatBangDiem.Enabled = false;
            btnTimKiemSinhVien.Enabled = false;
            btnXemDiem.Enabled = false;


        }

        private void btnThongKeHocVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            List<BL.KetQua> kq = new List<BL.KetQua>();
            BL.XtraReport rp = new BL.XtraReport();
   
            BL.BlKetQua ketQua = new BL.BlKetQua();
            kq= ketQua.LayKetQua(MsTk);
            rp.DataSource = kq;


            rp.ShowPreviewDialog();
        }
        private Form kiemtraform(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }

        private void btnPhanLopSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        private void PhanQuyen(string chucVu)
        {
            if(chucVu=="GV")
            {
                btnThemSinhVien.Enabled = true;
                btnTimKiemSinhVien.Enabled = true;
                btnNhapDiem.Enabled = true;

                ///show form nhập điểm
                NhapDiem nhapDiem = new NhapDiem(MsNamHoc);
                nhapDiem.MdiParent = this;
                nhapDiem.Show();

                ///show form giao viên
                GiaoVien giaoVien = new GiaoVien();
                giaoVien.MdiParent = this;
                giaoVien.Show();
            }
            if(chucVu=="SV")
            {
                btnDangKiMonHoc.Enabled = true;
                btnXemDiem.Enabled = true;
                btnXuatBangDiem.Enabled = true;

                ///show form nhập điểm
                NhapDiem nhapDiem = new NhapDiem(MsNamHoc);
                nhapDiem.MdiParent = this;
                nhapDiem.Show();
                
                
            }
            if(chucVu=="AD")
            {
                btnDangKiMonHoc.Enabled = true;
                btnCapNhatTaiKhoanGV.Enabled = true;
                btnDanhSachLopHoc.Enabled = true;
                btnHoSoGiaoVien.Enabled = true;
                btnHoSoKhoa.Enabled = true;
                btnKhaiBaoNamHoc.Enabled = true;
                btnNhapDiem.Enabled = true;
                btnPhanLopSinhVien.Enabled = true;
                btnThemSinhVien.Enabled = true;
                btnXuatBangDiem.Enabled = true;
                btnTimKiemSinhVien.Enabled = true;
                btnXemDiem.Enabled = true;

                CapNhat capNhat = new CapNhat();
                HocSinh hocSinh = new HocSinh();
                NhapDiem nhapDiem = new NhapDiem(MsNamHoc);
                GiaoVien giaoVien = new GiaoVien();
                Khoa khoa = new Khoa();
                LopHoc lopHoc = new LopHoc();
                NamHoc namHoc = new NamHoc();

                ///show form học sinh

                hocSinh.MdiParent = this;
                hocSinh.Show();

                ///show form nhập điểm
               
                nhapDiem.MdiParent = this;
                nhapDiem.Show();

                ///show form giao viên
               
                giaoVien.MdiParent = this;
                giaoVien.Show();

                /// show form khóa học
               
                khoa.MdiParent = this;
                khoa.Show();

                /// show form lớp học
               
                lopHoc.MdiParent = this;
                lopHoc.Show();

                /// show form năm học
               
                namHoc.MdiParent = this;
                namHoc.Show();

                ///show form Cập Nhật
               
               
            }
           
            
        }
        DangNhap dangNhap = new DangNhap();
        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            dangNhap.Show();
            dangNhap.Disposed += DangNhap_Disposed;
           
        }

        private void DangNhap_Disposed(object sender, EventArgs e)
        {
            BL.Users users = new BL.Users();
            BL.BLNamHoc namHoc = new BL.BLNamHoc();
            msNamHoc = namHoc.LayNamHocHienTai();
            Kt = dangNhap.Kt;
            isDangNhap = Kt;
            MsTk = dangNhap.MsTK;
            if(Kt)
            {
                ChucVu = dangNhap.ChucVu;
                PhanQuyen(ChucVu);
                lbTenTaiKhoan.Visible = true;
                lbTenTaiKhoan.Text = users.TimTenTaiKhoan(MsTk, ChucVu);
                

            }

        }

       
        private void KTDangNhap()
        {
            if(isDangNhap)
            {

            }
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           string chucVu = null;
            kt = false;
            isDangNhap = false;

            btnDangKiMonHoc.Enabled = false;
            btnCapNhatTaiKhoanGV.Enabled = false;
            btnDanhSachLopHoc.Enabled = false;
            btnHoSoGiaoVien.Enabled = false;
            btnHoSoKhoa.Enabled = false;
            btnKhaiBaoNamHoc.Enabled = false;
            btnNhapDiem.Enabled = false;
            btnPhanLopSinhVien.Enabled = false;
            btnThemSinhVien.Enabled = false;
            btnXuatBangDiem.Enabled = false;
            btnTimKiemSinhVien.Enabled = false;
            btnXemDiem.Enabled = false;

            CapNhat capNhat = new CapNhat();
            HocSinh hocSinh = new HocSinh();
            NhapDiem nhapDiem = new NhapDiem();
            GiaoVien giaoVien = new GiaoVien();
            Khoa khoa = new Khoa();
            LopHoc lopHoc = new LopHoc();
            NamHoc namHoc = new NamHoc();

            
            hocSinh.Visible = false;
            nhapDiem.Visible = false;
            giaoVien.Visible = false;
            khoa.Visible = false;
            lopHoc.Visible = false;
            namHoc.Visible = false;
        }

        private void btnCapNhatTaiKhoanGV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(CapNhat));
            if (frm == null)
            {
                CapNhat khoa = new CapNhat("GV");
                khoa.MdiParent = this;
                khoa.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnCapNhatTaiKhoanSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(CapNhat));
            if (frm == null)
            {
                CapNhat khoa = new CapNhat("SV");
                khoa.MdiParent = this;
                khoa.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnDangKiMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(DangKyMonHoc));
            if (frm == null)
            {
                DangKyMonHoc khoa = new DangKyMonHoc(MsTk,MsNamHoc);
                khoa.MdiParent = this;
                khoa.Show();
            }
            else
            {
                frm.Activate();
            }
        }
    }
}
