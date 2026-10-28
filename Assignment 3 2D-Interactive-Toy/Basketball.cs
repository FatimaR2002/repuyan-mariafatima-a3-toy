using System;
using System.Collections.Generic;
using System.Text;

namespace MohawkGame2D
{
    public class Basketball
    {
        Color BasketballBrown = new Color("B54213");
        public void Setup()
        {
            //Prepare drawing variables for the basketball 
        }

        public void Update()
        {
            Draw.LineSize = (0);
            Draw.FillColor = BasketballBrown;
            //body of the basketball
            Draw.Circle(Input.GetMouseX(), Input.GetMouseY(), 45);
        }
        public void UniqueFunctions()
        {
            {
                Draw.LineSize = (0);
                Draw.FillColor = BasketballBrown;
                //body of the basketball
                Draw.Circle(Input.GetMouseX(), Input.GetMouseY(), 45);
            }
        }
    }
}






