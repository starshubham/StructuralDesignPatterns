using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralDesignPatterns.Bridge
{
    public abstract class Notification
    {
        protected readonly IMessageSender _sender;

        protected Notification(IMessageSender sender)
        {
            _sender = sender;
        }

        public abstract void Send();
    }
}
