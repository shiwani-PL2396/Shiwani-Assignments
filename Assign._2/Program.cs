using System;
using Assign._2;

class OrderProgram
{
    static void Main()
    {
        Order order = new Order
        {
            OrderId = 101,
            Date = DateTime.Now,
            CustomerID = 1,
            ProductID = 501,
            ProductName = "Wireless Mouse",
            Quantity = 3,
            Rate = 450.00
        };
        order.DisplayOrder();

        Console.ReadLine();
    }
}

