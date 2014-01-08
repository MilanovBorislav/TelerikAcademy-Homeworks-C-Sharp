using KingsValey.Models;
using KingsValey.Models.GameModels;
using System.Data.Entity;

namespace KingsValey.Context
{
    public class KingsValeyContext : DbContext
    {
        public KingsValeyContext()
            : base("KingsValeyContext")
        {
        }

        public DbSet<Player> Players { get; set; }

        public DbSet<GameStateModel> Games { get; set; }
    }
}