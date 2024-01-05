using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD.UI;

namespace TDD.Test.Tests
{
	[TestClass]
	public class Form1ViewModelTest
	{
		[TestMethod]
		public void シナリオテスト()
		{
			var viewModel = new Form1ViewModel();
			// Viewの初期状態（テキストボックスが空など）を確認する
			Assert.AreEqual("", viewModel.ATextBoxText);
			Assert.AreEqual("", viewModel.BTextBoxText);
			Assert.AreEqual("", viewModel.ResultLabelText);

			// プロパティに直接値を代入し、ボタンクリックメソッドを追加・実行した後にResultLabelに数値文字列が入っているかを確認している
			viewModel.ATextBoxText = "2";
			viewModel.BTextBoxText = "5";
			viewModel.CalculationAction();
			Assert.AreEqual("7", viewModel.ResultLabelText);
		}
	}
}
