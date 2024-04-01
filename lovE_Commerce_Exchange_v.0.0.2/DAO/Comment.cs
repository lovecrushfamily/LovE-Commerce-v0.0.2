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
            MyConnection.ExecuteNonQuery($"sp_insertComment {comment_.ProductId}, " +
                                                            $"{comment_.CustomerId}, " +
                                                            $"{comment_.Star}," +
                                                            $"'{comment_.Content}'," +
                                                            $"{comment_.ResponseComment}");
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
                    ProductId = row["ProductID"].ToString(),
                    CustomerId = row["CustomerID"].ToString(),
                    Star = row["Star"].ToString().ToInt(),
                    Content = row["Content"].ToString(),
                    Date = row["DateOfComment"].ToString(),
                    ResponseComment = row["ResponseComment"].ToString().ToBool()

                };

            }
        }
    }
}
