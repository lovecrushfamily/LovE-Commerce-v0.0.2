using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Notification : DLL.Notification_, Entity
    {
        public Notification(DLL.Notification_ notification_)
        {
            NotificationID  = notification_.NotificationID;
            ReceivedID =    notification_.ReceivedID;
            NotificationType = notification_.NotificationType;
            Tittle = notification_.Tittle;
            Time = notification_.Time;
            Content = notification_.Content;
        }

        public void Add()
        {

        }

        public void Remove()
        {

        }

        public static Notification[] GetNotifications()
        {
            return DAO.Notification.Select().Select(c => new Notification(c)).ToArray();
        }

    }
}
