using System.Drawing;
using System.Windows.Forms;

namespace Balls_Common
{
    public class RandomColorMovementBall : RandomMovementBall
    {
        public RandomColorMovementBall(Form form) : base(form)
        {
            color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }
        
        //Переопределение метода
        protected override void Go()
        {
            base.Go();

            if (centerX <= LeftBorder())
            {
                centerX = LeftBorder();
                vx = -vx;
            }

            if (centerX >= RightBorder())
            {
                centerX = RightBorder();
                vx = -vx;
            }

            if (centerY <= TopBorder())
            {
                centerY = TopBorder();
                vy = -vy;
            }

            if (centerY >= DawnBorder())
            {
                centerY = DawnBorder();
                vy = -vy;
            }
        }
        
    }
}
