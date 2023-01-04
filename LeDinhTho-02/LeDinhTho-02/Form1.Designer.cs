namespace LeDinhTho_02
{
    partial class Form1
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
            this.ma = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbDonvi = new System.Windows.Forms.ComboBox();
            this.gioitinh = new System.Windows.Forms.CheckBox();
            this.tbMa = new System.Windows.Forms.TextBox();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.tbNoisinh = new System.Windows.Forms.TextBox();
            this.dateNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.dateCgv = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noisinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dateCgv)).BeginInit();
            this.SuspendLayout();
            // 
            // ma
            // 
            this.ma.AutoSize = true;
            this.ma.Location = new System.Drawing.Point(13, 13);
            this.ma.Name = "ma";
            this.ma.Size = new System.Drawing.Size(26, 16);
            this.ma.TabIndex = 0;
            this.ma.Text = "Mã";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đơn vị";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nơi sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(537, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày sinh";
            // 
            // cbDonvi
            // 
            this.cbDonvi.FormattingEnabled = true;
            this.cbDonvi.Location = new System.Drawing.Point(84, 52);
            this.cbDonvi.Name = "cbDonvi";
            this.cbDonvi.Size = new System.Drawing.Size(143, 24);
            this.cbDonvi.TabIndex = 1;
            // 
            // gioitinh
            // 
            this.gioitinh.AutoSize = true;
            this.gioitinh.Location = new System.Drawing.Point(792, 12);
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.Size = new System.Drawing.Size(108, 20);
            this.gioitinh.TabIndex = 2;
            this.gioitinh.Text = "Giới tính Nam";
            this.gioitinh.UseVisualStyleBackColor = true;
            this.gioitinh.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tbMa
            // 
            this.tbMa.Location = new System.Drawing.Point(84, 13);
            this.tbMa.Name = "tbMa";
            this.tbMa.Size = new System.Drawing.Size(143, 22);
            this.tbMa.TabIndex = 3;
            this.tbMa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(329, 10);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(182, 22);
            this.tbTen.TabIndex = 3;
            this.tbTen.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbNoisinh
            // 
            this.tbNoisinh.Location = new System.Drawing.Point(338, 54);
            this.tbNoisinh.Name = "tbNoisinh";
            this.tbNoisinh.Size = new System.Drawing.Size(539, 22);
            this.tbNoisinh.TabIndex = 3;
            this.tbNoisinh.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dateNgaysinh
            // 
            this.dateNgaysinh.Location = new System.Drawing.Point(610, 11);
            this.dateNgaysinh.Name = "dateNgaysinh";
            this.dateNgaysinh.Size = new System.Drawing.Size(162, 22);
            this.dateNgaysinh.TabIndex = 4;
            // 
            // dateCgv
            // 
            this.dateCgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dateCgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.ngaysinh,
            this.nam,
            this.noisinh,
            this.donvi});
            this.dateCgv.Location = new System.Drawing.Point(12, 82);
            this.dateCgv.Name = "dateCgv";
            this.dateCgv.RowHeadersWidth = 51;
            this.dateCgv.RowTemplate.Height = 24;
            this.dateCgv.Size = new System.Drawing.Size(898, 346);
            this.dateCgv.TabIndex = 5;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(476, 434);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(591, 434);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(697, 434);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(802, 434);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_1);
            // 
            // id
            // 
            this.id.HeaderText = "Mã";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "Họ Tên";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 140;
            // 
            // ngaysinh
            // 
            this.ngaysinh.HeaderText = "Ngày Sinh";
            this.ngaysinh.MinimumWidth = 6;
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Width = 140;
            // 
            // nam
            // 
            this.nam.HeaderText = "Giới tính";
            this.nam.MinimumWidth = 6;
            this.nam.Name = "nam";
            this.nam.Width = 140;
            // 
            // noisinh
            // 
            this.noisinh.HeaderText = "Nơi sinh";
            this.noisinh.MinimumWidth = 6;
            this.noisinh.Name = "noisinh";
            this.noisinh.Width = 140;
            // 
            // donvi
            // 
            this.donvi.HeaderText = "Đơn vị";
            this.donvi.MinimumWidth = 6;
            this.donvi.Name = "donvi";
            this.donvi.Width = 140;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 464);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dateCgv);
            this.Controls.Add(this.dateNgaysinh);
            this.Controls.Add(this.tbNoisinh);
            this.Controls.Add(this.tbTen);
            this.Controls.Add(this.tbMa);
            this.Controls.Add(this.gioitinh);
            this.Controls.Add(this.cbDonvi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dateCgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbDonvi;
        private System.Windows.Forms.CheckBox gioitinh;
        private System.Windows.Forms.TextBox tbMa;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.TextBox tbNoisinh;
        private System.Windows.Forms.DateTimePicker dateNgaysinh;
        private System.Windows.Forms.DataGridView dateCgv;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn nam;
        private System.Windows.Forms.DataGridViewTextBoxColumn noisinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn donvi;
    }
}

