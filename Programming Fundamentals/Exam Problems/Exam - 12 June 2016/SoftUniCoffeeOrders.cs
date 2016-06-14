using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace SoftUniCoffeeOrders
{
    public class SoftUniCoffeeOrders
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            decimal totalPrice = 0M;
            
            for (int j = 0; j < n; j++)
            {
                decimal price = decimal.Parse(Console.ReadLine());
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                int capsulesCount = int.Parse(Console.ReadLine());

                int daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);
                long coffeeCount = (long)daysInMonth*capsulesCount;

                decimal coffeePrice = coffeeCount*price;

                Console.WriteLine("The price for the coffee is: ${0:F2}", coffeePrice);

                totalPrice += coffeePrice;
            }
			
            Console.WriteLine("Total: ${0:F2}", totalPrice);
        }
    }
}
