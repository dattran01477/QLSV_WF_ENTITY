﻿using System;
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
    public partial class CapNhat : DevExpress.XtraEditors.XtraForm
    {
        string gvOrSVUpdate;

        public string GvOrSVUpdate { get => gvOrSVUpdate; set => gvOrSVUpdate = value; }

        public CapNhat()
        {
            InitializeComponent();
        }
        public CapNhat(string gvOrSV)
        {
            InitializeComponent();
            this.GvOrSVUpdate = gvOrSV;
            
        }
        public void loadData()
        {
            BL.Users users = new BL.Users();
            DataTable dt = users.DanhSachChuaCoTk(gvOrSVUpdate);

            int i = 0;

            if(gvOrSVUpdate=="GV")
            {
                foreach (DataRow row in dt.Rows)

                {
                    lsvDsChuaCoTKGV.Items.Add(row["msGV"].ToString());

                    lsvDsChuaCoTKGV.Items[i].SubItems.Add(row["tenGV"].ToString());
                    i++;
                }
            }
            else
                if(gvOrSVUpdate=="SV")
            {
                foreach (DataRow row in dt.Rows)

                {
                    lsvDsChuaCoTKGV.Items.Add(row["msSV"].ToString());

                    lsvDsChuaCoTKGV.Items[i].SubItems.Add(row["tenSV"].ToString());
                    i++;
                }
            }
            
        }

        private void CapNhat_Load(object sender, EventArgs e)
        {
             lsvDsChuaCoTKGV.View = View.Details;
            lsvDsChuaCoTKGV.Items.Clear();
            lsvDsChuaCoTKGV.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lsvDsChuaCoTKGV.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            lsvDanhSachChon.View = View.Details;
            lsvDanhSachChon.Items.Clear();
            lsvDanhSachChon.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lsvDanhSachChon.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);


            //if(gvOrSVUpdate=="GV")
            //lsvDsChuaCoTKGV.Columns.Add("Mã Số GV");
            //lsvDsChuaCoTKGV.Columns.Add("Tên GV");
            loadData();
        }
        private void TimTK()
        {
            string ms = txtMSGV.Text;
        
            foreach(ListViewItem a in lsvDsChuaCoTKGV.Items)
            {
                if(a.Text==ms)
                {
                    a.Selected = true;
                    a.BackColor = Color.Red;
                }
            }
         
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            TimTK();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem a in lsvDsChuaCoTKGV.Items)
            {
                    a.Selected = true;
                    a.BackColor = Color.Red;
              
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach(ListViewItem a in lsvDsChuaCoTKGV.Items)
            {
                if(a.Selected)
                {
                    lsvDsChuaCoTKGV.Items.Remove(a);
                    lsvDanhSachChon.Items.Add(a);
                    lsvDanhSachChon.Items[i].SubItems.Add(a.SubItems[1]);
                    i++;
                }
                
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (ListViewItem a in lsvDanhSachChon.Items)
            {
                if (a.Selected)
                {
                    lsvDanhSachChon.Items.Remove(a);
                    lsvDsChuaCoTKGV.Items.Add(a);
                    lsvDsChuaCoTKGV.Items[i].SubItems.Add(a.SubItems[1]);
                    i++;
                }

            }
        }

        private void btnCapTaiKhoan_Click(object sender, EventArgs e)
        {
            BL.Users users = new BL.Users();
            if(gvOrSVUpdate=="GV")
            foreach(ListViewItem a in lsvDanhSachChon.Items)
            {
                users.CapPhatTaiKhoan(a.Text.ToString(), "GV");

            }
            else
                 if (gvOrSVUpdate == "SV")
                foreach (ListViewItem a in lsvDanhSachChon.Items)
                {
                    users.CapPhatTaiKhoan(a.Text.ToString(), "SV");

                }



        }
    }
}