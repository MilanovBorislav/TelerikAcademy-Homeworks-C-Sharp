using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _08.Task_SearchingSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            SqlConnection connect = new SqlConnection(connection.Default.DBConnectionString);
            connect.Open();
            using (connect)
            {
                SqlCommand cmd = new SqlCommand("SELECT ProductName FROM dbo.Products WHERE ProductName  LIKE '%\\" + word + "%' ESCAPE '\\'", connect);
                SqlDataReader reader = cmd.ExecuteReader();

                using (reader)
                {
                    while (reader.Read())
                    {
                        string product = (string)reader[0];
                        Console.Write("Product : {0}  ", product);
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
