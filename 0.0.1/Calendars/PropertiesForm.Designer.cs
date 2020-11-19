
namespace My.Calendars
{
	partial class PropertiesForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtNoTradeHoursBefore = new System.Windows.Forms.TextBox();
			this.txtNoTradeMaxHoursBefore = new System.Windows.Forms.TextBox();
			this.txtNoTradeHoursAfter = new System.Windows.Forms.TextBox();
			this.txtNoTradeMaxHourseAfter = new System.Windows.Forms.TextBox();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(125, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "NoTrade_HoursBefore:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(148, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "NoTrade_MaxHoursBefore:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 77);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(117, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "NoTrade_HoursAfter:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 101);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(146, 15);
			this.label4.TabIndex = 3;
			this.label4.Text = "NoTrade_MaxHourseAfter:";
			// 
			// txtNoTradeHoursBefore
			// 
			this.txtNoTradeHoursBefore.Location = new System.Drawing.Point(192, 4);
			this.txtNoTradeHoursBefore.Name = "txtNoTradeHoursBefore";
			this.txtNoTradeHoursBefore.Size = new System.Drawing.Size(88, 23);
			this.txtNoTradeHoursBefore.TabIndex = 4;
			// 
			// txtNoTradeMaxHoursBefore
			// 
			this.txtNoTradeMaxHoursBefore.Location = new System.Drawing.Point(192, 30);
			this.txtNoTradeMaxHoursBefore.Name = "txtNoTradeMaxHoursBefore";
			this.txtNoTradeMaxHoursBefore.Size = new System.Drawing.Size(88, 23);
			this.txtNoTradeMaxHoursBefore.TabIndex = 5;
			// 
			// txtNoTradeHoursAfter
			// 
			this.txtNoTradeHoursAfter.Location = new System.Drawing.Point(192, 69);
			this.txtNoTradeHoursAfter.Name = "txtNoTradeHoursAfter";
			this.txtNoTradeHoursAfter.Size = new System.Drawing.Size(88, 23);
			this.txtNoTradeHoursAfter.TabIndex = 6;
			// 
			// txtNoTradeMaxHourseAfter
			// 
			this.txtNoTradeMaxHourseAfter.Location = new System.Drawing.Point(192, 96);
			this.txtNoTradeMaxHourseAfter.Name = "txtNoTradeMaxHourseAfter";
			this.txtNoTradeMaxHourseAfter.Size = new System.Drawing.Size(88, 23);
			this.txtNoTradeMaxHourseAfter.TabIndex = 7;
			// 
			// btnSubmit
			// 
			this.btnSubmit.Location = new System.Drawing.Point(192, 137);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(88, 23);
			this.btnSubmit.TabIndex = 8;
			this.btnSubmit.Text = "Submit";
			this.btnSubmit.UseVisualStyleBackColor = true;
			// 
			// PropertiesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(295, 175);
			this.Controls.Add(this.btnSubmit);
			this.Controls.Add(this.txtNoTradeMaxHourseAfter);
			this.Controls.Add(this.txtNoTradeHoursAfter);
			this.Controls.Add(this.txtNoTradeMaxHoursBefore);
			this.Controls.Add(this.txtNoTradeHoursBefore);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "PropertiesForm";
			this.Text = "Properties Form";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtNoTradeHoursBefore;
		private System.Windows.Forms.TextBox txtNoTradeMaxHoursBefore;
		private System.Windows.Forms.TextBox txtNoTradeHoursAfter;
		private System.Windows.Forms.TextBox txtNoTradeMaxHourseAfter;
		private System.Windows.Forms.Button btnSubmit;
	}
}