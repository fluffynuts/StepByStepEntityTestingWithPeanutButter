using PeanutButter.TestUtils.Entity;

namespace SomeProjectUsingEntity.Tests.Models
{
    public abstract class SomeContextPersistenceTestFixtureBase: EntityPersistenceTestFixtureBase<SomeContext>
    {
        public SomeContextPersistenceTestFixtureBase()
        {
            Configure(false, connectionString => new DbSchemaImporter(connectionString, SomeDBSchema.DB_SCHEMA));
        }
    }
}