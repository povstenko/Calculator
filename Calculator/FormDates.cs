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
	public partial class FormDates : Form
	{
		public FormDates()
		{
			InitializeComponent();
		}
		private int DaysBetween(DateTime d1, DateTime d2)
		{
			TimeSpan span = d2.Subtract(d1);
			return (int)span.TotalDays + 1;
		}

		private void From_ValueChanged(object sender, EventArgs e)
		{
			if(DaysBetween(From.Value, To.Value) == 0)
				difference.Text = "Одинаковые даты";
			else
				difference.Text = Convert.ToString(DaysBetween(From.Value, To.Value)) + " Дней";
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
			FormProgrammer p = new FormProgrammer();

			p.Show();
			this.Hide();
		}
		private void menuDates_Click(object sender, EventArgs e)
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
}
