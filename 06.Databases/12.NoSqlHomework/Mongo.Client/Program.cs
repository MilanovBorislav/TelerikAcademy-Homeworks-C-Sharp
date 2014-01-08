using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mongo.Data;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;

namespace Mongo.Client
{
    class Program
    {
        public static MongoHelper<Word> db = new MongoHelper<Word>();

        public static void InsertInDictionary(object obj)
        {
            db.InsertData((Word)obj);
        }

        public static void DeleteFromDictionary(string objectId)
        {
            db.DeleteData<Word>(objectId);
        }

        public static void FindWord(string searched)
        {
            var word = db.MongoCollection.AsQueryable<Word>();
            var s = word.Where(w => w.WordNative == searched).ToList();
            Console.WriteLine(searched + " ---> " +  s[0].Translation);
        }

        public static void ListAllWords(IEnumerable<Word> words)
        {
            foreach (var word in words)
            {
                Console.WriteLine("Word : {0}", word.WordNative);
                Console.WriteLine("Translation : {0}", word.Translation);
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            db.MongoCollection.Drop();

            var words = new List<Word>()
                {
                    new Word()
                        {
                            WordNative = "local",
                            Translation = "characteristic of or associated with a particular locality or area",
                            TimeInserted = DateTime.Now
                        },

                    new Word()
                        {
                            WordNative = "nice",
                            Translation = "pleasant or commendable",
                            TimeInserted = DateTime.Now
                        },

                    new Word()
                        {
                            WordNative = "difficult",
                            Translation = "not easy to do; requiring effort ",
                            TimeInserted = DateTime.Now
                        }
                };

            foreach (Word t in words)
            {
                InsertInDictionary(t);
            }

            var wordsList = db.LoadData<Word>().ToList();
            ListAllWords(wordsList);
            FindWord("nice");
           
            foreach (var word in wordsList)
            {
                DeleteFromDictionary(word._id.ToString());
            }

            var clearedData= db.LoadData<Word>().ToList();

            Console.WriteLine("After clear");
            Console.WriteLine("Documents in collection {0}", clearedData.Count);
            Console.WriteLine();

            Console.WriteLine();
        }
    }
}
