using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.CodeFirst;
using ApplicationContext = Test.Data.Context.ApplicationContext;

namespace Test.Data.ContextInitializer
{
    public class ApplicationContextInitializer : SqliteDropCreateDatabaseAlways<ApplicationContext>
    {
        public ApplicationContextInitializer(DbModelBuilder modelBuilder) : base(modelBuilder)
        {
        }

        protected override void Seed(ApplicationContext db)
        {

        }
    }
}