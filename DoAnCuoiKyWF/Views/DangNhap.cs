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
    public partial class DangNhap : DevExpress.XtraEditors.XtraForm
    {
        string chucVu = null;
        bool kt = false;
        int msTK;

        public string ChucVu { get => chucVu; set => chucVu = value; }
        public bool Kt { get => kt; set => kt = value; }
        public int MsTK { get => msTK; set => msTK = value; }

        public DangNhap()
        {
            InitializeComponent();
        }
        private bool KiemTraDangNhap()
        {
            BL.BLUser user = new BL.BLUser();
           
            string err = null;
            if(isGV.Checked)
            {
                ChucVu = "GV";
            }
            if(isSV.Checked)
            {
                ChucVu = "SV";
            }
            if(isAdmin.Checked)
            {
                ChucVu = "AD";
            }

            if(user.KiemTraDanhTinh(txtTenDN.Text,txtPass.Text,ChucVu,err))
            {
                return true;
            }
            return false;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            
            Kt = KiemTraDangNhap();
            MsTK = int.Parse(txtTenDN.Text);
            if(Kt)
            {
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập lại");
                txtTenDN.Focus();
            }

        }

        private void isGV_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}