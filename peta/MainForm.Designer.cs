namespace peta
{
	partial class MainForm
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
			this.buttonsConfBtn = new System.Windows.Forms.Button();
			this.buttonsPictureBox = new System.Windows.Forms.PictureBox();
			this.buttonsLabel = new System.Windows.Forms.Label();
			this.handPictureBox = new System.Windows.Forms.PictureBox();
			this.handConfBtn = new System.Windows.Forms.Button();
			this.handLabel = new System.Windows.Forms.Label();
			this.handTextBox = new System.Windows.Forms.TextBox();
			this.tablePictureBox = new System.Windows.Forms.PictureBox();
			this.tableLabel = new System.Windows.Forms.Label();
			this.tableConfBtn = new System.Windows.Forms.Button();
			this.tableTextBox = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.buttonsPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.handPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tablePictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonsConfBtn
			// 
			this.buttonsConfBtn.Location = new System.Drawing.Point(126, 6);
			this.buttonsConfBtn.Name = "buttonsConfBtn";
			this.buttonsConfBtn.Size = new System.Drawing.Size(70, 21);
			this.buttonsConfBtn.TabIndex = 0;
			this.buttonsConfBtn.Text = "configure";
			this.buttonsConfBtn.UseVisualStyleBackColor = true;
			this.buttonsConfBtn.Click += new System.EventHandler(this.configureZonesBtn_Click);
			// 
			// buttonsPictureBox
			// 
			this.buttonsPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.buttonsPictureBox.Location = new System.Drawing.Point(16, 33);
			this.buttonsPictureBox.Name = "buttonsPictureBox";
			this.buttonsPictureBox.Size = new System.Drawing.Size(180, 120);
			this.buttonsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.buttonsPictureBox.TabIndex = 1;
			this.buttonsPictureBox.TabStop = false;
			// 
			// buttonsLabel
			// 
			this.buttonsLabel.AutoSize = true;
			this.buttonsLabel.Location = new System.Drawing.Point(13, 10);
			this.buttonsLabel.Name = "buttonsLabel";
			this.buttonsLabel.Size = new System.Drawing.Size(46, 13);
			this.buttonsLabel.TabIndex = 2;
			this.buttonsLabel.Text = "Buttons:";
			// 
			// handPictureBox
			// 
			this.handPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.handPictureBox.Location = new System.Drawing.Point(508, 33);
			this.handPictureBox.Name = "handPictureBox";
			this.handPictureBox.Size = new System.Drawing.Size(180, 120);
			this.handPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.handPictureBox.TabIndex = 3;
			this.handPictureBox.TabStop = false;
			// 
			// handConfBtn
			// 
			this.handConfBtn.Location = new System.Drawing.Point(618, 6);
			this.handConfBtn.Name = "handConfBtn";
			this.handConfBtn.Size = new System.Drawing.Size(70, 21);
			this.handConfBtn.TabIndex = 4;
			this.handConfBtn.Text = "configure";
			this.handConfBtn.UseVisualStyleBackColor = true;
			this.handConfBtn.Click += new System.EventHandler(this.handConfBtn_Click);
			// 
			// handLabel
			// 
			this.handLabel.AutoSize = true;
			this.handLabel.Location = new System.Drawing.Point(508, 10);
			this.handLabel.Name = "handLabel";
			this.handLabel.Size = new System.Drawing.Size(36, 13);
			this.handLabel.TabIndex = 5;
			this.handLabel.Text = "Hand:";
			// 
			// handTextBox
			// 
			this.handTextBox.Location = new System.Drawing.Point(508, 159);
			this.handTextBox.Name = "handTextBox";
			this.handTextBox.Size = new System.Drawing.Size(180, 20);
			this.handTextBox.TabIndex = 6;
			// 
			// tablePictureBox
			// 
			this.tablePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tablePictureBox.Location = new System.Drawing.Point(202, 33);
			this.tablePictureBox.Name = "tablePictureBox";
			this.tablePictureBox.Size = new System.Drawing.Size(300, 120);
			this.tablePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.tablePictureBox.TabIndex = 7;
			this.tablePictureBox.TabStop = false;
			// 
			// tableLabel
			// 
			this.tableLabel.AutoSize = true;
			this.tableLabel.Location = new System.Drawing.Point(202, 10);
			this.tableLabel.Name = "tableLabel";
			this.tableLabel.Size = new System.Drawing.Size(37, 13);
			this.tableLabel.TabIndex = 8;
			this.tableLabel.Text = "Table:";
			// 
			// tableConfBtn
			// 
			this.tableConfBtn.Location = new System.Drawing.Point(432, 6);
			this.tableConfBtn.Name = "tableConfBtn";
			this.tableConfBtn.Size = new System.Drawing.Size(70, 21);
			this.tableConfBtn.TabIndex = 9;
			this.tableConfBtn.Text = "configure";
			this.tableConfBtn.UseVisualStyleBackColor = true;
			this.tableConfBtn.Click += new System.EventHandler(this.tableConfBtn_Click);
			// 
			// tableTextBox
			// 
			this.tableTextBox.Location = new System.Drawing.Point(202, 159);
			this.tableTextBox.Name = "tableTextBox";
			this.tableTextBox.Size = new System.Drawing.Size(180, 20);
			this.tableTextBox.TabIndex = 10;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tableTextBox);
			this.Controls.Add(this.tableConfBtn);
			this.Controls.Add(this.tableLabel);
			this.Controls.Add(this.tablePictureBox);
			this.Controls.Add(this.handTextBox);
			this.Controls.Add(this.handLabel);
			this.Controls.Add(this.handConfBtn);
			this.Controls.Add(this.handPictureBox);
			this.Controls.Add(this.buttonsLabel);
			this.Controls.Add(this.buttonsPictureBox);
			this.Controls.Add(this.buttonsConfBtn);
			this.Name = "MainForm";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.Text = "peta";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.buttonsPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.handPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tablePictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonsConfBtn;
		private System.Windows.Forms.PictureBox buttonsPictureBox;
		private System.Windows.Forms.Label buttonsLabel;
		private System.Windows.Forms.PictureBox handPictureBox;
		private System.Windows.Forms.Button handConfBtn;
		private System.Windows.Forms.Label handLabel;
		private System.Windows.Forms.TextBox handTextBox;
		private System.Windows.Forms.PictureBox tablePictureBox;
		private System.Windows.Forms.Label tableLabel;
		private System.Windows.Forms.Button tableConfBtn;
		private System.Windows.Forms.TextBox tableTextBox;
	}
}

