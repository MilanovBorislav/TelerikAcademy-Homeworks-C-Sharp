using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Task_ShowNameAndDescription
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connect = new SqlConnection(connetion.Default.DBConnectionString);
            connect.Open();
            using (connect)
            {
                SqlCommand cmd = new SqlCommand(@"
                 SELECT CategoryName,Description
	                  FROM Categories       
                ", connect);
                SqlDataReader reader = cmd.ExecuteReader();

                using (reader)
                {
                    while (reader.Read())
                    {
                        string catName = (string) reader[0];
                        string catDescription = (string) reader[1];
                        Console.Write("Name : {0}" , catName);
                        Console.WriteLine();
                        Console.WriteLine("Description : {0}", catDescription);
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
