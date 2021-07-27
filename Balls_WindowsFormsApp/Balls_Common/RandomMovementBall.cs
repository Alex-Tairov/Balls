using System;
using System.Drawing;
using System.Windows.Forms;

namespace Balls_Common
{
    public class RandomMovementBall : RandomPointBall
    {
        public RandomMovementBall(Form form) : base(form)
        {
            vx = (float)(random.NextDouble()-0.5)*10;
            vy = (float)(random.NextDouble() - 0.5) * 10;

        }
    }
}
