using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge_2
{
    class Product : IComparable<Product>
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }

        public int CompareTo(Product other)
        {
            if (this.Price > other.Price)
                return 1;
            else if (this.Price < other.Price)
                return -1;
            else
                return 0;
        }
    }

    class ProductProgram
    {
        public void Execute()
        {
            List<Product> products = new List<Product>();

            Console.WriteLine("Enter details of 10 products:\n");

            for (int i = 0; i < 10; i++)
            {
                Product p = new Product();

                Console.Write("Enter Product ID: ");
                p.ProductId = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Product Name: ");
                p.ProductName = Console.ReadLine();

                Console.Write("Enter Price: ");
                p.Price = Convert.ToDouble(Console.ReadLine());

                products.Add(p);
                Console.WriteLine();
            }

            products.Sort();

            Console.WriteLine("Products sorted by price:\n");

            foreach (Product p in products)
            {
                Console.WriteLine(
                    "ID: " + p.ProductId +
                    ", Name: " + p.ProductName +
                    ", Price: " + p.Price
                );
            }
        }
    }
}