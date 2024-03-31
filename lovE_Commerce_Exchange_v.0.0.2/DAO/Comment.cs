using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL;

namespace DAO
{
    public class Comment
    {
        public static void Add(Comment_ comment_)
        {
            MyConnection.ExecuteNonQuery($"sp_insertComment {comment_.ProductId}, " +
                                                            $"{comment_.CustomerId}, " +
                                                            $"{comment_.Star}," +
                                                            $"'{comment_.Content}'," +
                                                            $"{comment_.ResponseComment}");
        }
        public static void Update(Comment_ comment_)
        {

        }
        public static void Delete(Comment_ comment_)
        {

        }
        public static Comment_[] Select()
        {
            return new Comment_[] { };
        }
    }
}
