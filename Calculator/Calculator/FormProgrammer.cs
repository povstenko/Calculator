using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
	public partial class FormProgrammer : Form
	{
		Calculator calc;
		char operation;
		bool sign;// true - "+", false - "-"
		string mem = "";

		public FormProgrammer()
		{
			InitializeComponent();
			calc = new Calculator();
			sign = true;
			result.Text = "0";

			btnA.Enabled = false;
			btnB.Enabled = false;
			btnC.Enabled = false;
			btnD.Enabled = false;
			btnE.Enabled = false;
			btnF.Enabled = false;

			hex.Enabled = false;
			memoryList.Enabled = false;
		}

		public void Calculate()
		{
			double arg = 0;

			if (bin.Checked)
			{
				arg = Convert.ToDouble(calc.Bin_Dec(result.Text));
			}
			else if (oct.Checked)
			{
				arg = Convert.ToDouble(calc.Oct_Dec(result.Text));
			}
			else if (dec.Checked)
			{
				arg = Convert.ToDouble(result.Text);
			}
			else if (hex.Checked)
			{
				// it doesnt work!
				arg = Convert.ToDouble(calc.Hex_Dec(result.Text));
			}

			if (operation == '+')
				result.Text = calc.Sum(arg).ToString();
			else if (operation == '-')
				result.Text = calc.Substract(arg).ToString();
			else if (operation == '×')
				result.Text = calc.Multiplication(arg).ToString();
			else if (operation == '÷')
			{
				if (calc.Division(arg).ToString() == "∞")
				{
					result.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
					result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
					result.Text = "Деление на ноль невозможно";

					calc.CanErease = true;
					plusMin.Enabled = false;
					dot.Enabled = false;
					plus.Enabled = false;
					minus.Enabled = false;
					div.Enabled = false;
					mult.Enabled = false;
					equals.Enabled = false;

					lsh.Enabled = false;
					rsh.Enabled = false;
					or.Enabled = false;
					xor.Enabled = false;
					not.Enabled = false;
					and.Enabled = false;

					button1.Enabled = false;
					button2.Enabled = false;
					button3.Enabled = false;

					//memorySave.Enabled = false;
				}
				else
					result.Text = calc.Division(arg).ToString();
			}
		}

		private void number_Click(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			if (bin.Checked)
			{
				if (result.Text == "0" || calc.CanErease)
				{
					result.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
					result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
					result.Text = btn.Text;

					plusMin.Enabled = true;
					dot.Enabled = true;
					plus.Enabled = true;
					minus.Enabled = true;
					div.Enabled = true;
					mult.Enabled = true;
					equals.Enabled = true;

					lsh.Enabled = true;
					rsh.Enabled = true;
					or.Enabled = true;
					xor.Enabled = true;
					not.Enabled = true;
					and.Enabled = true;

					button1.Enabled = true;
					button2.Enabled = true;
					button3.Enabled = true;

					//memorySave.Enabled = true;

					calc.CanErease = false;
				}
				else
					result.Text += btn.Text;

				hexLabel.Text = calc.Bin_Hex(result.Text);
				decLabel.Text = calc.Bin_Dec(result.Text);
				octLabel.Text = calc.Bin_Oct(result.Text);
				binLabel.Text = result.Text;
			}
			else if(oct.Checked)
			{
				int num = Convert.ToInt32(btn.Text);

				if (result.Text == "0" || calc.CanErease)
				{
					result.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
					result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
					result.Text = num.ToString();

					plusMin.Enabled = true;
					dot.Enabled = true;
					plus.Enabled = true;
					minus.Enabled = true;
					div.Enabled = true;
					mult.Enabled = true;
					equals.Enabled = true;

					lsh.Enabled = true;
					rsh.Enabled = true;
					or.Enabled = true;
					xor.Enabled = true;
					not.Enabled = true;
					and.Enabled = true;

					button1.Enabled = true;
					button2.Enabled = true;
					button3.Enabled = true;

					//memorySave.Enabled = true;

					calc.CanErease = false;
				}
				else
					result.Text += num.ToString();

				hexLabel.Text = calc.Oct_Hex(result.Text);
				decLabel.Text = calc.Oct_Dec(result.Text);
				octLabel.Text = result.Text;
				binLabel.Text = calc.Oct_Bin(result.Text);
			}
			else if (dec.Checked)
			{
				int num = Convert.ToInt32(btn.Text);

				if (result.Text == "0" || calc.CanErease)
				{
					result.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
					result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
					result.Text = num.ToString();

					plusMin.Enabled = true;
					dot.Enabled = true;
					plus.Enabled = true;
					minus.Enabled = true;
					div.Enabled = true;
					mult.Enabled = true;
					equals.Enabled = true;

					lsh.Enabled = true;
					rsh.Enabled = true;
					or.Enabled = true;
					xor.Enabled = true;
					not.Enabled = true;
					and.Enabled = true;

					button1.Enabled = true;
					button2.Enabled = true;
					button3.Enabled = true;

					//memorySave.Enabled = true;

					calc.CanErease = false;
				}
				else
					result.Text += num.ToString();

				hexLabel.Text = calc.Dec_Hex(result.Text);
				decLabel.Text = result.Text;
				octLabel.Text = calc.Dec_Oct(result.Text);
				binLabel.Text = calc.Dec_Bin(result.Text);
			}
			else if (hex.Checked)
			{
				if (result.Text == "0" || calc.CanErease)
				{
					result.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
					result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
					result.Text = btn.Text;

					plusMin.Enabled = true;
					dot.Enabled = true;
					plus.Enabled = true;
					minus.Enabled = true;
					div.Enabled = true;
					mult.Enabled = true;
					equals.Enabled = true;

					lsh.Enabled = true;
					rsh.Enabled = true;
					or.Enabled = true;
					xor.Enabled = true;
					not.Enabled = true;
					and.Enabled = true;

					button1.Enabled = true;
					button2.Enabled = true;
					button3.Enabled = true;

					//memorySave.Enabled = true;

					calc.CanErease = false;
				}
				else
					result.Text += btn.Text;

				hexLabel.Text = result.Text;
				decLabel.Text = calc.Hex_Dec(result.Text);
				octLabel.Text = calc.Hex_Oct(result.Text);
				binLabel.Text = calc.Hex_Bin(result.Text);
			}
			
		}
		private void letter_Click(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			string let = "";
			if (btn.Text == "A") let = "a";
			else if (btn.Text == "B") let = "b";
			else if (btn.Text == "C") let = "c";
			else if (btn.Text == "D") let = "d";
			else if (btn.Text == "E") let = "e";
			else if (btn.Text == "F") let = "f";

			if (result.Text == "0" || calc.CanErease)
			{
				result.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
				result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				result.Text = btn.Text;

				plusMin.Enabled = true;
				dot.Enabled = true;
				plus.Enabled = true;
				minus.Enabled = true;
				div.Enabled = true;
				mult.Enabled = true;
				equals.Enabled = true;

				lsh.Enabled = true;
				rsh.Enabled = true;
				or.Enabled = true;
				xor.Enabled = true;
				not.Enabled = true;
				and.Enabled = true;

				button1.Enabled = true;
				button2.Enabled = true;
				button3.Enabled = true;

				//memorySave.Enabled = true;

				calc.CanErease = false;
			}
			else
				result.Text += let;

			hexLabel.Text = result.Text;
			decLabel.Text = calc.Hex_Dec(result.Text);
			octLabel.Text = calc.Hex_Oct(result.Text);
			binLabel.Text = calc.Hex_Bin(result.Text);
		}
		private void dot_Click(object sender, EventArgs e)
		{
			if (result.Text.IndexOf(',') == -1)
				result.Text += ",";
		}
		private void plusMin_Click(object sender, EventArgs e)
		{
			if (sign)
			{
				result.Text = "-" + result.Text;
				sign = false;
			}
			else
			{
				result.Text = result.Text.Replace("-", "");
				sign = true;
			}
		}

		private void plus_Click(object sender, EventArgs e)
		{
			if (lastString.Text != "")
			{
				string op1 = lastString.Text;
				string op2 = result.Text;

				lastString.Text = "";
				Calculate();
				calc.AddToHistory(op1, op2, result.Text);
				calc.CanErease = true;
			}

			if (bin.Checked)
			{
				calc.SetA(Convert.ToDouble(calc.Bin_Dec(result.Text)));
			}
			else if (oct.Checked)
			{
				calc.SetA(Convert.ToDouble(calc.Oct_Dec(result.Text)));
			}
			else if (dec.Checked)
			{
				calc.SetA(Convert.ToDouble(result.Text));
			}
			else if (hex.Checked)
			{
				// it doesnt work!
				calc.SetA(Convert.ToDouble(calc.Hex_Dec(result.Text)));
			}

			operation = '+';
			lastString.Text = Convert.ToDouble(result.Text) + " + ";
			sign = true;
			calc.CanErease = true;
		}
		private void minus_Click(object sender, EventArgs e)
		{
			if (lastString.Text != "")
			{
				string op1 = lastString.Text;
				string op2 = result.Text;

				lastString.Text = "";
				Calculate();
				calc.AddToHistory(op1, op2, result.Text);
				calc.CanErease = true;
			}
			calc.SetA(Convert.ToDouble(result.Text));
			operation = '-';
			lastString.Text = Convert.ToDouble(result.Text) + " - ";
			sign = true;
			calc.CanErease = true;
		}
		private void mult_Click(object sender, EventArgs e)
		{
			if (lastString.Text != "")
			{
				string op1 = lastString.Text;
				string op2 = result.Text;

				lastString.Text = "";
				Calculate();
				calc.AddToHistory(op1, op2, result.Text);
				calc.CanErease = true;
			}
			calc.SetA(Convert.ToDouble(result.Text));
			operation = '×';
			lastString.Text = Convert.ToDouble(result.Text) + " × ";
			sign = true;
			calc.CanErease = true;
		}
		private void div_Click(object sender, EventArgs e)
		{
			if (lastString.Text != "")
			{
				string op1 = lastString.Text;
				string op2 = result.Text;

				lastString.Text = "";
				Calculate();
				calc.AddToHistory(op1, op2, result.Text);
				calc.CanErease = true;
			}
			calc.SetA(Convert.ToDouble(result.Text));
			operation = '÷';
			lastString.Text = Convert.ToDouble(result.Text) + " ÷ ";
			sign = true;
			calc.CanErease = true;
		}
		private void equals_Click(object sender, EventArgs e)
		{
			string op1 = lastString.Text;
			string op2 = result.Text;

			lastString.Text = "";
			Calculate();
			calc.AddToHistory(op1, op2, result.Text);
			calc.CanErease = true;

			hexLabel.Text = calc.Dec_Hex(result.Text);
			decLabel.Text = Convert.ToString(Convert.ToInt32(result.Text), 10);
			octLabel.Text = calc.Dec_Oct(result.Text);
			binLabel.Text = calc.Dec_Bin(result.Text);

			if (bin.Checked)
			{
				result.Text = calc.Dec_Bin(result.Text);
			}
			else if (oct.Checked)
			{
				result.Text = calc.Dec_Oct(result.Text);
			}
			else if (dec.Checked)
			{
				result.Text = result.Text;
			}
			else if (hex.Checked)
			{
				result.Text = calc.Dec_Hex(result.Text);
			}
		}

		private void clear_Click(object sender, EventArgs e)
		{
			result.Text = "0";
			lastString.Text = "";
			hexLabel.Text = "0";
			decLabel.Text = "0";
			octLabel.Text = "0";
			binLabel.Text = "0";
		}
		private void clearE_Click(object sender, EventArgs e)
		{
			result.Text = "0";
			hexLabel.Text = "0";
			decLabel.Text = "0";
			octLabel.Text = "0";
			binLabel.Text = "0";
		}
		private void clearLast_Click(object sender, EventArgs e)
		{
			int len = result.Text.Length - 1;
			string text = result.Text;
			result.Clear();

			for (int i = 0; i < len; i++)
				result.Text = result.Text + text[i];

			if (result.Text == "")
				result.Text = "0";

			hexLabel.Text = "0";
			decLabel.Text = "0";
			octLabel.Text = "0";
			binLabel.Text = "0";
		}

		private void equals_MouseEnter(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			btn.BackColor = System.Drawing.SystemColors.Highlight;
			btn.ForeColor = Color.White;
		}
		private void equals_MouseLeave(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			btn.BackColor = System.Drawing.SystemColors.InactiveBorder;
			btn.ForeColor = Color.Black;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if(lsh.Text == "Lsh")
			{
				lsh.Text = "RoL";
				rsh.Text = "RoR";
			}
			else
			{
				lsh.Text = "Lsh";
				rsh.Text = "Rsh";
			}
		}
		private void qword_Click(object sender, EventArgs e)
		{
			Button btn = (Button)sender;

			if (btn.Text == "QWORD")
				btn.Text = "DWORD";
			else if (btn.Text == "DWORD")
				btn.Text = "WORD";
			else if (btn.Text == "WORD")
				btn.Text = "BYTE";
			else if (btn.Text == "BYTE")
				btn.Text = "QWORD";
		}

		private void hex_CheckedChanged(object sender, EventArgs e)
		{
			btnA.Enabled = true;
			btnB.Enabled = true;
			btnC.Enabled = true;
			btnD.Enabled = true;
			btnE.Enabled = true;
			btnF.Enabled = true;

			btn0.Enabled = true;
			btn1.Enabled = true;
			btn2.Enabled = true;
			btn3.Enabled = true;
			btn4.Enabled = true;
			btn5.Enabled = true;
			btn6.Enabled = true;
			btn7.Enabled = true;
			btn8.Enabled = true;
			btn9.Enabled = true;

			hexLabel.Text = "0";
			decLabel.Text = "0";
			octLabel.Text = "0";
			binLabel.Text = "0";
			result.Text = "0";
			lastString.Text = "";
			calc.CanErease = true;

		}
		private void dec_CheckedChanged(object sender, EventArgs e)
		{
			btnA.Enabled = false;
			btnB.Enabled = false;
			btnC.Enabled = false;
			btnD.Enabled = false;
			btnE.Enabled = false;
			btnF.Enabled = false;

			btn0.Enabled = true;
			btn1.Enabled = true;
			btn2.Enabled = true;
			btn3.Enabled = true;
			btn4.Enabled = true;
			btn5.Enabled = true;
			btn6.Enabled = true;
			btn7.Enabled = true;
			btn8.Enabled = true;
			btn9.Enabled = true;

			hexLabel.Text = "0";
			decLabel.Text = "0";
			octLabel.Text = "0";
			binLabel.Text = "0";
			result.Text = "0";
			lastString.Text = "";
			calc.CanErease = true;
		}
		private void oct_CheckedChanged(object sender, EventArgs e)
		{
			btnA.Enabled = false;
			btnB.Enabled = false;
			btnC.Enabled = false;
			btnD.Enabled = false;
			btnE.Enabled = false;
			btnF.Enabled = false;

			btn0.Enabled = true;
			btn1.Enabled = true;
			btn2.Enabled = true;
			btn3.Enabled = true;
			btn4.Enabled = true;
			btn5.Enabled = true;
			btn6.Enabled = true;
			btn7.Enabled = true;
			btn8.Enabled = false;
			btn9.Enabled = false;

			hexLabel.Text = "0";
			decLabel.Text = "0";
			octLabel.Text = "0";
			binLabel.Text = "0";
			result.Text = "0";
			lastString.Text = "";
			calc.CanErease = true;
		}
		private void bin_CheckedChanged(object sender, EventArgs e)
		{
			btnA.Enabled = false;
			btnB.Enabled = false;
			btnC.Enabled = false;
			btnD.Enabled = false;
			btnE.Enabled = false;
			btnF.Enabled = false;

			btn0.Enabled = true;
			btn1.Enabled = true;
			btn2.Enabled = false;
			btn3.Enabled = false;
			btn4.Enabled = false;
			btn5.Enabled = false;
			btn6.Enabled = false;
			btn7.Enabled = false;
			btn8.Enabled = false;
			btn9.Enabled = false;

			hexLabel.Text = "0";
			decLabel.Text = "0";
			octLabel.Text = "0";
			binLabel.Text = "0";
			result.Text = "0";
			lastString.Text = "";
			calc.CanErease = true;
		}

		private void memorySave_Click(object sender, EventArgs e)
		{
			//calc.MemorySave(Convert.ToDouble(result.Text));
			mem = result.Text;
			memoryList.Enabled = true;
		}
		private void memoryList_Click(object sender, EventArgs e)
		{
			if (!memoryPanel.Visible)
			{
				memoryPanel.Visible = true;
				memoryData.Visible = true;
				trash.Visible = true;

				memorySave.Enabled = false;
			}
			else
			{
				memoryPanel.Visible = false;
				memoryData.Visible = false;
				trash.Visible = false;

				if (memoryData.Text == "В памяти ничего не сохранено")
				{
					memoryData.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold);
					memoryData.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
					memorySave.Enabled = true;
					memoryList.Enabled = false;
				}
				else
				{
					memorySave.Enabled = true;
				}
			}
			//memoryData.Text = calc.MemoryRead().ToString();
			memoryData.Text = mem;
		}
		private void trash_Click(object sender, EventArgs e)
		{
			//calc.MemoryClear();
			mem = "";
			memoryData.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold);
			memoryData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			memoryData.Text = "В памяти ничего не сохранено";
		}

		private void history_Click(object sender, EventArgs e)
		{
			if (!historyPanel.Visible)
			{
				historyPanel.Visible = true;
				historyData.Visible = true;
				historyTrash.Visible = true;

				if (calc.GetHistory() == "")
				{
					historyData.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
					historyData.Text = "Журнала еще нет";
				}
				else
				{
					historyData.Text = calc.GetHistory();
					historyData.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				}
			}
			else
			{
				historyPanel.Visible = false;
				historyData.Visible = false;
				historyTrash.Visible = false;
			}
		}
		private void historyTrash_Click(object sender, EventArgs e)
		{
			calc.DeleteHistory();
			historyData.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			historyData.Text = "Журнала еще нет";
		}

		private void menu_Click(object sender, EventArgs e)
		{
			if (!menuPanel.Visible)
			{
				menu.BackColor = System.Drawing.SystemColors.Window;
				menuPanel.Visible = true;
				menuTitle.Visible = true;
				menuScroll.Visible = true;
				menuSimple.Visible = true;
				menuProgrammer.Visible = true;
				menuDates.Visible = true;
			}
			else
			{
				menu.BackColor = System.Drawing.SystemColors.Control;
				menuPanel.Visible = false;
				menuTitle.Visible = false;
				menuScroll.Visible = false;
				menuSimple.Visible = false;
				menuProgrammer.Visible = false;
				menuDates.Visible = false;
			}
		}
		private void menuSimple_Click(object sender, EventArgs e)
		{
			FormSimple s = new FormSimple();

			s.Show();
			this.Hide();
		}
		private void menuProgrammer_Click(object sender, EventArgs e)
		{
			menu.BackColor = System.Drawing.SystemColors.Control;
			menuPanel.Visible = false;
			menuTitle.Visible = false;
			menuScroll.Visible = false;
			menuSimple.Visible = false;
			menuProgrammer.Visible = false;
			menuDates.Visible = false;
		}
		private void menuDates_Click(object sender, EventArgs e)
		{
			FormDates d = new FormDates();

			d.Show();
			this.Hide();
		}
	}
}
