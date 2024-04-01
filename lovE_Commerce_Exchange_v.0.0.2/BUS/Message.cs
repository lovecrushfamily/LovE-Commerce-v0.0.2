using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Message : DLL.Message_
    {
        public Message() { }

        //public string MessageId;
        //public string SenderId;
        //public string ReceivedId;
        //public string Content;
        //public bool Time;
        //public bool SeenState;
        //public bool IsRecall;

        public void  Add()
        {

        }

        public void Recall()
        {

        }

        public static Message[] GetMessages()
        {
            return DAO.Message.Select() as Message[];
        }

    }
}
