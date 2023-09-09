using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RastgeleLig
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        Random rstgl = new Random();
        int fbpuan = 0;
        int gspuan = 0;
        int bjkpuan = 0;
        int tspuan = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            int a = rstgl.Next(0, 5);
            int b = rstgl.Next(0, 5);
            int c = rstgl.Next(0, 5);
            int d = rstgl.Next(0, 5);
            label3.Text = a.ToString();
            label5.Text = b.ToString();
            label8.Text = c.ToString();
            label6.Text = d.ToString();

            if (Convert.ToInt32(label3.Text) > Convert.ToInt32(label5.Text))
            {
                fbpuan += 3;
                labelfbpuan.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label5.Text) > Convert.ToInt32(label3.Text))
            {
                gspuan += 3;
                labelgspuan.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label3.Text) == Convert.ToInt32(label5.Text))
            {
                fbpuan += 1;
                gspuan += 1;
                labelfbpuan.Text = fbpuan.ToString();
                labelgspuan.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label8.Text) > Convert.ToInt32(label6.Text))
            {
                bjkpuan += 3;
                labelbjkpuan.Text = bjkpuan.ToString();

            }
            if (Convert.ToInt32(label6.Text) > Convert.ToInt32(label8.Text))
            {
                tspuan += 3;
                labeltspuan.Text = tspuan.ToString();
            }
            if (Convert.ToInt32(label8.Text) == Convert.ToInt32(label6.Text))
            {
                bjkpuan += 1;
                tspuan += 1;
                labelbjkpuan.Text = bjkpuan.ToString();
                labeltspuan.Text = tspuan.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            button2.Enabled = false;
            int a = rstgl.Next(0, 5);
            int b = rstgl.Next(0, 5);
            int c = rstgl.Next(0, 5);
            int d = rstgl.Next(0, 5);
            label16.Text = a.ToString();
            label12.Text = b.ToString();
            label15.Text = c.ToString();
            label11.Text = d.ToString();

            if (Convert.ToInt32(label16.Text) > Convert.ToInt32(label12.Text))
            {
                gspuan += 3;
                labelgspuan.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label12.Text) > Convert.ToInt32(label16.Text))
            {
                tspuan += 3;
                labeltspuan.Text = tspuan.ToString();
            }
            if (Convert.ToInt32(label12.Text) == Convert.ToInt32(label16.Text))
            {
                bjkpuan += 1;
                gspuan += 1;
                labelbjkpuan.Text = bjkpuan.ToString();
                labelgspuan.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label11.Text) > Convert.ToInt32(label15.Text))
            {
                fbpuan += 3;
                labelfbpuan.Text = fbpuan.ToString();

            }
            if (Convert.ToInt32(label15.Text) > Convert.ToInt32(label11.Text))
            {
                tspuan += 3;
                labeltspuan.Text = tspuan.ToString();
            }
            if (Convert.ToInt32(label15.Text) == Convert.ToInt32(label11.Text))
            {
                fbpuan += 1;
                tspuan += 1;
                labeltspuan.Text = tspuan.ToString();
                labelfbpuan.Text = fbpuan.ToString();
            }

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            int x = rstgl.Next(0, 5);
            int y = rstgl.Next(0, 5);
            int z = rstgl.Next(0, 5);
            int w = rstgl.Next(0, 5);
            label26.Text = x.ToString();
            label22.Text = y.ToString();
            label25.Text = z.ToString();
            label21.Text = w.ToString();

            if (Convert.ToInt32(label22.Text) > Convert.ToInt32(label26.Text))
            {
                fbpuan += 3;
                labelfbpuan.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label26.Text) > Convert.ToInt32(label22.Text))
            {
                bjkpuan += 3;
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label26.Text) == Convert.ToInt32(label22.Text))
            {
                fbpuan += 1;
                bjkpuan += 1;
                labelfbpuan.Text = fbpuan.ToString();
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label25.Text) > Convert.ToInt32(label21.Text))
            {
                gspuan += 3;
                labelgspuan.Text = gspuan.ToString();

            }
            if (Convert.ToInt32(label21.Text) > Convert.ToInt32(label25.Text))
            {
                tspuan += 3;
                labeltspuan.Text = tspuan.ToString();
            }
            if (Convert.ToInt32(label25.Text) == Convert.ToInt32(label21.Text))
            {
                gspuan += 1;
                tspuan += 1;
                labelgspuan.Text = gspuan.ToString();
                labeltspuan.Text = tspuan.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = true;
            if (Convert.ToInt32(labelfbpuan.Text) > Convert.ToInt32(labelgspuan.Text) && Convert.ToInt32(labelfbpuan.Text) > Convert.ToInt32(labeltspuan.Text) && Convert.ToInt32(labelfbpuan.Text) > Convert.ToInt32(labelbjkpuan.Text))
            {
                
                label31.Text = "ŞAMPİYON FENERBAHÇE";

                pictureBox1.ImageLocation = "C:\\Users\\muhammed PALA\\Desktop\\a.jpeg";
                axWindowsMediaPlayer1.URL = "C:\\Users\\muhammed PALA\\Desktop\\Tadic on fire   HULDIGING.mp3";
            }
            if (Convert.ToInt32(labelgspuan.Text) > Convert.ToInt32(labelfbpuan.Text) && Convert.ToInt32(labelgspuan.Text) > Convert.ToInt32(labeltspuan.Text) && Convert.ToInt32(labelgspuan.Text) > Convert.ToInt32(labelbjkpuan.Text))
            {
                label31.Text = "ŞAMPİYON GALATASARAY";
                pictureBox1.ImageLocation = "C:\\Users\\muhammed PALA\\Desktop\\g.png";
                axWindowsMediaPlayer1.URL = "C:\\Users\\muhammed PALA\\Desktop\\şereftir seni sevmek.wav";
            }
            if (Convert.ToInt32(labelbjkpuan.Text) > Convert.ToInt32(labelfbpuan.Text) && Convert.ToInt32(labelbjkpuan.Text) > Convert.ToInt32(labeltspuan.Text) && Convert.ToInt32(labelbjkpuan.Text) > Convert.ToInt32(labelgspuan.Text))
            {
                label31.Text = "ŞAMPİYON BEŞİKTAŞ";
                pictureBox1.ImageLocation = "C:\\Users\\muhammed PALA\\Desktop\\b.jpeg";
                axWindowsMediaPlayer1.URL = "C:\\Users\\muhammed PALA\\Desktop\\Gücüne-Güç-Katmaya-Geldik-Beşiktaş-Official-Video.wav";
            }
            if (Convert.ToInt32(labeltspuan.Text) > Convert.ToInt32(labelfbpuan.Text) && Convert.ToInt32(labeltspuan.Text) > Convert.ToInt32(labelbjkpuan.Text) && Convert.ToInt32(labeltspuan.Text) > Convert.ToInt32(labelgspuan.Text))
            {
                label31.Text = "ŞAMPİYON TRABZONSPOR";
                pictureBox1.ImageLocation = "C:\\Users\\muhammed PALA\\Desktop\\t.jpeg";
                axWindowsMediaPlayer1.URL = "C:\\Users\\muhammed PALA\\Desktop\\ÖZKAN-MEYDAN-Yarınlara-Güleceğiz-Official-Audio.wav";
             }
        }
    }
}
