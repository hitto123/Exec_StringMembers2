using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double sum = 102.143 + 25.155;
			double sum2 = (Math.Floor(sum * 100) ) / 100;
			string sum3=sum2.ToString("0.00");
			Console.WriteLine(sum3);
		}
	}
}
