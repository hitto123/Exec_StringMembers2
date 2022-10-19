using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string name = "Allen";
			Console.WriteLine("請輸入你的名字");
			string input=Console.ReadLine();

			if (string.IsNullOrEmpty(input))
			{
				Console.WriteLine("你未輸入");
				return;
			}
			if (name== input)
			{
				Console.WriteLine("正確");
			}
			else
				Console.WriteLine("錯誤");
		}
	}
}
