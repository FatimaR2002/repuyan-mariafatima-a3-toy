// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

namespace MohawkGame2D
{

    public class Game
    {
        //Variables 
        public Color bg = new Color("EDEADE");
        public Color BGstrip = new Color(65, 105, 225);
        public Color BGCushion = new Color(44, 72, 148);
        public Color BackboardRed = new Color("B23A32");
        public Color Shadow = new Color(255, 229, 180, 30);

        //objects    
        Hoop object2 = new Hoop();
        Basketball object1 = new Basketball();
        Banner object3 = new Banner();
        int score = 0;
        bool justscored = false;

        /// <summary>
        /// //////////////
        /// </summary>
        public void Setup()
        {
            //Add the Window size and title name
            Window.SetSize(800, 600);
            Window.SetTitle("Hoop to the Hoop");
            object1.Setup();
            object2.Setup();
            object3.Setup();
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
            //Draw the "Bg Cushions" at below the BG Strip 
            Draw.LineSize = 0;
            Draw.FillColor = BGCushion;
            Draw.Rectangle(new Vector2(0, 480), new Vector2(800, 130));

            //////////////
            ///
            //Backboard for the Basketball Hoop    
            {
                //Draw the wires attachted to the Basketball Hoop
                float y = 0;
                Draw.LineSize = 7;
                Draw.LineColor = Color.Black;
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

                //Draw the Backboard 
                //Draw the first rectangle, make it white
                Draw.LineSize = 2f;
                Draw.LineColor = Color.Black;
                Draw.FillColor = Color.White;
                Draw.Rectangle(new Vector2(250, 100), new Vector2(300, 200));
                //Draw the second rectangle, make it red
                Draw.LineSize = 2f;
                Draw.LineColor = Color.Black;
                Draw.FillColor = BackboardRed;
                Draw.Rectangle(new Vector2(270, 120), new Vector2(260, 160));
                //Third rectangle, make it white
                Draw.LineSize = 2f;
                Draw.LineColor = Color.Black;
                Draw.FillColor = Color.White;
                Draw.Rectangle(new Vector2(280, 130), new Vector2(240, 140));
                //Fourth rectangle, make it red
                Draw.LineSize = 2f;
                Draw.LineColor = Color.Black;
                Draw.FillColor = BackboardRed;
                Draw.Rectangle(new Vector2(340, 190), new Vector2(120, 80));
                //fifth rectangle, make it white
                Draw.LineSize = 2f;
                Draw.LineColor = Color.Black;
                Draw.FillColor = Color.White;
                Draw.Rectangle(new Vector2(350, 200), new Vector2(100, 60));
            }
            ////////////////
            ////
            ///Rectangle for Tally Chart 
            Draw.LineSize = 3;
            Draw.FillColor = Color.OffWhite;
            Draw.Rectangle(new Vector2(40, 410), new Vector2(210, 120));
            ///////////////
            ////
            ///Loop 1: Window Shadows 
            for (int i = 0; i < 4; i++)
            {
                Draw.LineSize = 0;
                Draw.FillColor = Shadow;
                //Y Coordinate, make it go down the y-axis every 30 pixels 
                int y = i * 30;
                //Draw a Quad that moves down y-axis every 30 pixels 
                Draw.Quad(new Vector2(0, y), new Vector2(900, y + 670), new Vector2(650, y + 670), new Vector2(0, y + 60));
            }
            ///////////////
            ////
            ///Loop 2: Tally Chart
            for (int i = 0; i < score; i++)

            {
                Draw.LineSize = 3;
                //X and Y coordinates, move every 30 pixels, each time the player gets the basketball into the hoop
                int x = i * 20;
                //Draw the line
                Draw.Line(new Vector2(x + 100, 430), new Vector2(x + 50, 510));
            }
            /////////////
            ///
            //Classes Update 
            object1.Update();
            object2.Update();
            object3.Update();

            ///////
            ///
            //Get a score if the basketball goes through the net
            if (object1.position.X > 380 && object1.position.X < 420)
            {
                if (object1.position.Y > 410 && object1.position.Y < 420 && justscored == false)
                {
                    score++;
                    justscored = true;
                }
            }
            //reset the net after the player scores 
            if (object1.position.X > 500) justscored = false;


        }

    }
}



