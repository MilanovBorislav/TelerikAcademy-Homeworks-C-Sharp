using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Task_WriteInExcel
{
    class Program
    {
        private static void InsertPlayerScore(string playerName, double playerScore, OleDbConnection connection)
        {
            var insertPlayer = new OleDbCommand(@"INSERT INTO [Sheet1$] (Name, Score) VALUES (@Name, @Score)", connection);
            insertPlayer.Parameters.AddWithValue("@Name", playerName);
            insertPlayer.Parameters.AddWithValue("Score", playerScore);

            insertPlayer.ExecuteNonQuery();
        }
       
        static void Main(string[] args)
        {
            string path = @"../../exTable.xlsx";
            string dbConnectionStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties=Excel 12.0;";

            var connection = new OleDbConnection(dbConnectionStr);

            connection.Open();

            using (connection)
            {
                InsertPlayerScore("Ivan Ivanov1", 19, connection);
                InsertPlayerScore("Ivan Ivanov2", 18, connection);
                InsertPlayerScore("Ivan Ivanov2", 17, connection);
                InsertPlayerScore("Ivan Ivanov4", 16, connection);
                InsertPlayerScore("Ivan Ivanov5", 15, connection);
                InsertPlayerScore("Ivan Ivanov6", 14, connection);
                InsertPlayerScore("Ivan Ivanov7", 13, connection);
                Console.WriteLine("Inserted.");
            }
        }
    }
}
