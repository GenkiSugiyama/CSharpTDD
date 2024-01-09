using HowToDealExceptionTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(3, Class1.Add(1, 2));
        }

        /// <summary>
        /// 例外を検知するテストには `[ExpectedException(typeof(InputException))]` をつける
        /// 1つのメソッドに対するテストを正常系・異常系と複数かかないといけないからちょっと不便・・・
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(InputException))]
        public void 例外用テスト()
        {
            Assert.AreEqual(3, Class1.Add(-1, 2));
        }
    }
}
