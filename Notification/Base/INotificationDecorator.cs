namespace NotificationPlugin.Base
{
    public interface INotificationDecorator : INotification
    {
        INotification WrappedNotification { get; }
    }
}
