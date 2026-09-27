using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralDesignPatterns.Facade
{
    public class OrderFacade
    {
        private readonly InventoryService _inventoryService;
        private readonly PaymentService _paymentService;
        private readonly InvoiceService _invoiceService;
        private readonly EmailService _emailService;

        public OrderFacade(
            InventoryService inventoryService,
            PaymentService paymentService,
            InvoiceService invoiceService,
            EmailService emailService)
        {
            _inventoryService = inventoryService;
            _paymentService = paymentService;
            _invoiceService = invoiceService;
            _emailService = emailService;
        }

        public void PlaceOrder(int productId, decimal amount)
        {
            Console.WriteLine("Starting order process...");
            Console.WriteLine();

            bool stockAvailable = _inventoryService.CheckStock(productId);

            if (!stockAvailable)
            {
                Console.WriteLine("Product is out of stock.");
                return;
            }

            bool paymentSuccessful = _paymentService.ProcessPayment(amount);

            if (!paymentSuccessful)
            {
                Console.WriteLine("Payment failed.");
                return;
            }

            _invoiceService.GenerateInvoice();

            _emailService.SendConfirmationEmail();

            Console.WriteLine();
            Console.WriteLine("Order completed successfully.");
        }
    }
}
