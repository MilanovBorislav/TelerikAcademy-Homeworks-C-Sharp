namespace FreeContentCatalog.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using CatalogOfFreeContent;
    using System.Linq;

    [TestClass]
    public class UnitTestCatalog
    {
        [TestMethod]
        public void TestMethodAddSingleItem()
        {
            Catalog catalog = new Catalog();
            ContentItem book = new ContentItem(ContentItemType.Book,
                new string[] { "Intro C#", "S.Nakov", "12763892", "http://introprograming.info/en/" });
            catalog.Add(book);
            Assert.AreEqual(1, catalog.Count);
        }

        [TestMethod]
        public void TestMethodAddTwoItems()
        {
            Catalog catalog = new Catalog();
            ContentItem book = new ContentItem(ContentItemType.Book,
                new string[] { "Intro C#", "S.Nakov", "12763892",
                    "http://introprograming.info/en/" });
            catalog.Add(book);
            Assert.AreEqual(1, catalog.Count);
            ContentItem movie = new ContentItem(ContentItemType.Movie,
                new string[] { "One", "James Wong (2001)", "969763002",
                    "http://www.imdb.com/title/tt0267804/" });
            catalog.Add(movie);
            Assert.AreEqual(2, catalog.Count);
        }

        [TestMethod]
        public void TestMethodAddAndFindItem()
        {
            Catalog catalog = new Catalog();
            ContentItem book = new ContentItem(ContentItemType.Book,
                new string[] { "Intro C#", "S.Nakov", "12763892",
                    "http://introprograming.info/en/" });
            catalog.Add(book);
            var result = catalog.GetListContent("Intro C#", 1);
            Assert.AreEqual(result.Count(), 1);
            Assert.AreSame(result.First(), book);
        }

        [TestMethod]
        public void TestMethodAddDuplicatedItem()
        {
            Catalog catalog = new Catalog();
            ContentItem book = new ContentItem(ContentItemType.Book,
                new string[] { "Intro C#", "S.Nakov", "12763892",
                    "http://introprograming.info/en/" });
            ContentItem book2 = new ContentItem(ContentItemType.Book,
                new string[] { "Intro C#", "S.Nakov", "12763892",
                    "http://introprograming.info/en/" });
            catalog.Add(book);
            catalog.Add(book2);
            Assert.AreEqual(2, catalog.Count);
        }

        [TestMethod]
        public void TestMethodAddMultipleItems()
        {
            Catalog catalog = new Catalog();

            ContentItem book = new ContentItem(ContentItemType.Book,
                new string[] { "Intro C#", "S.Nakov", "12763892",
                    "http://introprograming.info/en/" });
            ContentItem book2 = new ContentItem(ContentItemType.Book,
                new string[] { "Intro C#", "S.Nakov", "12763892", 
                    "http://introprograming.info/en/" });
            ContentItem movie = new ContentItem(ContentItemType.Movie,
                new string[] { "One", "James Wong (2001)", "969763002",
                    "http://www.imdb.com/title/tt0267804/" });
            ContentItem song = new ContentItem(ContentItemType.Song,
                new string[] { "One", "Metallica", "8771120",
                    "http://goo.gl/dIkth7gs" });

            catalog.Add(book);
            catalog.Add(book2);
            catalog.Add(book2);
            catalog.Add(book2);
            catalog.Add(movie);
            catalog.Add(song);
            catalog.Add(song);
            Assert.AreEqual(7, catalog.Count);
        }

        [TestMethod]
        public void TestMethodAdd50000Items()
        {
            Catalog catalog = new Catalog();

            for (int i = 0; i < 50000; i++)
            {
                ContentItem book = new ContentItem(ContentItemType.Book,
                    new string[] { "Intro C#" + i, "S.Nakov", "12763892",
                        "http://introprograming.info/en/" });
                catalog.Add(book);
            }
            Assert.AreEqual(50000, catalog.Count);
        }

        [TestMethod]
        public void TestMethodGetListContentSingleItem()
        {
            Catalog catalog = new Catalog();
            ContentItem book = new ContentItem(ContentItemType.Book,
                new string[] { "Intro C#", "S.Nakov", "12763892",
                    "http://introprograming.info/en/" });
            ContentItem movie = new ContentItem(ContentItemType.Movie,
               new string[] { "Intro movie", "Author", "564654",
                    "http://intropromovie.info/en/" });
            ContentItem app = new ContentItem(ContentItemType.Application,
               new string[] { "Some Application", "Developer", "1321654",
                    "http://introapp.info/en/" });
            catalog.Add(book);
            catalog.Add(movie);
            catalog.Add(app);
            var result = catalog.GetListContent("Intro C#", 10);
            Assert.AreEqual(result.Count(), 1);
            Assert.AreSame(result.First(), book);
        }

        [TestMethod]
        public void TestMethodGetListContentMissingItem()
        {
            Catalog catalog = new Catalog();
            ContentItem book = new ContentItem(ContentItemType.Book,
                new string[] { "Intro C#", "S.Nakov", "12763892",
                    "http://introprograming.info/en/" });
            ContentItem movie = new ContentItem(ContentItemType.Movie,
               new string[] { "Intro movie", "Author", "564654",
                    "http://intropromovie.info/en/" });
            ContentItem app = new ContentItem(ContentItemType.Application,
               new string[] { "Some Application", "Developer", "1321654",
                    "http://introapp.info/en/" });
            catalog.Add(book);
            catalog.Add(movie);
            catalog.Add(app);
            var result = catalog.GetListContent("Missing Item", 10);
            Assert.AreEqual(result.Count(), 0);
        }

        [TestMethod]
        public void TestMethodGetListContentTwoMatchingItems()
        {
            Catalog catalog = new Catalog();
            ContentItem book = new ContentItem(ContentItemType.Book,
                new string[] { "Intro C#", "S.Nakov", "12763892",
                    "http://introprograming.info/en/" });
            ContentItem movie = new ContentItem(ContentItemType.Movie,
               new string[] { "Intro C#", "Author", "564654",
                    "http://intropromovie.info/en/" });
            ContentItem app = new ContentItem(ContentItemType.Application,
               new string[] { "Some Application", "Developer", "1321654",
                    "http://introapp.info/en/" });
            catalog.Add(book);
            catalog.Add(movie);
            catalog.Add(app);
            var result = catalog.GetListContent("Intro C#", 10);
            Assert.AreEqual(result.Count(), 2);
        }

        [TestMethod]
        public void TestMethodGetListContentManyMatchingItemsGetFirstOnly()
        {
            Catalog catalog = new Catalog();
            ContentItem book = new ContentItem(ContentItemType.Book,
                new string[] { "Intro C#", "S.Nakov", "12763892",
                    "http://introprograming.info/en/" });
            ContentItem movie = new ContentItem(ContentItemType.Movie,
               new string[] { "Intro C#", "Author", "564654",
                    "http://intropromovie.info/en/" });
            ContentItem app = new ContentItem(ContentItemType.Application,
               new string[] { "Some Application", "Developer", "1321654",
                    "http://introapp.info/en/" });
            catalog.Add(book);
            catalog.Add(movie);
            catalog.Add(app);
            var result = catalog.GetListContent("Intro C#", 1);
            Assert.AreEqual(result.Count(), 1);
        }

        [TestMethod]
        public void TestMethodGetListContentCheckOrder()
        {
            Catalog catalog = new Catalog();
            ContentItem book = new ContentItem(ContentItemType.Book,
                new string[] { "Intro C#", "S.Nakov", "12763892",
                    "http://introprograming.info/en/" });
            ContentItem movie = new ContentItem(ContentItemType.Movie,
               new string[] { "Intro C#", "Author", "564654",
                    "http://intropromovie.info/en/" });
            ContentItem app = new ContentItem(ContentItemType.Application,
               new string[] { "Intro C#",  "Developer", "1321654",
                    "http://introapp.info/en/" });
            ContentItem book2 = new ContentItem(ContentItemType.Book,
                new string[] { "Intro C#", "Other Author", "12763892",
                    "http://introprograming.info/en/" });
            catalog.Add(book);
            catalog.Add(movie);
            catalog.Add(app);
            catalog.Add(book2);
            var result = catalog.GetListContent("Intro C#", 10);
            Assert.AreEqual(result.Count(), 4);

            string[] expected =
            {
                "Application: Intro C#; Developer; 1321654; http://introapp.info/en/",
                "Book: Intro C#; Other Author; 12763892; http://introprograming.info/en/",
                "Book: Intro C#; S.Nakov; 12763892; http://introprograming.info/en/",
                "Movie: Intro C#; Author; 564654; http://intropromovie.info/en/"
            };

            string[] actual = new string[]
            {
                result.First().ToString(),
                result.Skip(1).First().ToString(),
                result.Skip(2).First().ToString(),
                result.Skip(3).First().ToString()
            };
           CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodUpdateItems()
        {
            Catalog catalog = new Catalog();
            ContentItem book = new ContentItem(ContentItemType.Book,
                           new string[] { "Intro C#", "S.Nakov", "12763892",
                    "http://introprograming.info/en/" });
            ContentItem movie = new ContentItem(ContentItemType.Movie,
               new string[] { "Intro C#", "Author", "564654",
                    "http://intropromovie.info/en/" });
            ContentItem app = new ContentItem(ContentItemType.Application,
               new string[] { "Intro C#",  "Developer", "1321654",
                    "http://introapp.info/en/" });
            ContentItem book2 = new ContentItem(ContentItemType.Book,
                new string[] { "Intro C#", "Other Author", "12763892",
                    "http://introprograming.info/en/" });
            catalog.Add(book);
            catalog.Add(movie);
            catalog.Add(app);
            catalog.Add(book2);

           int updatedCount = catalog.UpdateContent("missing", "new");
           Assert.AreEqual(0, updatedCount);

           int updatedCount2 = catalog.UpdateContent(
               "http://introprograming.info/en/", "http://new");
           Assert.AreEqual(2, updatedCount2);

           int updatedCount3 = catalog.UpdateContent(
               "http://introprograming.info/en/", "http://new");
           Assert.AreEqual(0, updatedCount3);

           int updatedCount4 = catalog.UpdateContent(
               "http://new","http://alabala");
           Assert.AreEqual(2, updatedCount4);
        }
    }
}