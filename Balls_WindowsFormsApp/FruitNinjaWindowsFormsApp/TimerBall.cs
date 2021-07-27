using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FruitNinjaWindowsFormsApp
{
    public class TimerBall:FruitBall
    {
        public TimerBall(Form form) : base(form)
        {
            radius = 30;
            color = Color.Red;
        }

        
    }
}
