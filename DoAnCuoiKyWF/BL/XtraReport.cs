using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;

namespace DoAnCuoiKyWF.BL
{
    public partial class XtraReport : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport()
        {
            InitializeComponent();
            if(xrCheckBoxQuaMon.Text=="F")
            {
                xrCheckBoxQuaMon.CheckState = System.Windows.Forms.CheckState.Checked;
            }
        }

        private void xrCheckBoxQuaMon_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRCheckBox b = (XRCheckBox)sender;
            if (b.Text == "False")
            {
                b.Checked = false;
            }
            else
            {
                b.Checked = true;
            }


        }
    }
}
