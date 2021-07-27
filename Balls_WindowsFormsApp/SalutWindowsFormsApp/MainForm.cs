using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SalutWindowsFormsApp
{
    public partial class MainForm : Form
    {
        public float x;
        public float y;
        private Timer timer = new Timer();
        List<SalutBall> salutballs;
        List<int> width;
        static Random random = new Random();
        private int count;
                
        public MainForm()
        {
            InitializeComponent();
            timer.Tick += Timer_Tick;
            timer.Interval = 500;
            timer.Start();
            salutballs = new List<SalutBall>();
            width = new List<int> { this.ClientSize.Width / 2- this.ClientSize.Width /10, this.ClientSize.Width / 2 + this.ClientSize.Width / 10 };
            count = random.Next(5,10);
            
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            var salut = new SalutBall(this,width[random.Next(0,width.Count)], this.ClientSize.Height-50);
            salut.Start();
            salutballs.Add(salut);

            for (int i = 0; i < salutballs.Count; i++)
            {
                if (salutballs[i].CoordY() <= this.ClientSize.Height-this.ClientSize.Height / 3)
                {
                    
                    salutballs[i].Stop();
                    salutballs[i].Clear();
                    for (int j = 0; j < count; j++)
                    {
                        var salut1 = new SalutBall(this, salutballs[i].CoordX(), this.ClientSize.Height - this.ClientSize.Height / 3);
                        salut1.Start();
                    }
                    salutballs.RemoveAt(i);
                    

                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
