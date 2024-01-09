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

            // ChainingAssertion
            // AssertEx.Throws()で意図したエラーが返ってくるかが確認可能
            // Throws()のコールバック関数としてテストしたいクラスのメソッドを書く
            AssertEx.Throws<InputException>(() => Class1.Add(-1, 2));

            // AssetEx.Throws()は指定した型を受け取ることもできるので今回だとエラーのメッセージ内容まで確認可能
            var ex = AssertEx.Throws<InputException>(() => Class1.Add(-1, 2)); // ←でexにthrowｓされたエラーが入る
            Assert.AreEqual("マイナス値は入力できません", ex.Message); // ←ex.Message.Is("マイナス値は入力できません") とも書ける

            // ChainingAssertionによって正常系のテストもわかりやすく書ける
            // {メソッドやプロパティ呼び出し}.Is(期待値)で結果をテストできる
            Class1.Add(1, 2).Is(3);
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
