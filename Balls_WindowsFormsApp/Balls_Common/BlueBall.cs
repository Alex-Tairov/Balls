using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Balls_Common
{
    public class BlueBall:RedBall
    {
        public int blueflag = 0;
        public BlueBall(Form form) : base(form)
        {
            color = Color.Blue;
        }
        //Считаем шарики
        public bool CountBlueBall()
        {
            return centerX < form.ClientSize.Width / 2;

        }
    }
}
