using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotificationPlugin.Base;

namespace NotificationPlugin
{
    public class SmsNotificationDecorator : NotificationDecorator
    {
        private readonly string _phoneNumber;
        public SmsNotificationDecorator(INotification wrappedNotification, string phoneNumber) : base(wrappedNotification)
        {
            _phoneNumber = phoneNumber;
        }
        public override void Send(string message)
        {
            // Send SMS message
            SendSms(message);

            // Calls the wrapped notification
            base.Send(message);
        }
        private void SendSms(string message)
        {
            // Logic to send SMS
            Console.WriteLine($"Sending SMS to {_phoneNumber}: {message}");
        }
    }
}
