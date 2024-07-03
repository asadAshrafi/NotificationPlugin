namespace NotificationPlugin.Base
{
    public abstract class NotificationDecorator : INotificationDecorator
    {
        protected readonly INotification _wrappedNotification;
        public NotificationDecorator(INotification wrappedNotification)
        {
            _wrappedNotification = wrappedNotification;
        }

        public virtual void Send(string message)
        {
            _wrappedNotification.Send(message);

        }
        public INotification WrappedNotification => _wrappedNotification;
    }
}
