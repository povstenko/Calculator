namespace Calculator
{
	partial class FormSimple
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSimple));
			this.equals = new System.Windows.Forms.Button();
			this.dot = new System.Windows.Forms.Button();
			this.btn0 = new System.Windows.Forms.Button();
			this.plusMin = new System.Windows.Forms.Button();
			this.plus = new System.Windows.Forms.Button();
			this.minus = new System.Windows.Forms.Button();
			this.mult = new System.Windows.Forms.Button();
			this.div = new System.Windows.Forms.Button();
			this.oneToX = new System.Windows.Forms.Button();
			this.power = new System.Windows.Forms.Button();
			this.root = new System.Windows.Forms.Button();
			this.purcent = new System.Windows.Forms.Button();
			this.clearE = new System.Windows.Forms.Button();
			this.clear = new System.Windows.Forms.Button();
			this.clearLast = new System.Windows.Forms.Button();
			this.btn1 = new System.Windows.Forms.Button();
			this.btn2 = new System.Windows.Forms.Button();
			this.btn3 = new System.Windows.Forms.Button();
			this.btn4 = new System.Windows.Forms.Button();
			this.btn5 = new System.Windows.Forms.Button();
			this.btn6 = new System.Windows.Forms.Button();
			this.btn7 = new System.Windows.Forms.Button();
			this.btn8 = new System.Windows.Forms.Button();
			this.btn9 = new System.Windows.Forms.Button();
			this.result = new System.Windows.Forms.TextBox();
			this.memoryClear = new System.Windows.Forms.Button();
			this.memoryRead = new System.Windows.Forms.Button();
			this.memoryPlus = new System.Windows.Forms.Button();
			this.memoryMinus = new System.Windows.Forms.Button();
			this.memorySave = new System.Windows.Forms.Button();
			this.memoryList = new System.Windows.Forms.Button();
			this.lastString = new System.Windows.Forms.Label();
			this.mode = new System.Windows.Forms.Label();
			this.memoryPanel = new System.Windows.Forms.Panel();
			this.trash = new System.Windows.Forms.Button();
			this.memoryData = new System.Windows.Forms.TextBox();
			this.historyPanel = new System.Windows.Forms.Panel();
			this.historyTrash = new System.Windows.Forms.Button();
			this.historyData = new System.Windows.Forms.TextBox();
			this.menuPanel = new System.Windows.Forms.Panel();
			this.menuDates = new System.Windows.Forms.Button();
			this.menuProgrammer = new System.Windows.Forms.Button();
			this.menuSimple = new System.Windows.Forms.Button();
			this.menuScroll = new System.Windows.Forms.TextBox();
			this.menuTitle = new System.Windows.Forms.Label();
			this.menu = new System.Windows.Forms.Button();
			this.history = new System.Windows.Forms.Button();
			this.memoryPanel.SuspendLayout();
			this.historyPanel.SuspendLayout();
			this.menuPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// equals
			// 
			this.equals.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.equals.FlatAppearance.BorderSize = 0;
			this.equals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.equals.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.equals.Location = new System.Drawing.Point(245, 419);
			this.equals.Name = "equals";
			this.equals.Size = new System.Drawing.Size(75, 45);
			this.equals.TabIndex = 0;
			this.equals.Text = "=";
			this.equals.UseVisualStyleBackColor = false;
			this.equals.Click += new System.EventHandler(this.equals_Click);
			this.equals.MouseEnter += new System.EventHandler(this.equals_MouseEnter);
			this.equals.MouseLeave += new System.EventHandler(this.equals_MouseLeave);
			// 
			// dot
			// 
			this.dot.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.dot.FlatAppearance.BorderSize = 0;
			this.dot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.dot.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dot.Location = new System.Drawing.Point(164, 419);
			this.dot.Name = "dot";
			this.dot.Size = new System.Drawing.Size(75, 45);
			this.dot.TabIndex = 1;
			this.dot.Text = ",";
			this.dot.UseVisualStyleBackColor = false;
			this.dot.Click += new System.EventHandler(this.dot_Click);
			// 
			// btn0
			// 
			this.btn0.BackColor = System.Drawing.Color.White;
			this.btn0.FlatAppearance.BorderSize = 0;
			this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn0.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn0.Location = new System.Drawing.Point(83, 419);
			this.btn0.Name = "btn0";
			this.btn0.Size = new System.Drawing.Size(75, 45);
			this.btn0.TabIndex = 2;
			this.btn0.Text = "0";
			this.btn0.UseVisualStyleBackColor = false;
			this.btn0.Click += new System.EventHandler(this.number_Click);
			// 
			// plusMin
			// 
			this.plusMin.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.plusMin.FlatAppearance.BorderSize = 0;
			this.plusMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.plusMin.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.plusMin.Location = new System.Drawing.Point(2, 419);
			this.plusMin.Name = "plusMin";
			this.plusMin.Size = new System.Drawing.Size(75, 45);
			this.plusMin.TabIndex = 3;
			this.plusMin.Text = "±";
			this.plusMin.UseVisualStyleBackColor = false;
			this.plusMin.Click += new System.EventHandler(this.plusMin_Click);
			// 
			// plus
			// 
			this.plus.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.plus.FlatAppearance.BorderSize = 0;
			this.plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.plus.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.plus.Location = new System.Drawing.Point(245, 368);
			this.plus.Name = "plus";
			this.plus.Size = new System.Drawing.Size(75, 45);
			this.plus.TabIndex = 4;
			this.plus.Text = "+";
			this.plus.UseVisualStyleBackColor = false;
			this.plus.Click += new System.EventHandler(this.plus_Click);
			this.plus.MouseEnter += new System.EventHandler(this.equals_MouseEnter);
			this.plus.MouseLeave += new System.EventHandler(this.equals_MouseLeave);
			// 
			// minus
			// 
			this.minus.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.minus.FlatAppearance.BorderSize = 0;
			this.minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.minus.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.minus.Location = new System.Drawing.Point(245, 317);
			this.minus.Name = "minus";
			this.minus.Size = new System.Drawing.Size(75, 45);
			this.minus.TabIndex = 5;
			this.minus.Text = "-";
			this.minus.UseVisualStyleBackColor = false;
			this.minus.Click += new System.EventHandler(this.minus_Click);
			this.minus.MouseEnter += new System.EventHandler(this.equals_MouseEnter);
			this.minus.MouseLeave += new System.EventHandler(this.equals_MouseLeave);
			// 
			// mult
			// 
			this.mult.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.mult.FlatAppearance.BorderSize = 0;
			this.mult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.mult.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.mult.Location = new System.Drawing.Point(245, 266);
			this.mult.Name = "mult";
			this.mult.Size = new System.Drawing.Size(75, 45);
			this.mult.TabIndex = 6;
			this.mult.Text = "×";
			this.mult.UseVisualStyleBackColor = false;
			this.mult.Click += new System.EventHandler(this.mult_Click);
			this.mult.MouseEnter += new System.EventHandler(this.equals_MouseEnter);
			this.mult.MouseLeave += new System.EventHandler(this.equals_MouseLeave);
			// 
			// div
			// 
			this.div.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.div.FlatAppearance.BorderSize = 0;
			this.div.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.div.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.div.Location = new System.Drawing.Point(245, 215);
			this.div.Name = "div";
			this.div.Size = new System.Drawing.Size(75, 45);
			this.div.TabIndex = 7;
			this.div.Text = "÷";
			this.div.UseVisualStyleBackColor = false;
			this.div.Click += new System.EventHandler(this.div_Click);
			this.div.MouseEnter += new System.EventHandler(this.equals_MouseEnter);
			this.div.MouseLeave += new System.EventHandler(this.equals_MouseLeave);
			// 
			// oneToX
			// 
			this.oneToX.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.oneToX.FlatAppearance.BorderSize = 0;
			this.oneToX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.oneToX.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.oneToX.Location = new System.Drawing.Point(245, 164);
			this.oneToX.Name = "oneToX";
			this.oneToX.Size = new System.Drawing.Size(75, 45);
			this.oneToX.TabIndex = 8;
			this.oneToX.Text = "1/x";
			this.oneToX.UseVisualStyleBackColor = false;
			this.oneToX.Click += new System.EventHandler(this.oneToX_Click);
			// 
			// power
			// 
			this.power.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.power.FlatAppearance.BorderSize = 0;
			this.power.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.power.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.power.Location = new System.Drawing.Point(164, 164);
			this.power.Name = "power";
			this.power.Size = new System.Drawing.Size(75, 45);
			this.power.TabIndex = 9;
			this.power.Text = "x²";
			this.power.UseVisualStyleBackColor = false;
			this.power.Click += new System.EventHandler(this.power_Click);
			// 
			// root
			// 
			this.root.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.root.FlatAppearance.BorderSize = 0;
			this.root.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.root.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.root.Location = new System.Drawing.Point(83, 164);
			this.root.Name = "root";
			this.root.Size = new System.Drawing.Size(75, 45);
			this.root.TabIndex = 10;
			this.root.Text = "√";
			this.root.UseVisualStyleBackColor = false;
			this.root.Click += new System.EventHandler(this.root_Click);
			// 
			// purcent
			// 
			this.purcent.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.purcent.FlatAppearance.BorderSize = 0;
			this.purcent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.purcent.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.purcent.Location = new System.Drawing.Point(2, 164);
			this.purcent.Name = "purcent";
			this.purcent.Size = new System.Drawing.Size(75, 45);
			this.purcent.TabIndex = 11;
			this.purcent.Text = "%";
			this.purcent.UseVisualStyleBackColor = false;
			this.purcent.Click += new System.EventHandler(this.purcent_Click);
			// 
			// clearE
			// 
			this.clearE.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.clearE.FlatAppearance.BorderSize = 0;
			this.clearE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.clearE.Font = new System.Drawing.Font("Segoe UI Light", 12F);
			this.clearE.Location = new System.Drawing.Point(2, 215);
			this.clearE.Name = "clearE";
			this.clearE.Size = new System.Drawing.Size(75, 45);
			this.clearE.TabIndex = 12;
			this.clearE.Text = "CE";
			this.clearE.UseVisualStyleBackColor = false;
			this.clearE.Click += new System.EventHandler(this.clearE_Click);
			// 
			// clear
			// 
			this.clear.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.clear.FlatAppearance.BorderSize = 0;
			this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.clear.Font = new System.Drawing.Font("Segoe UI Light", 12F);
			this.clear.Location = new System.Drawing.Point(83, 215);
			this.clear.Name = "clear";
			this.clear.Size = new System.Drawing.Size(75, 45);
			this.clear.TabIndex = 13;
			this.clear.Text = "C";
			this.clear.UseVisualStyleBackColor = false;
			this.clear.Click += new System.EventHandler(this.clear_Click);
			// 
			// clearLast
			// 
			this.clearLast.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.clearLast.FlatAppearance.BorderSize = 0;
			this.clearLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.clearLast.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.clearLast.Location = new System.Drawing.Point(164, 215);
			this.clearLast.Name = "clearLast";
			this.clearLast.Size = new System.Drawing.Size(75, 45);
			this.clearLast.TabIndex = 14;
			this.clearLast.Text = "←";
			this.clearLast.UseVisualStyleBackColor = false;
			this.clearLast.Click += new System.EventHandler(this.clearLast_Click);
			// 
			// btn1
			// 
			this.btn1.BackColor = System.Drawing.Color.White;
			this.btn1.FlatAppearance.BorderSize = 0;
			this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn1.Location = new System.Drawing.Point(2, 368);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(75, 45);
			this.btn1.TabIndex = 15;
			this.btn1.Text = "1";
			this.btn1.UseVisualStyleBackColor = false;
			this.btn1.Click += new System.EventHandler(this.number_Click);
			// 
			// btn2
			// 
			this.btn2.BackColor = System.Drawing.Color.White;
			this.btn2.FlatAppearance.BorderSize = 0;
			this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn2.Location = new System.Drawing.Point(83, 368);
			this.btn2.Name = "btn2";
			this.btn2.Size = new System.Drawing.Size(75, 45);
			this.btn2.TabIndex = 16;
			this.btn2.Text = "2";
			this.btn2.UseVisualStyleBackColor = false;
			this.btn2.Click += new System.EventHandler(this.number_Click);
			// 
			// btn3
			// 
			this.btn3.BackColor = System.Drawing.Color.White;
			this.btn3.FlatAppearance.BorderSize = 0;
			this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn3.Location = new System.Drawing.Point(164, 368);
			this.btn3.Name = "btn3";
			this.btn3.Size = new System.Drawing.Size(75, 45);
			this.btn3.TabIndex = 17;
			this.btn3.Text = "3";
			this.btn3.UseVisualStyleBackColor = false;
			this.btn3.Click += new System.EventHandler(this.number_Click);
			// 
			// btn4
			// 
			this.btn4.BackColor = System.Drawing.Color.White;
			this.btn4.FlatAppearance.BorderSize = 0;
			this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn4.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn4.Location = new System.Drawing.Point(2, 317);
			this.btn4.Name = "btn4";
			this.btn4.Size = new System.Drawing.Size(75, 45);
			this.btn4.TabIndex = 18;
			this.btn4.Text = "4";
			this.btn4.UseVisualStyleBackColor = false;
			this.btn4.Click += new System.EventHandler(this.number_Click);
			// 
			// btn5
			// 
			this.btn5.BackColor = System.Drawing.Color.White;
			this.btn5.FlatAppearance.BorderSize = 0;
			this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn5.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn5.Location = new System.Drawing.Point(83, 317);
			this.btn5.Name = "btn5";
			this.btn5.Size = new System.Drawing.Size(75, 45);
			this.btn5.TabIndex = 19;
			this.btn5.Text = "5";
			this.btn5.UseVisualStyleBackColor = false;
			this.btn5.Click += new System.EventHandler(this.number_Click);
			// 
			// btn6
			// 
			this.btn6.BackColor = System.Drawing.Color.White;
			this.btn6.FlatAppearance.BorderSize = 0;
			this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn6.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn6.Location = new System.Drawing.Point(164, 317);
			this.btn6.Name = "btn6";
			this.btn6.Size = new System.Drawing.Size(75, 45);
			this.btn6.TabIndex = 20;
			this.btn6.Text = "6";
			this.btn6.UseVisualStyleBackColor = false;
			this.btn6.Click += new System.EventHandler(this.number_Click);
			// 
			// btn7
			// 
			this.btn7.BackColor = System.Drawing.Color.White;
			this.btn7.FlatAppearance.BorderSize = 0;
			this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn7.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn7.Location = new System.Drawing.Point(2, 266);
			this.btn7.Name = "btn7";
			this.btn7.Size = new System.Drawing.Size(75, 45);
			this.btn7.TabIndex = 21;
			this.btn7.Text = "7";
			this.btn7.UseVisualStyleBackColor = false;
			this.btn7.Click += new System.EventHandler(this.number_Click);
			// 
			// btn8
			// 
			this.btn8.BackColor = System.Drawing.Color.White;
			this.btn8.FlatAppearance.BorderSize = 0;
			this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn8.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn8.Location = new System.Drawing.Point(83, 266);
			this.btn8.Name = "btn8";
			this.btn8.Size = new System.Drawing.Size(75, 45);
			this.btn8.TabIndex = 22;
			this.btn8.Text = "8";
			this.btn8.UseVisualStyleBackColor = false;
			this.btn8.Click += new System.EventHandler(this.number_Click);
			// 
			// btn9
			// 
			this.btn9.BackColor = System.Drawing.Color.White;
			this.btn9.FlatAppearance.BorderSize = 0;
			this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn9.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn9.Location = new System.Drawing.Point(164, 266);
			this.btn9.Name = "btn9";
			this.btn9.Size = new System.Drawing.Size(75, 45);
			this.btn9.TabIndex = 23;
			this.btn9.Text = "9";
			this.btn9.UseVisualStyleBackColor = false;
			this.btn9.Click += new System.EventHandler(this.number_Click);
			// 
			// result
			// 
			this.result.BackColor = System.Drawing.SystemColors.Control;
			this.result.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.result.Font = new System.Drawing.Font("Segoe UI Semibold", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.result.Location = new System.Drawing.Point(2, 63);
			this.result.Multiline = true;
			this.result.Name = "result";
			this.result.Size = new System.Drawing.Size(318, 66);
			this.result.TabIndex = 24;
			this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// memoryClear
			// 
			this.memoryClear.BackColor = System.Drawing.SystemColors.Control;
			this.memoryClear.Enabled = false;
			this.memoryClear.FlatAppearance.BorderSize = 0;
			this.memoryClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.memoryClear.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.memoryClear.Location = new System.Drawing.Point(12, 135);
			this.memoryClear.Name = "memoryClear";
			this.memoryClear.Size = new System.Drawing.Size(43, 23);
			this.memoryClear.TabIndex = 25;
			this.memoryClear.Text = "MC";
			this.memoryClear.UseVisualStyleBackColor = false;
			this.memoryClear.Click += new System.EventHandler(this.memoryClear_Click);
			// 
			// memoryRead
			// 
			this.memoryRead.BackColor = System.Drawing.SystemColors.Control;
			this.memoryRead.Enabled = false;
			this.memoryRead.FlatAppearance.BorderSize = 0;
			this.memoryRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.memoryRead.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.memoryRead.Location = new System.Drawing.Point(61, 135);
			this.memoryRead.Name = "memoryRead";
			this.memoryRead.Size = new System.Drawing.Size(43, 23);
			this.memoryRead.TabIndex = 26;
			this.memoryRead.Text = "MR";
			this.memoryRead.UseVisualStyleBackColor = false;
			this.memoryRead.Click += new System.EventHandler(this.memoryRead_Click);
			// 
			// memoryPlus
			// 
			this.memoryPlus.BackColor = System.Drawing.SystemColors.Control;
			this.memoryPlus.FlatAppearance.BorderSize = 0;
			this.memoryPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.memoryPlus.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.memoryPlus.Location = new System.Drawing.Point(115, 135);
			this.memoryPlus.Name = "memoryPlus";
			this.memoryPlus.Size = new System.Drawing.Size(43, 23);
			this.memoryPlus.TabIndex = 27;
			this.memoryPlus.Text = "M+";
			this.memoryPlus.UseVisualStyleBackColor = false;
			this.memoryPlus.Click += new System.EventHandler(this.memoryPlus_Click);
			// 
			// memoryMinus
			// 
			this.memoryMinus.BackColor = System.Drawing.SystemColors.Control;
			this.memoryMinus.FlatAppearance.BorderSize = 0;
			this.memoryMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.memoryMinus.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.memoryMinus.Location = new System.Drawing.Point(164, 135);
			this.memoryMinus.Name = "memoryMinus";
			this.memoryMinus.Size = new System.Drawing.Size(43, 23);
			this.memoryMinus.TabIndex = 28;
			this.memoryMinus.Text = "M-";
			this.memoryMinus.UseVisualStyleBackColor = false;
			this.memoryMinus.Click += new System.EventHandler(this.memoryMinus_Click);
			// 
			// memorySave
			// 
			this.memorySave.BackColor = System.Drawing.SystemColors.Control;
			this.memorySave.FlatAppearance.BorderSize = 0;
			this.memorySave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.memorySave.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.memorySave.Location = new System.Drawing.Point(219, 135);
			this.memorySave.Name = "memorySave";
			this.memorySave.Size = new System.Drawing.Size(43, 23);
			this.memorySave.TabIndex = 29;
			this.memorySave.Text = "MS";
			this.memorySave.UseVisualStyleBackColor = false;
			this.memorySave.Click += new System.EventHandler(this.memorySave_Click);
			// 
			// memoryList
			// 
			this.memoryList.BackColor = System.Drawing.SystemColors.Control;
			this.memoryList.Enabled = false;
			this.memoryList.FlatAppearance.BorderSize = 0;
			this.memoryList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.memoryList.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.memoryList.Location = new System.Drawing.Point(268, 135);
			this.memoryList.Name = "memoryList";
			this.memoryList.Size = new System.Drawing.Size(43, 23);
			this.memoryList.TabIndex = 30;
			this.memoryList.Text = "M^";
			this.memoryList.UseVisualStyleBackColor = false;
			this.memoryList.Click += new System.EventHandler(this.memoryList_Click);
			// 
			// lastString
			// 
			this.lastString.AutoSize = true;
			this.lastString.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lastString.ForeColor = System.Drawing.SystemColors.GrayText;
			this.lastString.Location = new System.Drawing.Point(264, 40);
			this.lastString.Name = "lastString";
			this.lastString.Size = new System.Drawing.Size(0, 20);
			this.lastString.TabIndex = 31;
			this.lastString.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// mode
			// 
			this.mode.AutoSize = true;
			this.mode.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.mode.Location = new System.Drawing.Point(66, 9);
			this.mode.Name = "mode";
			this.mode.Size = new System.Drawing.Size(119, 32);
			this.mode.TabIndex = 34;
			this.mode.Text = "Обычный";
			// 
			// memoryPanel
			// 
			this.memoryPanel.BackColor = System.Drawing.SystemColors.Window;
			this.memoryPanel.Controls.Add(this.trash);
			this.memoryPanel.Controls.Add(this.memoryData);
			this.memoryPanel.Location = new System.Drawing.Point(-8, 164);
			this.memoryPanel.Name = "memoryPanel";
			this.memoryPanel.Size = new System.Drawing.Size(340, 314);
			this.memoryPanel.TabIndex = 35;
			this.memoryPanel.Visible = false;
			// 
			// trash
			// 
			this.trash.BackColor = System.Drawing.SystemColors.Window;
			this.trash.BackgroundImage = global::Calculator.Properties.Resources.trash;
			this.trash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.trash.FlatAppearance.BorderSize = 0;
			this.trash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.trash.Location = new System.Drawing.Point(284, 257);
			this.trash.Name = "trash";
			this.trash.Size = new System.Drawing.Size(35, 35);
			this.trash.TabIndex = 34;
			this.trash.UseVisualStyleBackColor = false;
			this.trash.Visible = false;
			this.trash.Click += new System.EventHandler(this.trash_Click);
			// 
			// memoryData
			// 
			this.memoryData.BackColor = System.Drawing.SystemColors.Window;
			this.memoryData.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.memoryData.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.memoryData.Location = new System.Drawing.Point(20, 31);
			this.memoryData.Multiline = true;
			this.memoryData.Name = "memoryData";
			this.memoryData.Size = new System.Drawing.Size(299, 42);
			this.memoryData.TabIndex = 25;
			this.memoryData.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// historyPanel
			// 
			this.historyPanel.BackColor = System.Drawing.SystemColors.Window;
			this.historyPanel.Controls.Add(this.historyTrash);
			this.historyPanel.Controls.Add(this.historyData);
			this.historyPanel.Location = new System.Drawing.Point(-5, 161);
			this.historyPanel.Name = "historyPanel";
			this.historyPanel.Size = new System.Drawing.Size(334, 314);
			this.historyPanel.TabIndex = 36;
			this.historyPanel.Visible = false;
			// 
			// historyTrash
			// 
			this.historyTrash.BackColor = System.Drawing.SystemColors.Window;
			this.historyTrash.BackgroundImage = global::Calculator.Properties.Resources.trash;
			this.historyTrash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.historyTrash.FlatAppearance.BorderSize = 0;
			this.historyTrash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.historyTrash.Location = new System.Drawing.Point(284, 257);
			this.historyTrash.Name = "historyTrash";
			this.historyTrash.Size = new System.Drawing.Size(35, 35);
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
			this.historyData.Size = new System.Drawing.Size(299, 248);
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
			this.menuPanel.Location = new System.Drawing.Point(0, 0);
			this.menuPanel.Name = "menuPanel";
			this.menuPanel.Size = new System.Drawing.Size(266, 476);
			this.menuPanel.TabIndex = 37;
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
			this.menuSimple.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
			this.menu.TabIndex = 32;
			this.menu.UseVisualStyleBackColor = false;
			this.menu.Click += new System.EventHandler(this.menu_Click);
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
			this.history.TabIndex = 33;
			this.history.UseVisualStyleBackColor = false;
			this.history.Click += new System.EventHandler(this.history_Click);
			// 
			// FormSimple
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(323, 468);
			this.Controls.Add(this.menu);
			this.Controls.Add(this.menuPanel);
			this.Controls.Add(this.historyPanel);
			this.Controls.Add(this.memoryPanel);
			this.Controls.Add(this.mode);
			this.Controls.Add(this.history);
			this.Controls.Add(this.lastString);
			this.Controls.Add(this.memoryList);
			this.Controls.Add(this.memorySave);
			this.Controls.Add(this.memoryMinus);
			this.Controls.Add(this.memoryPlus);
			this.Controls.Add(this.memoryRead);
			this.Controls.Add(this.memoryClear);
			this.Controls.Add(this.result);
			this.Controls.Add(this.btn9);
			this.Controls.Add(this.btn8);
			this.Controls.Add(this.btn7);
			this.Controls.Add(this.btn6);
			this.Controls.Add(this.btn5);
			this.Controls.Add(this.btn4);
			this.Controls.Add(this.btn3);
			this.Controls.Add(this.btn2);
			this.Controls.Add(this.btn1);
			this.Controls.Add(this.clearLast);
			this.Controls.Add(this.clear);
			this.Controls.Add(this.clearE);
			this.Controls.Add(this.purcent);
			this.Controls.Add(this.root);
			this.Controls.Add(this.power);
			this.Controls.Add(this.oneToX);
			this.Controls.Add(this.div);
			this.Controls.Add(this.mult);
			this.Controls.Add(this.minus);
			this.Controls.Add(this.plus);
			this.Controls.Add(this.plusMin);
			this.Controls.Add(this.btn0);
			this.Controls.Add(this.dot);
			this.Controls.Add(this.equals);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FormSimple";
			this.ShowIcon = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
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

		private System.Windows.Forms.Button equals;
		private System.Windows.Forms.Button dot;
		private System.Windows.Forms.Button btn0;
		private System.Windows.Forms.Button plusMin;
		private System.Windows.Forms.Button plus;
		private System.Windows.Forms.Button minus;
		private System.Windows.Forms.Button mult;
		private System.Windows.Forms.Button div;
		private System.Windows.Forms.Button oneToX;
		private System.Windows.Forms.Button power;
		private System.Windows.Forms.Button root;
		private System.Windows.Forms.Button purcent;
		private System.Windows.Forms.Button clearE;
		private System.Windows.Forms.Button clear;
		private System.Windows.Forms.Button clearLast;
		private System.Windows.Forms.Button btn1;
		private System.Windows.Forms.Button btn2;
		private System.Windows.Forms.Button btn3;
		private System.Windows.Forms.Button btn4;
		private System.Windows.Forms.Button btn5;
		private System.Windows.Forms.Button btn6;
		private System.Windows.Forms.Button btn7;
		private System.Windows.Forms.Button btn8;
		private System.Windows.Forms.Button btn9;
		private System.Windows.Forms.TextBox result;
		private System.Windows.Forms.Button memoryClear;
		private System.Windows.Forms.Button memoryRead;
		private System.Windows.Forms.Button memoryPlus;
		private System.Windows.Forms.Button memoryMinus;
		private System.Windows.Forms.Button memorySave;
		private System.Windows.Forms.Button memoryList;
		private System.Windows.Forms.Label lastString;
		private System.Windows.Forms.Button menu;
		private System.Windows.Forms.Button history;
		private System.Windows.Forms.Label mode;
		private System.Windows.Forms.Panel memoryPanel;
		private System.Windows.Forms.TextBox memoryData;
		private System.Windows.Forms.Button trash;
		private System.Windows.Forms.Panel historyPanel;
		private System.Windows.Forms.Button historyTrash;
		private System.Windows.Forms.TextBox historyData;
		private System.Windows.Forms.Panel menuPanel;
		private System.Windows.Forms.TextBox menuScroll;
		private System.Windows.Forms.Label menuTitle;
		private System.Windows.Forms.Button menuDates;
		private System.Windows.Forms.Button menuProgrammer;
		private System.Windows.Forms.Button menuSimple;
	}
}

