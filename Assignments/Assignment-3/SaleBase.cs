using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class SaleBase
    {
        protected int SalesNo;
        protected int ProductNo;
        protected double Price;
        protected int Qty;
        protected DateTime DateOfSale;
        protected double TotalAmount;

        public SaleBase(int salesNo, int productNo, double price, int qty, DateTime dateOfSale)
        {
            SalesNo = salesNo;
            ProductNo = productNo;
            Price = price;
            Qty = qty;
            DateOfSale = dateOfSale;
        }
    }
}
