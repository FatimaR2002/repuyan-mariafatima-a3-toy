using System;
using System.Collections.Generic;
using System.Text;

namespace MohawkGame2D
{
    public class Basketball
    {
     public Color BasketballBrown = new Color("B54213");

    public void Setup()
    {

    }

    public void Update()
    {
      Draw.LineSize = 1;
      Draw.FillColor = BasketballBrown;
      Draw.Circle(Input.GetMouseX(), Input.GetMouseY(), 45);

    }

    }
}
