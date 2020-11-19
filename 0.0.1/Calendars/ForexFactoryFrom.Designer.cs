namespace My.Calendars
{
	partial class ForexFactoryFrom
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
			this.cboCalendarType = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cboCurrencyOne = new System.Windows.Forms.ComboBox();
			this.cboCurrencyTwo = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cboCountryOne = new System.Windows.Forms.ComboBox();
			this.cboCountryTwo = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnFolder = new System.Windows.Forms.Button();
			this.txtProcessedFolderAddress = new System.Windows.Forms.TextBox();
			this.btnProperties = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.cboStrategy = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// btnUpload
			// 
			this.btnUpload.Location = new System.Drawing.Point(124, 213);
			this.btnUpload.Name = "btnUpload";
			this.btnUpload.Size = new System.Drawing.Size(162, 64);
			this.btnUpload.TabIndex = 0;
			this.btnUpload.Text = "Upload and Process";
			this.btnUpload.UseVisualStyleBackColor = true;
			this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
			// 
			// cboCalendarType
			// 
			this.cboCalendarType.FormattingEnabled = true;
			this.cboCalendarType.Location = new System.Drawing.Point(128, 8);
			this.cboCalendarType.Name = "cboCalendarType";
			this.cboCalendarType.Size = new System.Drawing.Size(158, 23);
			this.cboCalendarType.TabIndex = 1;
			this.cboCalendarType.SelectedIndexChanged += new System.EventHandler(this.cboCalendarType_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "Calendar Type:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "Forex Pairs:";
			// 
			// cboCurrencyOne
			// 
			this.cboCurrencyOne.FormattingEnabled = true;
			this.cboCurrencyOne.Location = new System.Drawing.Point(128, 35);
			this.cboCurrencyOne.Name = "cboCurrencyOne";
			this.cboCurrencyOne.Size = new System.Drawing.Size(76, 23);
			this.cboCurrencyOne.TabIndex = 1;
			// 
			// cboCurrencyTwo
			// 
			this.cboCurrencyTwo.FormattingEnabled = true;
			this.cboCurrencyTwo.Location = new System.Drawing.Point(210, 35);
			this.cboCurrencyTwo.Name = "cboCurrencyTwo";
			this.cboCurrencyTwo.Size = new System.Drawing.Size(76, 23);
			this.cboCurrencyTwo.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 15);
			this.label3.TabIndex = 3;
			this.label3.Text = "Metal Countries:";
			// 
			// cboCountryOne
			// 
			this.cboCountryOne.Enabled = false;
			this.cboCountryOne.FormattingEnabled = true;
			this.cboCountryOne.Location = new System.Drawing.Point(128, 64);
			this.cboCountryOne.Name = "cboCountryOne";
			this.cboCountryOne.Size = new System.Drawing.Size(76, 23);
			this.cboCountryOne.TabIndex = 1;
			// 
			// cboCountryTwo
			// 
			this.cboCountryTwo.Enabled = false;
			this.cboCountryTwo.FormattingEnabled = true;
			this.cboCountryTwo.Location = new System.Drawing.Point(210, 64);
			this.cboCountryTwo.Name = "cboCountryTwo";
			this.cboCountryTwo.Size = new System.Drawing.Size(76, 23);
			this.cboCountryTwo.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 153);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(113, 15);
			this.label4.TabIndex = 4;
			this.label4.Text = "Process Data Folder:";
			// 
			// btnFolder
			// 
			this.btnFolder.Location = new System.Drawing.Point(211, 178);
			this.btnFolder.Name = "btnFolder";
			this.btnFolder.Size = new System.Drawing.Size(75, 23);
			this.btnFolder.TabIndex = 5;
			this.btnFolder.Text = "Browse";
			this.btnFolder.UseVisualStyleBackColor = true;
			this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
			// 
			// txtProcessedFolderAddress
			// 
			this.txtProcessedFolderAddress.Enabled = false;
			this.txtProcessedFolderAddress.Location = new System.Drawing.Point(16, 178);
			this.txtProcessedFolderAddress.Name = "txtProcessedFolderAddress";
			this.txtProcessedFolderAddress.Size = new System.Drawing.Size(188, 23);
			this.txtProcessedFolderAddress.TabIndex = 6;
			// 
			// btnProperties
			// 
			this.btnProperties.Location = new System.Drawing.Point(128, 125);
			this.btnProperties.Name = "btnProperties";
			this.btnProperties.Size = new System.Drawing.Size(158, 23);
			this.btnProperties.TabIndex = 8;
			this.btnProperties.Text = "Properties";
			this.btnProperties.UseVisualStyleBackColor = true;
			this.btnProperties.Click += new System.EventHandler(this.btnProperties_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 127);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(82, 15);
			this.label5.TabIndex = 7;
			this.label5.Text = "Set Properties:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 99);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(53, 15);
			this.label6.TabIndex = 9;
			this.label6.Text = "Strategy:";
			// 
			// cboStrategy
			// 
			this.cboStrategy.FormattingEnabled = true;
			this.cboStrategy.Location = new System.Drawing.Point(128, 93);
			this.cboStrategy.Name = "cboStrategy";
			this.cboStrategy.Size = new System.Drawing.Size(158, 23);
			this.cboStrategy.TabIndex = 10;
			// 
			// ForexFactoryFrom
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(297, 319);
			this.Controls.Add(this.cboStrategy);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnProperties);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtProcessedFolderAddress);
			this.Controls.Add(this.btnFolder);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cboCountryTwo);
			this.Controls.Add(this.cboCountryOne);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cboCurrencyTwo);
			this.Controls.Add(this.cboCurrencyOne);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cboCalendarType);
			this.Controls.Add(this.btnUpload);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "ForexFactoryFrom";
			this.Text = "ForexFactory";
			this.Load += new System.EventHandler(this.ForexFactory_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnUpload;
		private System.Windows.Forms.ComboBox cboCalendarType;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cboCurrencyOne;
		private System.Windows.Forms.ComboBox cboCurrencyTwo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cboCountryOne;
		private System.Windows.Forms.ComboBox cboCountryTwo;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnFolder;
		private System.Windows.Forms.TextBox txtProcessedFolderAddress;
		private System.Windows.Forms.Button btnProperties;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cboStrategy;
	}
}