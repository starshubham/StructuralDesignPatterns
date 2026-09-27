using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralDesignPatterns.Adapter
{
    public class PaymentAdapter: IPayment
    {
        private readonly OldPaymentGateway _oldGateway;
        public PaymentAdapter(OldPaymentGateway oldPaymentGateway)
        {
            _oldGateway = oldPaymentGateway;
        }
        public void Pay(decimal amount)
        {
            // Convert decimal to double for the old payment gateway
            double convertedAmount = (double)amount;
            _oldGateway.MakePayment(convertedAmount);
        }
    }
}
