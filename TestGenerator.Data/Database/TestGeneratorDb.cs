using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGenerator.Data.Database.Entitites;

namespace TestGenerator.Data.Database
{
    public class TestGeneratorDb: DbContext
    {
        public DbSet<User> Users { get; set; }
        public TestGeneratorDb(): base("TEST_GENERATOR_DB")
        {
            System.Data.Entity.Database.SetInitializer<TestGeneratorDb>(new DropCreateDatabaseIfModelChanges<TestGeneratorDb>());
        }
    }
}
