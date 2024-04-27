using System;
using System.Collections.Generic;
using System.Data;
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
            int respond = comment_.ResponseComment ? 1 : 0;
            MyConnection.ExecuteNonQuery($"sp_insertComment " +
                                                            $"{comment_.CustomerId}, " +
                                                            $"{comment_.Star}," +
                                                            $"'{comment_.Content}'," +
                                                            $"{respond}," +
                                                            $"{comment_.OrderDetailID}");
        }
        public static void Update(Comment_ comment_)
        {
               //comment cannot be updated
        }
        public static void Delete(Comment_ comment_)
        {
            MyConnection.ExecuteNonQuery($"sp_deleteComment {comment_.CommentId}");

        }
        public static IEnumerable<Comment_> Select()
        {
            
            foreach (DataRow row in MyConnection.ExecuteDataTable($"sp_selectComment").Rows)
            {
                yield return new Comment_()
                {
                    CommentId = row["CommentID"].ToString(),
                    CustomerId = row["CustomerID"].ToString(),
                    Star = row["Star"].ToString().ToInt(),
                    Content = row["Content"].ToString(),
                    Date = row["DateOfComment"].ToString(),
                    ResponseComment = row["ResponseComment"].ToString().ToBool()    ,
                    OrderDetailID = row["OrderdetailID"].ToString() ,

                };

            }
        }
    }
}
