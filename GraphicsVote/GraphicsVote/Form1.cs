using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsVote
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void DrawForm(object sender, PaintEventArgs e)
        {
            label1.Text = "Oy Yüzdeleri";
            label2.Text = "Kişiler";
            label3.Text = "A";
            label4.Text = "B";
            label5.Text = "C";
            label6.Text = "D";
            label7.Text = "E";
            Graphics g = this.CreateGraphics();
            //Graphics g = e.Graphics;
            SolidBrush solidColorBrush = new SolidBrush(Color.Black);
            Pen coloredPen = new Pen(solidColorBrush);
            coloredPen.Color = Color.Black;
            g.DrawRectangle(coloredPen, 0, 0, 220, 500);
            g.DrawRectangle(coloredPen, 220, 240, 440, 260);
            g.DrawRectangle(coloredPen, 220, 0, 440, 240);
            #region BarChart
            //y çizgisi
            g.DrawLine(coloredPen, 260, 250, 260, 480);
            //x çizgisi
            g.DrawLine(coloredPen, 260, 480, 600, 480);
            //apsis değerler
            solidColorBrush.Color = Color.Black;
            Font f = new Font("Arial", 10);
            g.DrawString("20", f, solidColorBrush, 240, 435);
            g.DrawString("40", f, solidColorBrush, 240, 395);
            g.DrawString("60", f, solidColorBrush, 240, 355);
            g.DrawString("80", f, solidColorBrush, 240, 315);
            g.DrawString("100", f, solidColorBrush, 235, 275);
            //Ordinat değerler
            g.DrawString("A", f, solidColorBrush, 290, 480);
            g.DrawString("B", f, solidColorBrush, 350, 480);
            g.DrawString("C", f, solidColorBrush, 410, 480);
            g.DrawString("D", f, solidColorBrush, 470, 480);
            g.DrawString("E", f, solidColorBrush, 530, 480);
            // belirteçler
            coloredPen.Color = Color.LightGray;
            g.DrawLine(coloredPen, 260, 440, 600, 440);
            g.DrawLine(coloredPen, 260, 400, 600, 400);
            g.DrawLine(coloredPen, 260, 360, 600, 360);
            g.DrawLine(coloredPen, 260, 320, 600, 320);
            g.DrawLine(coloredPen, 260, 280, 600, 280);
            #endregion
            #region notasyon
            coloredPen.Width = 1;
            g.DrawString("A", f, solidColorBrush, 550, 40);
            g.DrawString("B", f, solidColorBrush, 550, 70);
            g.DrawString("C", f, solidColorBrush, 550, 100);
            g.DrawString("D", f, solidColorBrush, 550, 130);
            g.DrawString("E", f, solidColorBrush, 550, 160);
            solidColorBrush.Color = Color.DarkBlue;
            g.FillRectangle(solidColorBrush, 530, 43, 10, 10);
            solidColorBrush.Color = Color.RoyalBlue;
            g.FillRectangle(solidColorBrush, 530, 73, 10, 10);
            solidColorBrush.Color = Color.Maroon;
            g.FillRectangle(solidColorBrush, 530, 103, 10, 10);
            solidColorBrush.Color = Color.DarkSlateBlue;
            g.FillRectangle(solidColorBrush, 530, 133, 10, 10);
            solidColorBrush.Color = Color.LimeGreen;
            g.FillRectangle(solidColorBrush, 530, 163, 10, 10);
            #endregion
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Bugra();
        }
        private void Bugra()
        {
            double arc1 = 0, arc2 = 0, arc3 = 0, arc4 = 0, arc5 = 0;
            //arc1 = Convert.ToInt32(textBox1.Text);
            int result = 0;
            if (int.TryParse(textBox1.Text, out result))
                arc1 = Convert.ToInt32(textBox1.Text);
            if (int.TryParse(textBox2.Text, out result))
                arc2 = Convert.ToInt32(textBox2.Text);
            if (int.TryParse(textBox3.Text, out result))
                arc3 = Convert.ToInt32(textBox3.Text);
            if (int.TryParse(textBox4.Text, out result))
                arc4 = Convert.ToInt32(textBox4.Text);
            if (int.TryParse(textBox5.Text, out result))
                arc5 = Convert.ToInt32(textBox5.Text);
            Graphics g = this.CreateGraphics();
            SolidBrush solidColorBrush = new SolidBrush(Color.Black);
            Pen coloredPen = new Pen(solidColorBrush);
            var s1 = arc1 * 3.6;
            var s2 = arc2 * 3.6;
            var s3 = arc3 * 3.6;
            var s4 = arc4 * 3.6;
            var s5 = arc5 * 3.6;

            if (Math.Abs(arc1) + Math.Abs(arc2) + Math.Abs(arc3) + Math.Abs(arc4) + Math.Abs(arc5) == 100)
            {
                #region PieChart
                label8.Text = "";
                solidColorBrush.Color = Color.DarkBlue;
                g.FillPie(solidColorBrush, 350, 30, 150, 150, 0, float.Parse(s1.ToString(CultureInfo.InvariantCulture)));
                solidColorBrush.Color = Color.RoyalBlue;
                g.FillPie(solidColorBrush, 350, 30, 150, 150, float.Parse(s1.ToString(CultureInfo.InvariantCulture)), float.Parse(s2.ToString(CultureInfo.InvariantCulture)));
                solidColorBrush.Color = Color.Maroon;
                g.FillPie(solidColorBrush, 350, 30, 150, 150,
                    float.Parse(s1.ToString(CultureInfo.InvariantCulture)) + float.Parse(s2.ToString(CultureInfo.InvariantCulture)),
                    float.Parse(s3.ToString(CultureInfo.InvariantCulture)));
                solidColorBrush.Color = Color.DarkSlateBlue;
                g.FillPie(solidColorBrush, 350, 30, 150, 150, float.Parse(s1.ToString(CultureInfo.InvariantCulture)) + float.Parse(s2.ToString(CultureInfo.InvariantCulture)) + float.Parse(s3.ToString(CultureInfo.InvariantCulture)), float.Parse(s4.ToString(CultureInfo.InvariantCulture)));
                solidColorBrush.Color = Color.LimeGreen;
                g.FillPie(solidColorBrush, 350, 30, 150, 150,
                    float.Parse(s1.ToString(CultureInfo.InvariantCulture)) + float.Parse(s2.ToString(CultureInfo.InvariantCulture)) + float.Parse(s3.ToString(CultureInfo.InvariantCulture)) + float.Parse(s4.ToString(CultureInfo.InvariantCulture)),
                    float.Parse(s5.ToString(CultureInfo.InvariantCulture)));
                #endregion
                #region BarChart
                solidColorBrush.Color = Color.RoyalBlue;
                g.FillRectangle(solidColorBrush, 280, 480 - (float.Parse((arc1 * 2).ToString(CultureInfo.InvariantCulture)))
                    , 40, (float.Parse((arc1 * 2).ToString(CultureInfo.InvariantCulture))));
                g.FillRectangle(solidColorBrush, 340, 480 - (float.Parse((arc2 * 2).ToString(CultureInfo.InvariantCulture)))
                    , 40, (float.Parse((arc2 * 2).ToString(CultureInfo.InvariantCulture))));
                g.FillRectangle(solidColorBrush, 400, 480 - (float.Parse((arc3 * 2).ToString(CultureInfo.InvariantCulture)))
                    , 40, (float.Parse((arc3 * 2).ToString(CultureInfo.InvariantCulture))));
                g.FillRectangle(solidColorBrush, 460, 480 - (float.Parse((arc4 * 2).ToString(CultureInfo.InvariantCulture)))
                    , 40, (float.Parse((arc4 * 2).ToString(CultureInfo.InvariantCulture))));
                g.FillRectangle(solidColorBrush, 520, 480 - (float.Parse((arc5 * 2).ToString(CultureInfo.InvariantCulture)))
                    , 40, (float.Parse((arc5 * 2).ToString(CultureInfo.InvariantCulture))));
                #endregion
            }
            else
            {
                label8.Text = String.Format("Oy Yüzdelerin toplamı \n yüz olmalıdır.{0}\n '-' değerler + olarak alınır. ", Math.Abs(arc1) + Math.Abs(arc2) + Math.Abs(arc3) + Math.Abs(arc4) + Math.Abs(arc5));
                solidColorBrush.Color = Color.White;
                #region gizleme
                g.FillRectangle(solidColorBrush, 280, 250, 40, 230);
                g.FillRectangle(solidColorBrush, 340, 250, 40, 230);
                g.FillRectangle(solidColorBrush, 400, 250, 40, 230);
                g.FillRectangle(solidColorBrush, 460, 250, 40, 230);
                g.FillRectangle(solidColorBrush, 520, 250, 40, 230);
                g.FillPie(solidColorBrush, 350, 30, 150, 150, 0, 360);
                coloredPen.Color = Color.LightGray;
                g.DrawLine(coloredPen, 260, 440, 600, 440);
                g.DrawLine(coloredPen, 260, 400, 600, 400);
                g.DrawLine(coloredPen, 260, 360, 600, 360);
                g.DrawLine(coloredPen, 260, 320, 600, 320);
                g.DrawLine(coloredPen, 260, 280, 600, 280);
                #endregion



                //coloredPen, 220, 250, 440, 250);

                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Bugra();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Bugra();
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Bugra();
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Bugra();
        }
    }
}