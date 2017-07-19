using System;
using System.Collections.Generic;

namespace ValueTuple_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>();

            transactions.Add(("Ball1", 45.55, 10));
            transactions.Add(("Ball2", 40.55, 11));
            transactions.Add(("Ball3", 41.55, 12));
            transactions.Add(("Ball4", 43.55, 13));
            transactions.Add(("Ball5", 42.55, 14));

            Console.WriteLine("Items Sold Today:");
            var i = 0;
            double totalRevenue = 0;

            foreach ((string product, double amount, int quantity) t in transactions)
            {
                // Logic goes here to look up quantity and amount in each transaction

                var tempItemRevenue = t.amount * t.quantity;
                totalRevenue += tempItemRevenue;
                Console.WriteLine("-----" + i + "-----");
                Console.WriteLine(" - Title: " + t.product);
                Console.WriteLine("Revenue: " + tempItemRevenue);
                i++;

            }

            Console.WriteLine("----------");
            Console.WriteLine("----------");
            Console.WriteLine("Total Revenue Today: $" + totalRevenue);
            Console.ReadLine();
        }
    }
}