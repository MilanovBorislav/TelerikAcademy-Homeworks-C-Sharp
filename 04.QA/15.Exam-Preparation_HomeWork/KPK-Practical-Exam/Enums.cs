﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogOfFreeContent
{
    public enum CommandType
    {
        AddBook,
        AddMovie,
        AddSong,
        AddApplication,
        Update,
        Find,
    }

    public enum ContentItemType
    {
        Book,
        Movie,
        Song,
        Application,
    }

    public enum ItemContentParam
    {
        Title = 0,
        Author,
        Size,
        Url,
    }
}