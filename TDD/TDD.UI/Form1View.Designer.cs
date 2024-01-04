namespace TDD.UI
{
	partial class Form1View
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.ATextBox = new System.Windows.Forms.TextBox();
			this.BTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.ResultLabel = new System.Windows.Forms.Label();
			this.CalculationButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ATextBox
			// 
			this.ATextBox.Location = new System.Drawing.Point(12, 40);
			this.ATextBox.Name = "ATextBox";
			this.ATextBox.Size = new System.Drawing.Size(48, 19);
			this.ATextBox.TabIndex = 0;
			// 
			// BTextBox
			// 
			this.BTextBox.Location = new System.Drawing.Point(107, 40);
			this.BTextBox.Name = "BTextBox";
			this.BTextBox.Size = new System.Drawing.Size(48, 19);
			this.BTextBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(78, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(11, 12);
			this.label1.TabIndex = 2;
			this.label1.Text = "+";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(173, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(11, 12);
			this.label2.TabIndex = 3;
			this.label2.Text = "=";
			// 
			// ResultLabel
			// 
			this.ResultLabel.AutoSize = true;
			this.ResultLabel.Location = new System.Drawing.Point(201, 43);
			this.ResultLabel.Name = "ResultLabel";
			this.ResultLabel.Size = new System.Drawing.Size(23, 12);
			this.ResultLabel.TabIndex = 4;
			this.ResultLabel.Text = "xxx";
			// 
			// CalculationButton
			// 
			this.CalculationButton.Location = new System.Drawing.Point(45, 89);
			this.CalculationButton.Name = "CalculationButton";
			this.CalculationButton.Size = new System.Drawing.Size(75, 23);
			this.CalculationButton.TabIndex = 5;
			this.CalculationButton.Text = "計算";
			this.CalculationButton.UseVisualStyleBackColor = true;
			this.CalculationButton.Click += new System.EventHandler(this.CalculationButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.CalculationButton);
			this.Controls.Add(this.ResultLabel);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.BTextBox);
			this.Controls.Add(this.ATextBox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox ATextBox;
		private System.Windows.Forms.TextBox BTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label ResultLabel;
		private System.Windows.Forms.Button CalculationButton;
	}
}

