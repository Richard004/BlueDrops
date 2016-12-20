using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueDrops
{
    public class Dog
    {
        public int Xcoord = 50;
        public int Ycoord = 200;
        public int Size = 40;


    }

    public class Bubble
    {
        public Color Color = Color.LightBlue;
        public int Xcoord = 50;
        public float Ycoord = 50;
        public int Diameter = 30;
    }

    public class Ball
    {
        public Color Color = Color.Blue;
        public int Xcoord = 50;
        public float Ycoord = 50;
        public float Yvelocity = 0;
        public int Diameter = 40;
    }

    public class Aquarium
    {
        public List<Ball> balls = new List<Ball>();
        public Dog HlidaciPes = new Dog();
        public List <Bubble> bub = new List<Bubble>();

        public Aquarium()
        {
            balls.Add(new Ball { Color = Color.BlueViolet, Xcoord = 10, Ycoord = 40, Diameter = 40 });
            balls.Add(new Ball { Color = Color.Azure, Xcoord = 30, Ycoord = 140, Diameter = 60 });
            balls.Add(new Ball { Color = Color.Red, Xcoord = 60, Ycoord = 20, Diameter = 80 });
            balls.Add(new Ball { Color = Color.Bisque, Xcoord = 80, Ycoord = 60, Diameter = 50 });
            balls.Add(new Ball { Color = Color.Green, Xcoord = 120, Ycoord = 90, Diameter = 50 });
            balls.Add(new Ball { Color = Color.YellowGreen, Xcoord = 140, Ycoord = 60, Diameter = 50 });
            balls.Add(new Ball { Color = Color.Red, Xcoord = 180, Ycoord = 60, Diameter = 50 });
            balls.Add(new Ball { Color = Color.AliceBlue, Xcoord = 170, Ycoord = 50, Diameter = 50 });
            balls.Add(new Ball { Color = Color.Blue, Xcoord = 70, Ycoord = 150, Diameter = 70 });
            bub.Add(new Bubble { Xcoord = 10, Ycoord = 25});
            bub.Add(new Bubble { Xcoord = 147, Ycoord =60 });
            bub.Add(new Bubble { Xcoord =132 , Ycoord = 70});
            bub.Add(new Bubble { Xcoord = 63 , Ycoord = 60});
            bub.Add(new Bubble { Xcoord = 85, Ycoord = 50});
            bub.Add(new Bubble { Xcoord = 23, Ycoord = 80});
            bub.Add(new Bubble { Xcoord = 84, Ycoord = 90});
            bub.Add(new Bubble { Xcoord = 142, Ycoord = 60});
        }

        public void RainByPixel()
        {
            var drp = balls;
            for (int i = 0; i < drp.Count; i++)
            {

                var oneball = drp[i];

                var Xcur = 50f;
                var Ycur = 50f;
                var a = Ycur - oneball.Ycoord;
                var b = Xcur - oneball.Xcoord;
                var c = Math.Sqrt(a*a + b*b);
                var k = 1.0;
                var Fg = k*1.0*1.0/(c*c);
                var Fgx = Fg * b / c;
                var Fgy = Fg * a / c;



                var timeStep = 0.02f;
                var velocityY = oneball.Yvelocity;
                var g = 200.81f;
                var deltavelocityY = g * timeStep;
                oneball.Ycoord = oneball.Ycoord + velocityY * timeStep;
                oneball.Yvelocity = oneball.Yvelocity + deltavelocityY;

                if (oneball.Ycoord > 300)
                {
                    //oneball.Ycoord = 0;
                    oneball.Yvelocity = - 0.9f * oneball.Yvelocity;
                    //oneball.Yvelocity = -oneball.Yvelocity;
                }

            }
            HlidaciPes.Xcoord = HlidaciPes.Xcoord + 1;
            if (HlidaciPes.Xcoord > 180)
            {
                HlidaciPes.Xcoord = 0;
            }
            for (int i = 0; i < bub.Count; i++)
            {
                var onebub = bub[i];
                onebub.Ycoord = onebub.Ycoord - 0.2f*i-0.5f;

                if (onebub.Ycoord < 0)
                {
                    onebub.Ycoord = 300;
                }
            }

        }

    }
}
