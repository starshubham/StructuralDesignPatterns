using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralDesignPatterns.Bridge
{
    public class SmsSender : IMessageSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"SMS sent: {message}");
        }
    }
}
