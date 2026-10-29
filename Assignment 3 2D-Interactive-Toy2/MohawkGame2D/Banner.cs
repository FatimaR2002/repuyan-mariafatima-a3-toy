

using System.Numerics;

namespace MohawkGame2D
{
    public class Banner
    {
        public Color BannerBG = new Color("4f6d7a");
        public Color Symbol = new Color("e8dab2");
        public Color BannerEdge = new Color("dd6e42");

        public void Setup()
        {

        }
        public void Update()
        {
            //Banner 1
            Draw.LineSize = 0;
            Draw.FillColor = BannerBG;
            Draw.Rectangle(new Vector2(0, 150), new Vector2(50, 160));
            Draw.LineSize = 0;
            Draw.FillColor = BannerBG;
            Draw.Triangle(new Vector2(0, 310), new Vector2(50, 310), new Vector2(0, 360));
            //symbol
            Draw.LineSize = 0;
            Draw.FillColor = Symbol;
            Draw.Triangle(new Vector2(0, 190), new Vector2(40, 250), new Vector2(0, 250));
            Draw.Triangle(new Vector2(0, 250), new Vector2(0, 290), new Vector2(20, 250));
            Draw.Rectangle(new Vector2(0, 270), new Vector2(10, 50));

            //Banner 2
            Draw.LineSize = 0;
            Draw.FillColor = BannerBG;
            Draw.Rectangle(new Vector2(70, 150), new Vector2(160, 160));
            Draw.Triangle(new Vector2(70,310), new Vector2(230,310), new Vector2(150,370));
            //symbol
            Draw.LineSize = 0;
            Draw.FillColor = Symbol;
            Draw.Rectangle(new Vector2(120, 210), new Vector2(50, 170));
            Draw.Triangle(new Vector2(170, 210), new Vector2(170, 380), new Vector2(210, 380));

            //Banners Outline
            Draw.LineSize = 5;
            Draw.LineColor = BannerEdge;
            Draw.Line(new Vector2(0, 150), new Vector2(50, 150));
            Draw.Line(new Vector2(50, 150), new Vector2(50, 310));
            Draw.Line(new Vector2(50, 310), new Vector2(0, 360));




        }
    }
}

