using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string days = "1100225";
			int Years=days.Length;
			
			string year=days.Substring(0,3);
			int year2=Convert.ToInt32(year);

			double vids = year2 + 1911;

			string Month=days.Substring(3,4);

			Console.WriteLine(vids+Month);
		}
	}
}
