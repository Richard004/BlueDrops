using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlueDrops.Properties;

namespace BlueDrops
{
    public partial class Form1 : Form
    {
        private Aquarium maleAkvarko = new Aquarium();
        private Timer timer = new Timer();
        private Image DogImage = Properties.Resources.Dog;

        public Form1()
        {
            InitializeComponent();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
            timer.Start();
            this.DoubleBuffered = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            maleAkvarko.RainByPixel();
            this.Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode=SmoothingMode.AntiAlias;
            //e.Graphics.DrawEllipse(new Pen(Color.Aqua),50,50,30,30);
            //e.Graphics.FillEllipse(new SolidBrush(Color.Brown),14,15,15,15 );
            maleAkvarko.aqariumHeight = this.ClientRectangle.Height;
            maleAkvarko.aqariumWidth = this.ClientRectangle.Width;
            e.Graphics.DrawImage(DogImage, maleAkvarko.HlidaciPes.Xcoord, maleAkvarko.HlidaciPes.Ycoord, 100, 100);

            var drp = maleAkvarko.balls;
            for (int i = 0; i < drp.Count; i++)
            {
                e.Graphics.FillEllipse(new SolidBrush(drp[i].Color), drp[i].Xcoord, drp[i].Ycoord, drp[i].Diameter, drp[i].Diameter);
            }
            var bub = maleAkvarko.bub;
            for (int i = 0; i < bub.Count; i++)
            {
                e.Graphics.FillEllipse(new SolidBrush(bub[i].Color), bub[i].Xcoord, bub[i].Ycoord, bub[i].Diameter, bub[i].Diameter);
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
           

        }
    }
}
