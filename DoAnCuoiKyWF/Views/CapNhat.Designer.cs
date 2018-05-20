namespace DoAnCuoiKyWF
{
    partial class CapNhat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnCapTaiKhoan = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.lsvDanhSachChon = new System.Windows.Forms.ListView();
            this.msTK2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenTK2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lsvDsChuaCoTKGV = new System.Windows.Forms.ListView();
            this.maTK1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenTK1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMSGV = new System.Windows.Forms.TextBox();
            this.btnTim = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnChuyen = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnCapTaiKhoan);
            this.panelControl1.Controls.Add(this.simpleButton3);
            this.panelControl1.Controls.Add(this.groupControl3);
            this.panelControl1.Controls.Add(this.groupControl2);
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Controls.Add(this.btnChuyen);
            this.panelControl1.Location = new System.Drawing.Point(296, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(824, 611);
            this.panelControl1.TabIndex = 10;
            // 
            // btnCapTaiKhoan
            // 
            this.btnCapTaiKhoan.Location = new System.Drawing.Point(695, 555);
            this.btnCapTaiKhoan.Name = "btnCapTaiKhoan";
            this.btnCapTaiKhoan.Size = new System.Drawing.Size(108, 46);
            this.btnCapTaiKhoan.TabIndex = 15;
            this.btnCapTaiKhoan.Text = "Cấp Tài Khoản";
            this.btnCapTaiKhoan.Click += new System.EventHandler(this.btnCapTaiKhoan_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(255, 16);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(102, 23);
            this.simpleButton3.TabIndex = 14;
            this.simpleButton3.Text = "Chọn Tất Cả";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.lsvDanhSachChon);
            this.groupControl3.Location = new System.Drawing.Point(475, 30);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(328, 517);
            this.groupControl3.TabIndex = 13;
            this.groupControl3.Text = "Danh Sách Được Chọn";
            // 
            // lsvDanhSachChon
            // 
            this.lsvDanhSachChon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.msTK2,
            this.tenTK2});
            this.lsvDanhSachChon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvDanhSachChon.FullRowSelect = true;
            this.lsvDanhSachChon.GridLines = true;
            this.lsvDanhSachChon.Location = new System.Drawing.Point(2, 25);
            this.lsvDanhSachChon.Name = "lsvDanhSachChon";
            this.lsvDanhSachChon.Size = new System.Drawing.Size(324, 490);
            this.lsvDanhSachChon.TabIndex = 0;
            this.lsvDanhSachChon.UseCompatibleStateImageBehavior = false;
            // 
            // msTK2
            // 
            this.msTK2.Text = "Mã Số Tài Khoản";
            // 
            // tenTK2
            // 
            this.tenTK2.Text = "Tên Tài Khoản";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.lsvDsChuaCoTKGV);
            this.groupControl2.Location = new System.Drawing.Point(30, 30);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(327, 517);
            this.groupControl2.TabIndex = 12;
            this.groupControl2.Text = "Danh Sách Chưa Có TK";
            // 
            // lsvDsChuaCoTKGV
            // 
            this.lsvDsChuaCoTKGV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.maTK1,
            this.tenTK1});
            this.lsvDsChuaCoTKGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvDsChuaCoTKGV.FullRowSelect = true;
            this.lsvDsChuaCoTKGV.GridLines = true;
            this.lsvDsChuaCoTKGV.Location = new System.Drawing.Point(2, 25);
            this.lsvDsChuaCoTKGV.Name = "lsvDsChuaCoTKGV";
            this.lsvDsChuaCoTKGV.Size = new System.Drawing.Size(323, 490);
            this.lsvDsChuaCoTKGV.TabIndex = 0;
            this.lsvDsChuaCoTKGV.UseCompatibleStateImageBehavior = false;
            // 
            // maTK1
            // 
            this.maTK1.Text = "Mã Số Tài Khoản";
            // 
            // tenTK1
            // 
            this.tenTK1.Text = "Tên Tài Khoản";
            this.tenTK1.Width = 100;
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.Controls.Add(this.groupControl1);
            this.panelControl2.Location = new System.Drawing.Point(20, 12);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(270, 611);
            this.panelControl2.TabIndex = 11;
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txtMSGV);
            this.groupControl1.Controls.Add(this.btnTim);
            this.groupControl1.Location = new System.Drawing.Point(5, 220);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(263, 100);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "Tìm Nhanh TK";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã Số Tài Khoản";
            // 
            // txtMSGV
            // 
            this.txtMSGV.Location = new System.Drawing.Point(158, 29);
            this.txtMSGV.Name = "txtMSGV";
            this.txtMSGV.Size = new System.Drawing.Size(100, 23);
            this.txtMSGV.TabIndex = 4;
            // 
            // btnTim
            // 
            this.btnTim.AutoSize = true;
            this.btnTim.BackgroundImage = global::DoAnCuoiKyWF.Properties.Resources.searchperson;
            this.btnTim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTim.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnTim.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnTim.Location = new System.Drawing.Point(229, 58);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(20, 25);
            this.btnTim.TabIndex = 5;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.BackgroundImage = global::DoAnCuoiKyWF.Properties.Resources.muiTenTrai;
            this.simpleButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton2.Location = new System.Drawing.Point(379, 317);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 11;
            this.simpleButton2.Text = "<<<<";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btnChuyen
            // 
            this.btnChuyen.BackgroundImage = global::DoAnCuoiKyWF.Properties.Resources.muiTenPhai;
            this.btnChuyen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChuyen.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnChuyen.Location = new System.Drawing.Point(379, 273);
            this.btnChuyen.Name = "btnChuyen";
            this.btnChuyen.Size = new System.Drawing.Size(75, 23);
            this.btnChuyen.TabIndex = 10;
            this.btnChuyen.Text = ">>>>";
            this.btnChuyen.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // CapNhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 627);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CapNhat";
            this.Text = "CapNhat";
            this.Load += new System.EventHandler(this.CapNhat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.ListView lsvDanhSachChon;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.ListView lsvDsChuaCoTKGV;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnChuyen;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMSGV;
        private DevExpress.XtraEditors.SimpleButton btnTim;
        private System.Windows.Forms.ColumnHeader maTK1;
        private System.Windows.Forms.ColumnHeader tenTK1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.ColumnHeader msTK2;
        private System.Windows.Forms.ColumnHeader tenTK2;
        private DevExpress.XtraEditors.SimpleButton btnCapTaiKhoan;
    }
}