using NUnit.Framework;

namespace SomeProjectUsingEntity.Tests.Models
{
    [TestFixture]
    public class TestSomeContext: SomeContextPersistenceTestFixtureBase
    {
        [Test]
        public void ShouldNotAllowEntityMigrations()
        {
            using (var ctx = GetContext())
            {
                //---------------Set up test pack-------------------
                //---------------Assert Precondition----------------

                //---------------Execute Test ----------------------
                using (var cmd = ctx.Database.Connection.CreateCommand())
                {
                    cmd.CommandText = @"select * from INFORMATION_SCHEMA.TABLES where TABLE_NAME = '__MigrationHistory';";
                    using (var reader = cmd.ExecuteReader())
                    {
                        Assert.IsFalse(reader.Read(), "Should not have a __MigrationHistory table when EF migrations are disabled");
                    }
                    //---------------Test Result -----------------------
                }
            }
        }

    }
}