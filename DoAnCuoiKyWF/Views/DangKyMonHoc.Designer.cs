namespace DoAnCuoiKyWF
{
    partial class DangKyMonHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKyMonHoc));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTenKhoa = new System.Windows.Forms.ComboBox();
            this.cmbMonHoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lsDSDuKienDangKi = new System.Windows.Forms.ListView();
            this.groupBoxLsMonDangKy = new System.Windows.Forms.GroupBox();
            this.tenMonHoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDK = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.groupBoxLsMonDangKy.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(452, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng Ký Môn Học";
            // 
            // cmbTenKhoa
            // 
            this.cmbTenKhoa.FormattingEnabled = true;
            this.cmbTenKhoa.Location = new System.Drawing.Point(200, 159);
            this.cmbTenKhoa.Name = "cmbTenKhoa";
            this.cmbTenKhoa.Size = new System.Drawing.Size(304, 24);
            this.cmbTenKhoa.TabIndex = 1;
            this.cmbTenKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbTenKhoa_SelectedIndexChanged);
            // 
            // cmbMonHoc
            // 
            this.cmbMonHoc.FormattingEnabled = true;
            this.cmbMonHoc.Location = new System.Drawing.Point(200, 230);
            this.cmbMonHoc.Name = "cmbMonHoc";
            this.cmbMonHoc.Size = new System.Drawing.Size(304, 24);
            this.cmbMonHoc.TabIndex = 1;
            this.cmbMonHoc.SelectedIndexChanged += new System.EventHandler(this.cmbMonHoc_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Môn Học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khoa ";
            // 
            // lsDSDuKienDangKi
            // 
            this.lsDSDuKienDangKi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tenMonHoc});
            this.lsDSDuKienDangKi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsDSDuKienDangKi.FullRowSelect = true;
            this.lsDSDuKienDangKi.GridLines = true;
            this.lsDSDuKienDangKi.Location = new System.Drawing.Point(3, 19);
            this.lsDSDuKienDangKi.Name = "lsDSDuKienDangKi";
            this.lsDSDuKienDangKi.Size = new System.Drawing.Size(244, 249);
            this.lsDSDuKienDangKi.TabIndex = 6;
            this.lsDSDuKienDangKi.UseCompatibleStateImageBehavior = false;
            this.lsDSDuKienDangKi.UseWaitCursor = true;
            // 
            // groupBoxLsMonDangKy
            // 
            this.groupBoxLsMonDangKy.Controls.Add(this.lsDSDuKienDangKi);
            this.groupBoxLsMonDangKy.Location = new System.Drawing.Point(810, 118);
            this.groupBoxLsMonDangKy.Name = "groupBoxLsMonDangKy";
            this.groupBoxLsMonDangKy.Size = new System.Drawing.Size(250, 271);
            this.groupBoxLsMonDangKy.TabIndex = 7;
            this.groupBoxLsMonDangKy.TabStop = false;
            this.groupBoxLsMonDangKy.Text = "Các Môn Dự Kiến Đăng Kí";
            this.groupBoxLsMonDangKy.UseWaitCursor = true;
            // 
            // tenMonHoc
            // 
            this.tenMonHoc.Text = "Tên Môn Học";
            this.tenMonHoc.Width = 100;
            // 
            // btnDK
            // 
            this.btnDK.BackgroundImage = global::DoAnCuoiKyWF.Properties.Resources.imageres_dll_007_10;
            this.btnDK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnDK.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.btnDK.Location = new System.Drawing.Point(997, 408);
            this.btnDK.Name = "btnDK";
            this.btnDK.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.btnDK.Size = new System.Drawing.Size(60, 32);
            this.btnDK.TabIndex = 5;
            this.btnDK.Text = "Đăng Kí";
            this.btnDK.Click += new System.EventHandler(this.btnDK_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnThem.Location = new System.Drawing.Point(598, 179);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(104, 46);
            this.btnThem.TabIndex = 3;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // DangKyMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 506);
            this.Controls.Add(this.groupBoxLsMonDangKy);
            this.Controls.Add(this.btnDK);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbMonHoc);
            this.Controls.Add(this.cmbTenKhoa);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DangKyMonHoc";
            this.Text = "DangKyMonHoc";
            this.Load += new System.EventHandler(this.DangKyMonHoc_Load);
            this.groupBoxLsMonDangKy.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTenKhoa;
        private System.Windows.Forms.ComboBox cmbMonHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnDK;
        private System.Windows.Forms.ListView lsDSDuKienDangKi;
        private System.Windows.Forms.GroupBox groupBoxLsMonDangKy;
        private System.Windows.Forms.ColumnHeader tenMonHoc;
    }
}