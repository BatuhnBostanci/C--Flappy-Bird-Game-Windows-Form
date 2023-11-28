using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        
        int boruHizi = 8;
        int gravity = 15;
        int score = 0;


        public Form1()
        {
            InitializeComponent();
        }

 

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flapyBird.Top += gravity;
            BoruAlt.Left -= boruHizi;
            BoruUst.Left -= boruHizi;
            scoreText.Text = "Score: " + score;
            
            if (BoruAlt.Left < -150)
            {
                BoruAlt.Left = 800;
                score++;
            }
            if(BoruAlt.Left < -180)
            {
                BoruUst.Left = 950;
                score++;
            }

            if(flapyBird.Bounds.IntersectsWith(BoruAlt.Bounds) || flapyBird.Bounds.IntersectsWith(BoruUst.Bounds)||flapyBird.Bounds.IntersectsWith(Zemin.Bounds))
            {
                endGame();
            }
            if (score>5)
            {
                boruHizi = 10;
            }
            if (score > 10)
            {
                boruHizi = 20;
            }
            if (score > 15)
            {
                boruHizi = 35;
            }
            if (score > 25)
            {
                boruHizi = 45;
            }
            if (score > 35)
            {
                boruHizi = 65;
            }




            if (flapyBird.Top<-25)
            {
                endGame();
            }
        }

        private void gamekeyisdows(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }

        }

        private void gemakeyisup(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Space)
            {
                
                gravity = 15;
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text = "Game Over";


        }
    }
}
