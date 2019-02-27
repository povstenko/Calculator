namespace Calculator
{
	partial class FormDates
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
			this.mode = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.From = new System.Windows.Forms.DateTimePicker();
			this.To = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.difference = new System.Windows.Forms.Label();
			this.menuPanel = new System.Windows.Forms.Panel();
			this.menuDates = new System.Windows.Forms.Button();
			this.menuProgrammer = new System.Windows.Forms.Button();
			this.menuSimple = new System.Windows.Forms.Button();
			this.menuScroll = new System.Windows.Forms.TextBox();
			this.menuTitle = new System.Windows.Forms.Label();
			this.menu = new System.Windows.Forms.Button();
			this.menuPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// mode
			// 
			this.mode.AutoSize = true;
			this.mode.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.mode.Location = new System.Drawing.Point(51, 9);
			this.mode.Name = "mode";
			this.mode.Size = new System.Drawing.Size(202, 32);
			this.mode.TabIndex = 35;
			this.mode.Text = "Вычисление даты";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(13, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(175, 20);
			this.label1.TabIndex = 36;
			this.label1.Text = "Разница между датами";
			// 
			// From
			// 
			this.From.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.From.Location = new System.Drawing.Point(17, 120);
			this.From.Name = "From";
			this.From.Size = new System.Drawing.Size(171, 27);
			this.From.TabIndex = 37;
			this.From.ValueChanged += new System.EventHandler(this.From_ValueChanged);
			// 
			// To
			// 
			this.To.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.To.Location = new System.Drawing.Point(17, 217);
			this.To.Name = "To";
			this.To.Size = new System.Drawing.Size(171, 27);
			this.To.TabIndex = 38;
			this.To.ValueChanged += new System.EventHandler(this.From_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(13, 97);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(18, 20);
			this.label2.TabIndex = 39;
			this.label2.Text = "С";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(13, 194);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 20);
			this.label3.TabIndex = 40;
			this.label3.Text = "По";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(13, 282);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 20);
			this.label4.TabIndex = 41;
			this.label4.Text = "Разница";
			// 
			// difference
			// 
			this.difference.AutoSize = true;
			this.difference.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
			this.difference.Location = new System.Drawing.Point(12, 302);
			this.difference.Name = "difference";
			this.difference.Size = new System.Drawing.Size(173, 25);
			this.difference.TabIndex = 42;
			this.difference.Text = "Одинаковые даты";
			// 
			// menuPanel
			// 
			this.menuPanel.BackColor = System.Drawing.SystemColors.Window;
			this.menuPanel.Controls.Add(this.menuDates);
			this.menuPanel.Controls.Add(this.menuProgrammer);
			this.menuPanel.Controls.Add(this.menuSimple);
			this.menuPanel.Controls.Add(this.menuScroll);
			this.menuPanel.Controls.Add(this.menuTitle);
			this.menuPanel.Location = new System.Drawing.Point(0, 0);
			this.menuPanel.Name = "menuPanel";
			this.menuPanel.Size = new System.Drawing.Size(266, 476);
			this.menuPanel.TabIndex = 43;
			this.menuPanel.Visible = false;
			// 
			// menuDates
			// 
			this.menuDates.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.menuDates.FlatAppearance.BorderSize = 0;
			this.menuDates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.menuDates.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.menuDates.Location = new System.Drawing.Point(0, 136);
			this.menuDates.Name = "menuDates";
			this.menuDates.Size = new System.Drawing.Size(251, 45);
			this.menuDates.TabIndex = 4;
			this.menuDates.Text = "Вычисление даты";
			this.menuDates.UseVisualStyleBackColor = false;
			this.menuDates.Click += new System.EventHandler(this.menuDates_Click);
			// 
			// menuProgrammer
			// 
			this.menuProgrammer.FlatAppearance.BorderSize = 0;
			this.menuProgrammer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.menuProgrammer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.menuProgrammer.Location = new System.Drawing.Point(0, 97);
			this.menuProgrammer.Name = "menuProgrammer";
			this.menuProgrammer.Size = new System.Drawing.Size(251, 45);
			this.menuProgrammer.TabIndex = 3;
			this.menuProgrammer.Text = "Программист";
			this.menuProgrammer.UseVisualStyleBackColor = true;
			this.menuProgrammer.Click += new System.EventHandler(this.menuProgrammer_Click);
			// 
			// menuSimple
			// 
			this.menuSimple.BackColor = System.Drawing.SystemColors.Window;
			this.menuSimple.FlatAppearance.BorderSize = 0;
			this.menuSimple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.menuSimple.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.menuSimple.Location = new System.Drawing.Point(0, 55);
			this.menuSimple.Name = "menuSimple";
			this.menuSimple.Size = new System.Drawing.Size(251, 45);
			this.menuSimple.TabIndex = 2;
			this.menuSimple.Text = "Обычный";
			this.menuSimple.UseVisualStyleBackColor = false;
			this.menuSimple.Click += new System.EventHandler(this.menuSimple_Click);
			// 
			// menuScroll
			// 
			this.menuScroll.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.menuScroll.Location = new System.Drawing.Point(239, 0);
			this.menuScroll.Multiline = true;
			this.menuScroll.Name = "menuScroll";
			this.menuScroll.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.menuScroll.Size = new System.Drawing.Size(25, 473);
			this.menuScroll.TabIndex = 0;
			this.menuScroll.Visible = false;
			// 
			// menuTitle
			// 
			this.menuTitle.AutoSize = true;
			this.menuTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.menuTitle.Location = new System.Drawing.Point(69, 17);
			this.menuTitle.Name = "menuTitle";
			this.menuTitle.Size = new System.Drawing.Size(121, 25);
			this.menuTitle.TabIndex = 1;
			this.menuTitle.Text = "Калькулятор";
			this.menuTitle.Visible = false;
			// 
			// menu
			// 
			this.menu.BackColor = System.Drawing.SystemColors.Control;
			this.menu.BackgroundImage = global::Calculator.Properties.Resources.menu;
			this.menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.menu.FlatAppearance.BorderSize = 0;
			this.menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.menu.Location = new System.Drawing.Point(12, 12);
			this.menu.Name = "menu";
			this.menu.Size = new System.Drawing.Size(33, 26);
			this.menu.TabIndex = 33;
			this.menu.UseVisualStyleBackColor = false;
			this.menu.Click += new System.EventHandler(this.menu_Click);
			// 
			// FormDates
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(323, 468);
			this.Controls.Add(this.menu);
			this.Controls.Add(this.menuPanel);
			this.Controls.Add(this.difference);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.To);
			this.Controls.Add(this.From);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.mode);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FormDates";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Калькулятор";
			this.menuPanel.ResumeLayout(false);
			this.menuPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button menu;
		private System.Windows.Forms.Label mode;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker From;
		private System.Windows.Forms.DateTimePicker To;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label difference;
		private System.Windows.Forms.Panel menuPanel;
		private System.Windows.Forms.Button menuDates;
		private System.Windows.Forms.Button menuProgrammer;
		private System.Windows.Forms.Button menuSimple;
		private System.Windows.Forms.TextBox menuScroll;
		private System.Windows.Forms.Label menuTitle;
	}
}