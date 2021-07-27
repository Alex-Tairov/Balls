using System;
using System.Drawing;
using System.Windows.Forms;

namespace Balls_Common
{
    public class RandomPointBall : Ball
    {
        public RandomPointBall(Form form) : base(form)
        {
            
            color = Color.Red;
            centerX = random.Next(LeftBorder(),RightBorder());
            centerY = random.Next(TopBorder(),DawnBorder());

            
        }
    }



}
