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
using DevExpress.XtraGrid;

namespace DoAnCuoiKyWF
{
    public partial class GiaoVien : DevExpress.XtraEditors.XtraForm
    {
        private bool isThem = false;
        private bool isSua = false;
        private bool isXoa = false;
        private bool isLuu = false;
        private bool isHuy = false;

        public GiaoVien()
        {
            InitializeComponent();

        }

        private void checkEditGTNam_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            BL.BLGiaoVien blGV = new BL.BLGiaoVien();
            gridControlGiaoVien.DataSource = blGV.LayGiaoVien();
        }

        private void GiaoVien_Load(object sender, EventArgs e)
        {
            LoadData();
            BL.BLKhoa khoa = new BL.BLKhoa();
            var tenKhoa = from p in khoa.LayDanhSachKhoa()
                          select p.tenKhoa;
            foreach(var i in tenKhoa)
            {
                cmbKhoa.Items.Add(i);
            }
        }

        private void navigationPaneLopHoc_Click(object sender, EventArgs e)
        {

        }

        private void groupControlQuanLyGiaoVien_Paint(object sender, PaintEventArgs e)
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
            txtHoTenGV.ResetText();
            txtMSGV.ResetText();
            txtTuoi.ResetText();
            cmbKhoa.ResetText();
            CkIsNam.Checked = false;
            ckIsNu.Checked = false;
            txtHoTenGV.Focus();
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            isSua = true;
            isThem = false;
            isXoa = false;
            isHuy = false;


            btnLuu.Enabled = true;
            txtHoTenGV.Focus();
            
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
            string msGV = gridView2.GetRowCellValue(r, "msGV").ToString();
            DialogResult traloi;

            // Hiện hộp thoại hỏi đáp
            traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Ok không?
            if (traloi == DialogResult.Yes)
            {
                BL.BLGiaoVien qlGV = new BL.BLGiaoVien();
                qlGV.Xoa(msGV);
         
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
            isThem = false;
            isXoa = false;
            isLuu = false;
            isSua = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            isLuu = true;
            if (isThem)
            {
                if (isLuu)
                {
                    string gt = null;
                    BL.BLGiaoVien qlGV = new BL.BLGiaoVien();
                    if (CkIsNam.Checked)
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

                    qlGV.Them(txtHoTenGV.Text, txtTuoi.Text, gt,cmbKhoa.Text);
                    LoadData();

                }
            }
            if(isSua)
            {
                string gt = null;
  
                BL.BLGiaoVien qlGV = new BL.BLGiaoVien();
               
                if (CkIsNam.Checked)
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

                qlGV.CapNhat(txtMSGV.Text, txtHoTenGV.Text, txtTuoi.Text, cmbKhoa.Text, gt);
                LoadData();
                


            }
            
        }

    
    

        private void gridView2_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            int r = gridView2.FocusedRowHandle;
            string gt = gridView2.GetRowCellValue(r, "gioiTinh").ToString();
            string khoa= gridView2.GetRowCellValue(r, "khoa").ToString();
            txtHoTenGV.Text = gridView2.GetRowCellValue(r, "hoTen").ToString();
            txtTuoi.Text = gridView2.GetRowCellValue(r, "tuoi").ToString();
            txtMSGV.Text= gridView2.GetRowCellValue(r, "msGV").ToString();
            if(gt=="Nam")
            {
                CkIsNam.Checked = true;
            }
            else
            if(gt=="Nữ")
            {
                ckIsNu.Checked = true;
            }
            cmbKhoa.Text = khoa;
        }
    }
}