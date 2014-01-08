using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Threading;
using System.Globalization;


namespace _09.Task_BookShopMySQL
{
    class Program
    {
        static string connection = "Server=localhost; Database=BookShop; Uid=root; Pwd=local; Encrypt=true;";
        static MySqlConnection con = new MySqlConnection(connection);

        public static void ListAllBooks()
        {
            con.Open();
            using (con)
            {
                MySqlCommand cmd = new MySqlCommand("select * from Books", con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("Title : {0}", reader[0]);
                    Console.WriteLine("Author : {0}", reader[1]);
                    Console.WriteLine("Publish Date : {0}", reader[2]);
                    Console.WriteLine("ISBN : {0}", reader[3]);
                    Console.WriteLine();
                }
            }
        }

        private static void AddBook(string bookName, DateTime datePublish, long ISBN, string author)
        {
            MySqlConnection dbConnection = new MySqlConnection(connection);

            dbConnection.Open();
            using (dbConnection)
            {
             string bookStr = @"
                INSERT INTO BookShop.Books (Title, Author, PublishData, ISBN)
                VALUES (@title,@author ,@date, @isbn)
                ";
                MySqlCommand addBook = new MySqlCommand(bookStr, dbConnection);
                addBook.Parameters.AddWithValue("@title", bookName);
                addBook.Parameters.AddWithValue("@author", author);
                addBook.Parameters.AddWithValue("@date", datePublish);
                addBook.Parameters.AddWithValue("@isbn", ISBN);
                addBook.ExecuteNonQuery();
            }
        }

        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            ListAllBooks();
            AddBook("some book",DateTime.Now,456545,"Drug Pisatel");
        }
    }
}
