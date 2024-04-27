using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL;

namespace BUS
{
    public class Comment : Comment_, Entity
    {
        public Comment(Comment_ comment_)
        {
            CommentId = comment_.CommentId;
            CustomerId = comment_.CustomerId;
            Star = comment_.Star;
            Content = comment_.Content;
            Date = comment_.Date;
            ResponseComment = comment_.ResponseComment;
            OrderDetailID = comment_.OrderDetailID;
        }
 
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
            return DAO.Comment.Select().Select(c => new Comment(c)).ToArray();

        }

    }
}
