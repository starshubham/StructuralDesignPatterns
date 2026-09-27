using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralDesignPatterns.Bridge
{
    public interface IMessageSender
    {
        void Send(string message);
    }
}
