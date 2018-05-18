using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace DoAnCuoiKyWF
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private string chucVu = null;
        private bool kt = false;
        private bool isDangNhap=false;

        public bool Kt { get => kt; set => kt = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }

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
                NhapDiem nhapDiem = new NhapDiem();
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
                NhapDiem nhapDiem = new NhapDiem();
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

                ///show form Cập Nhật
                CapNhat capNhat = new CapNhat();
                capNhat.MdiParent = this;
                capNhat.Show();

               
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnBangDiemMonHoc.Enabled = false;
            btnCapNhatTaiKhoan.Enabled = false;
            btnDanhSachLopHoc.Enabled = false;
            btnHoSoGiaoVien.Enabled = false;
            btnHoSoKhoa.Enabled = false;
            btnKhaiBaoNamHoc.Enabled = false;
            btnNhapDiem.Enabled = false;
            btnPhanLopSinhVien.Enabled = false;
            btnThemSinhVien.Enabled = false;
            btnThongKeHocVu.Enabled = false;
            btnTimKiemSinhVien.Enabled = false;
            btnXemDiem.Enabled = false;


        }

        private void btnThongKeHocVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BL.XtraReport1 baoCao = new BL.XtraReport1();
            BL.BlKetQua ketQua = new BL.BlKetQua();
            baoCao.DataSource = ketQua.LayKetQua();
            baoCao.ShowPreviewDialog();
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
                NhapDiem nhapDiem = new NhapDiem();
                nhapDiem.MdiParent = this;
                nhapDiem.Show();

                ///show form giao viên
                GiaoVien giaoVien = new GiaoVien();
                giaoVien.MdiParent = this;
                giaoVien.Show();
            }
            if(chucVu=="HS")
            {
                btnBangDiemMonHoc.Enabled = true;
                btnXemDiem.Enabled = true;
                btnThongKeHocVu.Enabled = true;

                ///show form học sinh
                HocSinh hocSinh = new HocSinh();
                hocSinh.MdiParent = this;
                hocSinh.Show();

                ///show form nhập điểm
                NhapDiem nhapDiem = new NhapDiem();
                nhapDiem.MdiParent = this;
                nhapDiem.Show();
            }
            if(chucVu=="AD")
            {
                btnBangDiemMonHoc.Enabled = true;
                btnCapNhatTaiKhoan.Enabled = true;
                btnDanhSachLopHoc.Enabled = true;
                btnHoSoGiaoVien.Enabled = true;
                btnHoSoKhoa.Enabled = true;
                btnKhaiBaoNamHoc.Enabled = true;
                btnNhapDiem.Enabled = true;
                btnPhanLopSinhVien.Enabled = true;
                btnThemSinhVien.Enabled = true;
                btnThongKeHocVu.Enabled = true;
                btnTimKiemSinhVien.Enabled = true;
                btnXemDiem.Enabled = true;

                ///show form học sinh
                HocSinh hocSinh = new HocSinh();
                hocSinh.MdiParent = this;
                hocSinh.Show();

                ///show form nhập điểm
                NhapDiem nhapDiem = new NhapDiem();
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

                ///show form Cập Nhật
                CapNhat capNhat = new CapNhat();
                capNhat.MdiParent = this;
                capNhat.Show();
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
            Kt = dangNhap.Kt;
            isDangNhap = Kt;
            if(Kt)
            {
                ChucVu = dangNhap.ChucVu;
                PhanQuyen(ChucVu);
                

            }

        }

        private void btnCapNhatTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        private void KTDangNhap()
        {
            if(isDangNhap)
            {

            }
        }
    }
}
