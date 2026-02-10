using System.Diagnostics;
using System.Text;

namespace BitmapFontGenerator
{
    public partial class Form1 : Form
    {
        Font font = new Font("宋体", 16);
        public Form1()
        {
            InitializeComponent();
        }
        byte[] GenerateBitmap(Bitmap b)
        {
            uint pages = (uint)Math.Ceiling((double)b.Height / 8);
            byte[] data = new byte[pages * b.Width];
            for (int y = 0; y < b.Height; y++)
            {
                for (int x = 0; x < b.Width; x++)
                {
                    if (b.GetPixel(x, y).GetBrightness() == 1)
                    {
                        data[y / 8 * b.Width + x] |= (byte)(1 << (y % 8));
                    }
                }
            }
            return data;
        }
        byte[] GetCharBitmap(char c, int width, int height,bool display = true)
        {
            Bitmap b = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(b);
            g.Clear(Color.Black);

            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;

            //Font font = new Font("微软雅黑", width, FontStyle.Regular, GraphicsUnit.Pixel);

            string text = c.ToString();

            SizeF textSize = g.MeasureString(text, font);

            float x = (width - textSize.Width) / 2;
            float y = (height - textSize.Height) / 2;

            g.DrawString(text, font, Brushes.White, x, y);

            Convert1Bit(b);

            var data = GenerateBitmap(b);

            if(display) pictureBox1.Image = b;
            return data;
        }
        void Convert1Bit(Bitmap b)
        {
            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    if (b.GetPixel(i, j).GetBrightness() > 0.5)
                    {
                        b.SetPixel(i, j, Color.White);
                    }
                    else
                    {
                        b.SetPixel(i, j, Color.Black);
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var sp = sizeInput.Text.Split(',');
            int w = int.Parse(sp[0]);
            int h = int.Parse(sp[1]);
            if (textBox1.Text.Length == 1)
            {
                richTextBox1.Text = string.Join(",", GetCharBitmap(textBox1.Text[0], w, h));
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("{\r\n");
                string targetString = textBox1.Text;
                for (int i = 0; i < targetString.Length; i++)
                {
                    if (i != 0) sb.Append(',');
                    sb.Append("\t\t\"");
                    sb.Append(targetString[i]);
                    sb.Append("\":[");
                    sb.Append(string.Join(",", GetCharBitmap(textBox1.Text[i], w, h)));
                    sb.Append("]\r\n");
                }
                sb.Append('}');
                richTextBox1.Text = sb.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FontDialog fontDiag = new();
            if (fontDiag.ShowDialog() == DialogResult.OK)
            {
                font = fontDiag.Font;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer.exe", "https://github.com/xy660");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var od = new OpenFileDialog();
            if (od.ShowDialog() == DialogResult.OK)
            {
                var sp = sizeInput.Text.Split(',');
                int w = int.Parse(sp[0]);
                int h = int.Parse(sp[1]);
                Bitmap b = new Bitmap(w, h);
                Graphics g = Graphics.FromImage(b);
                g.DrawImage(Image.FromFile(od.FileName), 0, 0, w, h);
                Convert1Bit(b);
                var data = GenerateBitmap(b);
                richTextBox1.Text = string.Join(",", data);
                pictureBox1.Image = b;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            font = new Font("微软雅黑", 16, FontStyle.Regular, GraphicsUnit.Pixel);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //纵向1bit位图，高度必须是8的整数倍
            //单个字大小(fontSize)=width * height / 8
            //
            //[长度byte][宽度byte]size=2
            //[ASCII区U+0020 - U+007F]size=95*fontSize
            //[Unicode中文区U+4E00 - U+9FA5]
            var sp = sizeInput.Text.Split(',');
            int width = int.Parse(sp[0]);
            int height = int.Parse(sp[1]);
            using (var ms = new MemoryStream())
            {
                ms.WriteByte((byte)width);
                ms.WriteByte((byte)height);

                for(int i = 0x20;i <= 0x7F; i++)
                {
                    var data = GetCharBitmap((char)i, width, height,false);
                    ms.Write(data);
                }

                for(int i = 0x4E00;i <= 0x9FA5; i++)
                {
                    var data = GetCharBitmap((char)i, width, height,false);
                    ms.Write(data);
                }
                using (var od = new SaveFileDialog())
                {
                    od.Title = "保存字体文件";
                    od.FileName = $"{font.Name}-{width}x{height}.bin";
                    if (od.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllBytes(od.FileName, ms.ToArray());
                    }
                }
            }

            
        }
    }
}
