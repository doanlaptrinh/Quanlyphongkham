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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdThuoc = new System.Windows.Forms.TextBox();
            this.txtTenThuoc = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtLieuDung = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDelNV = new System.Windows.Forms.Button();
            this.btnUpdateNV = new System.Windows.Forms.Button();
            this.btnAddNV = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDLichSuKham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenThuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLieuDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.quanLyPhongKhamDataSet4 = new Quanlyphongkham.QuanLyPhongKhamDataSet4();
            this.donThuocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donThuocTableAdapter = new Quanlyphongkham.QuanLyPhongKhamDataSet4TableAdapters.DonThuocTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyPhongKhamDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donThuocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Thuốc";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số Lượng";
            // 
            // txtIdThuoc
            // 
            this.txtIdThuoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIdThuoc.Location = new System.Drawing.Point(352, 27);
            this.txtIdThuoc.Name = "txtIdThuoc";
            this.txtIdThuoc.Size = new System.Drawing.Size(151, 23);
            this.txtIdThuoc.TabIndex = 2;
            // 
            // txtTenThuoc
            // 
            this.txtTenThuoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenThuoc.Location = new System.Drawing.Point(352, 56);
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.Size = new System.Drawing.Size(151, 23);
            this.txtTenThuoc.TabIndex = 3;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSoLuong.Location = new System.Drawing.Point(352, 85);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(151, 23);
            this.txtSoLuong.TabIndex = 4;
            // 
            // txtLieuDung
            // 
            this.txtLieuDung.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLieuDung.Location = new System.Drawing.Point(635, 30);
            this.txtLieuDung.Name = "txtLieuDung";
            this.txtLieuDung.Size = new System.Drawing.Size(151, 23);
            this.txtLieuDung.TabIndex = 5;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDonGia.Location = new System.Drawing.Point(635, 59);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(151, 23);
            this.txtDonGia.TabIndex = 6;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGhiChu.Location = new System.Drawing.Point(635, 88);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(151, 23);
            this.txtGhiChu.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(550, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Liều Dùng";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(550, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Đơn Giá";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(550, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ghi Chú";
            // 
            // btnDelNV
            // 
            this.btnDelNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelNV.Location = new System.Drawing.Point(986, 113);
            this.btnDelNV.Name = "btnDelNV";
            this.btnDelNV.Size = new System.Drawing.Size(70, 23);
            this.btnDelNV.TabIndex = 12;
            this.btnDelNV.Text = "Xóa";
            this.btnDelNV.UseVisualStyleBackColor = true;
            this.btnDelNV.Click += new System.EventHandler(this.btnDelNV_Click);
            // 
            // btnUpdateNV
            // 
            this.btnUpdateNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdateNV.Location = new System.Drawing.Point(905, 113);
            this.btnUpdateNV.Name = "btnUpdateNV";
            this.btnUpdateNV.Size = new System.Drawing.Size(70, 23);
            this.btnUpdateNV.TabIndex = 11;
            this.btnUpdateNV.Text = "Sửa";
            this.btnUpdateNV.UseVisualStyleBackColor = true;
            this.btnUpdateNV.Click += new System.EventHandler(this.btnUpdateNV_Click);
            // 
            // btnAddNV
            // 
            this.btnAddNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddNV.Location = new System.Drawing.Point(824, 113);
            this.btnAddNV.Name = "btnAddNV";
            this.btnAddNV.Size = new System.Drawing.Size(70, 23);
            this.btnAddNV.TabIndex = 10;
            this.btnAddNV.Text = "Thêm";
            this.btnAddNV.UseVisualStyleBackColor = true;
            this.btnAddNV.Click += new System.EventHandler(this.btnAddNV_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtGhiChu);
            this.panel1.Controls.Add(this.btnDelNV);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnUpdateNV);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnAddNV);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtDonGia);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtLieuDung);
            this.panel1.Controls.Add(this.txtSoLuong);
            this.panel1.Controls.Add(this.txtIdThuoc);
            this.panel1.Controls.Add(this.txtTenThuoc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1392, 143);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.gridControl1);
            this.panel2.Location = new System.Drawing.Point(0, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1392, 288);
            this.panel2.TabIndex = 14;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.donThuocBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1392, 288);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colIDLichSuKham,
            this.colTenThuoc,
            this.colSoLuong,
            this.colLieuDung});
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
            // colIDLichSuKham
            // 
            this.colIDLichSuKham.FieldName = "IDLichSuKham";
            this.colIDLichSuKham.MinWidth = 25;
            this.colIDLichSuKham.Name = "colIDLichSuKham";
            this.colIDLichSuKham.Visible = true;
            this.colIDLichSuKham.VisibleIndex = 1;
            this.colIDLichSuKham.Width = 94;
            // 
            // colTenThuoc
            // 
            this.colTenThuoc.FieldName = "TenThuoc";
            this.colTenThuoc.MinWidth = 25;
            this.colTenThuoc.Name = "colTenThuoc";
            this.colTenThuoc.Visible = true;
            this.colTenThuoc.VisibleIndex = 2;
            this.colTenThuoc.Width = 94;
            // 
            // colSoLuong
            // 
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.MinWidth = 25;
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 3;
            this.colSoLuong.Width = 94;
            // 
            // colLieuDung
            // 
            this.colLieuDung.FieldName = "LieuDung";
            this.colLieuDung.MinWidth = 25;
            this.colLieuDung.Name = "colLieuDung";
            this.colLieuDung.Visible = true;
            this.colLieuDung.VisibleIndex = 4;
            this.colLieuDung.Width = 94;
            // 
            // quanLyPhongKhamDataSet4
            // 
            this.quanLyPhongKhamDataSet4.DataSetName = "QuanLyPhongKhamDataSet4";
            this.quanLyPhongKhamDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // donThuocBindingSource
            // 
            this.donThuocBindingSource.DataMember = "DonThuoc";
            this.donThuocBindingSource.DataSource = this.quanLyPhongKhamDataSet4;
            // 
            // donThuocTableAdapter
            // 
            this.donThuocTableAdapter.ClearBeforeFill = true;
            // 
            // Thuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 430);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Thuoc";
            this.Text = "Thuốc";
            this.Load += new System.EventHandler(this.Thuoc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyPhongKhamDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donThuocBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdThuoc;
        private System.Windows.Forms.TextBox txtTenThuoc;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtLieuDung;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDelNV;
        private System.Windows.Forms.Button btnUpdateNV;
        private System.Windows.Forms.Button btnAddNV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colIDLichSuKham;
        private DevExpress.XtraGrid.Columns.GridColumn colTenThuoc;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colLieuDung;
        private QuanLyPhongKhamDataSet4 quanLyPhongKhamDataSet4;
        private System.Windows.Forms.BindingSource donThuocBindingSource;
        private QuanLyPhongKhamDataSet4TableAdapters.DonThuocTableAdapter donThuocTableAdapter;
    }
}