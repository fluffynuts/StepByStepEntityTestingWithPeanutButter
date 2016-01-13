using NUnit.Framework;
using PeanutButter.TestUtils.Generic;
using SomeProjectUsingEntity.Models;

namespace SomeProjectUsingEntity.Tests.Models
{
    [TestFixture]
    public class TestSomeChildEntityPersistence: SomeContextPersistenceTestFixtureBase
    {
        [Test]
        public void SomeChildEntity_ShouldBeAbleToPersistAndRecall()
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

    }
}