using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using NUnit.Framework;

namespace smartcampustest
{
    class tests
    {
        [TestFixture]
        internal class TaskTests
        {
            [Test]
            public void SameText()
            {
                string description = "Hello World";
                string easyCompare = "Hello World";
                Assert.That(description.Equals(easyCompare));
            }
        }
    }
}
