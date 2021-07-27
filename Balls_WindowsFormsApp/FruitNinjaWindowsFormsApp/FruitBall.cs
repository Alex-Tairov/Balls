using Balls_Common;
using System.Windows.Forms;

namespace FruitNinjaWindowsFormsApp
{
    public class FruitBall: RandomColorMovementBall
    {
        private float g = 0.02f;
        public FruitBall(Form form) : base(form)
        {
            centerY = DawnBorder()+radius;
            vy = (float)(random.NextDouble() - 1) * 6 - 7;
            radius = 20;
        }
        protected override void Go()
        {
            base.Go();
            vy += g;
        }

        public void Slow()
        {
            vy = (float)(random.NextDouble() - 1) * 6 - 1;
            
        }
    }
}
