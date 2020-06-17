namespace Quanlyphongkham.Views
{
    partial class BenhAn
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.lichSuKhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyPhongKhamDataSet = new Quanlyphongkham.QuanLyPhongKhamDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDBenhNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenBenhNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayKham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtGetIDBenhNhan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.kiemTraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donThuocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lichSuKhamTableAdapter = new Quanlyphongkham.QuanLyPhongKhamDataSetTableAdapters.LichSuKhamTableAdapter();
            this.kiemTraTableAdapter = new Quanlyphongkham.QuanLyPhongKhamDataSetTableAdapters.KiemTraTableAdapter();
            this.donThuocTableAdapter = new Quanlyphongkham.QuanLyPhongKhamDataSetTableAdapters.DonThuocTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbIdThuoc = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThemKiemTra = new System.Windows.Forms.Button();
            this.btnThemThuoc = new System.Windows.Forms.Button();
            this.cbIdKiemTra = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.btnXoaKiemTra = new System.Windows.Forms.Button();
            this.btnXoaDonThuoc = new System.Windows.Forms.Button();
            this.quanLyPhongKhamDataSet1 = new Quanlyphongkham.QuanLyPhongKhamDataSet1();
            this.phieuKiemTraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phieuKiemTraTableAdapter = new Quanlyphongkham.QuanLyPhongKhamDataSet1TableAdapters.PhieuKiemTraTableAdapter();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaiKiemTra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiaTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.quanLyPhongKhamDataSet3 = new Quanlyphongkham.QuanLyPhongKhamDataSet3();
            this.phieuDonThuocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phieuDonThuocTableAdapter = new Quanlyphongkham.QuanLyPhongKhamDataSet3TableAdapters.PhieuDonThuocTableAdapter();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenThuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLieuDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSlThuoc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lichSuKhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyPhongKhamDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiemTraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donThuocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyPhongKhamDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuKiemTraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyPhongKhamDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuDonThuocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gridControl1.DataSource = this.lichSuKhamBindingSource;
            this.gridControl1.EmbeddedNavigator.Click += new System.EventHandler(this.gridControl1_EmbeddedNavigator_Click);
            this.gridControl1.Location = new System.Drawing.Point(19, 41);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(827, 147);
            this.gridControl1.TabIndex = 46;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // lichSuKhamBindingSource
            // 
            this.lichSuKhamBindingSource.DataMember = "LichSuKham";
            this.lichSuKhamBindingSource.DataSource = this.quanLyPhongKhamDataSet;
            // 
            // quanLyPhongKhamDataSet
            // 
            this.quanLyPhongKhamDataSet.DataSetName = "QuanLyPhongKhamDataSet";
            this.quanLyPhongKhamDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colIDBenhNhan,
            this.colTenBenhNhan,
            this.colNgayKham});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 25;
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 94;
            // 
            // colIDBenhNhan
            // 
            this.colIDBenhNhan.FieldName = "IDBenhNhan";
            this.colIDBenhNhan.MinWidth = 25;
            this.colIDBenhNhan.Name = "colIDBenhNhan";
            this.colIDBenhNhan.Visible = true;
            this.colIDBenhNhan.VisibleIndex = 1;
            this.colIDBenhNhan.Width = 94;
            // 
            // colTenBenhNhan
            // 
            this.colTenBenhNhan.FieldName = "TenBenhNhan";
            this.colTenBenhNhan.MinWidth = 25;
            this.colTenBenhNhan.Name = "colTenBenhNhan";
            this.colTenBenhNhan.Visible = true;
            this.colTenBenhNhan.VisibleIndex = 2;
            this.colTenBenhNhan.Width = 94;
            // 
            // colNgayKham
            // 
            this.colNgayKham.FieldName = "NgayKham";
            this.colNgayKham.MinWidth = 25;
            this.colNgayKham.Name = "colNgayKham";
            this.colNgayKham.Visible = true;
            this.colNgayKham.VisibleIndex = 3;
            this.colNgayKham.Width = 94;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.Location = new System.Drawing.Point(729, 194);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(117, 23);
            this.btnXoa.TabIndex = 50;
            this.btnXoa.Text = "Xóa Bệnh Án";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtGetIDBenhNhan
            // 
            this.txtGetIDBenhNhan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGetIDBenhNhan.Location = new System.Drawing.Point(109, 12);
            this.txtGetIDBenhNhan.Name = "txtGetIDBenhNhan";
            this.txtGetIDBenhNhan.Size = new System.Drawing.Size(138, 23);
            this.txtGetIDBenhNhan.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 52;
            this.label3.Text = "ID Bệnh Nhân";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(514, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 51;
            this.label2.Text = "Chuẩn Đoán";
            // 
            // textBox8
            // 
            this.textBox8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox8.Location = new System.Drawing.Point(605, 400);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(238, 23);
            this.textBox8.TabIndex = 68;
            // 
            // kiemTraBindingSource
            // 
            this.kiemTraBindingSource.DataMember = "KiemTra";
            this.kiemTraBindingSource.DataSource = this.quanLyPhongKhamDataSet;
            // 
            // donThuocBindingSource
            // 
            this.donThuocBindingSource.DataMember = "DonThuoc";
            this.donThuocBindingSource.DataSource = this.quanLyPhongKhamDataSet;
            // 
            // lichSuKhamTableAdapter
            // 
            this.lichSuKhamTableAdapter.ClearBeforeFill = true;
            // 
            // kiemTraTableAdapter
            // 
            this.kiemTraTableAdapter.ClearBeforeFill = true;
            // 
            // donThuocTableAdapter
            // 
            this.donThuocTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 52;
            this.label4.Text = "Kiểm tra";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 52;
            this.label5.Text = "Kê đơn thuốc";
            // 
            // cbIdThuoc
            // 
            this.cbIdThuoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbIdThuoc.FormattingEnabled = true;
            this.cbIdThuoc.Items.AddRange(new object[] {
            "Thuốc A",
            "Thuốc B",
            "Thuốc C"});
            this.cbIdThuoc.Location = new System.Drawing.Point(105, 399);
            this.cbIdThuoc.Name = "cbIdThuoc";
            this.cbIdThuoc.Size = new System.Drawing.Size(144, 24);
            this.cbIdThuoc.TabIndex = 71;
            this.cbIdThuoc.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.Location = new System.Drawing.Point(253, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 72;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnThemKiemTra
            // 
            this.btnThemKiemTra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThemKiemTra.Location = new System.Drawing.Point(255, 203);
            this.btnThemKiemTra.Name = "btnThemKiemTra";
            this.btnThemKiemTra.Size = new System.Drawing.Size(75, 23);
            this.btnThemKiemTra.TabIndex = 72;
            this.btnThemKiemTra.Text = "Thêm";
            this.btnThemKiemTra.UseVisualStyleBackColor = true;
            this.btnThemKiemTra.Click += new System.EventHandler(this.btnThemKiemTra_Click);
            // 
            // btnThemThuoc
            // 
            this.btnThemThuoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThemThuoc.Location = new System.Drawing.Point(357, 400);
            this.btnThemThuoc.Name = "btnThemThuoc";
            this.btnThemThuoc.Size = new System.Drawing.Size(75, 23);
            this.btnThemThuoc.TabIndex = 72;
            this.btnThemThuoc.Text = "Thêm";
            this.btnThemThuoc.UseVisualStyleBackColor = true;
            this.btnThemThuoc.Click += new System.EventHandler(this.btnThemThuoc_Click);
            // 
            // cbIdKiemTra
            // 
            this.cbIdKiemTra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbIdKiemTra.FormattingEnabled = true;
            this.cbIdKiemTra.Items.AddRange(new object[] {
            "Xét Nghiệm Máu",
            "Chụp X Quang"});
            this.cbIdKiemTra.Location = new System.Drawing.Point(111, 202);
            this.cbIdKiemTra.Name = "cbIdKiemTra";
            this.cbIdKiemTra.Size = new System.Drawing.Size(138, 24);
            this.cbIdKiemTra.TabIndex = 71;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button5.Location = new System.Drawing.Point(375, 587);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 23);
            this.button5.TabIndex = 73;
            this.button5.Text = "In Hóa Đơn";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnXoaKiemTra
            // 
            this.btnXoaKiemTra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoaKiemTra.Location = new System.Drawing.Point(731, 371);
            this.btnXoaKiemTra.Name = "btnXoaKiemTra";
            this.btnXoaKiemTra.Size = new System.Drawing.Size(113, 23);
            this.btnXoaKiemTra.TabIndex = 72;
            this.btnXoaKiemTra.Text = "Xóa Kiểm Tra";
            this.btnXoaKiemTra.UseVisualStyleBackColor = true;
            this.btnXoaKiemTra.Click += new System.EventHandler(this.btnXoaKiemTra_Click);
            // 
            // btnXoaDonThuoc
            // 
            this.btnXoaDonThuoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoaDonThuoc.Location = new System.Drawing.Point(725, 568);
            this.btnXoaDonThuoc.Name = "btnXoaDonThuoc";
            this.btnXoaDonThuoc.Size = new System.Drawing.Size(118, 23);
            this.btnXoaDonThuoc.TabIndex = 50;
            this.btnXoaDonThuoc.Text = "Xóa Đơn Thuốc";
            this.btnXoaDonThuoc.UseVisualStyleBackColor = true;
            this.btnXoaDonThuoc.Click += new System.EventHandler(this.btnXoaDonThuoc_Click);
            // 
            // quanLyPhongKhamDataSet1
            // 
            this.quanLyPhongKhamDataSet1.DataSetName = "QuanLyPhongKhamDataSet1";
            this.quanLyPhongKhamDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phieuKiemTraBindingSource
            // 
            this.phieuKiemTraBindingSource.DataMember = "PhieuKiemTra";
            this.phieuKiemTraBindingSource.DataSource = this.quanLyPhongKhamDataSet1;
            // 
            // phieuKiemTraTableAdapter
            // 
            this.phieuKiemTraTableAdapter.ClearBeforeFill = true;
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gridControl2.DataSource = this.phieuKiemTraBindingSource;
            this.gridControl2.Location = new System.Drawing.Point(19, 232);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(827, 133);
            this.gridControl2.TabIndex = 74;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControl2.Click += new System.EventHandler(this.gridControl2_Click_1);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colLoaiKiemTra,
            this.colGiaTien,
            this.gridColumn1});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // colSTT
            // 
            this.colSTT.FieldName = "STT";
            this.colSTT.MinWidth = 25;
            this.colSTT.Name = "colSTT";
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 0;
            this.colSTT.Width = 94;
            // 
            // colLoaiKiemTra
            // 
            this.colLoaiKiemTra.Caption = "Tên Kiểm Tra";
            this.colLoaiKiemTra.FieldName = "LoaiKiemTra";
            this.colLoaiKiemTra.MinWidth = 25;
            this.colLoaiKiemTra.Name = "colLoaiKiemTra";
            this.colLoaiKiemTra.Visible = true;
            this.colLoaiKiemTra.VisibleIndex = 1;
            this.colLoaiKiemTra.Width = 94;
            // 
            // colGiaTien
            // 
            this.colGiaTien.Caption = "Đơn Giá";
            this.colGiaTien.FieldName = "GiaTien";
            this.colGiaTien.MinWidth = 25;
            this.colGiaTien.Name = "colGiaTien";
            this.colGiaTien.Visible = true;
            this.colGiaTien.VisibleIndex = 2;
            this.colGiaTien.Width = 94;
            // 
            // gridColumn1
            // 
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Width = 94;
            // 
            // quanLyPhongKhamDataSet3
            // 
            this.quanLyPhongKhamDataSet3.DataSetName = "QuanLyPhongKhamDataSet3";
            this.quanLyPhongKhamDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phieuDonThuocBindingSource
            // 
            this.phieuDonThuocBindingSource.DataMember = "PhieuDonThuoc";
            this.phieuDonThuocBindingSource.DataSource = this.quanLyPhongKhamDataSet3;
            // 
            // phieuDonThuocTableAdapter
            // 
            this.phieuDonThuocTableAdapter.ClearBeforeFill = true;
            // 
            // gridControl3
            // 
            this.gridControl3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gridControl3.DataSource = this.phieuDonThuocBindingSource;
            this.gridControl3.Location = new System.Drawing.Point(19, 427);
            this.gridControl3.MainView = this.gridView3;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(824, 135);
            this.gridControl3.TabIndex = 75;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT1,
            this.colTenThuoc,
            this.colSoLuong,
            this.colLieuDung,
            this.colGhiChu,
            this.colDonGia});
            this.gridView3.GridControl = this.gridControl3;
            this.gridView3.Name = "gridView3";
            // 
            // colSTT1
            // 
            this.colSTT1.FieldName = "STT";
            this.colSTT1.MinWidth = 25;
            this.colSTT1.Name = "colSTT1";
            this.colSTT1.Visible = true;
            this.colSTT1.VisibleIndex = 0;
            this.colSTT1.Width = 94;
            // 
            // colTenThuoc
            // 
            this.colTenThuoc.FieldName = "TenThuoc";
            this.colTenThuoc.MinWidth = 25;
            this.colTenThuoc.Name = "colTenThuoc";
            this.colTenThuoc.Visible = true;
            this.colTenThuoc.VisibleIndex = 1;
            this.colTenThuoc.Width = 94;
            // 
            // colSoLuong
            // 
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.MinWidth = 25;
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 2;
            this.colSoLuong.Width = 94;
            // 
            // colLieuDung
            // 
            this.colLieuDung.FieldName = "LieuDung";
            this.colLieuDung.MinWidth = 25;
            this.colLieuDung.Name = "colLieuDung";
            this.colLieuDung.Visible = true;
            this.colLieuDung.VisibleIndex = 3;
            this.colLieuDung.Width = 94;
            // 
            // colGhiChu
            // 
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.MinWidth = 25;
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 4;
            this.colGhiChu.Width = 94;
            // 
            // colDonGia
            // 
            this.colDonGia.FieldName = "DonGia";
            this.colDonGia.MinWidth = 25;
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.Visible = true;
            this.colDonGia.VisibleIndex = 5;
            this.colDonGia.Width = 94;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 76;
            this.label1.Text = "SL";
            // 
            // txtSlThuoc
            // 
            this.txtSlThuoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSlThuoc.Location = new System.Drawing.Point(284, 399);
            this.txtSlThuoc.Name = "txtSlThuoc";
            this.txtSlThuoc.Size = new System.Drawing.Size(67, 23);
            this.txtSlThuoc.TabIndex = 77;
            // 
            // BenhAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 622);
            this.Controls.Add(this.txtSlThuoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridControl3);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnThemThuoc);
            this.Controls.Add(this.btnXoaKiemTra);
            this.Controls.Add(this.btnThemKiemTra);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cbIdKiemTra);
            this.Controls.Add(this.cbIdThuoc);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.txtGetIDBenhNhan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnXoaDonThuoc);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.gridControl1);
            this.Name = "BenhAn";
            this.Text = "Bệnh Án";
            this.Load += new System.EventHandler(this.BenhAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lichSuKhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyPhongKhamDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiemTraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donThuocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyPhongKhamDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuKiemTraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyPhongKhamDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuDonThuocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colIDBenhNhan;
        private DevExpress.XtraGrid.Columns.GridColumn colTenBenhNhan;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayKham;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtGetIDBenhNhan;
        private System.Windows.Forms.Label label3;
     
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox8;
        private QuanLyPhongKhamDataSet quanLyPhongKhamDataSet;
        private System.Windows.Forms.BindingSource lichSuKhamBindingSource;
        private QuanLyPhongKhamDataSetTableAdapters.LichSuKhamTableAdapter lichSuKhamTableAdapter;
        private System.Windows.Forms.BindingSource kiemTraBindingSource;
        private QuanLyPhongKhamDataSetTableAdapters.KiemTraTableAdapter kiemTraTableAdapter;
        private System.Windows.Forms.BindingSource donThuocBindingSource;
        private QuanLyPhongKhamDataSetTableAdapters.DonThuocTableAdapter donThuocTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbIdThuoc;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThemKiemTra;
        private System.Windows.Forms.Button btnThemThuoc;
        private System.Windows.Forms.ComboBox cbIdKiemTra;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnXoaKiemTra;
        private System.Windows.Forms.Button btnXoaDonThuoc;
        private QuanLyPhongKhamDataSet1 quanLyPhongKhamDataSet1;
        private System.Windows.Forms.BindingSource phieuKiemTraBindingSource;
        private QuanLyPhongKhamDataSet1TableAdapters.PhieuKiemTraTableAdapter phieuKiemTraTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaiKiemTra;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaTien;
        private QuanLyPhongKhamDataSet3 quanLyPhongKhamDataSet3;
        private System.Windows.Forms.BindingSource phieuDonThuocBindingSource;
        private QuanLyPhongKhamDataSet3TableAdapters.PhieuDonThuocTableAdapter phieuDonThuocTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT1;
        private DevExpress.XtraGrid.Columns.GridColumn colTenThuoc;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colLieuDung;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn colDonGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSlThuoc;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}