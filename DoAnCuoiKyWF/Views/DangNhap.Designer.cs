namespace DoAnCuoiKyWF
{
    partial class DangNhap
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
            this.components = new System.ComponentModel.Container();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lbTenDangNhap = new System.Windows.Forms.Label();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.txtTenDN = new DevExpress.XtraEditors.TextEdit();
            this.txtPass = new DevExpress.XtraEditors.TextEdit();
            this.isGV = new DevExpress.XtraEditors.CheckEdit();
            this.isSV = new DevExpress.XtraEditors.CheckEdit();
            this.isAdmin = new DevExpress.XtraEditors.CheckEdit();
            this.btnDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isAdmin.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(192, 39);
            this.labelControl1.LookAndFeel.SkinName = "Office 2010 Blue";
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(112, 24);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Đăng Nhập";
            // 
            // lbTenDangNhap
            // 
            this.lbTenDangNhap.AutoSize = true;
            this.lbTenDangNhap.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenDangNhap.Location = new System.Drawing.Point(85, 98);
            this.lbTenDangNhap.Name = "lbTenDangNhap";
            this.lbTenDangNhap.Size = new System.Drawing.Size(121, 18);
            this.lbTenDangNhap.TabIndex = 1;
            this.lbTenDangNhap.Text = "Tên Đăng Nhập";
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatKhau.Location = new System.Drawing.Point(88, 142);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(77, 18);
            this.lbMatKhau.TabIndex = 2;
            this.lbMatKhau.Text = "Mật Khẩu";
            // 
            // txtTenDN
            // 
            this.txtTenDN.Location = new System.Drawing.Point(220, 98);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtTenDN.Size = new System.Drawing.Size(129, 24);
            this.txtTenDN.TabIndex = 3;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(220, 138);
            this.txtPass.Name = "txtPass";
            this.txtPass.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtPass.Properties.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(129, 24);
            this.txtPass.TabIndex = 3;
            // 
            // isGV
            // 
            this.isGV.Location = new System.Drawing.Point(88, 193);
            this.isGV.Name = "isGV";
            this.isGV.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.isGV.Properties.Appearance.Options.UseForeColor = true;
            this.isGV.Properties.Caption = "Giáo Viên";
            this.isGV.Size = new System.Drawing.Size(75, 20);
            this.isGV.TabIndex = 4;
            this.isGV.CheckedChanged += new System.EventHandler(this.isGV_CheckedChanged);
            // 
            // isSV
            // 
            this.isSV.Location = new System.Drawing.Point(220, 193);
            this.isSV.Name = "isSV";
            this.isSV.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.isSV.Properties.Appearance.Options.UseForeColor = true;
            this.isSV.Properties.Caption = "Sinh Viên";
            this.isSV.Size = new System.Drawing.Size(75, 20);
            this.isSV.TabIndex = 4;
            // 
            // isAdmin
            // 
            this.isAdmin.Location = new System.Drawing.Point(335, 193);
            this.isAdmin.Name = "isAdmin";
            this.isAdmin.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.isAdmin.Properties.Appearance.Options.UseForeColor = true;
            this.isAdmin.Properties.Caption = "Admin";
            this.isAdmin.Size = new System.Drawing.Size(75, 20);
            this.isAdmin.TabIndex = 4;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(249, 248);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(100, 23);
            this.btnDangNhap.TabIndex = 5;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013";
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(498, 317);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.isAdmin);
            this.Controls.Add(this.isSV);
            this.Controls.Add(this.isGV);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtTenDN);
            this.Controls.Add(this.lbMatKhau);
            this.Controls.Add(this.lbTenDangNhap);
            this.Controls.Add(this.labelControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangNhap";
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isAdmin.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Label lbTenDangNhap;
        private System.Windows.Forms.Label lbMatKhau;
        private DevExpress.XtraEditors.TextEdit txtTenDN;
        private DevExpress.XtraEditors.TextEdit txtPass;
        private DevExpress.XtraEditors.CheckEdit isGV;
        private DevExpress.XtraEditors.CheckEdit isSV;
        private DevExpress.XtraEditors.CheckEdit isAdmin;
        private DevExpress.XtraEditors.SimpleButton btnDangNhap;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}