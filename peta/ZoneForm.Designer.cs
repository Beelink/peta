namespace peta
{
	partial class ZoneForm
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
			this.shiftLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Red;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(148, 39);
			this.label1.TabIndex = 0;
			this.label1.Text = "mouse wheel to change width\r\n(+shift to change width)\r\nenter to ok";
			// 
			// shiftLabel
			// 
			this.shiftLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.shiftLabel.AutoSize = true;
			this.shiftLabel.BackColor = System.Drawing.Color.Red;
			this.shiftLabel.Location = new System.Drawing.Point(12, 195);
			this.shiftLabel.Name = "shiftLabel";
			this.shiftLabel.Size = new System.Drawing.Size(66, 13);
			this.shiftLabel.TabIndex = 1;
			this.shiftLabel.Text = "shift pressed";
			this.shiftLabel.Visible = false;
			// 
			// ZoneForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Blue;
			this.ClientSize = new System.Drawing.Size(318, 217);
			this.Controls.Add(this.shiftLabel);
			this.Controls.Add(this.label1);
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.KeyPreview = true;
			this.MinimumSize = new System.Drawing.Size(64, 64);
			this.Name = "ZoneForm";
			this.Text = "ZoneForm";
			this.TransparencyKey = System.Drawing.Color.Blue;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ZoneForm_FormClosing);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.ZoneForm_Paint);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ZoneForm_KeyDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ZoneForm_KeyUp);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ZoneForm_MouseDown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label shiftLabel;
	}
}