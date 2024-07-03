using NotificationPlugin.Base;
using System.Text;

namespace NotificationPlugin
{
    public class SlackNotification : NotificationDecorator
    {
        private readonly string _webhookUrl;
        public SlackNotification(INotification wrappedNotification, string webhookUrl) : base(wrappedNotification)
        {
            _webhookUrl = webhookUrl;
        }
        public override void Send(string message)
        {
            SendSlackNotification(message);
            base.Send(message);
        }
        private void SendSlackNotification(string message)
        {
            // Logic to send SMS
            Console.WriteLine($"Sending slack notification: {message}");
        }

    }
}
