using Balls_Common;
using System.Drawing;
using System.Windows.Forms;

namespace SalutWindowsFormsApp
{
    public class SalutBall : RandomMovementBall
    {
        private float g = 0.2f;
        
        public  SalutBall(Form form,float x,float y) : base(form)
        {
            centerX = x;
            centerY = y;
            vy=(float)(random.NextDouble() - 1) * 8;
            radius = 20;
            color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }

                       
        protected override void Go()
        {
            base.Go();
            vy += g;
            
        }
        
                
        public float CoordX()
        {
            return centerX;
        }

        public float CoordY()
        {
            return centerY;
        }

        
        public bool Border()
        {
            return vy >= 0;
        }
        
    }

}
