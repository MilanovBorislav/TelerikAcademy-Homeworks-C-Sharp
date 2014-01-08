namespace CatalogOfFreeContent
{
    using System;
    using CatalogOfFreeContent;
    
    public interface IContentItem : IComparable
    {
        string Title { get; set; }

        string Author { get; set; }

        Int64 Size { get; set; }

        string Url { get; set; }

        ContentItemType Type { get; set; }

        string TextRepresentation { get; set; }
    }
}