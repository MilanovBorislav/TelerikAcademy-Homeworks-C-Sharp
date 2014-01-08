using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data.Entity;
using System.Net.Http;
using System.Net.Http.Headers;
using MusicStore.Data;
using MusicStore.Models;
using MusicStore.Data.Migrations;

namespace MusicStore.Client
{
    class Program
    {
        private static readonly HttpClient Client = new HttpClient {BaseAddress = new Uri("http://localhost:53814/")};
         
        static void Main(string[] args)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MusicStoreContext, MusicStore.Data.Migrations.Configuration>());

            var db = new MusicStoreContext();
            //seed Database
            #region
            //             var artist = new Artist
            //             {
            //                 Name = "Artist Name 1000",
            //                 Country = "Bulgaria"
            //             };
            // 
            //             var artist2 = new Artist
            //             {
            //                 Name = "Artist Name 222",
            //                 Country = "Greece"
            //             };
            // 
            // 
            //             var album = new Album
            //             {
            //                 Title = "Album Title 78971",
            //                 Songs = new Collection<Song>(),
            //                 Artists = new Collection<Artist>()
            //                 {
            //                     artist2,
            //                     new Artist
            //                     {
            //                         Name = "Artist Name 5000",
            //                         Country = "Bulgaria"
            //                     },
            //                     new Artist
            //                     {
            //                         Name = "Artist Name 6000",
            //                         Country = "Romania"
            //                     },
            // 
            //                 }
            //             };
            // 
            //             album.Songs.Add(
            //              new Song
            //              {
            //                  Title = "Song Title 922",
            //                  Genre = "Country",
            //                  Artist = artist
            //              }
            //                 );
            //             db.Albums.Add(album);
            //             db.SaveChanges();
            #endregion

            Artist artist = new Artist
            {
                Name = "AAAAAAAAAAAAAAAA",
                Country = "Romania"
            };

            const string Artists = "Artist";
            const string Albums = "Album";
            const string Songs = "Song";

            HttpClienHelper.ListItems<Artist>(Artists);
            HttpClienHelper.ListItems<Song>(Songs);
            HttpClienHelper.ListItems<Album>(Albums);

            HttpClienHelper.FindItem<Album>(Albums, 1);
            HttpClienHelper.FindItem<Artist>(Artists, 2);
            HttpClienHelper.FindItem<Song>(Songs, 2);  
          //  HttpClienHelper.AddItem(Songs,new Song(){Title = "Some Song Title",Genre = "R&B"});
          //  HttpClienHelper.AddItem(Artists,artist);
           // HttpClienHelper.DeleteItem(Artists, 10);
            HttpClienHelper.DeleteItem(Songs, 4);
            HttpClienHelper.UpdateItem(Artists,1,artist);
        }
    }
}
