using PeanutButter.TestUtils.Entity;
using PeanutButter.Utils.Entity;

namespace SomeProjectUsingEntity.Tests.Models
{
    public abstract class SomeContextPersistenceTestFixtureBase: EntityPersistenceTestFixtureBase<SomeContext>
    {
        public SomeContextPersistenceTestFixtureBase()
        {
            Configure(false, connectionString => new CompositeDBMigrator(connectionString, true));
            DisableDatabaseRegeneration();
            RunBeforeFirstGettingContext(Clear);
        }

        private void Clear(SomeContext ctx)
        {
            ctx.SomeChildEntities.Clear();
            ctx.SomeEntities.Clear();
            ctx.SaveChangesWithErrorReporting();
        }
    }
}