using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Task_ReadFromExcel
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"../../exTable.xlsx";
            string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties=Excel 12.0;";

            OleDbConnection excelCon = new OleDbConnection(connStr);
            excelCon.Open();

            using (excelCon)
            {
                OleDbCommand command = new OleDbCommand(@"SELECT * FROM [Sheet1$]", excelCon);
                OleDbDataReader reader = command.ExecuteReader();

                using (reader)
                {
                    while (reader != null && reader.Read())
                    {
                        string name = (string)reader["Name"];
                        double score = (double)reader["Score"];

                        Console.WriteLine("Player name: {0}  Player score: {1}", name.PadRight(20), score);
                    }
                }
            }
        }
    }
}
