using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Task_ShowAllProductAndCategories
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connect = new SqlConnection(connection.Default.DBConnectionString);
            connect.Open();
            using (connect)
            {
                SqlCommand cmd = new SqlCommand(@"
                 SELECT  p.ProductName,c.CategoryName
	                FROM dbo.Categories c 
		                JOIN  dbo.Products p
			                ON c.CategoryID = p.CategoryID      
                ", connect);
                SqlDataReader reader = cmd.ExecuteReader();

                using (reader)
                {
                    while (reader.Read())
                    {
                        string product = (string)reader[0];
                        string category = (string)reader[1];
                        Console.Write("Product : {0}  ", product);
                        Console.Write("Category : {0}  ", category);
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
