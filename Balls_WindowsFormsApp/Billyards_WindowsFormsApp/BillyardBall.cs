using Balls_Common;
using System;
using System.Windows.Forms;

namespace Billyards_WindowsFormsApp
{
    public class BillyardBall : RandomMovementBall
    {
        
       // public event EventHandler<HitEventArgs> Hit;
        public BillyardBall(Form form) : base(form)
        {

        }
        /*
        //Переопределение метода
        protected override void Go()
        {
            base.Go();
            if (centerX <= radius)
            {
                vx = -vx;
                if (Hit != null)
                {
                    Hit.Invoke(this, new HitEventArgs(Side.Left));
                }
            }
            if(centerX >= form.ClientSize.Width - radius)
            {
                vx = -vx;
                Hit?.Invoke(this, new HitEventArgs(Side.Right));
            }
            if (centerY <= radius )
            {
                vy = -vy;
                Hit?.Invoke(this, new HitEventArgs(Side.Top));
            }
            if(centerY >= form.ClientSize.Height - radius)
            {
                vy = -vy;
                Hit?.Invoke(this, new HitEventArgs(Side.Down));
            }
        }
        */
        
    }
}
