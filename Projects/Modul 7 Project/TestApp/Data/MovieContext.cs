using Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    /// <summary>
    /// Movie Database Context
    /// </summary>
    public class MovieContext : DbContext
    {
        /// <summary>
        /// Connection string
        /// </summary>
        private const string connection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MoviesCatalog;Integrated Security=True;";

        /// <summary>
        /// Movies Table
        /// </summary>
        public DbSet<Movie> Movies { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public MovieContext()
        {
            Database.EnsureCreated();
        }

        /// <summary>
        /// Connection string to Microsoft SQL Server
        /// </summary>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connection);
        }
    }
}