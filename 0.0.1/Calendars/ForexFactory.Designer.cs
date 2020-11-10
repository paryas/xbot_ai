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
			this.cboCalendarType = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cboFirstPair = new System.Windows.Forms.ComboBox();
			this.cboSecondPair = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cboFirstCountry = new System.Windows.Forms.ComboBox();
			this.cboSecondCountry = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnFolder = new System.Windows.Forms.Button();
			this.txtFolder = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnUpload
			// 
			this.btnUpload.Location = new System.Drawing.Point(124, 185);
			this.btnUpload.Name = "btnUpload";
			this.btnUpload.Size = new System.Drawing.Size(162, 64);
			this.btnUpload.TabIndex = 0;
			this.btnUpload.Text = "Upload";
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
			this.label2.Size = new System.Drawing.Size(61, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "Forx Pairs:";
			// 
			// cboFirstPair
			// 
			this.cboFirstPair.FormattingEnabled = true;
			this.cboFirstPair.Location = new System.Drawing.Point(128, 35);
			this.cboFirstPair.Name = "cboFirstPair";
			this.cboFirstPair.Size = new System.Drawing.Size(76, 23);
			this.cboFirstPair.TabIndex = 1;
			// 
			// cboSecondPair
			// 
			this.cboSecondPair.FormattingEnabled = true;
			this.cboSecondPair.Location = new System.Drawing.Point(210, 35);
			this.cboSecondPair.Name = "cboSecondPair";
			this.cboSecondPair.Size = new System.Drawing.Size(76, 23);
			this.cboSecondPair.TabIndex = 1;
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
			// cboFirstCountry
			// 
			this.cboFirstCountry.Enabled = false;
			this.cboFirstCountry.FormattingEnabled = true;
			this.cboFirstCountry.Location = new System.Drawing.Point(128, 64);
			this.cboFirstCountry.Name = "cboFirstCountry";
			this.cboFirstCountry.Size = new System.Drawing.Size(76, 23);
			this.cboFirstCountry.TabIndex = 1;
			// 
			// cboSecondCountry
			// 
			this.cboSecondCountry.Enabled = false;
			this.cboSecondCountry.FormattingEnabled = true;
			this.cboSecondCountry.Location = new System.Drawing.Point(210, 64);
			this.cboSecondCountry.Name = "cboSecondCountry";
			this.cboSecondCountry.Size = new System.Drawing.Size(76, 23);
			this.cboSecondCountry.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 125);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(113, 15);
			this.label4.TabIndex = 4;
			this.label4.Text = "Process Data Folder:";
			// 
			// btnFolder
			// 
			this.btnFolder.Location = new System.Drawing.Point(211, 150);
			this.btnFolder.Name = "btnFolder";
			this.btnFolder.Size = new System.Drawing.Size(75, 23);
			this.btnFolder.TabIndex = 5;
			this.btnFolder.Text = "Browse";
			this.btnFolder.UseVisualStyleBackColor = true;
			this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
			// 
			// txtFolder
			// 
			this.txtFolder.Enabled = false;
			this.txtFolder.Location = new System.Drawing.Point(16, 150);
			this.txtFolder.Name = "txtFolder";
			this.txtFolder.Size = new System.Drawing.Size(188, 23);
			this.txtFolder.TabIndex = 6;
			// 
			// button1
			// 
			this.button1.Enabled = false;
			this.button1.Location = new System.Drawing.Point(128, 97);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(158, 23);
			this.button1.TabIndex = 8;
			this.button1.Text = "Variables";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 101);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(75, 15);
			this.label5.TabIndex = 7;
			this.label5.Text = "Set Variables:";
			// 
			// ForexFactory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(297, 262);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtFolder);
			this.Controls.Add(this.btnFolder);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cboSecondCountry);
			this.Controls.Add(this.cboFirstCountry);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cboSecondPair);
			this.Controls.Add(this.cboFirstPair);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cboCalendarType);
			this.Controls.Add(this.btnUpload);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "ForexFactory";
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
		private System.Windows.Forms.ComboBox cboFirstPair;
		private System.Windows.Forms.ComboBox cboSecondPair;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cboFirstCountry;
		private System.Windows.Forms.ComboBox cboSecondCountry;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnFolder;
		private System.Windows.Forms.TextBox txtFolder;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label5;
	}
}