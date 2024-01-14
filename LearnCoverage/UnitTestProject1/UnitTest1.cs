using ClassLibrary1;
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
            Class1.Add(1, 2).Is(3);
            Class1.Add2(1, 2, 3).Is(6);
            Class1.Add3(1, 2).Is(3);
            Class1.Add3(0, 2).Is(0);
        }
    }
}
