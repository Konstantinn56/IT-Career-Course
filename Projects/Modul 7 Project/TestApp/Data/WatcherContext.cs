using Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class WatcherContext : DbContext
    {
        private const string connection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MoviesCatalog;Integrated Security=True;";

        public DbSet<Watcher> Watchers { get; set; }

        public WatcherContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connection);
        }
    }
}
