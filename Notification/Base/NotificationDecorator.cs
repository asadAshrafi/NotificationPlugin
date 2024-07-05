using NotificationPlugin.Models;

namespace NotificationPlugin.Base
{
    public abstract class NotificationDecorator : INotificationDecorator
    {
        protected readonly INotification _wrappedNotification;

        /// <summary>
        /// This constructor should be called when there is a notification to wrap
        /// </summary>
        public NotificationDecorator(INotification wrappedNotification)
        {
            _wrappedNotification = wrappedNotification;
        }

        /// <summary>
        /// This constructor should be called when there is no notification to wrap
        /// </summary>
        protected NotificationDecorator()
        {

        }
        /// <summary>
        /// Returns NotificationModel that contains message and its generated Id
        /// </summary>
        /// <returns></returns>
        public abstract NotificationModel GetNotificationObject();
        public virtual void Send(string message)
        {
            _wrappedNotification.Send(message);

        }

        public INotification WrappedNotification => _wrappedNotification;
    }
}
