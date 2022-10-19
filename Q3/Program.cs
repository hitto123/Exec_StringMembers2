using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string name = "aLLeN kUO";
			string temp=name.ToLower();

			string firstname=temp.Substring(0,1);
			string secondname=temp.Substring(6,1);

			Console.WriteLine(firstname.ToUpper()+temp.Substring(1,5)+secondname.ToUpper()+temp.Substring(7,2));
			
			
		
		}
	}
}
