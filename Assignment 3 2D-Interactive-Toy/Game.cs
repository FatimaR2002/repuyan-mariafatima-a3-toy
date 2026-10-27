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
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
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
            Window.ClearBackground(255, 245, 238);
            //Add the bottom background, for the wall cushions in a gym
            Draw.SetLineSize(0);
            Draw.SetFillColor(65, 105, 225);
            Draw.Rectangle(new Vector2(0, 450), new Vector2(800, 30));
            
            


        }
    }

}
