using Balls_Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Billyards_WindowsFormsApp
{
    public partial class BillyardsForm : Form
    {
        List<RedBall> redballs;
        List<BlueBall> blueballs;
        private Form form;
        private int counterRedBall=0;
        private int counterBlueBall = 0;
        int topCount = 0;
        int downCount = 0;
        int leftCount = 0;
        int rightCount = 0;
        
        private Timer timer1 = new Timer();


        public BillyardsForm()
        {
            InitializeComponent();
            timer1.Tick += Timer_Tick;
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
                                      
            foreach(var redball in redballs)
            {
                if ((redball.CountRedBall()) & (redball.redflag!=1))
                {
                    counterRedBall++;
                    redball.redflag=1;
                }
            }

            foreach (var blueball in blueballs)
            {
                if ((blueball.CountBlueBall()) & (blueball.blueflag != 1))
                {
                    counterBlueBall++;
                    blueball.blueflag = 1;
                }
            }
            
            if ((counterRedBall >= 5)&&(counterBlueBall>=5))
            {
                foreach(var redball in redballs)
                {
                   redball.Stop();
                }
                
                foreach(var blueball in blueballs)
                {
                   blueball.Stop();
                }

                var diffusionForm = new DiffusionForm();
                
                timer1.Stop();
                
                if (diffusionForm.ShowDialog(this) == DialogResult.OK)
                {
                    
                    foreach (var redball in redballs)
                    {
                        redball.Wash();
                        redball.Show();
                    }

                    foreach (var blueball in blueballs)
                    {
                        blueball.Wash();
                        blueball.Show();
                    }
                    redballs.Clear();
                    blueballs.Clear();
                    counterRedBall = 0;
                    counterBlueBall = 0;
                }
                else
                {
                    Close();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            balls = new List<Ball>();
            for (int i = 0; i < 1; i++)
            {
                var ball = new BillyardBall(this);
                ball.Hit += Ball_Hit;
                balls.Add(ball);
                ball.Start();
            }
            */
        }

        private void Ball_Hit(object sender, HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Top:
                    topCount++;
                    topLabel.Text = topCount.ToString();
                    break;
                case Side.Left:
                    leftCount++;
                    leftLabel.Text = leftCount.ToString();
                    break;
                case Side.Right:
                    rightCount++;
                    rightLabel.Text = rightCount.ToString();
                    break;
                case Side.Down:
                    downCount++;
                    downLabel.Text = downCount.ToString();
                    break;

            }
        }
        
        //Рисовать
        private void button1_Click(object sender, EventArgs e)
        {
            //Рисуем 10 красных шаров
            redballs = new List<RedBall>();
                                             
            var x1 = 30;
            var y1 = 50;
                        
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= 2; j++)
                {
                    var redball = new RedBall(this);
                    redball.DrawBall(x1, y1);
                    redballs.Add(redball);
                    x1 += 60;
                    redball.Show();
                }
                y1 +=this.ClientSize.Height/5;
                x1 = 30;
              
            }

            //Рисуем 10 синих шаров          
            blueballs = new List<BlueBall>();
            
            var x2 = this.ClientSize.Width - 100;
            var y2 = 50;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 2; j++)
                {
                    var blueball = new BlueBall(this);
                    blueball.DrawBall(x2, y2);
                    blueballs.Add(blueball);
                    x2 += 60;
                    blueball.Show();
                }
                y2 += this.ClientSize.Height / 5;
                x2 = this.ClientSize.Width - 100;

            }
          
        }
        //Двигать
        private void button2_Click(object sender, EventArgs e)
        {

            foreach (var ball in redballs)
            {
                ball.Start();
                
            }
                                 
            foreach (var ball in blueballs)
            {
                ball.Start();
            }
            
             
            timer1.Start();
            

        }
    }
}
