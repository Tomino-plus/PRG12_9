using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form

        //TODO volba šířky pera, color fill

    {
        public Form1()
        {
            InitializeComponent();
            this.Width = 1280;
            this.Height = 720;
            bm = new Bitmap(this.Width, this.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            picture.Image = bm;           
        }
        int index = 1; //urcuje nastroj kresleni
        // index 1 = pen; 2 = eraser; 3 = elipsa; 4 = rectangle; 5 = úsečka
        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black, 1); //pen TODO volba šířky?
        Pen erase = new Pen(Color.White,50); //eraser TODO volba šířky?
        int x, y, sX, sY, cX, cY; //pro slozitejsi obrazce
        ColorDialog cd = new ColorDialog(); //volba barvy
        Color new_color;
        private void picture_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;
            cX = e.X;
            cY = e.Y;
        }
        
        private void picture_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if(paint)
            {
                if (index == 3)
                {
                    g.DrawEllipse(p, cX, cY, sX, sY);
                }
                if (index == 4)
                {
                    g.DrawRectangle(p, cX, cY, sX, sY);
                }
                if (index == 5)
                {
                    g.DrawLine(p, cX, cY, x, y);
                }
            }
        }
        private void line_Click(object sender, EventArgs e) //úsečka
        {
            index = 5;
        }
        private void button_clear_Click(object sender, EventArgs e) //smazat picture box
        {
            g.Clear(Color.White);
            picture.Refresh();
            index = 0;
        }
        private void button_color_Click(object sender, EventArgs e) //funkce na výběr barvy
        {
            cd.ShowDialog();
            new_color = cd.Color;
            p.Color = cd.Color;
        }
        private void button_save_Click(object sender, EventArgs e) //uloží obrázek
        {
            var savefile = new SaveFileDialog();
            //savefile.Filter = "Image(*.jpg)|*.jpg|(*.*|*.*";
            savefile.Filter = "Image(*.png)|*.png|(*.*|*.*"; //png je asi lepší?
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                Bitmap sf = bm.Clone(new Rectangle(0,0,picture.Width,picture.Height), bm.PixelFormat);
                sf.Save(savefile.FileName,ImageFormat.Jpeg);
            }
        }
        private void picture_MouseMove(object sender, MouseEventArgs e)
        {
            if(paint)
            {
                if (index == 1) //pen
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                }
                if (index == 2) //erase
                {
                    px = e.Location;
                    g.DrawLine(erase, px, py);
                    py = px;
                }
            }
            picture.Refresh();
            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;
        }
        private void pen_Click(object sender, EventArgs e)
        {
            index = 1;
        }
        private void eraser_Click(object sender, EventArgs e)
        {
            index = 2;
        }
        private void elipse_Click(object sender, EventArgs e)
        {
            index = 3;
        }
        private void rectangle_Click(object sender, EventArgs e)
        {
            index = 4;
        }
        private void picture_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;

            sX = x - cX;
            sY = y - cY;

            if(index == 3)
            {
                g.DrawEllipse(p,cX,cY,sX,sY);
            }
            if(index == 4)
            {
                g.DrawRectangle(p,cX,cY,sX,sY);
            }
            if(index == 5)
            {
                g.DrawLine(p,cX,cY,x,y);
            }
        }
    }
}
