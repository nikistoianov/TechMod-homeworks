using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreyAndBilliard
{
    class Program
    {
        static void Main()
        {
            int nums = int.Parse(Console.ReadLine());
            var products = new Dictionary<string, double>();
            for (int i = 0; i < nums; i++)
            {
                string[] arr = Console.ReadLine().Split('-');
                products[arr[0]] = double.Parse(arr[1]);
            }

            var customers = new Dictionary<string, Customer>();
            double totalBill = 0;
            string input = Console.ReadLine();
            while (input != "end of clients")
            {
                string[] arr = input.Split('-');
                string customerName = arr[0];
                arr = arr[1].Split(',');
                string product = arr[0];
                int quantity = int.Parse(arr[1]);

                if (products.ContainsKey(product))
                {
                    if (!customers.ContainsKey(customerName))
                    {
                        customers[customerName] = new Customer();
                        customers[customerName].Products = new Dictionary<string, int>();
                    }

                    if (customers[customerName].Products.ContainsKey(product))
                    {
                        customers[customerName].Products[product] += quantity;
                    }
                    else
                    {
                        customers[customerName].Products[product] = quantity;
                    }

                    double currentBill = quantity * products[product];
                    customers[customerName].Bill += currentBill;
                    totalBill += currentBill;
                }

                input = Console.ReadLine();
            }

            foreach (var customer in customers.OrderBy(x => x.Key))
            {
                Console.WriteLine(customer.Key);
                foreach (var product in customer.Value.Products)
                {
                    Console.WriteLine($"-- {product.Key} - {product.Value}");
                }
                Console.WriteLine($"Bill: {customer.Value.Bill:F2}");
            }
            Console.WriteLine($"Total bill: {totalBill:F2}");
        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> Products { get; set; }
        public double Bill { get; set; }
    }
}
