using System;
using NUnit.Framework;
using PeanutButter.TestUtils.Entity;
using PeanutButter.TestUtils.Generic;
using SomeProjectUsingEntity.Models;

namespace SomeProjectUsingEntity.Tests.Models
{
    [TestFixture]
    public class TestSomeChildEntityPersistence: SomeContextPersistenceTestFixtureBase
    {
        [Test]
        public void SomeChildEntity_ShouldBeAbleToPersistAndRecall_NonFluent()
        {
            ShouldBeAbleToPersist<SomeChildEntityBuilder, SomeChildEntity>(
                ctx => ctx.SomeChildEntities,
                (ctx, beforePersisting) =>
                {
                    Assert.IsNotNull(beforePersisting.SomeEntity);
                },
                (beforePersisting, afterPersisting) =>
                {
                }, typeof (SomeChildEntity).VirtualProperties());
        }

        [Test]
        public void SomeChildEntity_ShouldBeAbleToPersistAndRecall()
        {
            // this is a more fluent approach to the same test above
            //---------------Set up test pack-------------------

            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            //  option 1: spin up a clean db every time and migrate
            EntityPersistenceTester.CreateFor<SomeChildEntity>()
                    .WithContext<SomeContext>()
                    // totally optional: the test helper will search for an existing builder or
                    //  create one on the fly (which would be re-used the next time someone needs one)
                    .WithBuilder<SomeChildEntityBuilder>()
                    .WithDbMigrator(connectionString => new CompositeDBMigrator(connectionString, true))
                    // optional: the tester can figure this out
                    .WithCollection(ctx => ctx.SomeChildEntities)
                    .BeforePersisting((ctx, entity) =>
                    {
                        Assert.IsNotNull(entity.SomeEntity);
                    })
                    .AfterPersisting((entityBefore, entityAfter) =>
                    {
                        // no assertions done here in this test, but this is where you would
                        //  do custom assertions
                    })
                    // totally optional: the default is for the tester to ignore virtual properties (ie, navigation properties)
                    .WithIgnoredProperties(typeof(SomeChildEntity).VirtualProperties())
                    // also optional: how much drift to allow for datetime property persistence
                    //  the amount which makes sense depends on your backing field's resolution
                    //  - the default behaviour allows just enough difference for most sql server implementations
                    .WithAllowedDateTimePropertyDelta(TimeSpan.FromMilliseconds(100))
                    .ShouldPersistAndRecall();

            // option 2: using the shared database from the base context
            //              - which requires:
            //                  [OneTimeSetup] should call Configure and perform migrations
            //                  [SetUp] should clear out the context to avoid collisions with the tester
            EntityPersistenceTester.CreateFor<SomeChildEntity>()
                .WithContext<SomeContext>()
                .WithSharedDatabase(_tempDb)
                .BeforePersisting((ctx, entity) =>
                {
                    Assert.IsNotNull(entity.SomeEntity);
                })
                .ShouldPersistAndRecall();
            //---------------Test Result -----------------------
        }


    }
}