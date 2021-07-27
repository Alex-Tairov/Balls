using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FruitNinjaWindowsFormsApp
{
    public partial class MainForm : Form
    {
        Timer timer = new Timer();
                
        static Random random = new Random();
        List<FruitBall> fruits=new List<FruitBall>();
        List<TimerBall> timers = new List<TimerBall>();
        List<BombBall> bombs = new List<BombBall>();
        private int timerBallCounter=0;
        private int bombBallCounter = 0;
        public int score = 0;
        
        public MainForm()
        {
            InitializeComponent();
            timer.Interval = 500;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        
        private void Timer_Tick(object sender, EventArgs e)
        {
            var timerBallRandom = random.Next(1, 5);
            if (timerBallCounter==timerBallRandom)
            {
                timerBallCounter = 0;
                var timerBall = new TimerBall(this);
                timers.Add(timerBall);
                timerBall.Start();
                
            }

            var bombBallRandom = random.Next(5, 10);
            if (bombBallCounter == bombBallRandom)
            {
                bombBallCounter = 0;
                var bombBall = new BombBall(this);
                bombs.Add(bombBall);
                bombBall.Start();
            }


            var fruitsCount = random.Next(2, 6);
            for (int i = 0; i < fruitsCount; i++)
            {
                var ball = new FruitBall(this);
                fruits.Add(ball);
                ball.Start();

            }
            
            GenerateRandomTimerInterval();
            timerBallCounter++;
            if (timerBallCounter == 5)
            {
                timerBallCounter = 0;
            }
            bombBallCounter++;
            if (bombBallCounter == 10)
            {
                bombBallCounter = 0;
            }
        }

        private void GenerateRandomTimerInterval()
        {
            timer.Interval = random.Next(1000, 3000);
        }

        
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (var fruit in fruits)
            {
                if (fruit.Catch(e.X, e.Y) && fruit.IsActive())
                {
                    fruit.Stop();
                    fruit.Clear();
                    score++;
                    ShowScore();
                    
                }
            }
            
            foreach (var timerBall in timers)
            {
                if (timerBall.Catch(e.X, e.Y) && timerBall.IsActive())
                {
                    timerBall.Stop();
                    timerBall.Clear();
                    
                    foreach (var fruit in fruits)
                    {
                        fruit.Slow();
                    }
                    timer.Stop();
                    GenerateRandomTimerInterval();
                    timer.Start();
                    
                    

                }
            
            }

            foreach (var bomb in bombs)
            {
                if (bomb.Catch(e.X, e.Y) && bomb.IsActive())
                {
                    bomb.Stop();
                    bomb.Clear();
                    timer.Stop();
                    foreach (var fruit in fruits)
                    {
                        fruit.Stop();
                        fruit.Clear();
                    }
                    foreach (var tb in timers)
                    {
                        tb.Stop();
                        tb.Clear();
                    }
                    
                    var gameOverForm = new GameOverForm(this);
                    
                    if (gameOverForm.ShowDialog(this) == DialogResult.OK)
                    {
                        score = 0;
                        scoreLabel.Text = score.ToString();
                        timer.Start();
                        
                    }
                    else
                    {
                        Close();
                    }
                }

            }



        }

        private void ShowScore()
        {
            scoreLabel.Text = score.ToString(); 
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
