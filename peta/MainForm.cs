using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace peta
{
	public partial class MainForm : Form
	{
		private ZoneForm zoneForm;

		public Rectangle buttonsRect;
		public Rectangle tableRect;
		public Rectangle handRect;

		private TesseractEngine engine = new TesseractEngine(@".\tessdata", "eng", EngineMode.Default);

		public MainForm()
		{
			InitializeComponent();
		}

		private void configureZonesBtn_Click(object sender, EventArgs e)
		{
			ShowZonesConfigurator("buttons");
		}

		private Bitmap GetImage(Rectangle rect)
		{
			Bitmap bmp = new Bitmap(rect.Width, rect.Height);
			using (Graphics g = Graphics.FromImage(bmp))
			{
				g.CopyFromScreen(new Point(rect.X, rect.Y), Point.Empty, new Size(rect.Width, rect.Height));
			}
			return bmp;
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			Task task = new Task(() =>
			{
				while (true)
				{
					if (tableRect.Width != 0)
					{
						Bitmap tableBmp = GetImage(tableRect);

						//int yGreen = 0;

						//for (int i = 0; i < tableBmp.Width; i++)
						//{
						//	for (int j = 0; j < tableBmp.Height; j++)
						//	{
						//		Color c = tableBmp.GetPixel(i, j);

						//		if (c.R > 120 && c.G < 120 && c.B < 120)
						//		{
						//			c = Color.FromArgb(255, 0, 0);
						//		}
						//		else if (c.R < 130 && c.G < 130 && c.B < 130)
						//		{
						//			c = Color.FromArgb(0, 0, 255);
						//		}
						//		else if ((c.R > 190 && c.G > 180 && c.B > 150) && (c.R < 240 && c.G < 230 && c.B < 210))
						//		{
						//			c = Color.FromArgb(0, 255, 0);

						//			if (yGreen == 0)
						//			{
						//				yGreen = j - 1;
						//			}
						//		}
						//		else
						//		{
						//			c = Color.FromArgb(255, 255, 255);
						//		}

						//		tableBmp.SetPixel(i, j, c);

						//		if (i < tableBmp.Width / 5)
						//		{
						//			//if (c.R == 0 && c.B)
						//		}
						//		else if ((i > tableBmp.Width / 5) && (i < tableBmp.Width / 5 * 2))
						//		{

						//		}
						//		else if ((i > tableBmp.Width / 5 * 2) && (i < tableBmp.Width / 5 * 3))
						//		{

						//		}
						//		else if ((i > tableBmp.Width / 5 * 3) && (i < tableBmp.Width / 5 * 4))
						//		{

						//		}
						//		else if (i > tableBmp.Width / 5 * 4)
						//		{

						//		}
						//	}
						//}

						//Bitmap tessaBmp = tableBmp.Clone(new Rectangle(0, 0, tableBmp.Width, yGreen), PixelFormat.Format24bppRgb);

						MemoryStream ms = new MemoryStream();
						tableBmp.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
						var bytes = ms.ToArray();

						using (var page = engine.Process(Pix.LoadFromMemory(bytes)))
						{
							tableTextBox.Invoke((MethodInvoker)(() => tableTextBox.Text = page.GetText()));
							//Console.WriteLine("text=" + page.GetText());
						}

						UpdatePictureBox(tablePictureBox, tableBmp);
					}
					
					//UpdatePictureBox(handRect, handPictureBox);

					Thread.Sleep(250);
				}
			});
			task.Start();
		}

		public void UpdatePictureBox(PictureBox pBox, Bitmap bmp)
		{
			if (pBox.Image != null)
			{
				pBox.Image.Dispose();
			}
			pBox.Invoke((MethodInvoker)(() => pBox.Image = bmp));
		}

		public void ShowZonesConfigurator(string zone)
		{
			if (zoneForm == null || zoneForm.IsDisposed)
			{
				zoneForm = new ZoneForm(zone);
				zoneForm.Owner = this;
				zoneForm.Show();
			}
		}

		private void handConfBtn_Click(object sender, EventArgs e)
		{
			ShowZonesConfigurator("hand");
		}

		private void tableConfBtn_Click(object sender, EventArgs e)
		{
			ShowZonesConfigurator("table");
		}
	}
}
