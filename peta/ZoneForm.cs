using System;
using System.Drawing;
using System.Windows.Forms;

namespace peta
{
	public partial class ZoneForm : Form
	{
		private const int WM_NCLBUTTONDOWN = 0xA1;
		private const int HT_CAPTION = 0x2;

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern bool ReleaseCapture();

		private bool shiftDown = false;
		private string destination;

		public ZoneForm(string destination)
		{
			this.destination = destination;

			InitializeComponent();

			this.MouseWheel += ZoneForm_MouseWheel;
		}

		private void ZoneForm_MouseWheel(object sender, MouseEventArgs e)
		{
			if (e.Delta > 0)
			{
				if (shiftDown)
				{
					this.Height -= 4;
				}
				else
				{
					this.Width -= 4;
				}

				this.Refresh();
			}
			else if (e.Delta < 0)
			{
				if (shiftDown)
				{
					this.Height += 4;
				}
				else
				{
					this.Width += 4;
				}

				this.Refresh();
			}
		}

		private void ZoneForm_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.DrawRectangle(new Pen(Color.Red, 2), new Rectangle(
				this.ClientRectangle.X + 1,
				this.ClientRectangle.Y + 1,
				this.ClientRectangle.Width - 2,
				this.ClientRectangle.Height - 2
			));
		}

		private void ZoneForm_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		private void ZoneForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Shift)
			{
				shiftDown = true;
				shiftLabel.Visible = true;
			}
			else if (e.KeyCode == Keys.Enter)
			{
				this.Close();
			}
		}

		private void ZoneForm_KeyUp(object sender, KeyEventArgs e)
		{
			shiftDown = false;
			shiftLabel.Visible = false;
		}

		private void ZoneForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Rectangle rect = new Rectangle(
				this.Location.X,
				this.Location.Y,
				this.Width,
				this.Height
			);

			switch (destination)
			{
				case "buttons":
					(this.Owner as MainForm).buttonsRect = rect;
					break;
				case "hand":
					(this.Owner as MainForm).handRect = rect;
					break;
				case "table":
					(this.Owner as MainForm).tableRect = rect;
					break;
			}
		}
	}
}
