using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PinPonOyunu
{
    public partial class pinponform : Form
    {
        public int speed_left = 6;
        public int speed_top=6;
        public int points=0;
        Random random = new Random();
        System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
        public pinponform()
        {
            InitializeComponent();

            timer1.Enabled = true;
            Cursor.Hide();
            //topu yuvarlak yapmak
            gp.AddEllipse(0, 0, ball.Width - 1, ball.Height - 1);
            Region rg = new Region(gp);
            ball.Region = rg;
           
            this.Bounds=Screen.PrimaryScreen.Bounds;//form'u tam ekran yapiyor!!
            racet.Top = oyunalani.Bottom - (oyunalani.Bottom / 10);
            gameover_lbl.Left= (oyunalani.Width/2)-(gameover_lbl.Width/2);
            gameover_lbl.Top=(oyunalani.Height/2)-(gameover_lbl.Height/2);
            gameover_lbl.Hide();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            racet.Left = Cursor.Position.X - (racet.Width / 2);

            ball.Left += speed_left;
            ball.Top += speed_top;
            if (ball.Left <= oyunalani.Left)
            {
                speed_left = -speed_left;
            }
            if (ball.Right >= oyunalani.Right)
            {
                speed_left = -speed_left;
            }
            if (ball.Top <= oyunalani.Top)
            {
                speed_top = -speed_top;
            }
            if(ball.Bottom >= oyunalani.Bottom)
            {
                gameover_lbl.Visible = true;
                timer1.Enabled= false;
            }
            if(ball.Bottom<=racet.Bottom && ball.Bottom >= racet.Top && ball.Left >= racet.Left && ball.Right <= racet.Right)
            {
                speed_left += 2;
                speed_top += 2; 
                speed_top = -speed_top;
                points++;
                point_lbl.Text=points.ToString();

                oyunalani.BackColor = Color.FromArgb(random.Next(150,255), random.Next(150, 255), random.Next(150, 255));
            } 
        }

        private void pinponform_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.F1)
            {
                gameover_lbl.Visible = false;
                timer1.Enabled = true;
                ball.Top = 50;
                ball.Left = 50;
                points = 0;
                point_lbl.Text = points.ToString();
                speed_top = 6;
                speed_left = 6;
                oyunalani.BackColor = Color.White;
            }
        }
    }
}
