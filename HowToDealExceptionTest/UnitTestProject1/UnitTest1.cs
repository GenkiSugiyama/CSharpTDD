using HowToDealExceptionTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ChainingAssertionを使わない正常系テスト()
        {
            Assert.AreEqual(3, Class1.Add(1, 2));
        }

        /// <summary>
        /// 例外を検知するテストには `[ExpectedException(typeof(InputException))]` をつける
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(InputException))]
        public void ChainingAssertionを使わない例外用テスト()
        {
            Assert.AreEqual(3, Class1.Add(-1, 2));
        }

        /// <summary>
        /// 上2つのテストメソッドはChainingAssertionを使用することで下のメソッドに統合できる
        /// </summary>
        [TestMethod]
        public void ChainingAssertionを使ったテストコード()
        {
            // ChainingAssertionによって正常系のテストもわかりやすく書ける
            // {メソッドやプロパティ呼び出し}.Is(期待値)で結果をテストできる
            Class1.Add(3, 2).Is(6);

            // ChainingAssertion
            // AssertEx.Throws()で意図したエラーが返ってくるかが確認可能
            // Throws()のコールバック関数としてテストしたいクラスのメソッドを書く
            var ex = AssertEx.Throws<InputException>(() => Class1.Add(-1, 2));
            // AssetEx.Throws()は指定した型を受け取ることもできるので今回だとエラーのメッセージ内容まで確認可能
            ex.Message.Is("マイナス値は入力できません");
        }
    }
}
