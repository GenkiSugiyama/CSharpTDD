using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.UI
{
	public class Form1ViewModel
	{
		//WEbForms上の入出力に関連のコントロールに対応するプロパティを作ることで画面(View)に対応したモデル(ViewModel)を作成する
		//private System.Windows.Forms.TextBox ATextBox;
		//private System.Windows.Forms.TextBox BTextBox;
		//private System.Windows.Forms.Label label1;
		//private System.Windows.Forms.Label label2;
		//private System.Windows.Forms.Label ResultLabel;
		//private System.Windows.Forms.Button CalculationButton;

		public string ATextBoxText { get; set; } = string.Empty;
		public string BTextBoxText { get; set; } = string.Empty;
		public string ResultLabelText { get; set; } = string.Empty;

		public void CalculationAction()
		{
			int a = Convert.ToInt32(ATextBoxText);
			int b = Convert.ToInt32(BTextBoxText);

			ResultLabelText = Calculation.Sum(a, b).ToString();
		}
	}
}
