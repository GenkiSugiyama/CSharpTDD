using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD.Test.Tests
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var val = TDD.UI.Calculation.Sum(2, 5);
			Assert.AreEqual(7, val);
		}

		[TestMethod]
		public void 平均値を取得できること()
		{
			var list = new List<int> { 1, 2, 3, 4, 5 };
			var result = TDD.UI.Calculation.Ave(list);
			Assert.AreEqual(5, result);
		}
	}
}
