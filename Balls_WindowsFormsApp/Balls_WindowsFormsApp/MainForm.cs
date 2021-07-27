using Balls_Common;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Balls_WindowsFormsApp
{
    
    public partial class MainForm : Form
    {
        List <RandomMovementBall> balls;
        
       // private int counter = 0;
        
        public MainForm()
        {
            InitializeComponent();
        }

       
        //Рисуем 10 шаров
        private void DrawRandomBalls(object sender, EventArgs e)
        {
            balls = new List<RandomMovementBall>();
            for(int i = 0; i < 10; i++)
            {
                var ball = new RandomMovementBall(this);
                ball.Show();
                balls.Add(ball);
            }
        }

        //Остановка
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (var ball in balls)
            {
                if (ball.Catch(e.X,e.Y))
                {
                    ball.Stop();
                }
            }
        }

        //Двигать
        private void MoveBalls(object sender, EventArgs e)
        {
            foreach (var ball in balls)
            {
                ball.Start();
            }
        }

        
        //Остановить
        private void StopBalls(object sender, EventArgs e)
        {
            foreach (var ball in balls)
            {
                ball.Stop();
            }

        }
        /*
        //Счет
        private void CountBalls(object sender, EventArgs e)
        {
            foreach (var ball in balls)
            {
                if (ball.OnForm())
                {
                    ++counter;
                }
            }
            MessageBox.Show(Convert.ToString(counter));
            counter = 0;
            
        }  
        */
            
         

            

        

        
    }
}
