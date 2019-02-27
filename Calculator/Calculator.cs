using System;
using System.Collections.Generic;

namespace Calculator
{
	public class Calculator
	{
		private double memory, a;
		public bool CanErease;
		private string history; 

		public Calculator()
		{
			memory = 0.0;
			a = 0.0;
			CanErease = false;
			history = "";
		}

		public void SetA(double a)
		{
			this.a = a;
		}
		public void ClearA()
		{
			a = 0;
		}

		public double Sum(double b)
		{
			return a + b;
		}
		public double Substract(double b)
		{
			return a - b;
		}
		public double Multiplication(double b)
		{
			return a * b;
		}
		public double Division(double b)
		{
			return a / b;
		}

		public double Percent(double b, char op)
		{
			if(a != 0.0)
			{
				if (op == '+')
					return a + ((a * b) / 100.0);
				else if (op == '-')
					return a - ((a * b) / 100.0);
				else if (op == '×')
					return a * ((a * b) / 100.0);
				else if (op == '÷')
					return a / ((a * b) / 100.0);
			}
			return 0.0;
		}
		public double Root(double b)
		{
			return Math.Sqrt(b);
		}
		public double Square(double b)
		{
			return Math.Pow(b, 2.0);
		}
		public double OneToX(double b)
		{
			return 1.0 / b;
		}

		public void MemorySave(double b)
		{
			memory = b;
		}
		public double MemoryRead()
		{
			return memory;
		}
		public void MemoryClear()
		{
			memory = 0;
		}
		public void MemorySum(double b)
		{
			memory += b;
		}
		public void MemorySubstract(double b)
		{
			memory -= b;
		}

		public void AddToHistory(string op1, string op2, string res)
		{
			history += $"{op1}{op2} = {res}\r\n";
		}
		public string GetHistory()
		{
			return history;
		}
		public void DeleteHistory()
		{
			history = "";
		}


		public string Bin_Oct(string Bin)
		{
			return Convert.ToString(Convert.ToInt64(Bin, 2), 8);
		}
		public string Bin_Dec(string Bin)
		{
			return Convert.ToString(Convert.ToInt64(Bin, 2));
		}
		public string Bin_Hex(string Bin)
		{
			return Convert.ToString(Convert.ToInt64(Bin, 2));
		}

		public string Oct_Bin(string Oct)
		{
			long temp = Convert.ToInt64(Oct, 8);
			return Convert.ToString(temp, 2);
		}
		public string Oct_Dec(string Oct)
		{
			return Convert.ToString(Convert.ToInt64(Oct, 8));
		}
		public string Oct_Hex(string Oct)
		{
			long temp = Convert.ToInt64(Oct, 8);
			return Convert.ToString(temp, 16);
		}

		public string Dec_Bin(string Dec)
		{
			return Convert.ToString(Convert.ToInt32(Dec), 2);
		}
		public string Dec_Oct(string Dec)
		{
			return Convert.ToString(Convert.ToInt32(Dec), 8);
		}
		public string Dec_Hex(string Dec)
		{
			return Convert.ToString(Convert.ToInt32(Dec), 16);
		}

		public string Hex_Bin(string Hex)
		{
			return "my programmer is too lasy";
		}
		public string Hex_Oct(string Hex)
		{
			return "my programmer is too lasy";
		}
		public string Hex_Dec(string Hex)
		{
			return "my programmer is too lasy";
		}
	}
}
