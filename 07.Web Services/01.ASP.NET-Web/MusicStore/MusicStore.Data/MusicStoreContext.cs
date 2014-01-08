using System.Data.Entity;
using MusicStore.Models;

namespace MusicStore.Data
{
    public class MusicStoreContext: DbContext
    {
        public MusicStoreContext()
            : base("MusicStoreDatabase")
        {
            
        }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
    }
}
