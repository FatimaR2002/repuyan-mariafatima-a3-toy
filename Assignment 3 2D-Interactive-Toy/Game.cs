// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        //Variables
        Color bg = new Color(255, 245, 238);
        Color BasketballBrown = new Color("#EE6730");
        Color BasketballBlack = new Color("#2c2c2c");
        public void Setup()
        {
            
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            //Add title and Window Size
            Window.SetTitle("Hoop to the Hoop");
            Window.SetSize(800, 600);

            //Add background colour, make it tan/beige 
            Window.ClearBackground(bg);

            //Add the bottom background, for the wall cushions in a gym
            Draw.SetLineSize(0);
            Draw.SetFillColor(65, 105, 225);
            Draw.Rectangle(new Vector2(0, 450), new Vector2(800, 30));

            
            { //Making the Hoop
                Draw.LineSize = 1;
                Draw.FillColor = Color.White;
                Draw.Rectangle(new Vector2(250, 100), new Vector2(300, 200));
                //Draw the first border
                Draw.LineSize = 1;
                Draw.FillColor = Color.Red;
                Draw.Rectangle(new Vector2(270, 120), new Vector2(260, 160));
                //Second border
                Draw.LineSize = 1;
                Draw.FillColor = Color.White;
                Draw.Rectangle(new Vector2(280, 130), new Vector2(240, 140));
                //Third border
                Draw.LineSize = 1;
                Draw.FillColor = Color.Red;
                Draw.Rectangle(new Vector2(340, 190), new Vector2(120, 80));
                //Fourth border
                Draw.LineSize = 1;
                Draw.FillColor = Color.White;
                Draw.Rectangle(new Vector2(350, 200), new Vector2(100, 60));
                //Draw Hoop
                Draw.LineSize = 0.5f;
                Draw.FillColor = Color.Magenta;
                Draw.Rectangle(new Vector2(330, 260), new Vector2(140, 20));
                //Draw the net
                Draw.LineSize = 2f;
                Draw.PolyLine(new Vector2(330, 280), new Vector2(340, 300), new Vector2(350, 310), new Vector2(355.5f, 350), new Vector2(355.5f, 370), new Vector2(350, 420));
            }

           
              




        }
    }

}
