namespace CrudWithoutORM.Data
{
    using System.Data.SqlClient;
    /// <summary>
    /// Microsoft SQL Server Database Connection Class
    /// </summary>
    public static class Database
    {
        private static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Shop;Integrated Security=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
