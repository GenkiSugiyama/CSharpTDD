using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD.UI;
using Moq;

namespace TDD.Test.Tests
{
	[TestClass]
	public class Form1ViewModelTest
	{
		[TestMethod]
		public void シナリオテスト()
		{
			// Moqを入れるとMockクラスを自作する必要がなくなる
			var mock = new Mock<IDB>();
			// Setup().Returns()でテストに使用するメソッドの返り値を指定する
			mock.Setup(x => x.GetDBValue()).Returns(100);
			// mock.Objectに実際のインスタンスが入っているのでそれを注入する
			var viewModel = new Form1ViewModel(mock.Object);

			// Viewの初期状態（テキストボックスが空など）を確認する
			Assert.AreEqual("", viewModel.ATextBoxText);
			Assert.AreEqual("", viewModel.BTextBoxText);
			Assert.AreEqual("", viewModel.ResultLabelText);

			// プロパティに直接値を代入し、ボタンクリックメソッドを追加・実行した後にResultLabelに数値文字列が入っているかを確認している
			viewModel.ATextBoxText = "2";
			viewModel.BTextBoxText = "5";

			// DBの値を加算する変更が加わった際のテストについて
			// 単体テストではDBとの接続・レコードの取得は問題なくできている前提でC#上のコードのロジックが問題ないかを確認する
			// そのためテスト時には直接DBから値をとらずにDBから取得する値と同じ型の値を返すメソッドをもつMockクラスを使用する
			// インタフェースを切って本番用クラスとテスト用Mockクラスで実装コードを書き、本番環境では本番クラスをテスト環境ではMockクラスを使用して動作させる
			viewModel.CalculationAction();
			Assert.AreEqual("107", viewModel.ResultLabelText);
		}
	}
}
