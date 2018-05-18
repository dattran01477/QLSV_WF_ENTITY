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
    public partial class Khoa : DevExpress.XtraEditors.XtraForm
    {
        private bool isThem = false;
        private bool isSua = false;
        private bool isXoa = false;
        private bool isLuu = false;
        private bool isHuy = false;
        public Khoa()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            BL.BLKhoa blKhoa = new BL.BLKhoa();
            gridControlKhoa.DataSource = blKhoa.LayDanhSachKhoaDatatable();
        }

        

        private void btnSua_Click(object sender, EventArgs e)
        {
            isSua = true;
            isThem = false;
            isXoa = false;
            isHuy = false;


            btnLuu.Enabled = true;
            txtTenKhoaThem.Focus();
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
            string msKhoa = gridView2.GetRowCellValue(r, "msKhoa").ToString();
            DialogResult traloi;

            // Hiện hộp thoại hỏi đáp
            traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Ok không?
            if (traloi == DialogResult.Yes)
            {
                BL.BLKhoa qlKhoa = new BL.BLKhoa();
                qlKhoa.Xoa(msKhoa); 

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
                    BL.BLKhoa qlKhoa = new BL.BLKhoa();
                  

                    qlKhoa.Them(txtTenKhoaThem.Text,cmbDiaDiemKhoa.Text);
                    LoadData();

                }
            }
            if (isSua)
            {
                BL.BLKhoa qlKhoa = new BL.BLKhoa();
                qlKhoa.CapNhat(txtMSKhoa.Text, txtTenKhoaThem.Text, cmbDiaDiemKhoa.Text);
                LoadData();



            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isThem = true;
            isXoa = false;
            isHuy = false;
            isLuu = false;
            isSua = false;


            btnLuu.Enabled = true;
            txtTenKhoaThem.ResetText();
            cmbDiaDiemKhoa.ResetText();
            txtTenKhoaThem.Focus();
        }

        private void gridView2_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            int r = gridView2.FocusedRowHandle;
            txtTenKhoaThem.Text = gridView2.GetRowCellValue(r, "tenKhoa").ToString();
            cmbDiaDiemKhoa.Text = gridView2.GetRowCellValue(r, "diaDiem").ToString();   
            txtMSKhoa.Text= gridView2.GetRowCellValue(r, "msKhoa").ToString();
        }

        private void Khoa_Load(object sender, EventArgs e)
        {
            LoadData();
            BL.BLKhoa khoa = new BL.BLKhoa();

            lsvGV.Columns.Add("Mã GV");
            lsvGV.Columns.Add("Tên GV");

            lsvMonHoc.Columns.Add("Mã MH");
            lsvMonHoc.Columns.Add("Tên Môn Học");
     
            lsvDSMonHocQLMH.Columns.Add("Mã MH");
            lsvDSMonHocQLMH.Columns.Add("Tên Môn Học");

            var diaDiemKhoa = (from p in khoa.LayDanhSachKhoa()
                          select p.diaDiem).Distinct();
            foreach (var i in diaDiemKhoa)
            {
                cmbDiaDiemKhoa.Items.Add(i);
            }
            var tenKhoa = (from p in khoa.LayDanhSachKhoa()
                          select p.tenKhoa);
            foreach (var i in tenKhoa)
            {
                cmbKhoaTTCT.Items.Add(i);
                cmbTimTenKhoaQLMH.Items.Add(i);
            }

        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            BL.BLKhoa khoa = new BL.BLKhoa();
            Data.Khoa khoaTemp = khoa.Tim(cmbKhoaTTCT.Text);
            txtTenKhoa.Text = khoaTemp.tenKhoa;
            txtDiaDiem.Text = khoaTemp.diaDiem;

            DataTable dt = khoa.LayDanhSachGVKhoa(cmbKhoaTTCT.Text);
            DataTable dt2 = khoa.LayDanhSachMonHocKhoa(cmbKhoaTTCT.Text);



            lsvGV.View = View.Details;
            lsvGV.Items.Clear();
            lsvGV.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lsvGV.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
          

            lsvMonHoc.View = View.Details;
            lsvMonHoc.Items.Clear();
            lsvMonHoc.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lsvMonHoc.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
          

            int i = 0;
            int j = 0;

            foreach (DataRow row in dt.Rows)

            {

                lsvGV.Items.Add(row["MSGV"].ToString());

                lsvGV.Items[i].SubItems.Add(row["tenGV"].ToString());
                i++;

            }

            foreach (DataRow row in dt2.Rows)

            {

                lsvMonHoc.Items.Add(row["msMonHoc"].ToString());

                lsvMonHoc.Items[j].SubItems.Add(row["tenMonHoc"].ToString());
                j++;

            }

        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {

        }

        private void btnSuaMon_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {

        }

        private void btnHuyThaoTac_Click(object sender, EventArgs e)
        {

        }

        private void btnLuuMon_Click(object sender, EventArgs e)
        {

        }

        private void csbTimTenKhoaQLMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            BL.BLKhoa khoa = new BL.BLKhoa();
            DataTable dt2 = khoa.LayDanhSachMonHocKhoa(cmbTimTenKhoaQLMH.Text);

            lsvDSMonHocQLMH.View = View.Details;
            lsvDSMonHocQLMH.Items.Clear();
            lsvDSMonHocQLMH.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lsvDSMonHocQLMH.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            int j = 0;
            foreach (DataRow row in dt2.Rows)
            {

                lsvDSMonHocQLMH.Items.Add(row["msMonHoc"].ToString());
                lsvDSMonHocQLMH.Items[j].SubItems.Add(row["tenMonHoc"].ToString());
                j++;

            }
        }

        private void lsvDSMonHocQLMH_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
            MessageBox.Show(lsvDSMonHocQLMH.SelectedIndices[0].ToString());
        }
    }
}