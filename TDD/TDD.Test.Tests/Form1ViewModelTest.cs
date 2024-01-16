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
			// new Mock<> でテスト対象となるクラスを指定しモックインスタンスを作成
			var mock = new Mock<IDB>();
			// Setup().Returns()でテストに使用するメソッドの返り値を定義する
			// 本来の実装を走らせて確認するのではなくモック用に単純に返り値を上書きしている
			mock.Setup(x => x.GetDBValue()).Returns(200);
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
			Assert.AreEqual("207", viewModel.ResultLabelText);
		}

        [TestMethod]
        public void シナリオテスト2()
		{
            var mock = new Mock<IDB>();
			var product = new Product(1, "sampleProduct");
            mock.Setup(x => x.GetProduct()).Returns(product);
            var viewModel = new Form1ViewModel(mock.Object);

			viewModel.ProductCommand();
			Assert.AreEqual("1", viewModel.ProductIdTextBoxText);
			Assert.AreEqual("sampleProduct", viewModel.ProductNameTextBoxText);

            // 画面上で取得してきた値を変更→保存するときのDB更新までのバックエンド側のテスト
            // ※更新系のテストでは、で永続化される直前に画面から渡しているデータが正しいかどうかを確認する
            // 例：ProductNameを更新したとする
            viewModel.ProductNameTextBoxText = "updateProduct";

            // Form1ViewModelのSaveメソッドが呼ばれた際にDBに永続化をかけに行く想定

            // viewModel.Save()の内部でIDBクラスのSaveProduct()が呼ばれるとする
            // そのメソッドとメソッド実行後の期待される値を下記のように定義する
			// It.IsAny<> で引数のデータの型を指定している このデータ型の引数が入ればモック用に定義するメソッドが呼ばれる
			// Callback<> でメソッドが受け取る引数を定義し、Callback内のラムダ式でモック用メソッドが呼び出された際の実行内容を定義する
            mock.Setup(x => x.SaveProduct(It.IsAny<Product>())).
                Callback<Product>(saveValue =>
                {
                    Assert.AreEqual(1, saveValue.ProductId);
                    Assert.AreEqual("updateProduct", saveValue.ProductName);
                });

            viewModel.Save();

			// Mock.VerifyAll() でモックに定義されたテスト用メソッドがすべてテストされたか（モックが動いたか）を確認する
			mock.VerifyAll();
        }

    }
}
