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
    public partial class NhapDiem : DevExpress.XtraEditors.XtraForm
    {
        string msNamHoc;
        public NhapDiem()
        {
            InitializeComponent();
        }
        public NhapDiem(string msNamHoc)
        {
            InitializeComponent();
            this.MsNamHoc = msNamHoc;
        }

        public string MsNamHoc { get => msNamHoc; set => msNamHoc = value; }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            BL.BlKetQua kq = new BL.BlKetQua();
            kq.ThemDiem(txtNhapDiemMSSV.Text, txtNhapDiemMSMH.Text, int.Parse(txtDiem.Text),MsNamHoc);
        }

        private void simpleButtonXemDiem_Click(object sender, EventArgs e)
        {
            BL.BlKetQua kq = new BL.BlKetQua();
            gridControlKetQua.DataSource = kq.LayKetQuaDatatable(int.Parse(txtMSSV.Text));
            txtDiemTrungBinh.Text = kq.TinhDiemTB(int.Parse(txtMSSV.Text)).ToString();


        }
    }
}