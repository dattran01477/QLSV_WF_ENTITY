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
    public partial class NamHoc : DevExpress.XtraEditors.XtraForm
    {
        private bool isThem = false;
        private bool isSua = false;
        private bool isXoa = false;
        private bool isLuu = false;
        private bool isHuy = false;
        public NamHoc()
        {
            InitializeComponent();
            LoadData();
        }

      

        private void NamHoc_Load(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
          
           
        }
        private void LoadData()
        {
            BL.BLNamHoc bLNamHoc = new BL.BLNamHoc();
            gridControlNamHoc.DataSource = bLNamHoc.LayNamHoc();
        }

        private void gridView2_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            int r = gridView2.FocusedRowHandle;
            string tgBD= gridView2.GetRowCellValue(r, "tgBatDau").ToString();
            string tgKT= gridView2.GetRowCellValue(r, "tgKetThuc").ToString();
            txtNamHoc.Text = gridView2.GetRowCellValue(r, "tenNamHoc").ToString();

            dtTGBD.Value = DateTime.Parse(tgBD);
            dtTGKT.Value = DateTime.Parse(tgKT);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isThem = true;
            isXoa = false;
            isHuy = false;
            isLuu = false;
            isSua = false;


            btnLuu.Enabled = true;
            txtNamHoc.ResetText();
            dtTGBD.ResetText();
            dtTGKT.ResetText();
            txtNamHoc.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            isLuu = true;
            if (isThem)
            {
                if (isLuu)
                {
                    
                    BL.BLNamHoc qlGV = new BL.BLNamHoc();



                    qlGV.Them(txtNamHoc.Text, DateTime.Parse(dtTGBD.Text), DateTime.Parse(dtTGKT.Text));
                    LoadData();

                }
            }
            if (isSua)
            {
                string gt = null;

                BL.BLSinhVien qlGV = new BL.BLSinhVien();

                

                //qlGV.CapNhat(txtMSSV.Text, txtHoTen.Text, txtTuoi.Text, cmbKhoa.Text, gt, rtxtDiaChi.Text);
                //LoadData();



            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtNamHoc.ResetText();
            isThem = false;
            isLuu = false;
            dtTGBD.ResetText();
            dtTGKT.ResetText();
        }
    }
}