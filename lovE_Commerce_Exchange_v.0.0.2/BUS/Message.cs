using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Message : DLL.Message_, Entity
    {
        public Message(DLL.Message_ message)
        {
            MessageId = message.MessageId;
            SenderId = message.SenderId;
            ReceivedId = message.ReceivedId;
            Content = message.Content;
            Time = message.Time;
            SeenState = message.SeenState;
            IsRecall = message.IsRecall;
        }

        public void  Add()
        {

        }

        public void Recall()
        {

        }

        public static Message[] GetMessages()
        {
            return DAO.Message.Select().Select(c => new Message(c)).ToArray();
        }

    }
}
