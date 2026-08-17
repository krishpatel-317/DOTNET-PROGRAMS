using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQLab
{
    class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
    }

    class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public double OrderAmount { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer { CustomerId = 1, Name = "Amit Shah", City = "Ahmedabad" },
                new Customer { CustomerId = 2, Name = "Priya Patel", City = "Surat" },
                new Customer { CustomerId = 3, Name = "Rahul Mehta", City = "Ahmedabad" },
                new Customer { CustomerId = 4, Name = "Neha Joshi", City = "Vadodara" }
            };

            List<Order> orders = new List<Order>()
            {
                new Order { OrderId = 101, CustomerId = 1, ProductName = "Laptop", Category = "Electronics", OrderAmount = 65000 },
                new Order { OrderId = 102, CustomerId = 1, ProductName = "Mouse", Category = "Electronics", OrderAmount = 1000 },
                new Order { OrderId = 103, CustomerId = 2, ProductName = "Mobile", Category = "Electronics", OrderAmount = 25000 },
                new Order { OrderId = 104, CustomerId = 3, ProductName = "Chair", Category = "Furniture", OrderAmount = 5000 },
                new Order { OrderId = 105, CustomerId = 3, ProductName = "Table", Category = "Furniture", OrderAmount = 12000 },
                new Order { OrderId = 106, CustomerId = 4, ProductName = "TV", Category = "Electronics", OrderAmount = 45000 }
            };

            var query1 = customers.Join(
                orders,
                c => c.CustomerId,
                o => o.CustomerId,
                (c, o) => new
                {
                    c.Name,
                    o.ProductName
                });

            Console.WriteLine("Query 1");
            foreach (var item in query1)
                Console.WriteLine($"{item.Name} - {item.ProductName}");

            var query2 = orders.FirstOrDefault(o => o.OrderAmount > 20000);

            Console.WriteLine("\nQuery 2");
            if (query2 != null)
                Console.WriteLine($"{query2.OrderId} {query2.ProductName} {query2.OrderAmount}");

            var query3 = customers
                .Where(c => c.City == "Ahmedabad")
                .Join(
                    orders,
                    c => c.CustomerId,
                    o => o.CustomerId,
                    (c, o) => new
                    {
                        c.Name,
                        o.OrderAmount
                    })
                .GroupBy(x => x.Name)
                .Select(g => new
                {
                    Name = g.Key,
                    TotalSpent = g.Sum(x => x.OrderAmount)
                });

            Console.WriteLine("\nQuery 3");
            foreach (var item in query3)
                Console.WriteLine($"{item.Name} - {item.TotalSpent}");

            var query4 = customers
                .Join(
                    orders,
                    c => c.CustomerId,
                    o => o.CustomerId,
                    (c, o) => new
                    {
                        c.Name,
                        o.ProductName,
                        o.OrderAmount
                    })
                .OrderByDescending(x => x.OrderAmount)
                .First();

            Console.WriteLine("\nQuery 4");
            Console.WriteLine($"{query4.Name} - {query4.ProductName} - {query4.OrderAmount}");

            Console.ReadKey();
        }
    }
}