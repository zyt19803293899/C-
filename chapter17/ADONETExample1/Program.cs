using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace ADONETExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Connect to database
            string conString = "Persist Security Info=False;Integrated Security=true;Initial Catalog=TestDB;Server=PC\\SQLEXPRESS";


            SqlConnection connection = new SqlConnection(conString);
            SqlDataReader dataReader = null;
            try
            {
                connection.Open();
                Console.WriteLine("Got connection");
                // Pass the connection to a command object
                SqlCommand cmd = new SqlCommand("SELECT * FROM users", connection);

                // get query results
                dataReader = cmd.ExecuteReader();

                // print the CustomerID of each record
                while (dataReader.Read())
                {
                    Console.WriteLine(dataReader[0]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }

                if (connection != null)
                {
                    connection.Close();
                }
            }

            Console.ReadKey();
        }
    }
}
