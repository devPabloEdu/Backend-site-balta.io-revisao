using System.Collections.Generic;

namespace Balta.NotificationContext
{
    public abstract class Notifiable 
    {
        public IList<Notification> Notifications { get; set; }

        public void Add(Notification notification)
        {
            Notifications.Add(notification);
        }
    }
}