﻿using NotificationPlugin.Base;
using NotificationPlugin.Models;

namespace NotificationPlugin
{
    public class SlackNotification : NotificationDecorator
    {
        private readonly string _webhookUrl;
        NotificationModel _notificationModel = new();
        /// <summary>
        /// This constructor should be called when there is a notification to wrap
        /// </summary>
        public SlackNotification(INotification wrappedNotification, string webhookUrl) : base(wrappedNotification)
        {
            _webhookUrl = webhookUrl;
        }

        /// <summary>
        /// This constructor should be called when there is no notification to wrap
        /// </summary>
        public SlackNotification(string webhookUrl)
        {
            _webhookUrl = webhookUrl;
        }

        public override void Send(string message)
        {
            SendSlackNotification(message);
            //Checks whether there is a wrapped notification
            if (_wrappedNotification != null)
            {
                // Calls the wrapped notification
                base.Send(message);
            }
        }

        private void SendSlackNotification(string message)
        {
            // Logic to send SMS
            SetNotificationId(message);
            Console.WriteLine($"Sending slack notification: {message}");
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
