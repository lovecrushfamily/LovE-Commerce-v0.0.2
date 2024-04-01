using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL;

namespace BUS
{
    public class Comment : Comment_
    {
        public Comment() { }

        //public string CommentId;
        //public string ProductId;
        //public string CustomerId;
        //public int Star;
        //public string CommentText;
        //public string Date;
        //public string ResponseComment;
                                               
        public void Add()
        {
            DAO.Comment.Add(this);
        }
        public void Update()
        {

        }

        public void Delete()
        {

        }

        public static Comment[] GetComments()
        {
            return DAO.Comment.Select() as Comment[];

        }

    }
}
