using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralDesignPatterns.Bridge
{
    public class ReminderNotification : Notification
    {
        public ReminderNotification(IMessageSender sender) : base(sender)
        {
        }

        public override void Send()
        {
            _sender.Send("Your appointment is tomorrow.");
        }
    }
}
