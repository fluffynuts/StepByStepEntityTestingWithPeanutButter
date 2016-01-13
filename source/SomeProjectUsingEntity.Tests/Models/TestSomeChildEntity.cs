using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PeanutButter.TestUtils.Generic;
using SomeProjectUsingEntity.DataConstants;
using SomeProjectUsingEntity.Models;

namespace SomeProjectUsingEntity.Tests.Models
{
    [TestFixture]
    public class TestSomeChildEntity
    {
        [Test]
        public void Construct_ShouldNotThrow()
        {
            //---------------Set up test pack-------------------

            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            Assert.DoesNotThrow(() => Create());

            //---------------Test Result -----------------------
        }

        [TestCase("Id", typeof(int))]
        [TestCase("SomeEntityId", typeof(int))]
        [TestCase("Name", typeof(string))]
        public void Type_ShouldHaveProperty_(string propertyName, Type propertyType)
        {
            //---------------Set up test pack-------------------
            var sut = typeof (SomeChildEntity);

            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            sut.ShouldHaveProperty(propertyName, propertyType);

            //---------------Test Result -----------------------
        }

        [TestCase("SomeEntity", typeof(SomeEntity))]
        public void Type_ShouldHaveVirtualProperty_(string propertyName, Type propertyType)
        {
            //---------------Set up test pack-------------------
            var sut = typeof (SomeChildEntity);
            var sutVirtualProperties = sut.VirtualProperties();

            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            sut.ShouldHaveProperty(propertyName, propertyType);
            Assert.IsTrue(sutVirtualProperties.Contains(propertyName), propertyName + " is not virtual and should be");

            //---------------Test Result -----------------------
        }

        private SomeChildEntity Create()
        {
            return new SomeChildEntity();
        }
    }
}
