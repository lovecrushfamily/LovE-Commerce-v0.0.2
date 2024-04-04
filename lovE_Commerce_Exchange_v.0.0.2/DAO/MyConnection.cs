using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.Sql;


namespace DAO
{
    public class MyConnection
    {
        private MyConnection() { }
        public static string ConfigurationFile;
        static object key = new object();
        private static MyConnection instance; // Ctrl + r + e
        //private string ConnectionString ;

        //Alternatives connection string
        private static string ConnectionString = @"Data Source = LOVECRUSH; Initial Catalog = LovE_Commerce_v2; Integrated Security=true; Application Name = Windows Forms Application";
        //private string AlternativeString = @"Data Source = LOVECRUSH; Initial Catalog = BikeStores; Integrated Security=true; Application Name = Windows Forms Application";
        public static MyConnection Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (key)
                    {
                        instance = new MyConnection();
                    }
                }
                return instance;
            }
        }

        public SqlDataReader ExecuteQuery(string sqlcommand, bool AutoCloseConnection = true)
        {
            //MyConnection.Instance.ExecuteQuery();
            SqlDataReader data;
            using (SqlConnection SqlConnection = new SqlConnection(ConnectionString))
            {

                SqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlcommand, SqlConnection);
                data = sqlCommand.ExecuteReader();
             

                if (AutoCloseConnection)
                {
                    SqlConnection.Close();
                }
            }
            return data;
        }
        public static void ExecuteNonQuery(string command)
        {
            int rowReturn;
            using (SqlConnection SqlConnection = new SqlConnection(ConnectionString))
            {
                SqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(command, SqlConnection);
                rowReturn = sqlCommand.ExecuteNonQuery();
                SqlConnection.Close();
                sqlCommand.Dispose();
            }
        }
        public DataSet ExecuteDataset(string sqlcommand)
        {
            DataSet dataset;
            using (SqlConnection SqlConnection = new SqlConnection(ConnectionString))
            {
                SqlConnection.Open();
                SqlDataAdapter dataadapter = new SqlDataAdapter(sqlcommand, SqlConnection);
                dataset = new DataSet();
                dataadapter.Fill(dataset);
                SqlConnection.Close();
                dataadapter.Dispose();

            }
            return dataset;
        }
        public static DataTable ExecuteDataTable(string sqlcommand)
        {
            DataTable datatable = new DataTable();
            using (SqlConnection SqlConnection = new SqlConnection(ConnectionString))
            {
                SqlConnection.Open();
                SqlDataAdapter datatableadapter = new SqlDataAdapter(sqlcommand, SqlConnection);
                datatableadapter.Fill(datatable);
                SqlConnection.Close();
                datatableadapter.Dispose();
            }
            return datatable;
        }

        public static int ExcuteScalar(string sqlcommand)
        {
            using (SqlConnection SqlConnection = new SqlConnection(ConnectionString))
            {
                SqlConnection.Open();
                SqlDataAdapter datatableadapter = new SqlDataAdapter(sqlcommand, SqlConnection);
                SqlCommand sqlCommand = new SqlCommand(sqlcommand, SqlConnection);
                int keyID = sqlCommand.ExecuteNonQuery();
                SqlConnection.Close();
                sqlCommand.Dispose();
                return keyID;
            }
        }
    }
}