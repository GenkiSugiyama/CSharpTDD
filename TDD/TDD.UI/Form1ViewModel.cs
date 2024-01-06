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
		//WEbForms上の入出力に関連のコントロールに対応するプロパティを作ることで画面(View)に対応したモデル(ViewModel)を作成する
		//private System.Windows.Forms.TextBox ATextBox;
		//private System.Windows.Forms.TextBox BTextBox;
		//private System.Windows.Forms.Label label1;
		//private System.Windows.Forms.Label label2;
		//private System.Windows.Forms.Label ResultLabel;
		//private System.Windows.Forms.Button CalculationButton;

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

        public void CalculationAction()
		{
			int a = Convert.ToInt32(ATextBoxText);
			int b = Convert.ToInt32(BTextBoxText);

			ResultLabelText = Calculation.Sum(a, b).ToString();
		}
	}
}
