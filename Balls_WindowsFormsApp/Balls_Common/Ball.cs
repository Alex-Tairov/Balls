using System;
using System.Drawing;
using System.Windows.Forms;


namespace Balls_Common
{
    public class Ball
    {
        protected Form form;
        private Graphics graphics;
        private Timer timer = new Timer();
        protected float vx = -10;
        protected float vy = -10;

        protected float centerX = 50;
        protected float centerY = 50;
        
        protected int radius = 25;
        protected Color color = Color.Green;
        protected static Random random = new Random();
        public Ball(Form form)
        {
            this.form = form;
            graphics = form.CreateGraphics();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
        }

        protected int RightBorder()
        {
            return form.ClientSize.Width - radius;
        }

        protected int LeftBorder()
        {
            return radius;
        }
        protected int TopBorder()
        {
            return radius;
        }
        protected int DawnBorder()
        {
            return form.ClientSize.Height - radius;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            Move();
        }
        public bool IsActive()
        {
            return timer.Enabled;
        }
        //Отображаем шарик
        public void Show()
        {
            Draw(color);

        }

        protected virtual void Go() //virtual-можно переопределить
        {
            centerX += vx;
            centerY += vy;
                        
        }

        public void Clear()
        {
            Draw(form.BackColor);
        }

      
        public void Move()
        {
            Clear();
            Go();
            Show();
        }

        public void Start()
        {
            timer.Start();
        }
        
        public void Stop()
        {
            timer.Stop();
        }

        private void Draw(Color color)
        {
            var rectangle = new RectangleF(centerX - radius, centerY - radius, 2 * radius, 2 * radius);
            graphics.FillEllipse(new SolidBrush(color), rectangle);
            
        }
        /*
        //Считаем шарики
        
        public bool OnForm()
        {

            return ((x >= 0 & x + size <= form.ClientSize.Width) & (y >= 0 & y + size <= form.ClientSize.Height));
        }
        */

        //Останавливаем шарик
        public bool Catch(int x, int y)
        {
            return (centerX - x) * (centerX - x) + (centerY - y) * (centerY - y) <= radius * radius;
        }

        public bool Intersect(Ball otherBall)
        {
            var dx = centerX - otherBall.centerX;
            var dy = centerY - otherBall.centerY;
            var distance = Math.Sqrt(dx * dx + dy * dy);
            return distance <= radius + otherBall.radius;
        }





    }



}
