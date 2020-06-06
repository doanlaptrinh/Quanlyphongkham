namespace Quanlyphongkham.Views
{
    partial class Thuoc
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
            this.thuocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyPhongKhamDataSet3 = new Quanlyphongkham.QuanLyPhongKhamDataSet3();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenThuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTacDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCachDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHamLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThanhPhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonVi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.thuocTableAdapter = new Quanlyphongkham.QuanLyPhongKhamDataSet3TableAdapters.ThuocTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyPhongKhamDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.thuocBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(938, 430);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // thuocBindingSource
            // 
            this.thuocBindingSource.DataMember = "Thuoc";
            this.thuocBindingSource.DataSource = this.quanLyPhongKhamDataSet3;
            // 
            // quanLyPhongKhamDataSet3
            // 
            this.quanLyPhongKhamDataSet3.DataSetName = "QuanLyPhongKhamDataSet3";
            this.quanLyPhongKhamDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colTenThuoc,
            this.colTacDung,
            this.colCachDung,
            this.colHamLuong,
            this.colThanhPhan,
            this.colDonVi,
            this.colGhiChu});
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
            // colTenThuoc
            // 
            this.colTenThuoc.Caption = "Tên Thuốc";
            this.colTenThuoc.FieldName = "TenThuoc";
            this.colTenThuoc.MinWidth = 25;
            this.colTenThuoc.Name = "colTenThuoc";
            this.colTenThuoc.Visible = true;
            this.colTenThuoc.VisibleIndex = 1;
            this.colTenThuoc.Width = 94;
            // 
            // colTacDung
            // 
            this.colTacDung.Caption = "Tác Dụng";
            this.colTacDung.FieldName = "TacDung";
            this.colTacDung.MinWidth = 25;
            this.colTacDung.Name = "colTacDung";
            this.colTacDung.Visible = true;
            this.colTacDung.VisibleIndex = 2;
            this.colTacDung.Width = 94;
            // 
            // colCachDung
            // 
            this.colCachDung.Caption = "Cách Dùng";
            this.colCachDung.FieldName = "CachDung";
            this.colCachDung.MinWidth = 25;
            this.colCachDung.Name = "colCachDung";
            this.colCachDung.Visible = true;
            this.colCachDung.VisibleIndex = 3;
            this.colCachDung.Width = 94;
            // 
            // colHamLuong
            // 
            this.colHamLuong.Caption = "Hàm Lượng";
            this.colHamLuong.FieldName = "HamLuong";
            this.colHamLuong.MinWidth = 25;
            this.colHamLuong.Name = "colHamLuong";
            this.colHamLuong.Visible = true;
            this.colHamLuong.VisibleIndex = 4;
            this.colHamLuong.Width = 94;
            // 
            // colThanhPhan
            // 
            this.colThanhPhan.Caption = "Thành Phần";
            this.colThanhPhan.FieldName = "ThanhPhan";
            this.colThanhPhan.MinWidth = 25;
            this.colThanhPhan.Name = "colThanhPhan";
            this.colThanhPhan.Visible = true;
            this.colThanhPhan.VisibleIndex = 5;
            this.colThanhPhan.Width = 94;
            // 
            // colDonVi
            // 
            this.colDonVi.Caption = "Đơn Vị";
            this.colDonVi.FieldName = "DonVi";
            this.colDonVi.MinWidth = 25;
            this.colDonVi.Name = "colDonVi";
            this.colDonVi.Visible = true;
            this.colDonVi.VisibleIndex = 6;
            this.colDonVi.Width = 94;
            // 
            // colGhiChu
            // 
            this.colGhiChu.Caption = "Ghi Chú";
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.MinWidth = 25;
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 7;
            this.colGhiChu.Width = 94;
            // 
            // thuocTableAdapter
            // 
            this.thuocTableAdapter.ClearBeforeFill = true;
            // 
            // Thuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 430);
            this.Controls.Add(this.gridControl1);
            this.Name = "Thuoc";
            this.Text = "Thuốc";
            this.Load += new System.EventHandler(this.Thuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyPhongKhamDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private QuanLyPhongKhamDataSet3 quanLyPhongKhamDataSet3;
        private System.Windows.Forms.BindingSource thuocBindingSource;
        private QuanLyPhongKhamDataSet3TableAdapters.ThuocTableAdapter thuocTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colTenThuoc;
        private DevExpress.XtraGrid.Columns.GridColumn colTacDung;
        private DevExpress.XtraGrid.Columns.GridColumn colCachDung;
        private DevExpress.XtraGrid.Columns.GridColumn colHamLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colThanhPhan;
        private DevExpress.XtraGrid.Columns.GridColumn colDonVi;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
    }
}