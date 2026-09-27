using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralDesignPatterns.Bridge
{
    public class EmailSender : IMessageSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Email sent: {message}");
        }
    }
}
