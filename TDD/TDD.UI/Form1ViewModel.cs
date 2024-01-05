using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.UI
{
	public class Form1ViewModel
	{
		//WEbForms上の入出力に関連のコントローラーに対応するプロパティを作ることで画面(View)に対応したモデル(ViewModel)を作成する
		//private System.Windows.Forms.TextBox ATextBox;
		//private System.Windows.Forms.TextBox BTextBox;
		//private System.Windows.Forms.Label label1;
		//private System.Windows.Forms.Label label2;
		//private System.Windows.Forms.Label ResultLabel;
		//private System.Windows.Forms.Button CalculationButton;

		public string ATextBox{ get; set; }
		public string BTextBox { get; set; }
		public string ResultLabel { get; set; }
	}
}
