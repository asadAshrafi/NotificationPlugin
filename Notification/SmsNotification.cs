using NotificationPlugin.Base;
using NotificationPlugin.Models;

namespace NotificationPlugin
{
    public class SmsNotification : NotificationDecorator
    {
        private readonly string _phoneNumber;
        NotificationModel _notificationModel = new();
        /// <summary>
        /// This constructor should be called when a notification to wrap
        /// </summary>
        public SmsNotification(INotification wrappedNotification, string phoneNumber) : base(wrappedNotification)
        {
            _phoneNumber = phoneNumber;
        }
        /// <summary>
        /// This constructor should be called when there is no notification to wrap
        /// </summary>
        public SmsNotification(string phoneNumber)
        {
            _phoneNumber = phoneNumber;
        }

        public override void Send(string message)
        {
            SendSms(message);

            //Checks whether there is a wrapped notification
            if (_wrappedNotification != null)
            {
                // Calls the wrapped notification
                base.Send(message);
            }
        }

        private void SendSms(string message)
        {
            // Logic to send SMS
            SetNotificationId(message);
            Console.WriteLine($"Sending SMS to {_phoneNumber}: {message}");
        }

        private void SetNotificationId(string message)
        {
            _notificationModel.Id = Guid.NewGuid();
            _notificationModel.Message = message;
        }

        public override NotificationModel GetNotificationObject()
        {
            return _notificationModel;
        }
    }
}
