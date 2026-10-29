using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MohawkGame2D
{
    public class Hoop
    {
        public Color HoopRim = new Color("EE6730");
        public Color Net = Color.Black;

    public void Setup()
     {

      }

    public void Update()
     {
       Draw.LineSize = 1;
       //HoopRim
       Draw.FillColor = HoopRim;
       Draw.Rectangle(new Vector2(330, 260), new Vector2(140, 20));


     }

    }
}

