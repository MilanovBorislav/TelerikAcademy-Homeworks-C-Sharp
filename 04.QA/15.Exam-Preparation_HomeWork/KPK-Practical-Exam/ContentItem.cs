namespace CatalogOfFreeContent
{
    using System;
    using System.Linq;

    public class ContentItem : IComparable, IContentItem
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public Int64 Size { get; set; }

        private string url;

        public string Url
        {
            get
            {
                return this.url;
            }
            set
            {
                this.url = value;
                this.TextRepresentation = this.ToString();
            }
        }

        public ContentItemType Type { get; set; }

        public string TextRepresentation { get; set; }

        public ContentItem(ContentItemType type, string[] commandParams)
        {
            this.Type = type;
            this.Title = commandParams[(int)ItemContentParam.Title];
            this.Author = commandParams[(int)ItemContentParam.Author];
            this.Size = Int64.Parse(commandParams[(int)ItemContentParam.Size]);
            this.Url = commandParams[(int)ItemContentParam.Url];
        }

        public int CompareTo(object obj)
        {
            if (null == obj)
                return 1;

            ContentItem otherContent = obj as ContentItem;
            if (otherContent != null)
            {
                int comparisonResul = this.TextRepresentation.CompareTo(
                    otherContent.TextRepresentation);

                return comparisonResul;
            }

            throw new ArgumentException("Can not compare Content with non-Content object");
        }

        public override string ToString()
        {
            string output = String.Format("{0}: {1}; {2}; {3}; {4}",
                this.Type.ToString(), this.Title, this.Author, this.Size, this.Url);

            return output;
        }
    }
}