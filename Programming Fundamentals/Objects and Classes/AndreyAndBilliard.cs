using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreyAndBilliard
{
    class AndreyAndBilliard
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> productsPrice = new Dictionary<string, decimal>();
            int productsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < productsCount; i++)
            {
                string[] input = Console.ReadLine().Split('-');
                string productName = input[0];
                decimal productPrice = decimal.Parse(input[1]);

                if (!productsPrice.ContainsKey(productName))
                {
                    productsPrice.Add(productName, productPrice);
                }

                productsPrice[productName] = productPrice;
            }

            string inputLine = Console.ReadLine();
            List<Customer> customers = new List<Customer>();
            while (!inputLine.Equals("end of clients"))
            {
                string[] customerInfo = inputLine.Split(',', '-');
                string customerName = customerInfo[0];
                string customerProdut = customerInfo[1];
                int quantity = int.Parse(customerInfo[2]);

                if (!productsPrice.ContainsKey(customerProdut))
                {
                    inputLine = Console.ReadLine();
                    continue;
                }

                if (customers.Any(c => c.Name == customerName))
                {
                    Customer customer = customers.First(c => c.Name == customerName);
                    if (!customer.OrdersQuantity.ContainsKey(customerProdut))
                    {
                        customer.OrdersQuantity.Add(customerProdut, quantity);
                    }
                    else
                    {
                        customer.OrdersQuantity[customerProdut] += quantity;
                    }


                    customer.Bill += quantity*productsPrice[customerProdut];
                }
                else
                {
                    Customer customer = new Customer();
                    customer.Name = customerName;
                    // customer.OrdersQuantity = new Dictionary<string, int>();
                    customer.OrdersQuantity.Add(customerProdut, quantity);
                    customer.Bill += quantity * productsPrice[customerProdut];
                    customers.Add(customer);
                }

                
                inputLine = Console.ReadLine();
            }


            foreach (Customer customer in customers.OrderBy(c => c.Name))
            {
                Console.WriteLine(customer.Name);
                foreach (KeyValuePair<string, int> customerOrders in customer.OrdersQuantity)
                {
                    Console.WriteLine("-- {0} - {1}", customerOrders.Key, customerOrders.Value);
                }

                Console.WriteLine("Bill: {0:F2}", customer.Bill);
            }

            decimal totalBill = customers.Sum(c => c.Bill);
            Console.WriteLine("Total bill: {0:F2}", totalBill);
        }

        public class Customer
        {
            public Customer()
            {
                this.OrdersQuantity = new Dictionary<string, int>();
            }

            public string Name { get; set; }

            public Dictionary<string, int> OrdersQuantity { get; set; }

            public decimal Bill { get; set; }
        }
    }
}
