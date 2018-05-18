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
    public partial class LopHoc : DevExpress.XtraEditors.XtraForm
    {
        public LopHoc()
        {
            InitializeComponent();
            LoadData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            BL.BLLopHoc blLop = new BL.BLLopHoc();
            gridControlLopHoc.DataSource = blLop.LayLopHocTable();
        }
    }
}