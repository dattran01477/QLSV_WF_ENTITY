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
    public partial class HocSinh : DevExpress.XtraEditors.XtraForm
    {
        private bool isThem = false;
        private bool isSua = false;
        private bool isXoa = false;
        private bool isLuu = false;
        private bool isHuy = false;
        public HocSinh()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void HocSinh_Load(object sender, EventArgs e)
        {
            LoadData();
            BL.BLKhoa khoa = new BL.BLKhoa();
            var tenKhoa = from p in khoa.LayDanhSachKhoa()
                          select p.tenKhoa;
            foreach (var i in tenKhoa)
            {
                cmbKhoa.Items.Add(i);
            }
            gridView2.BestFitColumns();
        }

        private void gridControlGiaoVien_Click(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            BL.BLSinhVien blSV = new BL.BLSinhVien();
            gridControlSV.DataSource = blSV.LaySinhVien();
          
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            isLuu = true;
            if (isThem)
            {
                if (isLuu)
                {
                    string gt = null;
                    BL.BLSinhVien qlGV = new BL.BLSinhVien();
                    if (ckIsNam.Checked)
                    {
                        gt = "Nam";

                    }
                    else
                    {
                        if (ckIsNu.Checked)
                        {
                            gt = "Nữ";
                        }
                    }

                    qlGV.Them(txtHoTen.Text,txtTuoi.Text,gt,cmbKhoa.Text,rtxtDiaChi.Text);
                    LoadData();

                }
            }
            if (isSua)
            {
                string gt = null;

                BL.BLSinhVien qlGV = new BL.BLSinhVien();

                if (ckIsNam.Checked)
                {
                    gt = "Nam";

                }
                else
                {
                    if (ckIsNu.Checked)
                    {
                        gt = "Nữ";
                    }
                }

                qlGV.CapNhat(txtMSSV.Text, txtHoTen.Text, txtTuoi.Text, cmbKhoa.Text, gt, rtxtDiaChi.Text);
                LoadData();



            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            isSua = true;
            isThem = false;
            isXoa = false;
            isHuy = false;


            btnLuu.Enabled = true;
            txtHoTen.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            isXoa = true;
            isThem = false;
            isHuy = false;
            isLuu = false;
            isSua = false;



            btnLuu.Enabled = true;
            //lay vị trí hiện tại 
            int r = gridView2.FocusedRowHandle;
            string msGV = gridView2.GetRowCellValue(r, "msSV").ToString();
            DialogResult traloi;

            // Hiện hộp thoại hỏi đáp
            traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Ok không?
            if (traloi == DialogResult.Yes)
            {
                BL.BLSinhVien qlSV = new BL.BLSinhVien();
                qlSV.Xoa(msGV);

                LoadData();
                // Thông báo
                MessageBox.Show("Đã xóa xong!");
            }
            else
            {
                // Thông báo
                MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isThem = true;
            isXoa = false;
            isHuy = false;
            isLuu = false;
            isSua = false;


            btnLuu.Enabled = true;
            txtHoTen.ResetText();
            txtMSSV.ResetText();
            txtTuoi.ResetText();
            txtPhone.ResetText();
            cmbKhoa.ResetText();
            rtxtDiaChi.ResetText();
            ckIsNam.Checked = false;
            ckIsNu.Checked = false;
            txtHoTen.Focus();
        }

        private void gridView2_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            int r = gridView2.FocusedRowHandle;
            string gt = gridView2.GetRowCellValue(r, "gioiTinh").ToString();
            string khoa = gridView2.GetRowCellValue(r, "khoa").ToString();
            txtHoTen.Text = gridView2.GetRowCellValue(r, "hoTen").ToString();
            rtxtDiaChi.Text = gridView2.GetRowCellValue(r, "diaChi").ToString();
            txtTuoi.Text = gridView2.GetRowCellValue(r, "tuoi").ToString();
            txtMSSV.Text = gridView2.GetRowCellValue(r, "msSV").ToString();
            if (gt == "Nam")
            {
                ckIsNam.Checked = true;
            }
            else
            if (gt == "Nữ")
            {
                ckIsNu.Checked = true;
            }
            cmbKhoa.Text = khoa;
        }
    }
}