using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniCoffeeSuplies
{
    public class SoftUniCoffeeSuplies
    {
        public static void Main()
        {
            string[] delimiters = Console.ReadLine().Split();
            string firstDelimiter = delimiters[0];
            string secondDelimiter = delimiters[1];

            Dictionary<string, string> coffeeTypeByPeople = new Dictionary<string, string>();
            Dictionary<string, int> coffeeTypeByQuantity = new Dictionary<string, int>();

            ReadInformation(coffeeTypeByPeople, coffeeTypeByQuantity, firstDelimiter, secondDelimiter);
            MonitorCoffeeUsage(coffeeTypeByPeople, coffeeTypeByQuantity);
            PrintReports(coffeeTypeByPeople, coffeeTypeByQuantity);
        }

        private static void PrintReports(Dictionary<string, string> coffeeTypeByPeople, Dictionary<string, int> coffeeTypeByQuantity)
        {
            Console.WriteLine("Coffee Left:");

            var filteredCoffeeTypes =
                coffeeTypeByQuantity.Where(coffeeType => coffeeType.Value > 0)
                    .ToDictionary(coffeeType => coffeeType.Key, coffeeType => coffeeType.Value);

            foreach (var filteredCoffeeType in filteredCoffeeTypes.OrderByDescending(coffeeType => coffeeType.Value))
            {
                Console.WriteLine("{0} {1}", filteredCoffeeType.Key, filteredCoffeeType.Value);
            }

            Console.WriteLine("For:");

            var coffeeLeftForPeople =
                coffeeTypeByPeople.Where(person => filteredCoffeeTypes.ContainsKey(person.Value))
                    .OrderBy(person => person.Value)
                    .ThenByDescending(person => person.Key);

            foreach (var keyValuePair in coffeeLeftForPeople)
            {
                Console.WriteLine("{0} {1}", keyValuePair.Key, keyValuePair.Value);
            }
        }

        private static void MonitorCoffeeUsage(Dictionary<string, string> coffeeTypeByPeople, Dictionary<string, int> coffeeTypeByQuantity)
        {
            foreach (var coffeeType in coffeeTypeByQuantity)
            {
                if (coffeeType.Value <= 0)
                {
                    Console.WriteLine("Out of {0}", coffeeType.Key);
                }
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end of week")
                {
                    break;
                }

                string[] commandArgs = command.Split();
                string personName = commandArgs[0];
                int quantity = int.Parse(commandArgs[1]);

                string coffeeType = coffeeTypeByPeople[personName];
                coffeeTypeByQuantity[coffeeType] -= quantity;

                if (coffeeTypeByQuantity[coffeeType] <= 0)
                {
                    Console.WriteLine("Out of {0}", coffeeType);
                }
            }
        }

        private static void ReadInformation(Dictionary<string, string> coffeeTypeByPeople, Dictionary<string, int> coffeeTypeByQuantity, string firstDelimiter, string secondDelimiter)
        {
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end of info")
                {
                    break;
                }

                if (command.Contains(firstDelimiter))
                {
                    int indexOfDelimiter = command.IndexOf(firstDelimiter);
                    string personName = command.Substring(0, indexOfDelimiter);
                    string coffeeType = command.Substring(indexOfDelimiter + firstDelimiter.Length);
                    

                    if (coffeeTypeByPeople.ContainsKey(personName))
                    {
                        coffeeTypeByPeople[personName] = coffeeType;
                    }
                    else
                    {
                        coffeeTypeByPeople.Add(personName, coffeeType);
                    }

                    if (!coffeeTypeByQuantity.ContainsKey(coffeeType))
                    {
                        coffeeTypeByQuantity.Add(coffeeType, 0);
                    }
                }
                else
                {
                    int indexOfDelimiter = command.IndexOf(secondDelimiter);
                    string coffeeName = command.Substring(0, indexOfDelimiter);
                    int quantity = int.Parse(command.Substring(indexOfDelimiter + secondDelimiter.Length));

                    if (coffeeTypeByQuantity.ContainsKey(coffeeName))
                    {
                        coffeeTypeByQuantity[coffeeName] += quantity;
                    }
                    else
                    {
                        coffeeTypeByQuantity.Add(coffeeName, quantity);
                    }
                }
            }
        }
    }
}
