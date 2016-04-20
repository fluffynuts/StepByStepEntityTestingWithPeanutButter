using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using PeanutButter.TestUtils.Entity;
using PeanutButter.TestUtils.Generic;
using SomeProjectUsingEntity.Models;

namespace SomeProjectUsingEntity.Tests.Models
{
    [TestFixture]
    public class TestSomeEntity
    {
        [TestCase("Id", typeof(int))]
        [TestCase("Name", typeof(string))]
        [TestCase("Notes", typeof(string))]
        public void Type_ShouldHaveProperty_(string propertyName, Type propertyType)
        {
            //---------------Set up test pack-------------------
            var sut = typeof (SomeEntity);

            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            sut.ShouldHaveProperty(propertyName, propertyType);

            //---------------Test Result -----------------------
        }

        [Test]
        public void Name_ShouldBeRequired()
        {
            //---------------Set up test pack-------------------
            var sut = Create();

            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            sut.ShouldBeRequired(o => o.Name);

            //---------------Test Result -----------------------
        }

        [Test]
        public void Name_ShouldHaveMaxLength_100()
        {
            //---------------Set up test pack-------------------
            var sut = Create();

            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            sut.ShouldHaveMaxLengthOf(100, o => o.Name);

            //---------------Test Result -----------------------
        }

        private SomeEntity Create()
        {
            return new SomeEntity();
        }
    }
}
