using Microsoft.VisualStudio.TestTools.UnitTesting;
using v2rayP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v2rayP.Model.Tests
{
    [TestClass()]
    public class V2RayVersionTests
    {
        [TestMethod()]
        public void V2RayVersionComparationTest()
        {
            var version1 = new V2RayVersion(1, 0);
            var version2 = new V2RayVersion(1, 1);
            var version3 = new V2RayVersion(2, 0);
            var version4 = new V2RayVersion(1, 0);

            Assert.IsTrue(version1 >= version4);
            Assert.IsTrue(version4 <= version1);

            Assert.IsTrue(version2 > version1);
            Assert.IsTrue(version2 >= version1);
            Assert.IsTrue(version3 > version1);
            Assert.IsTrue(version3 >= version1);

            Assert.IsTrue(version1 < version2);
            Assert.IsTrue(version1 <= version2);
            Assert.IsTrue(version1 < version3);
            Assert.IsTrue(version1 <= version3);

            Assert.IsTrue(version3 > version2);
            Assert.IsTrue(version3 >= version2);

            Assert.IsTrue(version2 < version3);
            Assert.IsTrue(version2 <= version3);
        }
    }
}