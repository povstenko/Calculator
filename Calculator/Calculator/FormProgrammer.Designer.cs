namespace Calculator
{
	partial class FormProgrammer
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
			this.menu = new System.Windows.Forms.Button();
			this.mode = new System.Windows.Forms.Label();
			this.result = new System.Windows.Forms.TextBox();
			this.lastString = new System.Windows.Forms.Label();
			this.hex = new System.Windows.Forms.RadioButton();
			this.dec = new System.Windows.Forms.RadioButton();
			this.oct = new System.Windows.Forms.RadioButton();
			this.bin = new System.Windows.Forms.RadioButton();
			this.hexLabel = new System.Windows.Forms.Label();
			this.octLabel = new System.Windows.Forms.Label();
			this.binLabel = new System.Windows.Forms.Label();
			this.decLabel = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.plusMin = new System.Windows.Forms.Button();
			this.btn0 = new System.Windows.Forms.Button();
			this.dot = new System.Windows.Forms.Button();
			this.equals = new System.Windows.Forms.Button();
			this.plus = new System.Windows.Forms.Button();
			this.btn3 = new System.Windows.Forms.Button();
			this.btn2 = new System.Windows.Forms.Button();
			this.btn1 = new System.Windows.Forms.Button();
			this.btnF = new System.Windows.Forms.Button();
			this.btnE = new System.Windows.Forms.Button();
			this.minus = new System.Windows.Forms.Button();
			this.btn6 = new System.Windows.Forms.Button();
			this.btn5 = new System.Windows.Forms.Button();
			this.btn4 = new System.Windows.Forms.Button();
			this.btnD = new System.Windows.Forms.Button();
			this.btnC = new System.Windows.Forms.Button();
			this.mult = new System.Windows.Forms.Button();
			this.btn9 = new System.Windows.Forms.Button();
			this.btn8 = new System.Windows.Forms.Button();
			this.btn7 = new System.Windows.Forms.Button();
			this.btnB = new System.Windows.Forms.Button();
			this.btnA = new System.Windows.Forms.Button();
			this.div = new System.Windows.Forms.Button();
			this.clearLast = new System.Windows.Forms.Button();
			this.clear = new System.Windows.Forms.Button();
			this.clearE = new System.Windows.Forms.Button();
			this.mod = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.and = new System.Windows.Forms.Button();
			this.not = new System.Windows.Forms.Button();
			this.xor = new System.Windows.Forms.Button();
			this.or = new System.Windows.Forms.Button();
			this.rsh = new System.Windows.Forms.Button();
			this.lsh = new System.Windows.Forms.Button();
			this.memoryList = new System.Windows.Forms.Button();
			this.memorySave = new System.Windows.Forms.Button();
			this.qword = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.memoryPanel = new System.Windows.Forms.Panel();
			this.trash = new System.Windows.Forms.Button();
			this.memoryData = new System.Windows.Forms.TextBox();
			this.history = new System.Windows.Forms.Button();
			this.historyPanel = new System.Windows.Forms.Panel();
			this.historyTrash = new System.Windows.Forms.Button();
			this.historyData = new System.Windows.Forms.TextBox();
			this.menuPanel = new System.Windows.Forms.Panel();
			this.menuDates = new System.Windows.Forms.Button();
			this.menuProgrammer = new System.Windows.Forms.Button();
			this.menuSimple = new System.Windows.Forms.Button();
			this.menuScroll = new System.Windows.Forms.TextBox();
			this.menuTitle = new System.Windows.Forms.Label();
			this.memoryPanel.SuspendLayout();
			this.historyPanel.SuspendLayout();
			this.menuPanel.SuspendLayout();
			this.SuspendLayout();
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
			// mode
			// 
			this.mode.AutoSize = true;
			this.mode.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.mode.Location = new System.Drawing.Point(51, 9);
			this.mode.Name = "mode";
			this.mode.Size = new System.Drawing.Size(161, 32);
			this.mode.TabIndex = 36;
			this.mode.Text = "Программист";
			// 
			// result
			// 
			this.result.BackColor = System.Drawing.SystemColors.Control;
			this.result.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.result.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.result.Location = new System.Drawing.Point(2, 70);
			this.result.Multiline = true;
			this.result.Name = "result";
			this.result.Size = new System.Drawing.Size(318, 48);
			this.result.TabIndex = 37;
			this.result.Text = "0";
			this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lastString
			// 
			this.lastString.AutoSize = true;
			this.lastString.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lastString.ForeColor = System.Drawing.SystemColors.GrayText;
			this.lastString.Location = new System.Drawing.Point(255, 47);
			this.lastString.Name = "lastString";
			this.lastString.Size = new System.Drawing.Size(0, 20);
			this.lastString.TabIndex = 38;
			this.lastString.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// hex
			// 
			this.hex.AutoSize = true;
			this.hex.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Desktop;
			this.hex.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.hex.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.hex.Location = new System.Drawing.Point(2, 113);
			this.hex.Name = "hex";
			this.hex.Size = new System.Drawing.Size(57, 22);
			this.hex.TabIndex = 39;
			this.hex.Text = "HEX";
			this.hex.UseVisualStyleBackColor = true;
			this.hex.CheckedChanged += new System.EventHandler(this.hex_CheckedChanged);
			// 
			// dec
			// 
			this.dec.AutoSize = true;
			this.dec.Checked = true;
			this.dec.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Desktop;
			this.dec.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.dec.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dec.Location = new System.Drawing.Point(2, 137);
			this.dec.Name = "dec";
			this.dec.Size = new System.Drawing.Size(56, 22);
			this.dec.TabIndex = 40;
			this.dec.TabStop = true;
			this.dec.Text = "DEC";
			this.dec.UseVisualStyleBackColor = true;
			this.dec.CheckedChanged += new System.EventHandler(this.dec_CheckedChanged);
			// 
			// oct
			// 
			this.oct.AutoSize = true;
			this.oct.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Desktop;
			this.oct.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.oct.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.oct.Location = new System.Drawing.Point(2, 161);
			this.oct.Name = "oct";
			this.oct.Size = new System.Drawing.Size(57, 22);
			this.oct.TabIndex = 41;
			this.oct.Text = "OCT";
			this.oct.UseVisualStyleBackColor = true;
			this.oct.CheckedChanged += new System.EventHandler(this.oct_CheckedChanged);
			// 
			// bin
			// 
			this.bin.AutoSize = true;
			this.bin.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Desktop;
			this.bin.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.bin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.bin.Location = new System.Drawing.Point(2, 184);
			this.bin.Name = "bin";
			this.bin.Size = new System.Drawing.Size(54, 22);
			this.bin.TabIndex = 42;
			this.bin.Text = "BIN";
			this.bin.UseVisualStyleBackColor = true;
			this.bin.CheckedChanged += new System.EventHandler(this.bin_CheckedChanged);
			// 
			// hexLabel
			// 
			this.hexLabel.AutoSize = true;
			this.hexLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.hexLabel.Location = new System.Drawing.Point(55, 115);
			this.hexLabel.Name = "hexLabel";
			this.hexLabel.Size = new System.Drawing.Size(15, 17);
			this.hexLabel.TabIndex = 43;
			this.hexLabel.Text = "0";
			// 
			// octLabel
			// 
			this.octLabel.AutoSize = true;
			this.octLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.octLabel.Location = new System.Drawing.Point(55, 163);
			this.octLabel.Name = "octLabel";
			this.octLabel.Size = new System.Drawing.Size(15, 17);
			this.octLabel.TabIndex = 44;
			this.octLabel.Text = "0";
			// 
			// binLabel
			// 
			this.binLabel.AutoSize = true;
			this.binLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.binLabel.Location = new System.Drawing.Point(55, 186);
			this.binLabel.Name = "binLabel";
			this.binLabel.Size = new System.Drawing.Size(15, 17);
			this.binLabel.TabIndex = 45;
			this.binLabel.Text = "0";
			// 
			// decLabel
			// 
			this.decLabel.AutoSize = true;
			this.decLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.decLabel.Location = new System.Drawing.Point(55, 139);
			this.decLabel.Name = "decLabel";
			this.decLabel.Size = new System.Drawing.Size(15, 17);
			this.decLabel.TabIndex = 46;
			this.decLabel.Text = "0";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(2, 435);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(50, 31);
			this.button1.TabIndex = 47;
			this.button1.Text = "(";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.Location = new System.Drawing.Point(55, 435);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(50, 31);
			this.button2.TabIndex = 48;
			this.button2.Text = ")";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// plusMin
			// 
			this.plusMin.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.plusMin.FlatAppearance.BorderSize = 0;
			this.plusMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.plusMin.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.plusMin.Location = new System.Drawing.Point(108, 435);
			this.plusMin.Name = "plusMin";
			this.plusMin.Size = new System.Drawing.Size(50, 31);
			this.plusMin.TabIndex = 49;
			this.plusMin.Text = "±";
			this.plusMin.UseVisualStyleBackColor = false;
			this.plusMin.Click += new System.EventHandler(this.plusMin_Click);
			// 
			// btn0
			// 
			this.btn0.BackColor = System.Drawing.SystemColors.Window;
			this.btn0.FlatAppearance.BorderSize = 0;
			this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn0.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn0.Location = new System.Drawing.Point(162, 435);
			this.btn0.Name = "btn0";
			this.btn0.Size = new System.Drawing.Size(50, 31);
			this.btn0.TabIndex = 50;
			this.btn0.Text = "0";
			this.btn0.UseVisualStyleBackColor = false;
			this.btn0.Click += new System.EventHandler(this.number_Click);
			// 
			// dot
			// 
			this.dot.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.dot.FlatAppearance.BorderSize = 0;
			this.dot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.dot.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dot.Location = new System.Drawing.Point(217, 435);
			this.dot.Name = "dot";
			this.dot.Size = new System.Drawing.Size(50, 31);
			this.dot.TabIndex = 51;
			this.dot.Text = ",";
			this.dot.UseVisualStyleBackColor = false;
			this.dot.Click += new System.EventHandler(this.dot_Click);
			// 
			// equals
			// 
			this.equals.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.equals.FlatAppearance.BorderSize = 0;
			this.equals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.equals.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.equals.Location = new System.Drawing.Point(270, 435);
			this.equals.Name = "equals";
			this.equals.Size = new System.Drawing.Size(50, 31);
			this.equals.TabIndex = 52;
			this.equals.Text = "=";
			this.equals.UseVisualStyleBackColor = false;
			this.equals.Click += new System.EventHandler(this.equals_Click);
			this.equals.MouseEnter += new System.EventHandler(this.equals_MouseEnter);
			this.equals.MouseLeave += new System.EventHandler(this.equals_MouseLeave);
			// 
			// plus
			// 
			this.plus.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.plus.FlatAppearance.BorderSize = 0;
			this.plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.plus.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.plus.Location = new System.Drawing.Point(270, 398);
			this.plus.Name = "plus";
			this.plus.Size = new System.Drawing.Size(50, 31);
			this.plus.TabIndex = 58;
			this.plus.Text = "+";
			this.plus.UseVisualStyleBackColor = false;
			this.plus.Click += new System.EventHandler(this.plus_Click);
			this.plus.MouseEnter += new System.EventHandler(this.equals_MouseEnter);
			this.plus.MouseLeave += new System.EventHandler(this.equals_MouseLeave);
			// 
			// btn3
			// 
			this.btn3.BackColor = System.Drawing.SystemColors.Window;
			this.btn3.FlatAppearance.BorderSize = 0;
			this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn3.Location = new System.Drawing.Point(217, 398);
			this.btn3.Name = "btn3";
			this.btn3.Size = new System.Drawing.Size(50, 31);
			this.btn3.TabIndex = 57;
			this.btn3.Text = "3";
			this.btn3.UseVisualStyleBackColor = false;
			this.btn3.Click += new System.EventHandler(this.number_Click);
			// 
			// btn2
			// 
			this.btn2.BackColor = System.Drawing.SystemColors.Window;
			this.btn2.FlatAppearance.BorderSize = 0;
			this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn2.Location = new System.Drawing.Point(162, 398);
			this.btn2.Name = "btn2";
			this.btn2.Size = new System.Drawing.Size(50, 31);
			this.btn2.TabIndex = 56;
			this.btn2.Text = "2";
			this.btn2.UseVisualStyleBackColor = false;
			this.btn2.Click += new System.EventHandler(this.number_Click);
			// 
			// btn1
			// 
			this.btn1.BackColor = System.Drawing.SystemColors.Window;
			this.btn1.FlatAppearance.BorderSize = 0;
			this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn1.Location = new System.Drawing.Point(108, 398);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(50, 31);
			this.btn1.TabIndex = 55;
			this.btn1.Text = "1";
			this.btn1.UseVisualStyleBackColor = false;
			this.btn1.Click += new System.EventHandler(this.number_Click);
			// 
			// btnF
			// 
			this.btnF.BackColor = System.Drawing.SystemColors.Window;
			this.btnF.FlatAppearance.BorderSize = 0;
			this.btnF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnF.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnF.Location = new System.Drawing.Point(55, 398);
			this.btnF.Name = "btnF";
			this.btnF.Size = new System.Drawing.Size(50, 31);
			this.btnF.TabIndex = 54;
			this.btnF.Text = "F";
			this.btnF.UseVisualStyleBackColor = false;
			this.btnF.Click += new System.EventHandler(this.letter_Click);
			// 
			// btnE
			// 
			this.btnE.BackColor = System.Drawing.SystemColors.Window;
			this.btnE.FlatAppearance.BorderSize = 0;
			this.btnE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnE.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnE.Location = new System.Drawing.Point(2, 398);
			this.btnE.Name = "btnE";
			this.btnE.Size = new System.Drawing.Size(50, 31);
			this.btnE.TabIndex = 53;
			this.btnE.Text = "E";
			this.btnE.UseVisualStyleBackColor = false;
			this.btnE.Click += new System.EventHandler(this.letter_Click);
			// 
			// minus
			// 
			this.minus.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.minus.FlatAppearance.BorderSize = 0;
			this.minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.minus.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.minus.Location = new System.Drawing.Point(270, 361);
			this.minus.Name = "minus";
			this.minus.Size = new System.Drawing.Size(50, 31);
			this.minus.TabIndex = 64;
			this.minus.Text = "-";
			this.minus.UseVisualStyleBackColor = false;
			this.minus.Click += new System.EventHandler(this.minus_Click);
			this.minus.MouseEnter += new System.EventHandler(this.equals_MouseEnter);
			this.minus.MouseLeave += new System.EventHandler(this.equals_MouseLeave);
			// 
			// btn6
			// 
			this.btn6.BackColor = System.Drawing.SystemColors.Window;
			this.btn6.FlatAppearance.BorderSize = 0;
			this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn6.Location = new System.Drawing.Point(217, 361);
			this.btn6.Name = "btn6";
			this.btn6.Size = new System.Drawing.Size(50, 31);
			this.btn6.TabIndex = 63;
			this.btn6.Text = "6";
			this.btn6.UseVisualStyleBackColor = false;
			this.btn6.Click += new System.EventHandler(this.number_Click);
			// 
			// btn5
			// 
			this.btn5.BackColor = System.Drawing.SystemColors.Window;
			this.btn5.FlatAppearance.BorderSize = 0;
			this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn5.Location = new System.Drawing.Point(162, 361);
			this.btn5.Name = "btn5";
			this.btn5.Size = new System.Drawing.Size(50, 31);
			this.btn5.TabIndex = 62;
			this.btn5.Text = "5";
			this.btn5.UseVisualStyleBackColor = false;
			this.btn5.Click += new System.EventHandler(this.number_Click);
			// 
			// btn4
			// 
			this.btn4.BackColor = System.Drawing.SystemColors.Window;
			this.btn4.FlatAppearance.BorderSize = 0;
			this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn4.Location = new System.Drawing.Point(108, 361);
			this.btn4.Name = "btn4";
			this.btn4.Size = new System.Drawing.Size(50, 31);
			this.btn4.TabIndex = 61;
			this.btn4.Text = "4";
			this.btn4.UseVisualStyleBackColor = false;
			this.btn4.Click += new System.EventHandler(this.number_Click);
			// 
			// btnD
			// 
			this.btnD.BackColor = System.Drawing.SystemColors.Window;
			this.btnD.FlatAppearance.BorderSize = 0;
			this.btnD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnD.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnD.Location = new System.Drawing.Point(55, 361);
			this.btnD.Name = "btnD";
			this.btnD.Size = new System.Drawing.Size(50, 31);
			this.btnD.TabIndex = 60;
			this.btnD.Text = "D";
			this.btnD.UseVisualStyleBackColor = false;
			this.btnD.Click += new System.EventHandler(this.letter_Click);
			// 
			// btnC
			// 
			this.btnC.BackColor = System.Drawing.SystemColors.Window;
			this.btnC.FlatAppearance.BorderSize = 0;
			this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnC.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnC.Location = new System.Drawing.Point(2, 361);
			this.btnC.Name = "btnC";
			this.btnC.Size = new System.Drawing.Size(50, 31);
			this.btnC.TabIndex = 59;
			this.btnC.Text = "C";
			this.btnC.UseVisualStyleBackColor = false;
			this.btnC.Click += new System.EventHandler(this.letter_Click);
			// 
			// mult
			// 
			this.mult.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.mult.FlatAppearance.BorderSize = 0;
			this.mult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.mult.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.mult.Location = new System.Drawing.Point(270, 324);
			this.mult.Name = "mult";
			this.mult.Size = new System.Drawing.Size(50, 31);
			this.mult.TabIndex = 70;
			this.mult.Text = "×";
			this.mult.UseVisualStyleBackColor = false;
			this.mult.Click += new System.EventHandler(this.mult_Click);
			this.mult.MouseEnter += new System.EventHandler(this.equals_MouseEnter);
			this.mult.MouseLeave += new System.EventHandler(this.equals_MouseLeave);
			// 
			// btn9
			// 
			this.btn9.BackColor = System.Drawing.SystemColors.Window;
			this.btn9.FlatAppearance.BorderSize = 0;
			this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn9.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn9.Location = new System.Drawing.Point(217, 324);
			this.btn9.Name = "btn9";
			this.btn9.Size = new System.Drawing.Size(50, 31);
			this.btn9.TabIndex = 69;
			this.btn9.Text = "9";
			this.btn9.UseVisualStyleBackColor = false;
			this.btn9.Click += new System.EventHandler(this.number_Click);
			// 
			// btn8
			// 
			this.btn8.BackColor = System.Drawing.SystemColors.Window;
			this.btn8.FlatAppearance.BorderSize = 0;
			this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn8.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn8.Location = new System.Drawing.Point(162, 324);
			this.btn8.Name = "btn8";
			this.btn8.Size = new System.Drawing.Size(50, 31);
			this.btn8.TabIndex = 68;
			this.btn8.Text = "8";
			this.btn8.UseVisualStyleBackColor = false;
			this.btn8.Click += new System.EventHandler(this.number_Click);
			// 
			// btn7
			// 
			this.btn7.BackColor = System.Drawing.SystemColors.Window;
			this.btn7.FlatAppearance.BorderSize = 0;
			this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn7.Location = new System.Drawing.Point(108, 324);
			this.btn7.Name = "btn7";
			this.btn7.Size = new System.Drawing.Size(50, 31);
			this.btn7.TabIndex = 67;
			this.btn7.Text = "7";
			this.btn7.UseVisualStyleBackColor = false;
			this.btn7.Click += new System.EventHandler(this.number_Click);
			// 
			// btnB
			// 
			this.btnB.BackColor = System.Drawing.SystemColors.Window;
			this.btnB.FlatAppearance.BorderSize = 0;
			this.btnB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnB.Location = new System.Drawing.Point(55, 324);
			this.btnB.Name = "btnB";
			this.btnB.Size = new System.Drawing.Size(50, 31);
			this.btnB.TabIndex = 66;
			this.btnB.Text = "B";
			this.btnB.UseVisualStyleBackColor = false;
			this.btnB.Click += new System.EventHandler(this.letter_Click);
			// 
			// btnA
			// 
			this.btnA.BackColor = System.Drawing.SystemColors.Window;
			this.btnA.FlatAppearance.BorderSize = 0;
			this.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnA.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnA.Location = new System.Drawing.Point(2, 324);
			this.btnA.Name = "btnA";
			this.btnA.Size = new System.Drawing.Size(50, 31);
			this.btnA.TabIndex = 65;
			this.btnA.Text = "A";
			this.btnA.UseVisualStyleBackColor = false;
			this.btnA.Click += new System.EventHandler(this.letter_Click);
			// 
			// div
			// 
			this.div.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.div.FlatAppearance.BorderSize = 0;
			this.div.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.div.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.div.Location = new System.Drawing.Point(270, 287);
			this.div.Name = "div";
			this.div.Size = new System.Drawing.Size(50, 31);
			this.div.TabIndex = 76;
			this.div.Text = "÷";
			this.div.UseVisualStyleBackColor = false;
			this.div.Click += new System.EventHandler(this.div_Click);
			this.div.MouseEnter += new System.EventHandler(this.equals_MouseEnter);
			this.div.MouseLeave += new System.EventHandler(this.equals_MouseLeave);
			// 
			// clearLast
			// 
			this.clearLast.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.clearLast.FlatAppearance.BorderSize = 0;
			this.clearLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.clearLast.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.clearLast.Location = new System.Drawing.Point(217, 287);
			this.clearLast.Name = "clearLast";
			this.clearLast.Size = new System.Drawing.Size(50, 31);
			this.clearLast.TabIndex = 75;
			this.clearLast.Text = "←";
			this.clearLast.UseVisualStyleBackColor = false;
			this.clearLast.Click += new System.EventHandler(this.clearLast_Click);
			// 
			// clear
			// 
			this.clear.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.clear.FlatAppearance.BorderSize = 0;
			this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.clear.Location = new System.Drawing.Point(162, 287);
			this.clear.Name = "clear";
			this.clear.Size = new System.Drawing.Size(50, 31);
			this.clear.TabIndex = 74;
			this.clear.Text = "C";
			this.clear.UseVisualStyleBackColor = false;
			this.clear.Click += new System.EventHandler(this.clear_Click);
			// 
			// clearE
			// 
			this.clearE.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.clearE.FlatAppearance.BorderSize = 0;
			this.clearE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.clearE.Location = new System.Drawing.Point(108, 287);
			this.clearE.Name = "clearE";
			this.clearE.Size = new System.Drawing.Size(50, 31);
			this.clearE.TabIndex = 73;
			this.clearE.Text = "CE";
			this.clearE.UseVisualStyleBackColor = false;
			this.clearE.Click += new System.EventHandler(this.clearE_Click);
			// 
			// mod
			// 
			this.mod.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.mod.FlatAppearance.BorderSize = 0;
			this.mod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.mod.Location = new System.Drawing.Point(55, 287);
			this.mod.Name = "mod";
			this.mod.Size = new System.Drawing.Size(50, 31);
			this.mod.TabIndex = 72;
			this.mod.Text = "Mod";
			this.mod.UseVisualStyleBackColor = false;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button3.Location = new System.Drawing.Point(2, 287);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(50, 31);
			this.button3.TabIndex = 71;
			this.button3.Text = "↑";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// and
			// 
			this.and.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.and.FlatAppearance.BorderSize = 0;
			this.and.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.and.Location = new System.Drawing.Point(270, 250);
			this.and.Name = "and";
			this.and.Size = new System.Drawing.Size(50, 31);
			this.and.TabIndex = 82;
			this.and.Text = "And";
			this.and.UseVisualStyleBackColor = false;
			// 
			// not
			// 
			this.not.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.not.FlatAppearance.BorderSize = 0;
			this.not.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.not.Location = new System.Drawing.Point(217, 250);
			this.not.Name = "not";
			this.not.Size = new System.Drawing.Size(50, 31);
			this.not.TabIndex = 81;
			this.not.Text = "Not";
			this.not.UseVisualStyleBackColor = false;
			// 
			// xor
			// 
			this.xor.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.xor.FlatAppearance.BorderSize = 0;
			this.xor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.xor.Location = new System.Drawing.Point(162, 250);
			this.xor.Name = "xor";
			this.xor.Size = new System.Drawing.Size(50, 31);
			this.xor.TabIndex = 80;
			this.xor.Text = "Xor";
			this.xor.UseVisualStyleBackColor = false;
			// 
			// or
			// 
			this.or.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.or.FlatAppearance.BorderSize = 0;
			this.or.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.or.Location = new System.Drawing.Point(108, 250);
			this.or.Name = "or";
			this.or.Size = new System.Drawing.Size(50, 31);
			this.or.TabIndex = 79;
			this.or.Text = "Or";
			this.or.UseVisualStyleBackColor = false;
			// 
			// rsh
			// 
			this.rsh.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.rsh.FlatAppearance.BorderSize = 0;
			this.rsh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rsh.Location = new System.Drawing.Point(55, 250);
			this.rsh.Name = "rsh";
			this.rsh.Size = new System.Drawing.Size(50, 31);
			this.rsh.TabIndex = 78;
			this.rsh.Text = "Rsh";
			this.rsh.UseVisualStyleBackColor = false;
			// 
			// lsh
			// 
			this.lsh.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.lsh.FlatAppearance.BorderSize = 0;
			this.lsh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lsh.Location = new System.Drawing.Point(2, 250);
			this.lsh.Name = "lsh";
			this.lsh.Size = new System.Drawing.Size(50, 31);
			this.lsh.TabIndex = 77;
			this.lsh.Text = "Lsh";
			this.lsh.UseVisualStyleBackColor = false;
			// 
			// memoryList
			// 
			this.memoryList.BackColor = System.Drawing.SystemColors.Control;
			this.memoryList.Enabled = false;
			this.memoryList.FlatAppearance.BorderSize = 0;
			this.memoryList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.memoryList.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.memoryList.Location = new System.Drawing.Point(273, 221);
			this.memoryList.Name = "memoryList";
			this.memoryList.Size = new System.Drawing.Size(47, 23);
			this.memoryList.TabIndex = 83;
			this.memoryList.Text = "M^";
			this.memoryList.UseVisualStyleBackColor = false;
			this.memoryList.Click += new System.EventHandler(this.memoryList_Click);
			// 
			// memorySave
			// 
			this.memorySave.BackColor = System.Drawing.SystemColors.Control;
			this.memorySave.FlatAppearance.BorderSize = 0;
			this.memorySave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.memorySave.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.memorySave.Location = new System.Drawing.Point(217, 221);
			this.memorySave.Name = "memorySave";
			this.memorySave.Size = new System.Drawing.Size(50, 23);
			this.memorySave.TabIndex = 84;
			this.memorySave.Text = "MS";
			this.memorySave.UseVisualStyleBackColor = false;
			this.memorySave.Click += new System.EventHandler(this.memorySave_Click);
			// 
			// qword
			// 
			this.qword.BackColor = System.Drawing.SystemColors.Control;
			this.qword.FlatAppearance.BorderSize = 0;
			this.qword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.qword.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.qword.Location = new System.Drawing.Point(130, 221);
			this.qword.Name = "qword";
			this.qword.Size = new System.Drawing.Size(62, 23);
			this.qword.TabIndex = 85;
			this.qword.Text = "QWORD";
			this.qword.UseVisualStyleBackColor = false;
			this.qword.Click += new System.EventHandler(this.qword_Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.SystemColors.Control;
			this.button5.Enabled = false;
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button5.Location = new System.Drawing.Point(2, 221);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(50, 23);
			this.button5.TabIndex = 86;
			this.button5.UseVisualStyleBackColor = false;
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.SystemColors.Control;
			this.button6.Enabled = false;
			this.button6.FlatAppearance.BorderSize = 0;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button6.Location = new System.Drawing.Point(57, 221);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(50, 23);
			this.button6.TabIndex = 87;
			this.button6.UseVisualStyleBackColor = false;
			// 
			// memoryPanel
			// 
			this.memoryPanel.BackColor = System.Drawing.SystemColors.Window;
			this.memoryPanel.Controls.Add(this.memoryData);
			this.memoryPanel.Controls.Add(this.trash);
			this.memoryPanel.Location = new System.Drawing.Point(-8, 250);
			this.memoryPanel.Name = "memoryPanel";
			this.memoryPanel.Size = new System.Drawing.Size(328, 216);
			this.memoryPanel.TabIndex = 88;
			this.memoryPanel.Visible = false;
			// 
			// trash
			// 
			this.trash.BackColor = System.Drawing.SystemColors.Window;
			this.trash.BackgroundImage = global::Calculator.Properties.Resources.trash;
			this.trash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.trash.FlatAppearance.BorderSize = 0;
			this.trash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.trash.Location = new System.Drawing.Point(290, 178);
			this.trash.Name = "trash";
			this.trash.Size = new System.Drawing.Size(29, 28);
			this.trash.TabIndex = 34;
			this.trash.UseVisualStyleBackColor = false;
			this.trash.Visible = false;
			this.trash.Click += new System.EventHandler(this.trash_Click);
			// 
			// memoryData
			// 
			this.memoryData.BackColor = System.Drawing.SystemColors.Window;
			this.memoryData.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.memoryData.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.memoryData.Location = new System.Drawing.Point(20, 21);
			this.memoryData.Multiline = true;
			this.memoryData.Name = "memoryData";
			this.memoryData.Size = new System.Drawing.Size(299, 54);
			this.memoryData.TabIndex = 36;
			this.memoryData.Text = "\r\nВ памяти ничего не сохранено";
			this.memoryData.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.memoryData.Visible = false;
			// 
			// history
			// 
			this.history.BackColor = System.Drawing.SystemColors.Control;
			this.history.BackgroundImage = global::Calculator.Properties.Resources.history;
			this.history.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.history.FlatAppearance.BorderSize = 0;
			this.history.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.history.Location = new System.Drawing.Point(287, 12);
			this.history.Name = "history";
			this.history.Size = new System.Drawing.Size(24, 26);
			this.history.TabIndex = 89;
			this.history.UseVisualStyleBackColor = false;
			this.history.Click += new System.EventHandler(this.history_Click);
			// 
			// historyPanel
			// 
			this.historyPanel.BackColor = System.Drawing.SystemColors.Window;
			this.historyPanel.Controls.Add(this.historyTrash);
			this.historyPanel.Controls.Add(this.historyData);
			this.historyPanel.Location = new System.Drawing.Point(-5, 250);
			this.historyPanel.Name = "historyPanel";
			this.historyPanel.Size = new System.Drawing.Size(341, 216);
			this.historyPanel.TabIndex = 90;
			this.historyPanel.Visible = false;
			// 
			// historyTrash
			// 
			this.historyTrash.BackColor = System.Drawing.SystemColors.Window;
			this.historyTrash.BackgroundImage = global::Calculator.Properties.Resources.trash;
			this.historyTrash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.historyTrash.FlatAppearance.BorderSize = 0;
			this.historyTrash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.historyTrash.Location = new System.Drawing.Point(287, 181);
			this.historyTrash.Name = "historyTrash";
			this.historyTrash.Size = new System.Drawing.Size(29, 25);
			this.historyTrash.TabIndex = 34;
			this.historyTrash.UseVisualStyleBackColor = false;
			this.historyTrash.Visible = false;
			this.historyTrash.Click += new System.EventHandler(this.historyTrash_Click);
			// 
			// historyData
			// 
			this.historyData.BackColor = System.Drawing.SystemColors.Window;
			this.historyData.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.historyData.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.historyData.Location = new System.Drawing.Point(17, 12);
			this.historyData.Multiline = true;
			this.historyData.Name = "historyData";
			this.historyData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.historyData.Size = new System.Drawing.Size(299, 194);
			this.historyData.TabIndex = 35;
			this.historyData.Text = "\r\n";
			this.historyData.Visible = false;
			// 
			// menuPanel
			// 
			this.menuPanel.BackColor = System.Drawing.SystemColors.Window;
			this.menuPanel.Controls.Add(this.menuDates);
			this.menuPanel.Controls.Add(this.menuProgrammer);
			this.menuPanel.Controls.Add(this.menuSimple);
			this.menuPanel.Controls.Add(this.menuScroll);
			this.menuPanel.Controls.Add(this.menuTitle);
			this.menuPanel.Location = new System.Drawing.Point(-2, -2);
			this.menuPanel.Name = "menuPanel";
			this.menuPanel.Size = new System.Drawing.Size(269, 478);
			this.menuPanel.TabIndex = 91;
			this.menuPanel.Visible = false;
			// 
			// menuDates
			// 
			this.menuDates.FlatAppearance.BorderSize = 0;
			this.menuDates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.menuDates.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.menuDates.Location = new System.Drawing.Point(0, 136);
			this.menuDates.Name = "menuDates";
			this.menuDates.Size = new System.Drawing.Size(251, 45);
			this.menuDates.TabIndex = 4;
			this.menuDates.Text = "Вычисление даты";
			this.menuDates.UseVisualStyleBackColor = true;
			this.menuDates.Click += new System.EventHandler(this.menuDates_Click);
			// 
			// menuProgrammer
			// 
			this.menuProgrammer.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.menuProgrammer.FlatAppearance.BorderSize = 0;
			this.menuProgrammer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.menuProgrammer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.menuProgrammer.Location = new System.Drawing.Point(0, 97);
			this.menuProgrammer.Name = "menuProgrammer";
			this.menuProgrammer.Size = new System.Drawing.Size(251, 45);
			this.menuProgrammer.TabIndex = 3;
			this.menuProgrammer.Text = "Программист";
			this.menuProgrammer.UseVisualStyleBackColor = false;
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
			// FormProgrammer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(323, 468);
			this.Controls.Add(this.menu);
			this.Controls.Add(this.menuPanel);
			this.Controls.Add(this.historyPanel);
			this.Controls.Add(this.history);
			this.Controls.Add(this.memoryPanel);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.qword);
			this.Controls.Add(this.memorySave);
			this.Controls.Add(this.memoryList);
			this.Controls.Add(this.and);
			this.Controls.Add(this.not);
			this.Controls.Add(this.xor);
			this.Controls.Add(this.or);
			this.Controls.Add(this.rsh);
			this.Controls.Add(this.lsh);
			this.Controls.Add(this.div);
			this.Controls.Add(this.clearLast);
			this.Controls.Add(this.clear);
			this.Controls.Add(this.clearE);
			this.Controls.Add(this.mod);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.mult);
			this.Controls.Add(this.btn9);
			this.Controls.Add(this.btn8);
			this.Controls.Add(this.btn7);
			this.Controls.Add(this.btnB);
			this.Controls.Add(this.btnA);
			this.Controls.Add(this.minus);
			this.Controls.Add(this.btn6);
			this.Controls.Add(this.btn5);
			this.Controls.Add(this.btn4);
			this.Controls.Add(this.btnD);
			this.Controls.Add(this.btnC);
			this.Controls.Add(this.plus);
			this.Controls.Add(this.btn3);
			this.Controls.Add(this.btn2);
			this.Controls.Add(this.btn1);
			this.Controls.Add(this.btnF);
			this.Controls.Add(this.btnE);
			this.Controls.Add(this.equals);
			this.Controls.Add(this.dot);
			this.Controls.Add(this.btn0);
			this.Controls.Add(this.plusMin);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.decLabel);
			this.Controls.Add(this.binLabel);
			this.Controls.Add(this.octLabel);
			this.Controls.Add(this.hexLabel);
			this.Controls.Add(this.bin);
			this.Controls.Add(this.oct);
			this.Controls.Add(this.dec);
			this.Controls.Add(this.hex);
			this.Controls.Add(this.lastString);
			this.Controls.Add(this.result);
			this.Controls.Add(this.mode);
			this.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FormProgrammer";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Калькулятор";
			this.memoryPanel.ResumeLayout(false);
			this.memoryPanel.PerformLayout();
			this.historyPanel.ResumeLayout(false);
			this.historyPanel.PerformLayout();
			this.menuPanel.ResumeLayout(false);
			this.menuPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button menu;
		private System.Windows.Forms.Label mode;
		private System.Windows.Forms.TextBox result;
		private System.Windows.Forms.Label lastString;
		private System.Windows.Forms.RadioButton hex;
		private System.Windows.Forms.RadioButton dec;
		private System.Windows.Forms.RadioButton oct;
		private System.Windows.Forms.RadioButton bin;
		private System.Windows.Forms.Label hexLabel;
		private System.Windows.Forms.Label octLabel;
		private System.Windows.Forms.Label binLabel;
		private System.Windows.Forms.Label decLabel;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button plusMin;
		private System.Windows.Forms.Button btn0;
		private System.Windows.Forms.Button dot;
		private System.Windows.Forms.Button equals;
		private System.Windows.Forms.Button plus;
		private System.Windows.Forms.Button btn3;
		private System.Windows.Forms.Button btn2;
		private System.Windows.Forms.Button btn1;
		private System.Windows.Forms.Button btnF;
		private System.Windows.Forms.Button btnE;
		private System.Windows.Forms.Button minus;
		private System.Windows.Forms.Button btn6;
		private System.Windows.Forms.Button btn5;
		private System.Windows.Forms.Button btn4;
		private System.Windows.Forms.Button btnD;
		private System.Windows.Forms.Button btnC;
		private System.Windows.Forms.Button mult;
		private System.Windows.Forms.Button btn9;
		private System.Windows.Forms.Button btn8;
		private System.Windows.Forms.Button btn7;
		private System.Windows.Forms.Button btnB;
		private System.Windows.Forms.Button btnA;
		private System.Windows.Forms.Button div;
		private System.Windows.Forms.Button clearLast;
		private System.Windows.Forms.Button clear;
		private System.Windows.Forms.Button clearE;
		private System.Windows.Forms.Button mod;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button and;
		private System.Windows.Forms.Button not;
		private System.Windows.Forms.Button xor;
		private System.Windows.Forms.Button or;
		private System.Windows.Forms.Button rsh;
		private System.Windows.Forms.Button lsh;
		private System.Windows.Forms.Button memoryList;
		private System.Windows.Forms.Button memorySave;
		private System.Windows.Forms.Button qword;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Panel memoryPanel;
		private System.Windows.Forms.Button trash;
		private System.Windows.Forms.TextBox memoryData;
		private System.Windows.Forms.Button history;
		private System.Windows.Forms.Panel historyPanel;
		private System.Windows.Forms.Button historyTrash;
		private System.Windows.Forms.TextBox historyData;
		private System.Windows.Forms.Panel menuPanel;
		private System.Windows.Forms.Button menuDates;
		private System.Windows.Forms.Button menuProgrammer;
		private System.Windows.Forms.Button menuSimple;
		private System.Windows.Forms.TextBox menuScroll;
		private System.Windows.Forms.Label menuTitle;
	}
}