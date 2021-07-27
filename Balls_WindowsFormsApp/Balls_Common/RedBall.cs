using System.Drawing;
using System.Windows.Forms;

namespace Balls_Common
{

    public class RedBall : RandomMovementBall
    {
        public int redflag = 0;

        public RedBall(Form form) : base(form)
        {
            color = Color.Red;
            vx = random.Next(-5, 5);
            vy = random.Next(-5, 5);

        }
        public void Wash()
        {
            color = Color.White;
        }

        //Ставим шарики
        public void DrawBall(int x, int y)
        {
            centerX = x;
            centerY = y;
        }
        //Считаем шарики
        public bool CountRedBall()
        {
            return centerX > form.ClientSize.Width / 2;

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
