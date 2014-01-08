using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;


namespace _10.Task_SQLite
{
    class Program
    {

        public static void ListAllBooksTitles()
        {
            SQLiteConnection Connection = new SQLiteConnection("Data Source=data.db3;Version=3;");
            Connection.Open();
            using (Connection)
            {
                SQLiteCommand cmd = new SQLiteCommand("select * from Books", Connection);
                var reader = cmd.ExecuteReader();
                Console.WriteLine("Book Titles");
                Console.WriteLine();
                while (reader.Read())
                {
                    Console.WriteLine(reader[1]);
                }

            }
        }

        private static void AddBook(string bookName, string author, DateTime datePublish, string isbn)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=data.db3;Version=3;");
            con.Open();
            using (con)
            {
                string bookStr = @"
                INSERT INTO  Books(Title,Author,PublishDate,ISBN)
                VALUES (@title,@author ,@date, @isbn)
                ";
                var addBook = new SQLiteCommand(bookStr, con);
                addBook.Parameters.AddWithValue("@title", bookName);
                addBook.Parameters.AddWithValue("@author", author);
                addBook.Parameters.AddWithValue("@date", datePublish);
                addBook.Parameters.AddWithValue("@isbn", isbn);
                addBook.ExecuteNonQuery();
            }
        }

        private static void FindBookByTitle(string bookName)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=data.db3;Version=3;");
            con.Open();
            using (con)
            {
                string bookStr = @"
                SELECT * FROM Books
                    WHERE   Title LIKE @title
                ";
                SQLiteCommand cmd = new SQLiteCommand(bookStr, con);
                cmd.Parameters.AddWithValue("@title", bookName);
                var reader = cmd.ExecuteReader();
                Console.WriteLine("Book Titles");
                Console.WriteLine();
                while (reader.Read())
                {
                    Console.WriteLine(reader[1]);
                    Console.WriteLine("Founded");
                }

            }
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                AddBook("Title" + i, "Author" + i, DateTime.Now, "1234545" + i);
            }
            ListAllBooksTitles();
            Console.WriteLine("");
            FindBookByTitle("Title2");

        }
    }
}
