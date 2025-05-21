using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign._2
{
    public class Order
    {
        public int OrderId { get; set; }
        //  validation of order id

        public DateTime Date { get; set; }


        public int CustomerID { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double Rate { get; set; }

        public double Total => Quantity * Rate;

        public void DisplayOrder()
        {
            Console.WriteLine("---- Order Details ----");
            Console.WriteLine($"Order ID: {OrderId}");
            Console.WriteLine($"Date: {Date.ToShortDateString()}");
            Console.WriteLine($"Customer ID: {CustomerID}");
            Console.WriteLine($"Product ID: {ProductID}");
            Console.WriteLine($"Product Name: {ProductName}");
            Console.WriteLine($"Quantity: {Quantity}");
            Console.WriteLine($"Rate: {Rate}");
            Console.WriteLine($"Total: {Total}");
        }
    }
}
