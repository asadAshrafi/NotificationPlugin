using NotificationPlugin.Base;
using NotificationPlugin.Models;

namespace NotificationPlugin
{
    public class EmailNotification : NotificationDecorator 
    {
        private readonly string _smtpServer;
        private readonly int _port;
        private readonly string _fromEmail;
        private readonly string _toEmail;
        private readonly string _username;
        private readonly string _password;
        NotificationModel _notificationModel = new ();

        /// <summary>
        /// This constructor should be called when there is a notification to wrap
        /// </summary>
        public EmailNotification(
            INotification wrappedNotification,
            string smtpServer,
            int port,
            string fromEmail,
            string toEmail,
            string username,
            string password) :base(wrappedNotification)
        {
            _smtpServer = smtpServer;
            _port = port;
            _fromEmail = fromEmail;
                _toEmail = toEmail;
            _username = username;
            _password = password;
        }

        /// <summary>
        /// This constructor should be called when there is no notification to wrap
        /// </summary>
        public EmailNotification( 
            string smtpServer,
            int port,
            string fromEmail,
            string toEmail,
            string username,
            string password
            )
        {
            _smtpServer = smtpServer;
            _port = port;
            _fromEmail = fromEmail;
            _toEmail = toEmail;
            _username = username;
            _password = password;
        }

        public override void Send(string message)
        {
            SendEmail(message);
            //Checks whether there is a wrapped notification
            if (_wrappedNotification != null)
            {
                // Calls the wrapped notification
                base.Send(message);
            }
        }

        private void SendEmail(string message)
        {
            //Logic to send Email
            SetNotificationId(message);
            Console.WriteLine($"sending email: {message}");
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
