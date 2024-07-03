using NotificationPlugin.Base;

namespace NotificationPlugin
{
    public class EmailNotification : INotification // Assuming that EmailNotification is already implemented in the plugin
    {
        private readonly string _smtpServer;
        private readonly int _port;
        private readonly string _fromEmail;
        private readonly string _toEmail;
        private readonly string _username;
        private readonly string _password;
        private readonly string _message;
        public EmailNotification(
            string smtpServer,
            int port,
            string fromEmail,
            string toEmail,
            string username,
            string password)
        {

        }
        public void Send(string message)
        {
            //Logic to send Email
            Console.WriteLine("sending email: ",message);
        }
    }
}
