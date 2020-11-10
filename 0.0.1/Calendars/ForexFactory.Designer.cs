namespace My.Calendars
{
	partial class ForexFactory
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
			this.btnUpload = new System.Windows.Forms.Button();
			this.groupBoxCalendarType = new System.Windows.Forms.GroupBox();
			this.rbtnMetal = new System.Windows.Forms.RadioButton();
			this.rbtnForex = new System.Windows.Forms.RadioButton();
			this.groupBoxCalendarType.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnUpload
			// 
			this.btnUpload.Location = new System.Drawing.Point(183, 83);
			this.btnUpload.Name = "btnUpload";
			this.btnUpload.Size = new System.Drawing.Size(75, 23);
			this.btnUpload.TabIndex = 0;
			this.btnUpload.Text = "Upload";
			this.btnUpload.UseVisualStyleBackColor = true;
			this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
			// 
			// groupBoxCalendarType
			// 
			this.groupBoxCalendarType.Controls.Add(this.rbtnMetal);
			this.groupBoxCalendarType.Controls.Add(this.rbtnForex);
			this.groupBoxCalendarType.Location = new System.Drawing.Point(12, 12);
			this.groupBoxCalendarType.Name = "groupBoxCalendarType";
			this.groupBoxCalendarType.Size = new System.Drawing.Size(246, 56);
			this.groupBoxCalendarType.TabIndex = 1;
			this.groupBoxCalendarType.TabStop = false;
			this.groupBoxCalendarType.Text = "Calendar Type";
			// 
			// rbtnMetal
			// 
			this.rbtnMetal.AutoSize = true;
			this.rbtnMetal.Location = new System.Drawing.Point(67, 23);
			this.rbtnMetal.Name = "rbtnMetal";
			this.rbtnMetal.Size = new System.Drawing.Size(55, 19);
			this.rbtnMetal.TabIndex = 1;
			this.rbtnMetal.TabStop = true;
			this.rbtnMetal.Text = "Metal";
			this.rbtnMetal.UseVisualStyleBackColor = true;
			// 
			// rbtnForex
			// 
			this.rbtnForex.AutoSize = true;
			this.rbtnForex.Checked = true;
			this.rbtnForex.Location = new System.Drawing.Point(7, 23);
			this.rbtnForex.Name = "rbtnForex";
			this.rbtnForex.Size = new System.Drawing.Size(54, 19);
			this.rbtnForex.TabIndex = 0;
			this.rbtnForex.TabStop = true;
			this.rbtnForex.Text = "Forex";
			this.rbtnForex.UseVisualStyleBackColor = true;
			// 
			// ForexFactory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(275, 132);
			this.Controls.Add(this.groupBoxCalendarType);
			this.Controls.Add(this.btnUpload);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "ForexFactory";
			this.Text = "ForexFactory";
			this.groupBoxCalendarType.ResumeLayout(false);
			this.groupBoxCalendarType.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnUpload;
		private System.Windows.Forms.GroupBox groupBoxCalendarType;
		private System.Windows.Forms.RadioButton rbtnForex;
		private System.Windows.Forms.RadioButton rbtnMetal;
	}
}