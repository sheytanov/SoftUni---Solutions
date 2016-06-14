using System;

namespace SoftUniAirline
{
    public class SoftUniAirline
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            decimal totalProfit = 0m;

            for (int i = 0; i < n; i++)
            {
                int adultCount = int.Parse(Console.ReadLine());
                decimal adultPrice = decimal.Parse(Console.ReadLine());
                int youthCount = int.Parse(Console.ReadLine());
                decimal youthPrice = decimal.Parse(Console.ReadLine());
                decimal fuelPrice = decimal.Parse(Console.ReadLine());
                decimal fuelConsumption = decimal.Parse(Console.ReadLine());
                int flightDuration = int.Parse(Console.ReadLine());

                decimal income = adultCount * adultPrice + youthCount * youthPrice;
                decimal expense = fuelPrice * fuelConsumption * flightDuration;
                decimal profit = income - expense;

                Console.WriteLine(profit >= 0 ? 
                    string.Format("You are ahead with {0:F3}$.", profit) : 
                    string.Format("We've got to sell more tickets! We've lost {0:F3}$.", profit));

                totalProfit += profit;
            }
            Console.WriteLine("Overall profit -> {0:F3}$.", totalProfit);
            Console.WriteLine("Average profit -> {0:F3}$.", totalProfit / n);
        }
    }
}
