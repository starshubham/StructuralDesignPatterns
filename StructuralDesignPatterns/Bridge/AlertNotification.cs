using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralDesignPatterns.Bridge
{
    public class AlertNotification : Notification
    {
        public AlertNotification(IMessageSender sender) : base(sender)
        {
        }

        public override void Send()
        {
            _sender.Send("Critical Alert!");
        }
    }
}
