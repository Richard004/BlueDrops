using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueDrops
{
    public class Drop
    {
        public Color Color = Color.Blue;
        public int Xcoord = 50;
        public int Ycoord = 50;
        public int Diameter = 40;
    }

    public class Aquarium
    {
        public List<Drop> drops = new List<Drop>();

        public Aquarium()
        {
            drops.Add(new Drop { Color = Color.BlueViolet, Xcoord = 10, Ycoord = 40, Diameter = 40 });
            drops.Add(new Drop { Color = Color.Azure, Xcoord = 30, Ycoord = 140, Diameter = 60 });
            drops.Add(new Drop { Color = Color.Red, Xcoord = 60, Ycoord = 20, Diameter = 80 });
            drops.Add(new Drop { Color = Color.Bisque, Xcoord = 80, Ycoord = 60, Diameter = 50 });
            drops.Add(new Drop { Color = Color.Green, Xcoord = 120, Ycoord = 90, Diameter = 50 });
            drops.Add(new Drop { Color = Color.YellowGreen, Xcoord = 140, Ycoord = 60, Diameter = 50 });
            drops.Add(new Drop { Color = Color.Red, Xcoord = 180, Ycoord = 60, Diameter = 50 });
        }

        public void RainByPixel()
        {
            var drp = drops;
            for (int i = 0; i < drp.Count; i++)
            {
                var onedrop = drp[i];
                onedrop.Ycoord = onedrop.Ycoord + 1;

                if (onedrop.Ycoord > 300)
                {
                    onedrop.Ycoord = 0;
                }

            }

        }

    }
}
