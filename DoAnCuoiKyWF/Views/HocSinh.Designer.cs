namespace DoAnCuoiKyWF
{
    partial class HocSinh
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
            this.navigationPaneSinhVien = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPageQlSinhVien = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.gridControlSV = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.hoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tuoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.khoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.msSV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.diaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControlQuanLyGiaoVien = new DevExpress.XtraEditors.GroupControl();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.rtxtDiaChi = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.ckIsNu = new DevExpress.XtraEditors.CheckEdit();
            this.ckIsNam = new DevExpress.XtraEditors.CheckEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtTuoi = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPaneSinhVien)).BeginInit();
            this.navigationPaneSinhVien.SuspendLayout();
            this.navigationPageQlSinhVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlQuanLyGiaoVien)).BeginInit();
            this.groupControlQuanLyGiaoVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckIsNu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckIsNam.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // navigationPaneSinhVien
            // 
            this.navigationPaneSinhVien.Controls.Add(this.navigationPageQlSinhVien);
            this.navigationPaneSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPaneSinhVien.Location = new System.Drawing.Point(0, 0);
            this.navigationPaneSinhVien.Name = "navigationPaneSinhVien";
            this.navigationPaneSinhVien.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPageQlSinhVien});
            this.navigationPaneSinhVien.RegularSize = new System.Drawing.Size(1208, 553);
            this.navigationPaneSinhVien.SelectedPage = this.navigationPageQlSinhVien;
            this.navigationPaneSinhVien.Size = new System.Drawing.Size(1208, 553);
            this.navigationPaneSinhVien.TabIndex = 8;
            this.navigationPaneSinhVien.Text = "Quản Lý Sinh Viên";
            // 
            // navigationPageQlSinhVien
            // 
            this.navigationPageQlSinhVien.Caption = "Quản Lý Lớp Học";
            this.navigationPageQlSinhVien.Controls.Add(this.gridControlSV);
            this.navigationPageQlSinhVien.Controls.Add(this.groupControlQuanLyGiaoVien);
            this.navigationPageQlSinhVien.Name = "navigationPageQlSinhVien";
            this.navigationPageQlSinhVien.Size = new System.Drawing.Size(1052, 482);
            // 
            // gridControlSV
            // 
            this.gridControlSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSV.Location = new System.Drawing.Point(0, 0);
            this.gridControlSV.MainView = this.gridView2;
            this.gridControlSV.Name = "gridControlSV";
            this.gridControlSV.Size = new System.Drawing.Size(652, 482);
            this.gridControlSV.TabIndex = 6;
            this.gridControlSV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2,
            this.gridView1});
            this.gridControlSV.Click += new System.EventHandler(this.gridControlGiaoVien_Click);
            // 
            // gridView2
            // 
            this.gridView2.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(222)))));
            this.gridView2.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(199)))), ((int)(((byte)(146)))));
            this.gridView2.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(222)))));
            this.gridView2.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView2.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView2.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView2.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView2.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(244)))));
            this.gridView2.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(222)))), ((int)(((byte)(183)))));
            this.gridView2.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(244)))));
            this.gridView2.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView2.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridView2.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridView2.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridView2.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.Empty.Options.UseBackColor = true;
            this.gridView2.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(222)))));
            this.gridView2.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView2.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridView2.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(222)))));
            this.gridView2.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(199)))), ((int)(((byte)(146)))));
            this.gridView2.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(222)))));
            this.gridView2.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView2.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridView2.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridView2.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridView2.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(158)))), ((int)(((byte)(126)))));
            this.gridView2.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridView2.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(128)))), ((int)(((byte)(88)))));
            this.gridView2.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView2.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView2.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView2.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(160)))), ((int)(((byte)(112)))));
            this.gridView2.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridView2.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView2.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView2.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(222)))));
            this.gridView2.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(199)))), ((int)(((byte)(146)))));
            this.gridView2.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(222)))));
            this.gridView2.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView2.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridView2.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(195)))));
            this.gridView2.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(195)))));
            this.gridView2.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridView2.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridView2.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridView2.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(195)))));
            this.gridView2.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(195)))));
            this.gridView2.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridView2.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridView2.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridView2.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView2.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridView2.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(158)))), ((int)(((byte)(126)))));
            this.gridView2.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(222)))));
            this.gridView2.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(195)))));
            this.gridView2.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(195)))));
            this.gridView2.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridView2.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridView2.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gridView2.Appearance.GroupRow.Options.UseFont = true;
            this.gridView2.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView2.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(222)))));
            this.gridView2.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(199)))), ((int)(((byte)(146)))));
            this.gridView2.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(222)))));
            this.gridView2.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView2.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView2.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(207)))), ((int)(((byte)(170)))));
            this.gridView2.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(160)))), ((int)(((byte)(112)))));
            this.gridView2.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView2.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView2.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(168)))), ((int)(((byte)(128)))));
            this.gridView2.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridView2.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(247)))));
            this.gridView2.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(160)))), ((int)(((byte)(112)))));
            this.gridView2.Appearance.Preview.Options.UseBackColor = true;
            this.gridView2.Appearance.Preview.Options.UseForeColor = true;
            this.gridView2.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.Row.Options.UseBackColor = true;
            this.gridView2.Appearance.Row.Options.UseForeColor = true;
            this.gridView2.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView2.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(178)))), ((int)(((byte)(133)))));
            this.gridView2.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridView2.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView2.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView2.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gridView2.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(160)))), ((int)(((byte)(188)))));
            this.gridView2.Appearance.VertLine.Options.UseBackColor = true;
            this.gridView2.AutoFillColumn = this.hoTen;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.hoTen,
            this.tuoi,
            this.gioiTinh,
            this.khoa,
            this.msSV,
            this.diaChi});
            this.gridView2.GridControl = this.gridControlSV;
            this.gridView2.HorzScrollStep = 20;
            this.gridView2.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gridView2.OptionsBehavior.ReadOnly = true;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView2.PaintStyleName = "MixedXP";
            this.gridView2.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView2_RowCellClick);
            // 
            // hoTen
            // 
            this.hoTen.Caption = "Họ Tên";
            this.hoTen.FieldName = "hoTen";
            this.hoTen.Name = "hoTen";
            this.hoTen.OptionsColumn.ReadOnly = true;
            this.hoTen.OptionsFilter.AllowAutoFilter = false;
            this.hoTen.OptionsFilter.AllowFilter = false;
            this.hoTen.Visible = true;
            this.hoTen.VisibleIndex = 1;
            this.hoTen.Width = 163;
            // 
            // tuoi
            // 
            this.tuoi.Caption = "Tuổi";
            this.tuoi.FieldName = "tuoi";
            this.tuoi.Name = "tuoi";
            this.tuoi.OptionsColumn.ReadOnly = true;
            this.tuoi.Visible = true;
            this.tuoi.VisibleIndex = 2;
            this.tuoi.Width = 163;
            // 
            // gioiTinh
            // 
            this.gioiTinh.Caption = "Giới Tính";
            this.gioiTinh.FieldName = "gioiTinh";
            this.gioiTinh.Name = "gioiTinh";
            this.gioiTinh.OptionsColumn.ReadOnly = true;
            this.gioiTinh.Visible = true;
            this.gioiTinh.VisibleIndex = 3;
            this.gioiTinh.Width = 163;
            // 
            // khoa
            // 
            this.khoa.Caption = "Khoa";
            this.khoa.FieldName = "khoa";
            this.khoa.Name = "khoa";
            this.khoa.OptionsColumn.ReadOnly = true;
            this.khoa.Visible = true;
            this.khoa.VisibleIndex = 4;
            this.khoa.Width = 140;
            // 
            // msSV
            // 
            this.msSV.Caption = "MSSV";
            this.msSV.FieldName = "msSV";
            this.msSV.Name = "msSV";
            this.msSV.OptionsColumn.ReadOnly = true;
            this.msSV.Visible = true;
            this.msSV.VisibleIndex = 0;
            this.msSV.Width = 186;
            // 
            // diaChi
            // 
            this.diaChi.Caption = "Địa Chỉ";
            this.diaChi.FieldName = "diaChi";
            this.diaChi.Name = "diaChi";
            this.diaChi.Visible = true;
            this.diaChi.VisibleIndex = 5;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlSV;
            this.gridView1.Name = "gridView1";
            // 
            // groupControlQuanLyGiaoVien
            // 
            this.groupControlQuanLyGiaoVien.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.groupControlQuanLyGiaoVien.Appearance.Options.UseFont = true;
            this.groupControlQuanLyGiaoVien.Controls.Add(this.label7);
            this.groupControlQuanLyGiaoVien.Controls.Add(this.txtMSSV);
            this.groupControlQuanLyGiaoVien.Controls.Add(this.rtxtDiaChi);
            this.groupControlQuanLyGiaoVien.Controls.Add(this.label6);
            this.groupControlQuanLyGiaoVien.Controls.Add(this.cmbKhoa);
            this.groupControlQuanLyGiaoVien.Controls.Add(this.ckIsNu);
            this.groupControlQuanLyGiaoVien.Controls.Add(this.ckIsNam);
            this.groupControlQuanLyGiaoVien.Controls.Add(this.label4);
            this.groupControlQuanLyGiaoVien.Controls.Add(this.label3);
            this.groupControlQuanLyGiaoVien.Controls.Add(this.label2);
            this.groupControlQuanLyGiaoVien.Controls.Add(this.label5);
            this.groupControlQuanLyGiaoVien.Controls.Add(this.label1);
            this.groupControlQuanLyGiaoVien.Controls.Add(this.txtPhone);
            this.groupControlQuanLyGiaoVien.Controls.Add(this.txtTuoi);
            this.groupControlQuanLyGiaoVien.Controls.Add(this.txtHoTen);
            this.groupControlQuanLyGiaoVien.Controls.Add(this.btnSua);
            this.groupControlQuanLyGiaoVien.Controls.Add(this.btnXoa);
            this.groupControlQuanLyGiaoVien.Controls.Add(this.btnHuy);
            this.groupControlQuanLyGiaoVien.Controls.Add(this.btnThem);
            this.groupControlQuanLyGiaoVien.Controls.Add(this.btnLuu);
            this.groupControlQuanLyGiaoVien.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControlQuanLyGiaoVien.Location = new System.Drawing.Point(652, 0);
            this.groupControlQuanLyGiaoVien.Name = "groupControlQuanLyGiaoVien";
            this.groupControlQuanLyGiaoVien.Size = new System.Drawing.Size(400, 482);
            this.groupControlQuanLyGiaoVien.TabIndex = 5;
            this.groupControlQuanLyGiaoVien.Text = "Quản Lý Sinh Viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(96, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Mã Số Sinh Viên";
            // 
            // txtMSSV
            // 
            this.txtMSSV.Enabled = false;
            this.txtMSSV.Location = new System.Drawing.Point(220, 39);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(60, 23);
            this.txtMSSV.TabIndex = 10;
            // 
            // rtxtDiaChi
            // 
            this.rtxtDiaChi.Location = new System.Drawing.Point(172, 261);
            this.rtxtDiaChi.Name = "rtxtDiaChi";
            this.rtxtDiaChi.Size = new System.Drawing.Size(181, 96);
            this.rtxtDiaChi.TabIndex = 9;
            this.rtxtDiaChi.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Địa Chỉ";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(175, 387);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(172, 24);
            this.cmbKhoa.TabIndex = 6;
            // 
            // ckIsNu
            // 
            this.ckIsNu.Location = new System.Drawing.Point(175, 187);
            this.ckIsNu.Name = "ckIsNu";
            this.ckIsNu.Properties.Caption = "Nữ";
            this.ckIsNu.Size = new System.Drawing.Size(75, 21);
            this.ckIsNu.TabIndex = 4;
            // 
            // ckIsNam
            // 
            this.ckIsNam.Location = new System.Drawing.Point(278, 187);
            this.ckIsNam.Name = "ckIsNam";
            this.ckIsNam.Properties.Caption = "Nam";
            this.ckIsNam.Size = new System.Drawing.Size(75, 20);
            this.ckIsNam.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Khoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Giới Tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tuổi";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "sdt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Họ Tên ";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(175, 232);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(178, 23);
            this.txtPhone.TabIndex = 2;
            // 
            // txtTuoi
            // 
            this.txtTuoi.Location = new System.Drawing.Point(175, 145);
            this.txtTuoi.Name = "txtTuoi";
            this.txtTuoi.Size = new System.Drawing.Size(39, 23);
            this.txtTuoi.TabIndex = 2;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(175, 107);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(178, 23);
            this.txtHoTen.TabIndex = 2;
            // 
            // btnSua
            // 
            this.btnSua.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.Location = new System.Drawing.Point(44, 432);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(41, 29);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Location = new System.Drawing.Point(117, 432);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(41, 29);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Location = new System.Drawing.Point(189, 432);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(41, 29);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Location = new System.Drawing.Point(259, 432);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(41, 29);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Location = new System.Drawing.Point(327, 432);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(41, 29);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // HocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 553);
            this.Controls.Add(this.navigationPaneSinhVien);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HocSinh";
            this.Text = "Sinh Viên";
            this.Load += new System.EventHandler(this.HocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPaneSinhVien)).EndInit();
            this.navigationPaneSinhVien.ResumeLayout(false);
            this.navigationPageQlSinhVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlQuanLyGiaoVien)).EndInit();
            this.groupControlQuanLyGiaoVien.ResumeLayout(false);
            this.groupControlQuanLyGiaoVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckIsNu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckIsNam.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationPane navigationPaneSinhVien;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPageQlSinhVien;
        private DevExpress.XtraGrid.GridControl gridControlSV;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn hoTen;
        private DevExpress.XtraGrid.Columns.GridColumn tuoi;
        private DevExpress.XtraGrid.Columns.GridColumn gioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn khoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControlQuanLyGiaoVien;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private DevExpress.XtraEditors.CheckEdit ckIsNu;
        private DevExpress.XtraEditors.CheckEdit ckIsNam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtTuoi;
        private System.Windows.Forms.TextBox txtHoTen;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private System.Windows.Forms.RichTextBox rtxtDiaChi;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraGrid.Columns.GridColumn msSV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMSSV;
        private DevExpress.XtraGrid.Columns.GridColumn diaChi;
    }
}