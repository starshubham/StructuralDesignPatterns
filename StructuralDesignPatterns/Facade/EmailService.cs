using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralDesignPatterns.Facade
{
    public class EmailService
    {
        public void SendConfirmationEmail()
        {
            Console.WriteLine("Order confirmation email sent.");
        }
    }
}
