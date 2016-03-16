using System;

namespace GasPump
{
	public class Program
	{
		public enum GasType
		{
			None,
			RegularGas,
			MidgradeGas,
			PremiumGas,
			DieselFuel				
		}

		static void Main(string[] args)
		{
            bool sentinal = false;
            while (!sentinal)
            {
                String type;
                GasType gasType;
                String amount;
                int gasAmount = 0;
                double totalCost = 0.0;
                double gasPrice = 0.0;
                Console.WriteLine("Please enter purchased gas type, Q/q to quit:");
                type = Console.ReadLine();
                if (UserEnteredSentinelValue(type))
                {
                    sentinal = true;
                    continue;
                }
                else if (!UserEnteredValidGasType(type))
                {
                    Console.WriteLine("Wrong input");
                    continue;
                }
                else
                {
                    gasType = GasTypeMapper(type[0]);
                    gasPrice = GasPriceMapper(gasType);
                }
                Console.WriteLine("Please enter purchased gas amount, Q/q to quit:");
                amount = Console.ReadLine();
                if (UserEnteredSentinelValue(amount))
                {
                    sentinal = true;
                    continue;
                }
                else if (!UserEnteredValidAmount(amount))
                {
                    Console.WriteLine("Wrong input");
                    continue;
                }
                else
                {
                    gasAmount = int.Parse(amount);
                }
                CalculateTotalCost(gasType, gasAmount, ref totalCost);
                Console.WriteLine("You bought {0} gallons of {1} at ${2}", gasType, gasAmount, gasPrice);
                Console.WriteLine("Your total cost for this purchase is:${0}", totalCost);
            }
            Console.WriteLine("Application terminated");
            Console.Read();
           
        }

		// use this method to check and see if sentinel value is entered
		public static bool UserEnteredSentinelValue(string userInput)
		{
			var result = false;

            if(userInput == "Q"|| userInput == "q")
            {
                result = true;
            }
           // else if(userInput == null)
           // {

          //  }

			return result;
		}

		// use this method to parse and check the characters entered
		// this does not conform 
		public static bool UserEnteredValidGasType(string userInput)
		{
			var result = false;

            String[] InputCollection ={ "R", "r", "M", "m", "P", "p", "D", "d" };
            for (int i = 0; i < InputCollection.Length; i++)
            {
                if (userInput == InputCollection[i])
                    result = true;
            }

            return result;
		}

		// use this method to parse and check the double type entered
		// please use Double.TryParse() method 
		public static bool UserEnteredValidAmount(string userInput)
		{
			var result = false;
            double res;

            result = Double.TryParse(userInput, out res);

			return result;
		}

		// use this method to map a valid char entry to its enum representation
		// e.g. User enters 'R' or 'r' --> this should be mapped to GasType.RegularGas
		// this mapping "must" be used within CalculateTotalCost() method later on
		public static GasType GasTypeMapper(char c)
		{
			GasType gasType = GasType.None;

            if (c == 'R' || c == 'r')
            {
                gasType = GasType.RegularGas;
            }
			else if (c == 'M' || c == 'm')
            {
                gasType = GasType.MidgradeGas;
            }
            else if (c == 'P' || c == 'p')
            {
                gasType = GasType.PremiumGas;
            }
            else if (c == 'D' || c == 'd')
            {
                gasType = GasType.DieselFuel;
            }

			return gasType;
		}

		public static double GasPriceMapper(GasType gasType)
		{
			var result = 0.0;

			if(gasType == GasType.RegularGas)
            {
                result = 1.94;
            }
            else if(gasType == GasType.MidgradeGas)
            {
                result = 2;
            }
            else if(gasType == GasType.DieselFuel)
            {
                result = 2.17;
            }
            else if(gasType == GasType.PremiumGas)
            {
                result = 2.24;
            }

			return result;
	}

		public static void CalculateTotalCost(GasType gasType, int gasAmount, ref double totalCost)
		{
            var gasPrice = GasPriceMapper(gasType);
            totalCost = gasPrice * gasAmount;
		}
	}
}
