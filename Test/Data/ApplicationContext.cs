using System.Data.Entity;
using SQLite.CodeFirst;
using Test.Data.Tables;

namespace Test.Data.Context
{
    public class ApplicationContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNotExists<ApplicationContext>(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);

            var model = modelBuilder.Build(Database.Connection);
            ISqlGenerator sqlGenerator = new SqliteSqlGenerator();
            _ = sqlGenerator.Generate(model.StoreModel);
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
