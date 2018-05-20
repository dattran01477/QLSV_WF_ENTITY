namespace DoAnCuoiKyWF
{
    partial class NamHoc
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
            this.navigationPageQlNamHoc = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.gridControlNamHoc = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenNamHoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tgBatDau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tgKetThuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControlQuanLyNamHoc = new DevExpress.XtraEditors.GroupControl();
            this.txtNamHoc = new DevExpress.XtraEditors.TextEdit();
            this.dtTGKT = new System.Windows.Forms.DateTimePicker();
            this.dtTGBD = new System.Windows.Forms.DateTimePicker();
            this.lbTGKetThucNamHoc = new System.Windows.Forms.Label();
            this.lbTGBatDauNamHoc = new System.Windows.Forms.Label();
            this.lbNamHoc = new System.Windows.Forms.Label();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.navigationPaneNamHoc = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPageQlNamHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNamHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlQuanLyNamHoc)).BeginInit();
            this.groupControlQuanLyNamHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPaneNamHoc)).BeginInit();
            this.navigationPaneNamHoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationPageQlNamHoc
            // 
            this.navigationPageQlNamHoc.Caption = "Quản Lý Năm Học";
            this.navigationPageQlNamHoc.Controls.Add(this.gridControlNamHoc);
            this.navigationPageQlNamHoc.Controls.Add(this.groupControlQuanLyNamHoc);
            this.navigationPageQlNamHoc.Name = "navigationPageQlNamHoc";
            this.navigationPageQlNamHoc.Size = new System.Drawing.Size(900, 382);
            // 
            // gridControlNamHoc
            // 
            this.gridControlNamHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlNamHoc.Location = new System.Drawing.Point(0, 0);
            this.gridControlNamHoc.MainView = this.gridView2;
            this.gridControlNamHoc.Name = "gridControlNamHoc";
            this.gridControlNamHoc.Size = new System.Drawing.Size(500, 382);
            this.gridControlNamHoc.TabIndex = 6;
            this.gridControlNamHoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
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
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.tenNamHoc,
            this.tgBatDau,
            this.tgKetThuc});
            this.gridView2.GridControl = this.gridControlNamHoc;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gridView2.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView2.PaintStyleName = "MixedXP";
            this.gridView2.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView2_RowCellClick);
            // 
            // STT
            // 
            this.STT.Caption = "STT";
            this.STT.FieldName = "msNamHoc";
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 109;
            // 
            // tenNamHoc
            // 
            this.tenNamHoc.Caption = "Năm Học";
            this.tenNamHoc.FieldName = "tenNamHoc";
            this.tenNamHoc.Name = "tenNamHoc";
            this.tenNamHoc.Visible = true;
            this.tenNamHoc.VisibleIndex = 1;
            this.tenNamHoc.Width = 180;
            // 
            // tgBatDau
            // 
            this.tgBatDau.Caption = "Thời Gian Bắt Đầu";
            this.tgBatDau.FieldName = "tgBatDau";
            this.tgBatDau.Name = "tgBatDau";
            this.tgBatDau.Visible = true;
            this.tgBatDau.VisibleIndex = 2;
            this.tgBatDau.Width = 260;
            // 
            // tgKetThuc
            // 
            this.tgKetThuc.Caption = "Thời Gian Kết Thúc";
            this.tgKetThuc.FieldName = "tgKetThuc";
            this.tgKetThuc.Name = "tgKetThuc";
            this.tgKetThuc.Visible = true;
            this.tgKetThuc.VisibleIndex = 3;
            this.tgKetThuc.Width = 266;
            // 
            // groupControlQuanLyNamHoc
            // 
            this.groupControlQuanLyNamHoc.Controls.Add(this.txtNamHoc);
            this.groupControlQuanLyNamHoc.Controls.Add(this.dtTGKT);
            this.groupControlQuanLyNamHoc.Controls.Add(this.dtTGBD);
            this.groupControlQuanLyNamHoc.Controls.Add(this.lbTGKetThucNamHoc);
            this.groupControlQuanLyNamHoc.Controls.Add(this.lbTGBatDauNamHoc);
            this.groupControlQuanLyNamHoc.Controls.Add(this.lbNamHoc);
            this.groupControlQuanLyNamHoc.Controls.Add(this.btnSua);
            this.groupControlQuanLyNamHoc.Controls.Add(this.btnXoa);
            this.groupControlQuanLyNamHoc.Controls.Add(this.btnHuy);
            this.groupControlQuanLyNamHoc.Controls.Add(this.btnThem);
            this.groupControlQuanLyNamHoc.Controls.Add(this.btnLuu);
            this.groupControlQuanLyNamHoc.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControlQuanLyNamHoc.Location = new System.Drawing.Point(500, 0);
            this.groupControlQuanLyNamHoc.Name = "groupControlQuanLyNamHoc";
            this.groupControlQuanLyNamHoc.Size = new System.Drawing.Size(400, 382);
            this.groupControlQuanLyNamHoc.TabIndex = 5;
            this.groupControlQuanLyNamHoc.Text = "Quản Lý Năm Học";
            // 
            // txtNamHoc
            // 
            this.txtNamHoc.Location = new System.Drawing.Point(165, 48);
            this.txtNamHoc.Name = "txtNamHoc";
            this.txtNamHoc.Size = new System.Drawing.Size(199, 22);
            this.txtNamHoc.TabIndex = 9;
            // 
            // dtTGKT
            // 
            this.dtTGKT.Location = new System.Drawing.Point(165, 119);
            this.dtTGKT.Name = "dtTGKT";
            this.dtTGKT.Size = new System.Drawing.Size(200, 23);
            this.dtTGKT.TabIndex = 8;
            // 
            // dtTGBD
            // 
            this.dtTGBD.Location = new System.Drawing.Point(165, 80);
            this.dtTGBD.Name = "dtTGBD";
            this.dtTGBD.Size = new System.Drawing.Size(200, 23);
            this.dtTGBD.TabIndex = 8;
            // 
            // lbTGKetThucNamHoc
            // 
            this.lbTGKetThucNamHoc.AutoSize = true;
            this.lbTGKetThucNamHoc.Location = new System.Drawing.Point(43, 125);
            this.lbTGKetThucNamHoc.Name = "lbTGKetThucNamHoc";
            this.lbTGKetThucNamHoc.Size = new System.Drawing.Size(123, 17);
            this.lbTGKetThucNamHoc.TabIndex = 6;
            this.lbTGKetThucNamHoc.Text = "Thời Gian Kết Thúc";
            // 
            // lbTGBatDauNamHoc
            // 
            this.lbTGBatDauNamHoc.AutoSize = true;
            this.lbTGBatDauNamHoc.Location = new System.Drawing.Point(43, 85);
            this.lbTGBatDauNamHoc.Name = "lbTGBatDauNamHoc";
            this.lbTGBatDauNamHoc.Size = new System.Drawing.Size(117, 17);
            this.lbTGBatDauNamHoc.TabIndex = 6;
            this.lbTGBatDauNamHoc.Text = "Thời Gian Bắt Đầu";
            // 
            // lbNamHoc
            // 
            this.lbNamHoc.AutoSize = true;
            this.lbNamHoc.Location = new System.Drawing.Point(43, 48);
            this.lbNamHoc.Name = "lbNamHoc";
            this.lbNamHoc.Size = new System.Drawing.Size(64, 17);
            this.lbNamHoc.TabIndex = 5;
            this.lbNamHoc.Text = "Năm Học";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(119, 182);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(41, 29);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(192, 182);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(41, 29);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(264, 182);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(41, 29);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(46, 182);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(41, 29);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(343, 182);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(41, 29);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // navigationPaneNamHoc
            // 
            this.navigationPaneNamHoc.Controls.Add(this.navigationPageQlNamHoc);
            this.navigationPaneNamHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPaneNamHoc.Location = new System.Drawing.Point(0, 0);
            this.navigationPaneNamHoc.Name = "navigationPaneNamHoc";
            this.navigationPaneNamHoc.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPageQlNamHoc});
            this.navigationPaneNamHoc.RegularSize = new System.Drawing.Size(1061, 453);
            this.navigationPaneNamHoc.SelectedPage = this.navigationPageQlNamHoc;
            this.navigationPaneNamHoc.Size = new System.Drawing.Size(1061, 453);
            this.navigationPaneNamHoc.TabIndex = 0;
            this.navigationPaneNamHoc.Text = "navigationPane1";
            // 
            // NamHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 453);
            this.Controls.Add(this.navigationPaneNamHoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NamHoc";
            this.Text = "NamHoc";
            this.Load += new System.EventHandler(this.NamHoc_Load);
            this.navigationPageQlNamHoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNamHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlQuanLyNamHoc)).EndInit();
            this.groupControlQuanLyNamHoc.ResumeLayout(false);
            this.groupControlQuanLyNamHoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPaneNamHoc)).EndInit();
            this.navigationPaneNamHoc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationPage navigationPageQlNamHoc;
        private DevExpress.XtraGrid.GridControl gridControlNamHoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn tenNamHoc;
        private DevExpress.XtraGrid.Columns.GridColumn tgBatDau;
        private DevExpress.XtraGrid.Columns.GridColumn tgKetThuc;
        private DevExpress.XtraEditors.GroupControl groupControlQuanLyNamHoc;
        private System.Windows.Forms.DateTimePicker dtTGKT;
        private System.Windows.Forms.DateTimePicker dtTGBD;
        private System.Windows.Forms.Label lbTGKetThucNamHoc;
        private System.Windows.Forms.Label lbTGBatDauNamHoc;
        private System.Windows.Forms.Label lbNamHoc;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraBars.Navigation.NavigationPane navigationPaneNamHoc;
        private DevExpress.XtraEditors.TextEdit txtNamHoc;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraEditors.SimpleButton btnThem;
    }
}