using System.Drawing;
using System.Windows.Forms;

namespace FruitNinjaWindowsFormsApp
{
    public class BombBall:FruitBall
    {
        public BombBall(Form form) : base(form)
        {
            radius = 30;
            color = Color.Black;
        }
    }
}
