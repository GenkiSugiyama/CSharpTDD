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
			// テストコードを動かす際はテスト用DBMockを注入する
			var viewModel = new Form1ViewModel(new DBMock());

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

	// テスト環境用のMockクラス
	// テストコードを動かす際はこのクラスを使用して値を取得する
	public class DBMock : IDB
	{
		public int GetDBValue()
		{
			return 100;
		}
	}
}
