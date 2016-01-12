using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
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

    }
}
