using System.Data.Entity;

namespace Linq
{
    public class LinqContext : DbContext
    {

        public LinqContext() : base("name=Linq") { }

        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}