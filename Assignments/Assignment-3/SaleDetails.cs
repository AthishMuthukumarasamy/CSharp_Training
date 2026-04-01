using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment_3
{
    internal class SaleDetails : SaleBase
    {
        public SaleDetails(int salesNo, int productNo, double price, int qty, DateTime dateOfSale)
            : base(salesNo, productNo, price, qty, dateOfSale)
        {
        }

        public void Sales()
        {
            TotalAmount = Qty * Price;
        }

        public void ShowData()
        {
            Console.WriteLine("\n--- Sale Details ---");
            Console.WriteLine("Sales No     : " + SalesNo);
            Console.WriteLine("Product No   : " + ProductNo);
            Console.WriteLine("Price        : " + Price);
            Console.WriteLine("Quantity     : " + Qty);
            Console.WriteLine("Date of Sale : " + DateOfSale.ToShortDateString());
            Console.WriteLine("Total Amount : " + TotalAmount);
        }
    }
}