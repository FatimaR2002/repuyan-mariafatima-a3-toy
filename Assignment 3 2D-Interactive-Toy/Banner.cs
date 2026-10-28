using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Numerics;
using System.Text;

namespace MohawkGame2D
{
    public class Banner
    {
        //Variables 
        Color BannerBG = new Color ("4F7942");

        //Color bg = new Color(255, 245, 238);
        Color bg = new Color(255, 245, 238);
        Color BannerSymbol = new Color("7C3030");

        public void Setup()
        {

        }

        public void Update()
        {
            //Make the Banner Shape 

            //Banner 1
            Draw.LineSize = 0;
            Draw.FillColor = BannerBG;
            Draw.Rectangle(new Vector2(0, 150), new Vector2(50, 150));


        }
    }
}
