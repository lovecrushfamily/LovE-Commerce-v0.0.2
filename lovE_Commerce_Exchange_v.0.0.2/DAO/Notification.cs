using System;
using System.Collections.Generic;
using System.Data;
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
            MyConnection.ExecuteNonQuery($"sp_updateNotification {notification_.NotificationID}, {notification_.SeenState}");
        }
        public static void Delete(Notification_ notification_)
        {
            MyConnection.ExecuteNonQuery($"sp_deleteNotification {notification_.NotificationID}");
        }
        public static IEnumerable<Notification_> Select()
        {
            foreach(DataRow row in MyConnection.ExecuteDataTable("sp_selectNotification").Rows ) 
            {
                yield return new Notification_()
                {
                    NotificationID = row["NotificationID"].ToString(),
                    ReceivedID = row["ReceiverID"].ToString(),
                    Tittle = row["Tittle"].ToString(),
                    SeenState = row["SeenState"].ToString().ToBool(),
                    Time = row["Time_"].ToString(),
                    Content = row["Content"].ToString()
                };
            }
        }
    }
}
