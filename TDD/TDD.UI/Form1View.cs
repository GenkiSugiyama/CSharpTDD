using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDD.UI
{
	public partial class Form1View : Form
	{
		// ViewにViewModelを持たせる
		// 本番用のコードでは本番用DBクラスを注入する
		private Form1ViewModel _viewModel = new Form1ViewModel(new DB());
		public Form1View()
		{
			InitializeComponent();

			// コントロールとViewModelプロパティを紐づけるためにDataBindings.Addを使用する
			ATextBox.DataBindings.Add("Text", _viewModel, "ATextBoxText");
			BTextBox.DataBindings.Add("Text", _viewModel, "BTextBoxText");
			ResultLabel.DataBindings.Add("Text", _viewModel, "ResultLabelText");
        }

        private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void CalculationButton_Click(object sender, EventArgs e)
		{
			// 画面上のアクションが発生したらViewModelのメソッドを呼び出す
			_viewModel.CalculationAction();
		}
    }
}
