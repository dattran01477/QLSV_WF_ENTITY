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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
        
        }

        private void simpleBtnThem_Click(object sender, EventArgs e)
        {
           
          

        }

        private void NamHoc_Load(object sender, EventArgs e)
        {
            
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
    }
}