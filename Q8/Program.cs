using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string Phonenumber = "0935123046";

			string Marknumber=Phonenumber.Substring(0,4)+new string('*',4)+Phonenumber.Substring(8,2);
			Console.WriteLine(Marknumber);
		}
	}
}
