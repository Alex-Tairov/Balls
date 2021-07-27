using System.Drawing;
using System.Windows.Forms;

namespace Balls_Common
{
    public class PointBall : Ball
    {
        public PointBall(Form form, int x, int y) : base(form)
        {
            centerX = radius / 2;
            centerY = radius / 2;
            color = Color.Yellow;


        }
    }



}
