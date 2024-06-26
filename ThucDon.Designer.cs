﻿namespace HealthyApp
{
	partial class ThucDon
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
			labelThoiGian = new Label();
			dateTimeTrangChu = new DateTimePicker();
			dataGridThucdon = new DataGridView();
			dataGridNguyenLieu = new DataGridView();
			buttonThem = new Button();
			buttonXoa = new Button();
			dataGridChitiet = new DataGridView();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			numericSoluong = new NumericUpDown();
			buttonLammoi = new Button();
			buttonSua = new Button();
			label = new Label();
			TextBoxGhichu = new RichTextBox();
			label1 = new Label();
			textBoxTongCalo = new TextBox();
			buttonBack = new Button();
			label5 = new Label();
			textBoxTimKiem = new TextBox();
			((System.ComponentModel.ISupportInitialize)dataGridThucdon).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridNguyenLieu).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridChitiet).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericSoluong).BeginInit();
			SuspendLayout();
			// 
			// labelThoiGian
			// 
			labelThoiGian.AutoSize = true;
			labelThoiGian.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			labelThoiGian.Location = new Point(12, 36);
			labelThoiGian.Name = "labelThoiGian";
			labelThoiGian.Size = new Size(95, 25);
			labelThoiGian.TabIndex = 2;
			labelThoiGian.Text = "Thời gian";
			// 
			// dateTimeTrangChu
			// 
			dateTimeTrangChu.Enabled = false;
			dateTimeTrangChu.Format = DateTimePickerFormat.Short;
			dateTimeTrangChu.Location = new Point(113, 38);
			dateTimeTrangChu.Name = "dateTimeTrangChu";
			dateTimeTrangChu.Size = new Size(89, 23);
			dateTimeTrangChu.TabIndex = 8;
			// 
			// dataGridThucdon
			// 
			dataGridThucdon.AllowUserToAddRows = false;
			dataGridThucdon.AllowUserToDeleteRows = false;
			dataGridThucdon.AllowUserToResizeRows = false;
			dataGridThucdon.BorderStyle = BorderStyle.None;
			dataGridThucdon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridThucdon.Location = new Point(277, 97);
			dataGridThucdon.MultiSelect = false;
			dataGridThucdon.Name = "dataGridThucdon";
			dataGridThucdon.ReadOnly = true;
			dataGridThucdon.RowHeadersVisible = false;
			dataGridThucdon.RowTemplate.Height = 25;
			dataGridThucdon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridThucdon.Size = new Size(352, 192);
			dataGridThucdon.TabIndex = 1;
			dataGridThucdon.DataSourceChanged += dataGridThucdon_DataSourceChanged;
			dataGridThucdon.CellClick += dataGridThucdon_CellClick;
			dataGridThucdon.CellContentClick += dataGridThucdon_CellContentClick;
			// 
			// dataGridNguyenLieu
			// 
			dataGridNguyenLieu.AllowUserToAddRows = false;
			dataGridNguyenLieu.AllowUserToDeleteRows = false;
			dataGridNguyenLieu.AllowUserToResizeColumns = false;
			dataGridNguyenLieu.AllowUserToResizeRows = false;
			dataGridNguyenLieu.BorderStyle = BorderStyle.None;
			dataGridNguyenLieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridNguyenLieu.Location = new Point(17, 131);
			dataGridNguyenLieu.MultiSelect = false;
			dataGridNguyenLieu.Name = "dataGridNguyenLieu";
			dataGridNguyenLieu.ReadOnly = true;
			dataGridNguyenLieu.RowHeadersVisible = false;
			dataGridNguyenLieu.RowTemplate.Height = 25;
			dataGridNguyenLieu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridNguyenLieu.Size = new Size(240, 158);
			dataGridNguyenLieu.TabIndex = 0;
			dataGridNguyenLieu.CellClick += dataGridNguyenLieu_CellClick;
			dataGridNguyenLieu.CellContentClick += dataGridNguyenLieu_CellContentClick;
			// 
			// buttonThem
			// 
			buttonThem.Location = new Point(12, 472);
			buttonThem.Name = "buttonThem";
			buttonThem.Size = new Size(75, 23);
			buttonThem.TabIndex = 5;
			buttonThem.Text = "Thêm";
			buttonThem.UseVisualStyleBackColor = true;
			buttonThem.Click += buttonThem_Click;
			// 
			// buttonXoa
			// 
			buttonXoa.Location = new Point(174, 472);
			buttonXoa.Name = "buttonXoa";
			buttonXoa.Size = new Size(75, 23);
			buttonXoa.TabIndex = 7;
			buttonXoa.Text = "Xóa";
			buttonXoa.UseVisualStyleBackColor = true;
			buttonXoa.Click += buttonXoa_Click;
			// 
			// dataGridChitiet
			// 
			dataGridChitiet.AllowUserToAddRows = false;
			dataGridChitiet.AllowUserToDeleteRows = false;
			dataGridChitiet.AllowUserToResizeColumns = false;
			dataGridChitiet.AllowUserToResizeRows = false;
			dataGridChitiet.BorderStyle = BorderStyle.None;
			dataGridChitiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridChitiet.Location = new Point(12, 316);
			dataGridChitiet.MultiSelect = false;
			dataGridChitiet.Name = "dataGridChitiet";
			dataGridChitiet.ReadOnly = true;
			dataGridChitiet.RowHeadersVisible = false;
			dataGridChitiet.RowTemplate.Height = 25;
			dataGridChitiet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridChitiet.Size = new Size(617, 117);
			dataGridChitiet.TabIndex = 2;
			dataGridChitiet.CellClick += dataGridChitiet_CellClick;
			dataGridChitiet.CellContentClick += dataGridChitiet_CellContentClick;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label2.Location = new Point(84, 292);
			label2.Name = "label2";
			label2.Size = new Size(65, 21);
			label2.TabIndex = 17;
			label2.Text = "Chi tiết";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label3.Location = new Point(84, 73);
			label3.Name = "label3";
			label3.Size = new Size(68, 21);
			label3.TabIndex = 18;
			label3.Text = "Món ăn";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(17, 445);
			label4.Name = "label4";
			label4.Size = new Size(54, 15);
			label4.TabIndex = 20;
			label4.Text = "Số lượng";
			// 
			// numericSoluong
			// 
			numericSoluong.Location = new Point(77, 443);
			numericSoluong.Name = "numericSoluong";
			numericSoluong.Size = new Size(131, 23);
			numericSoluong.TabIndex = 3;
			numericSoluong.ValueChanged += numericSoluong_ValueChanged;
			// 
			// buttonLammoi
			// 
			buttonLammoi.Location = new Point(255, 472);
			buttonLammoi.Name = "buttonLammoi";
			buttonLammoi.Size = new Size(75, 23);
			buttonLammoi.TabIndex = 8;
			buttonLammoi.Text = "Làm mới";
			buttonLammoi.UseVisualStyleBackColor = true;
			buttonLammoi.Click += buttonLammoi_Click;
			// 
			// buttonSua
			// 
			buttonSua.Location = new Point(93, 472);
			buttonSua.Name = "buttonSua";
			buttonSua.Size = new Size(75, 23);
			buttonSua.TabIndex = 6;
			buttonSua.Text = "Sửa";
			buttonSua.UseVisualStyleBackColor = true;
			buttonSua.Click += buttonSua_Click;
			// 
			// label
			// 
			label.AutoSize = true;
			label.Location = new Point(295, 445);
			label.Name = "label";
			label.Size = new Size(48, 15);
			label.TabIndex = 24;
			label.Text = "Ghi chú";
			// 
			// TextBoxGhichu
			// 
			TextBoxGhichu.Location = new Point(349, 445);
			TextBoxGhichu.Name = "TextBoxGhichu";
			TextBoxGhichu.Size = new Size(280, 50);
			TextBoxGhichu.TabIndex = 4;
			TextBoxGhichu.Text = "";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(282, 44);
			label1.Name = "label1";
			label1.Size = new Size(61, 15);
			label1.TabIndex = 26;
			label1.Text = "Tổng Calo";
			// 
			// textBoxTongCalo
			// 
			textBoxTongCalo.Location = new Point(349, 41);
			textBoxTongCalo.Name = "textBoxTongCalo";
			textBoxTongCalo.ReadOnly = true;
			textBoxTongCalo.Size = new Size(172, 23);
			textBoxTongCalo.TabIndex = 27;
			// 
			// buttonBack
			// 
			buttonBack.Location = new Point(554, 41);
			buttonBack.Name = "buttonBack";
			buttonBack.Size = new Size(75, 23);
			buttonBack.TabIndex = 28;
			buttonBack.Text = "Quay lại";
			buttonBack.UseVisualStyleBackColor = true;
			buttonBack.Click += buttonBack_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label5.Location = new Point(404, 73);
			label5.Name = "label5";
			label5.Size = new Size(82, 21);
			label5.TabIndex = 29;
			label5.Text = "Thực đơn";
			// 
			// textBoxTimKiem
			// 
			textBoxTimKiem.Location = new Point(17, 102);
			textBoxTimKiem.Name = "textBoxTimKiem";
			textBoxTimKiem.PlaceholderText = "Tìm kiếm";
			textBoxTimKiem.Size = new Size(240, 23);
			textBoxTimKiem.TabIndex = 30;
			textBoxTimKiem.TextChanged += textBoxTimKiem_TextChanged;
			// 
			// ThucDon
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(641, 538);
			Controls.Add(textBoxTimKiem);
			Controls.Add(label5);
			Controls.Add(buttonBack);
			Controls.Add(textBoxTongCalo);
			Controls.Add(label1);
			Controls.Add(TextBoxGhichu);
			Controls.Add(label);
			Controls.Add(buttonSua);
			Controls.Add(buttonLammoi);
			Controls.Add(numericSoluong);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(dataGridChitiet);
			Controls.Add(buttonXoa);
			Controls.Add(buttonThem);
			Controls.Add(dataGridNguyenLieu);
			Controls.Add(dataGridThucdon);
			Controls.Add(dateTimeTrangChu);
			Controls.Add(labelThoiGian);
			FormBorderStyle = FormBorderStyle.None;
			Name = "ThucDon";
			Text = "ThucDon";
			Load += ThucDon_Load;
			((System.ComponentModel.ISupportInitialize)dataGridThucdon).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridNguyenLieu).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridChitiet).EndInit();
			((System.ComponentModel.ISupportInitialize)numericSoluong).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label labelThoiGian;
		private DateTimePicker dateTimeTrangChu;
		private DataGridView dataGridThucdon;
		private DataGridView dataGridNguyenLieu;
		private Button buttonThem;
		private Button buttonXoa;
		private DataGridView dataGridChitiet;
		private Label label2;
		private Label label3;
		private Label label4;
		private NumericUpDown numericSoluong;
		private Button buttonLammoi;
		private Button buttonSua;
		private Label label;
		private RichTextBox TextBoxGhichu;
		private Label label1;
		private TextBox textBoxTongCalo;
		private Button buttonBack;
		private Label label5;
		private TextBox textBoxTimKiem;
	}
}