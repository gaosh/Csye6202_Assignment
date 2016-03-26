using System;
namespace FizzBuzz
{
	class Program
	{
		static void Main(string[] args)
		{
            FizzBuzz FB = new FizzBuzz();
            int number;
            string s = System.Console.ReadLine();
            Int32.TryParse(s,out number);
            Console.WriteLine(FB.RunFizzBuzz(number));
            Console.Read();
		}
	}
}
