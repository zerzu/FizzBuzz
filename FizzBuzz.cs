using System;

namespace FizzBuzzExercise
{
	internal class Program
	{
		public static string FizzBuzz(int userNum)
		{
			if (userNum % 3 == 0 && userNum % 5 == 0)
			{
				return "FizzBuzz";
			}
			
			else if (userNum % 3 == 0 && userNum % 5 != 0)
			{
				return "Fizz";
			}
			
			else if (userNum % 3 != 0 && userNum % 5 == 0)
			{
				return "Buzz";
			}
			
			else
			{
				return "";
			}
		}
		static void Main(string[] args)
		{
			for (int i = 1; i < 50; i++)
			{
				Console.WriteLine(FizzBuzz(i));
			}				
		}
	}
}
