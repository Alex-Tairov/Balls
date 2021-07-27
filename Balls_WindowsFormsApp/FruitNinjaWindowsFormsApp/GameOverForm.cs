using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FruitNinjaWindowsFormsApp
{
    
    public partial class GameOverForm : Form
    {
        private MainForm main;
        public GameOverForm(MainForm main)
        {
            InitializeComponent();
            this.main = main;
            userScoreLabel.Text = main.score.ToString();
        }
                
    }
}
