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
            this.quanLyPhongKhamDataSet6 = new Quanlyphongkham.QuanLyPhongKhamDataSet6();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenBenhNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgheNghiep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.benhNhanTableAdapter = new Quanlyphongkham.QuanLyPhongKhamDataSet6TableAdapters.BenhNhanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benhNhanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyPhongKhamDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 17);
            this.label11.TabIndex = 44;
            this.label11.Text = "Danh Sách Bệnh Nhân";
            // 
            // txtJobpatient
            // 
            this.txtJobpatient.Location = new System.Drawing.Point(613, 44);
            this.txtJobpatient.Name = "txtJobpatient";
            this.txtJobpatient.Size = new System.Drawing.Size(100, 23);
            this.txtJobpatient.TabIndex = 42;
            // 
            // txtNotepatient
            // 
            this.txtNotepatient.Location = new System.Drawing.Point(613, 78);
            this.txtNotepatient.Name = "txtNotepatient";
            this.txtNotepatient.Size = new System.Drawing.Size(100, 23);
            this.txtNotepatient.TabIndex = 41;
            // 
            // txtGenderpatient
            // 
            this.txtGenderpatient.Location = new System.Drawing.Point(382, 47);
            this.txtGenderpatient.Name = "txtGenderpatient";
            this.txtGenderpatient.Size = new System.Drawing.Size(100, 23);
            this.txtGenderpatient.TabIndex = 40;
            // 
            // txtBornpatient
            // 
            this.txtBornpatient.Location = new System.Drawing.Point(180, 108);
            this.txtBornpatient.Name = "txtBornpatient";
            this.txtBornpatient.Size = new System.Drawing.Size(100, 23);
            this.txtBornpatient.TabIndex = 39;
            // 
            // txtIDpatient
            // 
            this.txtIDpatient.Location = new System.Drawing.Point(180, 78);
            this.txtIDpatient.Name = "txtIDpatient";
            this.txtIDpatient.Size = new System.Drawing.Size(100, 23);
            this.txtIDpatient.TabIndex = 38;
            // 
            // txtNamepatient
            // 
            this.txtNamepatient.Location = new System.Drawing.Point(180, 47);
            this.txtNamepatient.Name = "txtNamepatient";
            this.txtNamepatient.Size = new System.Drawing.Size(100, 23);
            this.txtNamepatient.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(304, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Điện Thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "Ngày Sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "Địa Chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Giới Tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Tên Bệnh Nhân";
            // 
            // btnDelpatient
            // 
            this.btnDelpatient.Location = new System.Drawing.Point(707, 164);
            this.btnDelpatient.Name = "btnDelpatient";
            this.btnDelpatient.Size = new System.Drawing.Size(75, 23);
            this.btnDelpatient.TabIndex = 30;
            this.btnDelpatient.Text = "Xóa";
            this.btnDelpatient.UseVisualStyleBackColor = true;
            this.btnDelpatient.Click += new System.EventHandler(this.btnDelpatient_Click);
            // 
            // btnUpdatepatient
            // 
            this.btnUpdatepatient.Location = new System.Drawing.Point(626, 164);
            this.btnUpdatepatient.Name = "btnUpdatepatient";
            this.btnUpdatepatient.Size = new System.Drawing.Size(75, 23);
            this.btnUpdatepatient.TabIndex = 29;
            this.btnUpdatepatient.Text = "Sửa";
            this.btnUpdatepatient.UseVisualStyleBackColor = true;
            // 
            // btnAddpatient
            // 
            this.btnAddpatient.Location = new System.Drawing.Point(545, 164);
            this.btnAddpatient.Name = "btnAddpatient";
            this.btnAddpatient.Size = new System.Drawing.Size(75, 23);
            this.btnAddpatient.TabIndex = 28;
            this.btnAddpatient.Text = "Thêm";
            this.btnAddpatient.UseVisualStyleBackColor = true;
            this.btnAddpatient.Click += new System.EventHandler(this.btnAddpatient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(512, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nghề Nghiệp";
            // 
            // txtAddresspatient
            // 
            this.txtAddresspatient.Location = new System.Drawing.Point(382, 111);
            this.txtAddresspatient.Name = "txtAddresspatient";
            this.txtAddresspatient.Size = new System.Drawing.Size(100, 23);
            this.txtAddresspatient.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(512, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "Ghi Chú";
            // 
            // txtPhonepatient
            // 
            this.txtPhonepatient.Location = new System.Drawing.Point(382, 78);
            this.txtPhonepatient.Name = "txtPhonepatient";
            this.txtPhonepatient.Size = new System.Drawing.Size(100, 23);
            this.txtPhonepatient.TabIndex = 41;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.benhNhanBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 190);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(763, 214);
            this.gridControl1.TabIndex = 46;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // benhNhanBindingSource
            // 
            this.benhNhanBindingSource.DataMember = "BenhNhan";
            this.benhNhanBindingSource.DataSource = this.quanLyPhongKhamDataSet6;
            // 
            // quanLyPhongKhamDataSet6
            // 
            this.quanLyPhongKhamDataSet6.DataSetName = "QuanLyPhongKhamDataSet6";
            this.quanLyPhongKhamDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // frmBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 416);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtJobpatient);
            this.Controls.Add(this.txtPhonepatient);
            this.Controls.Add(this.txtAddresspatient);
            this.Controls.Add(this.txtNotepatient);
            this.Controls.Add(this.txtGenderpatient);
            this.Controls.Add(this.txtBornpatient);
            this.Controls.Add(this.txtIDpatient);
            this.Controls.Add(this.txtNamepatient);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelpatient);
            this.Controls.Add(this.btnUpdatepatient);
            this.Controls.Add(this.btnAddpatient);
            this.Name = "frmBenhNhan";
            this.Text = "Bệnh Nhân";
            this.Load += new System.EventHandler(this.BenhNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benhNhanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyPhongKhamDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private QuanLyPhongKhamDataSet6 quanLyPhongKhamDataSet6;
        private System.Windows.Forms.BindingSource benhNhanBindingSource;
        private QuanLyPhongKhamDataSet6TableAdapters.BenhNhanTableAdapter benhNhanTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colTenBenhNhan;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn colGioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colNgheNghiep;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
    }
}