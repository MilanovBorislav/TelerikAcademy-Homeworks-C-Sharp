namespace CatalogOfFreeContent
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    public interface ICatalog
    {
        /// <summary>
        /// Adds a content item to the catalog
        /// </summary>
        /// <param name="content">the content item for insertion</param>
        void Add(IContentItem content);

        /// <summary>
        /// Find all content items in the catalog that match the specified title
        /// Return no more than numberOfContentElementsToList elementst
        /// The order of returned elements is alphabetical regarding their.ToStirng()
        /// representation
        /// </summary>
        /// <param name="title">The title of the elementst we searched</param>
        /// <param name="numberOfContentElementsToList">\
        /// The maximal number of returned elementst
        /// </param>
        /// <remarks>
        /// This method can return less than all matching elements in the catalog.
        /// For example: if we have 30 matchin elemetns but only 10 requested,
        /// the mothod will returned 10 elements but only 3 matches are found
        /// only 3 elements will be returned.
        /// </remarks>
        /// <returns></returns>
        IEnumerable<IContentItem> GetListContent(string title, int numberOfContentElementsToList);

        int UpdateContent(string oldUrl, string newUrl);
    }
}