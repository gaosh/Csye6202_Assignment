namespace FizzBuzz
{
	public class FizzBuzz
	{
		public string RunFizzBuzz(int number)
		{
			string result = number.ToString();

            if (number == 0)
            {
               
            }
            else if (number % 15 == 0)
            {
                result = "FizzBuzz";

            }
            else if(number % 3 == 0)
            {
                result = "Fizz";
            }
            else if(number % 5 == 0)
            {
                result = "Buzz";
            }
                



			// your solution/implementation should go in here

			return result;
		}
	}
}
