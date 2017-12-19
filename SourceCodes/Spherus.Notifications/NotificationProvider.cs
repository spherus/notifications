using Spherus.Notifications.Interfaces;

namespace Spherus.Notifications
{
    public class NotificationProvider
    {
        public INotificationModel NotificationModel { get; set; }

        public INotificationService NotificationService { get; set; }

    }
}