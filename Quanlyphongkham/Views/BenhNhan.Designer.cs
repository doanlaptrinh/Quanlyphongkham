namespace Quanlyphongkham.Views
{
    partial class frmBenhNhan
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
            this.label11 = new System.Windows.Forms.Label();
            this.txtJobpatient = new System.Windows.Forms.TextBox();
            this.txtNotepatient = new System.Windows.Forms.TextBox();
            this.txtGenderpatient = new System.Windows.Forms.TextBox();
            this.txtBornpatient = new System.Windows.Forms.TextBox();
            this.txtIDpatient = new System.Windows.Forms.TextBox();
            this.txtNamepatient = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelpatient = new System.Windows.Forms.Button();
            this.btnUpdatepatient = new System.Windows.Forms.Button();
            this.btnAddpatient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddresspatient = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPhonepatient = new System.Windows.Forms.TextBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.benhNhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyPhongKhamDataSet = new Quanlyphongkham.QuanLyPhongKhamDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenBenhNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgheNghiep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.benhNhanTableAdapter = new Quanlyphongkham.QuanLyPhongKhamDataSetTableAdapters.BenhNhanTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benhNhanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyPhongKhamDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 17);
            this.label11.TabIndex = 44;
            this.label11.Text = "Danh Sách Bệnh Nhân";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtJobpatient
            // 
            this.txtJobpatient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtJobpatient.Location = new System.Drawing.Point(854, 14);
            this.txtJobpatient.Name = "txtJobpatient";
            this.txtJobpatient.Size = new System.Drawing.Size(100, 23);
            this.txtJobpatient.TabIndex = 42;
            // 
            // txtNotepatient
            // 
            this.txtNotepatient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNotepatient.Location = new System.Drawing.Point(854, 48);
            this.txtNotepatient.Name = "txtNotepatient";
            this.txtNotepatient.Size = new System.Drawing.Size(100, 23);
            this.txtNotepatient.TabIndex = 41;
            // 
            // txtGenderpatient
            // 
            this.txtGenderpatient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGenderpatient.Location = new System.Drawing.Point(614, 17);
            this.txtGenderpatient.Name = "txtGenderpatient";
            this.txtGenderpatient.Size = new System.Drawing.Size(100, 23);
            this.txtGenderpatient.TabIndex = 40;
            // 
            // txtBornpatient
            // 
            this.txtBornpatient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBornpatient.Location = new System.Drawing.Point(405, 78);
            this.txtBornpatient.Name = "txtBornpatient";
            this.txtBornpatient.Size = new System.Drawing.Size(100, 23);
            this.txtBornpatient.TabIndex = 39;
            // 
            // txtIDpatient
            // 
            this.txtIDpatient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIDpatient.Location = new System.Drawing.Point(405, 48);
            this.txtIDpatient.Name = "txtIDpatient";
            this.txtIDpatient.Size = new System.Drawing.Size(100, 23);
            this.txtIDpatient.TabIndex = 38;
            // 
            // txtNamepatient
            // 
            this.txtNamepatient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNamepatient.Location = new System.Drawing.Point(405, 17);
            this.txtNamepatient.Name = "txtNamepatient";
            this.txtNamepatient.Size = new System.Drawing.Size(100, 23);
            this.txtNamepatient.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(536, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Điện Thoại";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "Ngày Sinh";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(536, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "Địa Chỉ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(536, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Giới Tính";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "ID";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Tên Bệnh Nhân";
            // 
            // btnDelpatient
            // 
            this.btnDelpatient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelpatient.Location = new System.Drawing.Point(879, 116);
            this.btnDelpatient.Name = "btnDelpatient";
            this.btnDelpatient.Size = new System.Drawing.Size(75, 23);
            this.btnDelpatient.TabIndex = 30;
            this.btnDelpatient.Text = "Xóa";
            this.btnDelpatient.UseVisualStyleBackColor = true;
            this.btnDelpatient.Click += new System.EventHandler(this.btnDelpatient_Click);
            // 
            // btnUpdatepatient
            // 
            this.btnUpdatepatient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdatepatient.Location = new System.Drawing.Point(798, 116);
            this.btnUpdatepatient.Name = "btnUpdatepatient";
            this.btnUpdatepatient.Size = new System.Drawing.Size(75, 23);
            this.btnUpdatepatient.TabIndex = 29;
            this.btnUpdatepatient.Text = "Sửa";
            this.btnUpdatepatient.UseVisualStyleBackColor = true;
            this.btnUpdatepatient.Click += new System.EventHandler(this.btnUpdatepatient_Click);
            // 
            // btnAddpatient
            // 
            this.btnAddpatient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddpatient.Location = new System.Drawing.Point(717, 116);
            this.btnAddpatient.Name = "btnAddpatient";
            this.btnAddpatient.Size = new System.Drawing.Size(75, 23);
            this.btnAddpatient.TabIndex = 28;
            this.btnAddpatient.Text = "Thêm";
            this.btnAddpatient.UseVisualStyleBackColor = true;
            this.btnAddpatient.Click += new System.EventHandler(this.btnAddpatient_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(753, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nghề Nghiệp";
            // 
            // txtAddresspatient
            // 
            this.txtAddresspatient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAddresspatient.Location = new System.Drawing.Point(614, 81);
            this.txtAddresspatient.Name = "txtAddresspatient";
            this.txtAddresspatient.Size = new System.Drawing.Size(100, 23);
            this.txtAddresspatient.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(753, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "Ghi Chú";
            // 
            // txtPhonepatient
            // 
            this.txtPhonepatient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPhonepatient.Location = new System.Drawing.Point(614, 48);
            this.txtPhonepatient.Name = "txtPhonepatient";
            this.txtPhonepatient.Size = new System.Drawing.Size(100, 23);
            this.txtPhonepatient.TabIndex = 41;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.benhNhanBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1303, 261);
            this.gridControl1.TabIndex = 46;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // benhNhanBindingSource
            // 
            this.benhNhanBindingSource.DataMember = "BenhNhan";
            this.benhNhanBindingSource.DataSource = this.quanLyPhongKhamDataSet;
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
            this.colTenBenhNhan,
            this.colNgaySinh,
            this.colGioiTinh,
            this.colDienThoai,
            this.colDiaChi,
            this.colNgheNghiep,
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
            this.colID.Width = 35;
            // 
            // colTenBenhNhan
            // 
            this.colTenBenhNhan.Caption = "Tên";
            this.colTenBenhNhan.FieldName = "TenBenhNhan";
            this.colTenBenhNhan.MinWidth = 25;
            this.colTenBenhNhan.Name = "colTenBenhNhan";
            this.colTenBenhNhan.Visible = true;
            this.colTenBenhNhan.VisibleIndex = 1;
            this.colTenBenhNhan.Width = 90;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.Caption = "Ngày Sinh";
            this.colNgaySinh.FieldName = "NgaySinh";
            this.colNgaySinh.MinWidth = 25;
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.Visible = true;
            this.colNgaySinh.VisibleIndex = 2;
            this.colNgaySinh.Width = 70;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.Caption = "Giới Tính";
            this.colGioiTinh.FieldName = "GioiTinh";
            this.colGioiTinh.MinWidth = 25;
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.Visible = true;
            this.colGioiTinh.VisibleIndex = 3;
            this.colGioiTinh.Width = 58;
            // 
            // colDienThoai
            // 
            this.colDienThoai.Caption = "Điện Thoại";
            this.colDienThoai.FieldName = "DienThoai";
            this.colDienThoai.MinWidth = 25;
            this.colDienThoai.Name = "colDienThoai";
            this.colDienThoai.Visible = true;
            this.colDienThoai.VisibleIndex = 4;
            this.colDienThoai.Width = 101;
            // 
            // colDiaChi
            // 
            this.colDiaChi.Caption = "Địa Chỉ";
            this.colDiaChi.FieldName = "DiaChi";
            this.colDiaChi.MinWidth = 25;
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 5;
            this.colDiaChi.Width = 101;
            // 
            // colNgheNghiep
            // 
            this.colNgheNghiep.Caption = "Nghề Nghiệp";
            this.colNgheNghiep.FieldName = "NgheNghiep";
            this.colNgheNghiep.MinWidth = 25;
            this.colNgheNghiep.Name = "colNgheNghiep";
            this.colNgheNghiep.Visible = true;
            this.colNgheNghiep.VisibleIndex = 6;
            this.colNgheNghiep.Width = 100;
            // 
            // colGhiChu
            // 
            this.colGhiChu.Caption = "Ghi Chú";
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.MinWidth = 25;
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 7;
            this.colGhiChu.Width = 121;
            // 
            // benhNhanTableAdapter
            // 
            this.benhNhanTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnAddpatient);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnUpdatepatient);
            this.panel1.Controls.Add(this.txtJobpatient);
            this.panel1.Controls.Add(this.btnDelpatient);
            this.panel1.Controls.Add(this.txtPhonepatient);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtAddresspatient);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNotepatient);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtGenderpatient);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBornpatient);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtIDpatient);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtNamepatient);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1303, 155);
            this.panel1.TabIndex = 47;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.gridControl1);
            this.panel2.Location = new System.Drawing.Point(0, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1303, 261);
            this.panel2.TabIndex = 48;
            // 
            // frmBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 416);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmBenhNhan";
            this.Text = "Bệnh Nhân";
            this.Load += new System.EventHandler(this.BenhNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benhNhanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyPhongKhamDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtJobpatient;
        private System.Windows.Forms.TextBox txtNotepatient;
        private System.Windows.Forms.TextBox txtGenderpatient;
        private System.Windows.Forms.TextBox txtBornpatient;
        private System.Windows.Forms.TextBox txtIDpatient;
        private System.Windows.Forms.TextBox txtNamepatient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelpatient;
        private System.Windows.Forms.Button btnUpdatepatient;
        private System.Windows.Forms.Button btnAddpatient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddresspatient;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPhonepatient;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
      
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colTenBenhNhan;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn colGioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colNgheNghiep;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private QuanLyPhongKhamDataSet quanLyPhongKhamDataSet;
        private System.Windows.Forms.BindingSource benhNhanBindingSource;
        private QuanLyPhongKhamDataSetTableAdapters.BenhNhanTableAdapter benhNhanTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}