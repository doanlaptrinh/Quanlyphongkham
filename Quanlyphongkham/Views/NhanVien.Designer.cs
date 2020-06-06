namespace Quanlyphongkham.Views
{
    partial class frmNhanVien
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
            this.quanLyPhongKhamDataSet1 = new Quanlyphongkham.QuanLyPhongKhamDataSet();
            this.GridNhanVien = new DevExpress.XtraGrid.GridControl();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyPhongKhamDataSet2 = new Quanlyphongkham.QuanLyPhongKhamDataSet2();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQueQuan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChucVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhanQuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nhanVienTableAdapter = new Quanlyphongkham.QuanLyPhongKhamDataSet2TableAdapters.NhanVienTableAdapter();
            this.btnAddNV = new System.Windows.Forms.Button();
            this.btnUpdateNV = new System.Windows.Forms.Button();
            this.btnDelNV = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtBorn = new System.Windows.Forms.TextBox();
            this.txtNativeLane = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNPhone = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDecen = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyPhongKhamDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyPhongKhamDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // quanLyPhongKhamDataSet1
            // 
            this.quanLyPhongKhamDataSet1.DataSetName = "QuanLyPhongKhamDataSet";
            this.quanLyPhongKhamDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GridNhanVien
            // 
            this.GridNhanVien.DataSource = this.nhanVienBindingSource;
            this.GridNhanVien.Location = new System.Drawing.Point(12, 189);
            this.GridNhanVien.MainView = this.gridView1;
            this.GridNhanVien.Name = "GridNhanVien";
            this.GridNhanVien.Size = new System.Drawing.Size(871, 288);
            this.GridNhanVien.TabIndex = 0;
            this.GridNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.quanLyPhongKhamDataSet2;
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
            this.colHoTen,
            this.colGioiTinh,
            this.colNgaySinh,
            this.colQueQuan,
            this.colSoDienThoai,
            this.colEmail,
            this.colChucVu,
            this.colPhanQuyen});
            this.gridView1.GridControl = this.GridNhanVien;
            this.gridView1.Name = "gridView1";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 25;
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 38;
            // 
            // colHoTen
            // 
            this.colHoTen.Caption = "Họ Tên";
            this.colHoTen.FieldName = "HoTen";
            this.colHoTen.MinWidth = 25;
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Visible = true;
            this.colHoTen.VisibleIndex = 1;
            this.colHoTen.Width = 112;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.Caption = "Giới Tính";
            this.colGioiTinh.FieldName = "GioiTinh";
            this.colGioiTinh.MinWidth = 25;
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.Visible = true;
            this.colGioiTinh.VisibleIndex = 2;
            this.colGioiTinh.Width = 48;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.Caption = "Ngày Sinh";
            this.colNgaySinh.FieldName = "NgaySinh";
            this.colNgaySinh.MinWidth = 25;
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.Visible = true;
            this.colNgaySinh.VisibleIndex = 3;
            this.colNgaySinh.Width = 78;
            // 
            // colQueQuan
            // 
            this.colQueQuan.Caption = "Quê Quán";
            this.colQueQuan.FieldName = "QueQuan";
            this.colQueQuan.MinWidth = 25;
            this.colQueQuan.Name = "colQueQuan";
            this.colQueQuan.Visible = true;
            this.colQueQuan.VisibleIndex = 4;
            this.colQueQuan.Width = 102;
            // 
            // colSoDienThoai
            // 
            this.colSoDienThoai.Caption = "Số Điện Thoại";
            this.colSoDienThoai.FieldName = "SoDienThoai";
            this.colSoDienThoai.MinWidth = 25;
            this.colSoDienThoai.Name = "colSoDienThoai";
            this.colSoDienThoai.Visible = true;
            this.colSoDienThoai.VisibleIndex = 5;
            this.colSoDienThoai.Width = 108;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.MinWidth = 25;
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 6;
            this.colEmail.Width = 173;
            // 
            // colChucVu
            // 
            this.colChucVu.Caption = "Chức Vụ";
            this.colChucVu.FieldName = "ChucVu";
            this.colChucVu.MinWidth = 25;
            this.colChucVu.Name = "colChucVu";
            this.colChucVu.Visible = true;
            this.colChucVu.VisibleIndex = 7;
            this.colChucVu.Width = 79;
            // 
            // colPhanQuyen
            // 
            this.colPhanQuyen.Caption = "Phân Quyền";
            this.colPhanQuyen.FieldName = "PhanQuyen";
            this.colPhanQuyen.MinWidth = 25;
            this.colPhanQuyen.Name = "colPhanQuyen";
            this.colPhanQuyen.Visible = true;
            this.colPhanQuyen.VisibleIndex = 8;
            this.colPhanQuyen.Width = 103;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // btnAddNV
            // 
            this.btnAddNV.Location = new System.Drawing.Point(646, 163);
            this.btnAddNV.Name = "btnAddNV";
            this.btnAddNV.Size = new System.Drawing.Size(75, 23);
            this.btnAddNV.TabIndex = 2;
            this.btnAddNV.Text = "Thêm";
            this.btnAddNV.UseVisualStyleBackColor = true;
            this.btnAddNV.Click += new System.EventHandler(this.btnAddnv_Click);
            // 
            // btnUpdateNV
            // 
            this.btnUpdateNV.Location = new System.Drawing.Point(727, 163);
            this.btnUpdateNV.Name = "btnUpdateNV";
            this.btnUpdateNV.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateNV.TabIndex = 3;
            this.btnUpdateNV.Text = "Sửa";
            this.btnUpdateNV.UseVisualStyleBackColor = true;
            this.btnUpdateNV.Click += new System.EventHandler(this.btnUpdateNV_Click);
            // 
            // btnDelNV
            // 
            this.btnDelNV.Location = new System.Drawing.Point(808, 163);
            this.btnDelNV.Name = "btnDelNV";
            this.btnDelNV.Size = new System.Drawing.Size(75, 23);
            this.btnDelNV.TabIndex = 4;
            this.btnDelNV.Text = "Xóa";
            this.btnDelNV.UseVisualStyleBackColor = true;
            this.btnDelNV.Click += new System.EventHandler(this.btnDelNV_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên Nhân Viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Giới Tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ngày Sinh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(350, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Điện Thoại";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(226, 44);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(100, 23);
            this.txtTen.TabIndex = 15;
            // 
            // txtBorn
            // 
            this.txtBorn.Location = new System.Drawing.Point(226, 105);
            this.txtBorn.Name = "txtBorn";
            this.txtBorn.Size = new System.Drawing.Size(100, 23);
            this.txtBorn.TabIndex = 17;
            // 
            // txtNativeLane
            // 
            this.txtNativeLane.Location = new System.Drawing.Point(436, 41);
            this.txtNativeLane.Name = "txtNativeLane";
            this.txtNativeLane.Size = new System.Drawing.Size(100, 23);
            this.txtNativeLane.TabIndex = 18;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(436, 108);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 23);
            this.txtEmail.TabIndex = 19;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(668, 38);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(100, 23);
            this.txtPosition.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Danh Sách Nhân Viên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(566, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Chức vụ";
            // 
            // txtNPhone
            // 
            this.txtNPhone.Location = new System.Drawing.Point(436, 75);
            this.txtNPhone.Name = "txtNPhone";
            this.txtNPhone.Size = new System.Drawing.Size(100, 23);
            this.txtNPhone.TabIndex = 19;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(226, 75);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(100, 23);
            this.txtGender.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quê quán";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(566, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(668, 75);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 23);
            this.txtID.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(566, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "Phân Quyền";
            // 
            // txtDecen
            // 
            this.txtDecen.Location = new System.Drawing.Point(668, 111);
            this.txtDecen.Name = "txtDecen";
            this.txtDecen.Size = new System.Drawing.Size(100, 23);
            this.txtDecen.TabIndex = 27;
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 488);
            this.Controls.Add(this.txtDecen);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.txtNPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNativeLane);
            this.Controls.Add(this.txtBorn);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelNV);
            this.Controls.Add(this.btnUpdateNV);
            this.Controls.Add(this.btnAddNV);
            this.Controls.Add(this.GridNhanVien);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::Quanlyphongkham.Properties.Settings.Default, "vitri", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Location = global::Quanlyphongkham.Properties.Settings.Default.vitri;
            this.Name = "frmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Nhân Viên";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyPhongKhamDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyPhongKhamDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private QuanLyPhongKhamDataSet quanLyPhongKhamDataSet1;
        private DevExpress.XtraGrid.GridControl GridNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private QuanLyPhongKhamDataSet2 quanLyPhongKhamDataSet2;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private QuanLyPhongKhamDataSet2TableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colHoTen;
        private DevExpress.XtraGrid.Columns.GridColumn colGioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn colQueQuan;
        private DevExpress.XtraGrid.Columns.GridColumn colSoDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colChucVu;
        private DevExpress.XtraGrid.Columns.GridColumn colPhanQuyen;
        private System.Windows.Forms.Button btnAddNV;
        private System.Windows.Forms.Button btnUpdateNV;
        private System.Windows.Forms.Button btnDelNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtBorn;
        private System.Windows.Forms.TextBox txtNativeLane;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNPhone;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDecen;
    }
}