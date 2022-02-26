namespace CrudWithORM.Data
{
    using CrudWithORM.Data.Model;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Product Database Context
    /// </summary>
    public class ProductContext : DbContext
    {
        //DbContext - представлява базата
        //DbSet - представлява таблиците/Tables
        private const string connetionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Shop;Integrated Security=True;";

        public DbSet<Product> Products { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public ProductContext()
        {
            //Create the database automaticly
            Database.EnsureCreated();
        }

        /// <summary>
        /// Connection string to Microsoft SQL Server
        /// </summary>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connetionString);
        }

    }
}
