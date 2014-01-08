using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Task_RowCont
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connect = new SqlConnection(set.Default.DBConnectionString);
            connect.Open();
            using (connect)
            {
                SqlCommand cmdCount = new SqlCommand(@"
                    SELECT COUNT(*) 
                        FROM Categories
                 ",connect);
                int count = (int) cmdCount.ExecuteScalar();
                Console.WriteLine("Count is {0}",count);
            }
        }
    }
}
