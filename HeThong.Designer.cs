﻿namespace HealthyApp
{
	partial class HeThong
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
			menuStrip1 = new MenuStrip();
			trangChủToolStripMenuItem = new ToolStripMenuItem();
			côngThứcToolStripMenuItem = new ToolStripMenuItem();
			chỉSốCơThểToolStripMenuItem = new ToolStripMenuItem();
			thốngKêToolStripMenuItem = new ToolStripMenuItem();
			tàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
			nguyênLiệuToolStripMenuItem = new ToolStripMenuItem();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new ToolStripItem[] { trangChủToolStripMenuItem, côngThứcToolStripMenuItem, chỉSốCơThểToolStripMenuItem, thốngKêToolStripMenuItem, tàiKhoảnToolStripMenuItem, nguyênLiệuToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(800, 24);
			menuStrip1.TabIndex = 1;
			menuStrip1.Text = "menuStrip1";
			menuStrip1.ItemClicked += menuStrip1_ItemClicked;
			// 
			// trangChủToolStripMenuItem
			// 
			trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
			trangChủToolStripMenuItem.Size = new Size(71, 20);
			trangChủToolStripMenuItem.Text = "Trang chủ";
			trangChủToolStripMenuItem.Click += trangChủToolStripMenuItem_Click;
			// 
			// côngThứcToolStripMenuItem
			// 
			côngThứcToolStripMenuItem.Name = "côngThứcToolStripMenuItem";
			côngThứcToolStripMenuItem.Size = new Size(75, 20);
			côngThứcToolStripMenuItem.Text = "Công thức";
			côngThứcToolStripMenuItem.Click += côngThứcToolStripMenuItem_Click;
			// 
			// chỉSốCơThểToolStripMenuItem
			// 
			chỉSốCơThểToolStripMenuItem.Name = "chỉSốCơThểToolStripMenuItem";
			chỉSốCơThểToolStripMenuItem.Size = new Size(88, 20);
			chỉSốCơThểToolStripMenuItem.Text = "Chỉ số cơ thể";
			chỉSốCơThểToolStripMenuItem.Click += chỉSốCơThểToolStripMenuItem_Click;
			// 
			// thốngKêToolStripMenuItem
			// 
			thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
			thốngKêToolStripMenuItem.Size = new Size(61, 20);
			thốngKêToolStripMenuItem.Text = "Báo cáo";
			thốngKêToolStripMenuItem.Click += thốngKêToolStripMenuItem_Click;
			// 
			// tàiKhoảnToolStripMenuItem
			// 
			tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
			tàiKhoảnToolStripMenuItem.Size = new Size(69, 20);
			tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
			tàiKhoảnToolStripMenuItem.Click += tàiKhoảnToolStripMenuItem_Click;
			// 
			// nguyênLiệuToolStripMenuItem
			// 
			nguyênLiệuToolStripMenuItem.Name = "nguyênLiệuToolStripMenuItem";
			nguyênLiệuToolStripMenuItem.Size = new Size(83, 20);
			nguyênLiệuToolStripMenuItem.Text = "Nguyên liệu";
			nguyênLiệuToolStripMenuItem.Click += nguyênLiệuToolStripMenuItem_Click;
			// 
			// HeThong
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(menuStrip1);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			IsMdiContainer = true;
			MainMenuStrip = menuStrip1;
			MaximizeBox = false;
			Name = "HeThong";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Healthy App";
			FormClosed += HeThong_FormClosed;
			Load += HeThong_Load;
			SizeChanged += HeThong_SizeChanged;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem trangChủToolStripMenuItem;
		private ToolStripMenuItem côngThứcToolStripMenuItem;
		private ToolStripMenuItem chỉSốCơThểToolStripMenuItem;
		private ToolStripMenuItem thốngKêToolStripMenuItem;
		private ToolStripMenuItem tàiKhoảnToolStripMenuItem;
		private ToolStripMenuItem nguyênLiệuToolStripMenuItem;
	}
}