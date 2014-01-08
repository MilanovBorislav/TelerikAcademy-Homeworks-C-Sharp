namespace CatalogOfFreeContent
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Wintellect.PowerCollections;

    public class Catalog : ICatalog
    {
        private readonly MultiDictionary<string, IContentItem> url;
        private readonly OrderedMultiDictionary<string, IContentItem> title;

        public Catalog()
        {
            bool allowDuplicateValues = true;
            this.title = new OrderedMultiDictionary<string, IContentItem>(allowDuplicateValues);
            this.url = new MultiDictionary<string, IContentItem>(allowDuplicateValues);
        }

        public void Add(IContentItem content)
        {
            this.title.Add(content.Title, content);
            this.url.Add(content.Url, content);
        }

        public IEnumerable<IContentItem> GetListContent(string title,
            int numberOfContentElementsToList)
        {
            //performance bottleneck: find 100 elements in 60000 items is slow
            IEnumerable<IContentItem> contentToList =
                                                     from c in this.title[title]
                                                     select c;

            return contentToList.Take(numberOfContentElementsToList);
        }

        public int UpdateContent(string oldUrl, string newUrl)
        {
            int updatedElemenCounts = 0;

            ICollection<IContentItem> matchedElements = this.url[oldUrl].ToList();
            int updateCount = 0;
            foreach (ContentItem content in matchedElements)
            {
                content.Url = newUrl;
                updateCount++;
            }

            this.url.Remove(oldUrl);
            this.url.AddMany(newUrl, matchedElements);

            return updateCount;
        }

        public int Count
        {
            get
            {
                return this.title.KeyValuePairs.Count;
            }
        }
    }
}