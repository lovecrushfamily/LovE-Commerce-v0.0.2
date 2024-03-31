using System;
using System.Collections.Generic;
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

        }
        public static void Delete(Message_ message_)
        {

        }
    }
}
