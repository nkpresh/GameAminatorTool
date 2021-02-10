using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace GamerTool
{
    public partial class GamerTool : Form
    {
        public GamerTool()
        {
            InitializeComponent();
        }
        public readonly List<Bitmap> AnimationImages = new List<Bitmap>();
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            decimal number = (1000 / TimeInterval.Value);
            int LineSpeed = runningPanel.Width / AnimationImages.Count;
            timer1.Interval = (int)number;
            if (i < AnimationImages.Count)
            {
                Canvas.Image = AnimationImages[i];
                runningLine.Left += LineSpeed;

            }
            else
            {
                i = 0;
                Canvas.Image = AnimationImages[i];
                runningLine.Left = 0;
            }
            i++;
        }
        private void play_Click_1(object sender, EventArgs e)
        {
            if (Canvas.Image == null)
            {
                MessageBox.Show("There is no sprite allocated");
            }
            else
            {
                timer1.Start();
            }
        }
        private void button19_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        private void GamerTool_Load(object sender, EventArgs e)
        {
            runningLine.Left = 0;
        }
        Bitmap Sprite;
        private void importSpriteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            AnimationImages.Clear();
            OpenFileDialog File = new OpenFileDialog()
            {
                Filter = "Image File(*.Jpg,*.png,*.jpeg,*jfif)|*.jpg;*.png;*.jpeg;*jfif",
            };
            DialogResult result = File.ShowDialog();
            if (result == DialogResult.OK)
            {

                Sprite = new Bitmap(File.FileName);
                dimensionLog dimensionLog = new dimensionLog();
                dimensionLog.ShowDialog();
                var dimensionControls = dimensionLog.Controls;
                int Xaxis = (int)dimensionLog.dimensionX.Value;
                int Yaxis = (int)dimensionLog.dimensionY.Value;
                ProcessSprite(Xaxis, Yaxis);
            }
            else
            {
                Sprite = null;
            }
        }
        private void ProcessSprite(int Xaxis, int Yaxis)
        {
            int newParentHeight = Sprite.Height;
            int newParentWidth = Sprite.Width;
            Bitmap btmp = new Bitmap(newParentWidth, newParentHeight);
            using (Graphics g = Graphics.FromImage(btmp))
            {
                if (newParentHeight % Yaxis != 0)
                {
                    while (newParentHeight % Yaxis != 0)
                    {
                        newParentHeight += 1;
                    }
                }
                else
                {

                }
                if (newParentWidth % Xaxis != 0)
                {
                    while (newParentWidth % Xaxis != 0)
                    {
                        newParentWidth += 1;
                    }
                }
                else
                {

                }
                int ChildHeight = newParentHeight / Yaxis;
                int ChildWidth = newParentWidth / Xaxis;
                g.DrawImageUnscaledAndClipped(Sprite, new Rectangle(0, 0, newParentWidth, newParentHeight));
                g.Save();
                for (int y = 0; y < newParentHeight; y += ChildHeight)
                {
                    for (int x = 0; x < newParentWidth; x += ChildWidth)
                    {
                        if (x >= newParentWidth)
                        {
                            x = 0;
                            break;
                        }
                        try
                        {
                            Rectangle rect = new Rectangle(x, y, ChildWidth, ChildHeight);
                            Bitmap ChildImage = btmp.Clone(rect, btmp.PixelFormat);
                            AnimationImages.Add(ChildImage);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            Console.WriteLine(e.Source);
                            Console.WriteLine(e.InnerException);


                        }
                    }
                }
                Canvas.Image = AnimationImages[0];
            }

        }
        private void importImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Amen");
        }
        private void Refresh_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            AnimationImages.Clear();
            Canvas.Image = null;
        }
    }
}
