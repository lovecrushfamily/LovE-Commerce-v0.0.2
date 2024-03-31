using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL;

namespace DAO
{
    public class Notification
    {
        public static void Add(Notification_ notification_)
        {
            MyConnection.ExecuteNonQuery($"sp_insertNotification {notification_.ReceivedID}," +
                                                                $"'{notification_.Tittle}'," +
                                                                $"'{notification_.Content}'");

        }
        public static void Update(Notification_ notification_)
        {

        }
        public static void Delete(Notification_ notification_)
        {

        }
    }
}
