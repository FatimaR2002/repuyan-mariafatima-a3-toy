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
        Color BGstrip = new Color(65, 105, 225);
        Color BasketballBrown = new Color("B54213");
        Color BackboardRed = new Color("B23A32");
        Color HoopRim = new Color("EE6730");
        Color Shadow = new Color(255, 229, 180, 20);
        Color BannerBG = new Color("4F7942");
        Color BannerSymbol = new Color("7C3030");
      //object1 = new ();
      //object2 = new ();
      //object3 = new ();
        //int score = 0;
        /// <summary>
        /// //////////////
        /// </summary>
        public void Setup()
        {
            //Add the Window size and title name
            Window.SetSize(800, 600);
            Window.SetTitle("Hoop to the Hoop");

            //add the objects 
            //object1.Setup();
            //object2.Setup();
            //object3.Setup();


        }
        /// <summary>
        /// Updates the current state or values of the object.
        /// </summary>
        public void Update()
        {
            //Draw the "Color bg" for the background 
            Window.ClearBackground(bg);

            //Draw the "BG Strip" at the bottom of the background 
            Draw.LineSize = 0;
            Draw.FillColor = BGstrip;
            Draw.Rectangle(new Vector2(0, 450), new Vector2(800, 30));
            //////////////
            ///
            //Backboard for the Basketball Hoop 
            //Draw the wires attachted to the Basketball Hoop
            {
                float y = 0;
                Draw.LineSize = 7;
                Draw.Line(new Vector2(300, y), new Vector2(300, 100));
                Draw.LineSize = 7;
                Draw.Line(new Vector2(500, y), new Vector2(500, 100));
                Draw.LineSize = 7;
                Draw.Line(new Vector2(300, 80), new Vector2(500, 80));
                Draw.LineSize = 7;
                Draw.Line(new Vector2(400, y), new Vector2(300, 75));
                Draw.LineSize = 7;
                Draw.Line(new Vector2(400, y), new Vector2(500, 75));
                Draw.FillColor = Color.Black;
                Draw.Circle(400f, 110f, 15f);
            }

        }
    }

}
