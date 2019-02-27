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
	public partial class FormSimple : Form
	{
		Calculator calc;
		char operation;
		bool sign;// true - "+", false - "-"

		public FormSimple()
		{
			InitializeComponent();
			calc = new Calculator();
			sign = true;
			result.Text = "0";
			historyData.Text = "Журнaла еще нет\r\n";
			memoryList.Enabled = false;
		}

		public void Calculate()
		{
			if (operation == '+')
				result.Text = calc.Sum(Convert.ToDouble(result.Text)).ToString();
			else if (operation == '-')
				result.Text = calc.Substract(Convert.ToDouble(result.Text)).ToString();
			else if (operation == '×')
				result.Text = calc.Multiplication(Convert.ToDouble(result.Text)).ToString();
			else if (operation == '÷')
			{
				if(calc.Division(Convert.ToDouble(result.Text)).ToString() == "∞")
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
					purcent.Enabled = false;
					root.Enabled = false;
					power.Enabled = false;
					oneToX.Enabled = false;
					equals.Enabled = false;

					memoryPlus.Enabled = false;
					memoryMinus.Enabled = false;
					memorySave.Enabled = false;
				}
				else
					result.Text = calc.Division(Convert.ToDouble(result.Text)).ToString();
			}
		}
		
		private void number_Click(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			int num = Convert.ToInt32(btn.Text);

			if (result.Text == "0" || calc.CanErease)
			{
				result.Font = new System.Drawing.Font("Segoe UI Semibold", 34F, System.Drawing.FontStyle.Bold);
				result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				result.Text = num.ToString();

				plusMin.Enabled = true;
				dot.Enabled = true;
				plus.Enabled = true;
				minus.Enabled = true;
				div.Enabled = true;
				mult.Enabled = true;
				purcent.Enabled = true;
				root.Enabled = true;
				power.Enabled = true;
				oneToX.Enabled = true;
				equals.Enabled = true;

				memoryPlus.Enabled = true;
				memoryMinus.Enabled = true;
				memorySave.Enabled = true;

				calc.CanErease = false;
			}
			else
				result.Text += num.ToString();
		}
		private void dot_Click(object sender, EventArgs e)
		{
			if(result.Text.IndexOf(',') == -1)
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
			calc.SetA(Convert.ToDouble(result.Text));
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
			if(lastString.Text != "")
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
		}

		private void purcent_Click(object sender, EventArgs e)
		{
			double p = Convert.ToDouble(result.Text);

			if(calc.Percent(p, operation) != 0.0)
			{
				lastString.Text += p;
				result.Text = calc.Percent(p, operation).ToString();
				calc.AddToHistory(lastString.Text, "%", result.Text);
				calc.CanErease = true;
			}	
		}
		private void root_Click(object sender, EventArgs e)
		{
			lastString.Text = $"√({result.Text})";
			result.Text = calc.Root(Convert.ToInt32(result.Text)).ToString();
			calc.AddToHistory(lastString.Text, "", result.Text);
			calc.CanErease = true;
		}
		private void power_Click(object sender, EventArgs e)
		{
			lastString.Text = $"({result.Text})²";
			result.Text = calc.Square(Convert.ToInt32(result.Text)).ToString();
			calc.AddToHistory(lastString.Text, "", result.Text);
			calc.CanErease = true;
		}
		private void oneToX_Click(object sender, EventArgs e)
		{
			lastString.Text = $"1/({result.Text})";
			result.Text = calc.OneToX(Convert.ToInt32(result.Text)).ToString();
			calc.AddToHistory(lastString.Text, "", result.Text);
			calc.CanErease = true;
		}

		private void clear_Click(object sender, EventArgs e)
		{
			result.Text = "0";
			lastString.Text = "";
		}
		private void clearE_Click(object sender, EventArgs e)
		{
			result.Text = "0";
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
		}
		
		private void memorySave_Click(object sender, EventArgs e)
		{
			calc.MemorySave(Convert.ToDouble(result.Text));
			memoryClear.Enabled = true;
			memoryRead.Enabled = true;
			memoryList.Enabled = true;
		}
		private void memoryClear_Click(object sender, EventArgs e)
		{
			calc.MemoryClear();
			memoryClear.Enabled = false;
			memoryRead.Enabled = false;
			memoryList.Enabled = false;
		}
		private void memoryRead_Click(object sender, EventArgs e)
		{
			result.Text = calc.MemoryRead().ToString();
		}
		private void memoryPlus_Click(object sender, EventArgs e)
		{
			calc.MemorySum(Convert.ToDouble(result.Text));
			memoryClear.Enabled = true;
			memoryRead.Enabled = true;
			memoryList.Enabled = true;
		}
		private void memoryMinus_Click(object sender, EventArgs e)
		{
			calc.MemorySubstract(Convert.ToDouble(result.Text));
			memoryClear.Enabled = true;
			memoryRead.Enabled = true;
			memoryList.Enabled = true;
		}
		private void memoryList_Click(object sender, EventArgs e)
		{
			if (!memoryPanel.Visible)
			{
				memoryPanel.Visible = true;
				trash.Visible = true;

				memoryClear.Enabled = false;
				memoryRead.Enabled = false;
				memoryMinus.Enabled = false;
				memoryPlus.Enabled = false;
				memorySave.Enabled = false;
			}
			else
			{
				memoryPanel.Visible = false;
				trash.Visible = false;

				if(memoryData.Text == "В памяти ничего не сохранено")
				{
					memoryData.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold);
					memoryData.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
					memoryMinus.Enabled = true;
					memoryPlus.Enabled = true;
					memorySave.Enabled = true;
					memoryList.Enabled = false;
				}
				else
				{
					memoryClear.Enabled = true;
					memoryRead.Enabled = true;
					memoryMinus.Enabled = true;
					memoryPlus.Enabled = true;
					memorySave.Enabled = true;
				}
			}
			memoryData.Text = calc.MemoryRead().ToString();
		}
		private void trash_Click(object sender, EventArgs e)
		{
			calc.MemoryClear();
			memoryData.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold);
			memoryData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			memoryData.Text = "В памяти ничего не сохранено";
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
			menu.BackColor = System.Drawing.SystemColors.Control;
			menuPanel.Visible = false;
			menuTitle.Visible = false;
			menuScroll.Visible = false;
			menuSimple.Visible = false;
			menuProgrammer.Visible = false;
			menuDates.Visible = false;
		}
		private void menuProgrammer_Click(object sender, EventArgs e)
		{
			FormProgrammer p = new FormProgrammer();

			p.Show();
			this.Hide();
		}
		private void menuDates_Click(object sender, EventArgs e)
		{
			FormDates d = new FormDates();
			
			d.Show();
			this.Hide();
		}
	}
}
