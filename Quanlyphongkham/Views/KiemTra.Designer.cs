namespace Quanlyphongkham.Views
{
    partial class KiemTra
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
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.kiemTraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyPhongKhamDataSet2 = new Quanlyphongkham.QuanLyPhongKhamDataSet2();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKiemTra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoaDon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtTenKiemTra = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kiemTraTableAdapter = new Quanlyphongkham.QuanLyPhongKhamDataSet2TableAdapters.KiemTraTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiemTraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyPhongKhamDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.Location = new System.Drawing.Point(754, 115);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.Location = new System.Drawing.Point(673, 115);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.Location = new System.Drawing.Point(591, 115);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.kiemTraBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 144);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(883, 329);
            this.gridControl1.TabIndex = 14;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // kiemTraBindingSource
            // 
            this.kiemTraBindingSource.DataMember = "KiemTra";
            this.kiemTraBindingSource.DataSource = this.quanLyPhongKhamDataSet2;
            // 
            // quanLyPhongKhamDataSet2
            // 
            this.quanLyPhongKhamDataSet2.DataSetName = "QuanLyPhongKhamDataSet2";
            this.quanLyPhongKhamDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colKiemTra,
            this.colHoaDon});
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
            // colKiemTra
            // 
            this.colKiemTra.FieldName = "KiemTra";
            this.colKiemTra.MinWidth = 25;
            this.colKiemTra.Name = "colKiemTra";
            this.colKiemTra.Visible = true;
            this.colKiemTra.VisibleIndex = 1;
            this.colKiemTra.Width = 94;
            // 
            // colHoaDon
            // 
            this.colHoaDon.FieldName = "HoaDon";
            this.colHoaDon.MinWidth = 25;
            this.colHoaDon.Name = "colHoaDon";
            this.colHoaDon.Visible = true;
            this.colHoaDon.VisibleIndex = 2;
            this.colHoaDon.Width = 94;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDonGia.Location = new System.Drawing.Point(205, 112);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(100, 23);
            this.txtDonGia.TabIndex = 13;
            // 
            // txtTenKiemTra
            // 
            this.txtTenKiemTra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenKiemTra.Location = new System.Drawing.Point(205, 75);
            this.txtTenKiemTra.Name = "txtTenKiemTra";
            this.txtTenKiemTra.Size = new System.Drawing.Size(100, 23);
            this.txtTenKiemTra.TabIndex = 12;
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtID.Location = new System.Drawing.Point(205, 38);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 23);
            this.txtID.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Đơn Giá";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên Kiểm Tra";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID";
            // 
            // kiemTraTableAdapter
            // 
            this.kiemTraTableAdapter.ClearBeforeFill = true;
            // 
            // KiemTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 473);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtTenKiemTra);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KiemTra";
            this.Text = "frmKiemTra";
            this.Load += new System.EventHandler(this.frmKiemTra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiemTraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyPhongKhamDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colKiemTra;
        private DevExpress.XtraGrid.Columns.GridColumn colHoaDon;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtTenKiemTra;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private QuanLyPhongKhamDataSet2 quanLyPhongKhamDataSet2;
        private System.Windows.Forms.BindingSource kiemTraBindingSource;
        private QuanLyPhongKhamDataSet2TableAdapters.KiemTraTableAdapter kiemTraTableAdapter;
    }
}