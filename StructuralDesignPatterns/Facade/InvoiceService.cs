using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralDesignPatterns.Facade
{
    public class InvoiceService
    {
        public void GenerateInvoice()
        {
            Console.WriteLine("Invoice generated.");
        }
    }
}
