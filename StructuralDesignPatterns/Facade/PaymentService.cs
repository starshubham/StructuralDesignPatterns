using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralDesignPatterns.Facade
{
    public class PaymentService
    {
        public bool ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing payment of ₹{amount}");

            return true;
        }
    }
}
