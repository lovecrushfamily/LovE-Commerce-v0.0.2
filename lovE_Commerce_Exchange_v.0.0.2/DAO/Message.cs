using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL;

namespace DAO
{
    public class Message
    {
        public static void Add(Message_ message_)
        {
            MyConnection.ExecuteNonQuery($"sp_insertMessage {message_.SenderId}," +
                                                            $"{message_.ReceivedId}," +
                                                            $"'{message_.Content}'");
                                                     
        }
        public static void Update(Message_ message_)
        {
            MyConnection.ExecuteNonQuery($"sp_updateMessage {message_.MessageId}," +
                                                            $"{message_.SeenState}," +
                                                            $"{message_.IsRecall}");
        }
        public static void Delete(Message_ message_)
        {
            MyConnection.ExecuteNonQuery($"sp_deleteMessage {message_.MessageId}");

        }
        public static IEnumerable<Message_> Select()
        {
            foreach(DataRow row in MyConnection.ExecuteDataTable("sp_selectMessage").Rows) 
            {
                yield return new Message_()
                {
                    MessageId = row["MessageID"].ToString(),
                    SenderId = row["SenderID"].ToString(),
                    ReceivedId = row["ReceiverID"].ToString(),
                    Content = row["Content"].ToString(),
                    Date = row["Date_"].ToString(),
                    Time = row["Time_"].ToString(),
                    SeenState = row["NotificationType"].ToString().ToBool(),
                    IsRecall = row["IsRecall"].ToString().ToBool()
                };
            }
        }
    }
}
