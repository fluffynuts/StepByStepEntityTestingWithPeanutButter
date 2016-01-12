using NUnit.Framework;
using PeanutButter.TestUtils.Generic;
using SomeProjectUsingEntity.Models;

namespace SomeProjectUsingEntity.Tests.Models
{
    public class TestSomeEntityPersistence: SomeContextPersistenceTestFixtureBase
    {
        [Test]
        public void SomeEntity_ShouldBeAbleToPersistAndRecall()
        {
            ShouldBeAbleToPersist<SomeEntityBuilder, SomeEntity>(
                ctx => ctx.SomeEntities,
                (ctx, beforePersisting) =>
                {
                },
                (beforePersisting, afterPersisting) =>
                {
                }, typeof (SomeEntity).VirtualProperties());
        }
    }
}