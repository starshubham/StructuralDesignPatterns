using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralDesignPatterns.Adapter
{
    public class OldPaymentGateway
    {
        public void MakePayment(double amount)
        {
            Console.WriteLine($"Old Payment Gateway processed payment of ₹{amount}");
        }
    }
}
