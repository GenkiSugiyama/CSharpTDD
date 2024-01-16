using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.UI
{
	// View上の変更をViewModelに通知（ViewとViewModelの連動）するためにINotifyPropertyChangedをViewModelで実装する
	public class Form1ViewModel : INotifyPropertyChanged
	{
		
		private IDB _db;

        // インタフェースをプライベート変数として持つようにする
        // このクラスを使用する際の初期化時に外から本番用のDBクラスかテスト用のDBMockクラスかを注入する（実装者が選べる）
        public Form1ViewModel(IDB db)
		{
			_db = db;
		}

		// INotifyPropertyChangedの実装（プロパティ・メソッド）
		public event PropertyChangedEventHandler PropertyChanged;
		public void OnPropertyChanged(string propertyName)
		{
			if(PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// OnPropertyChanged メソッドはプロパティのセッター内に記述
		// 別の値がセットされたタイミングでOnPropertyChangedを呼び出すことでView側に変更を通知する
		private string _aTextBoxText = string.Empty;
		public string ATextBoxText
		{
			get { return _aTextBoxText; }
			set
			{
				if (_aTextBoxText == value) return;

				_aTextBoxText= value;
				OnPropertyChanged("ATextBoxText");
			}
		}

		private string _bTextBoxText = string.Empty;
		public string BTextBoxText
		{
			get { return _bTextBoxText; }
			set
			{
				if (_bTextBoxText == value) return;

				_bTextBoxText = value;
				OnPropertyChanged("BTextBoxText");
			}
		}

        private string _resultLabelText = string.Empty;
		public string ResultLabelText
		{
			get { return _resultLabelText; }
			set
			{
				if (_resultLabelText == value) return;

				_resultLabelText = value;
				OnPropertyChanged("ResultLabelText");
			}
		}

        private string _productIdTextBoxText = string.Empty;
        public string ProductIdTextBoxText
        {
            get { return _productIdTextBoxText; }
            set
            {
                if (_productIdTextBoxText == value) return;

                _productIdTextBoxText = value;
                OnPropertyChanged("ProductIdTextBoxText");
            }
        }

        private string _productNameTextBoxText = string.Empty;
        public string ProductNameTextBoxText
        {
            get { return _productNameTextBoxText; }
            set
            {
                if (_productNameTextBoxText == value) return;

                _productNameTextBoxText = value;
                OnPropertyChanged("ProductIdTextBoxText");
            }
        }

        public void CalculationAction()
		{
			int a = Convert.ToInt32(ATextBoxText);
			int b = Convert.ToInt32(BTextBoxText);

			// 画面の入力値にDBからの値を足し合わせる機能に変更
			int dbValue = _db.GetDBValue();
			ResultLabelText = (Calculation.Sum(a, b) + dbValue).ToString();
		}

        public void ProductCommand()
        {
			Product product = _db.GetProduct();
			ProductIdTextBoxText = product.ProductId.ToString();
			ProductNameTextBoxText = product.ProductName.ToString();
        }

        public void Save()
        {
			var product = new Product(
				Convert.ToInt32(ProductIdTextBoxText),
				ProductNameTextBoxText);

			_db.SaveProduct(product);
        }
    }
}
