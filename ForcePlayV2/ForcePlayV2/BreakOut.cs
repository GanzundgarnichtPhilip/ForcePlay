using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForcePlayV2
{
    public partial class BreakOut : Form
    {

        bool goLeft;
        bool goRight;
        bool isGameOver;

        int ballx;
        int highscore;
        int bally;
        int playerSpeed;

        Random rnd = new Random();  



        public BreakOut()
        {
            InitializeComponent();

            setupGame();
        }

        private void setupGame()
        {
            highscore = 0;
            ballx = 5;  
            bally = 5;  
            playerSpeed = 12;

            score.Text = $"Score: {highscore}";

            gameTimer.Start();

            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "blocks")
                {
                    x.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                }
            }
        }

        private void gameOver(string message)
        {
            isGameOver = true;
            gameTimer.Stop();

            score.Text = $"Score: {highscore} {message}";
        }


        private void player_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void mainGameTimerEvent(object sender, EventArgs e)
        {

            score.Text = $"Score: {highscore}";

            if (goLeft == true && player.Left > 0)
            {
                player.Left -= playerSpeed;
            }

            if (goRight == true && player.Left < 700)
            {
                player.Left += playerSpeed;
            }

            ball.Left += ballx;
            ball.Top += bally;

            if (ball.Left < 0 || ball.Left > 775)
            {
                ballx = -ballx;
            }

            if (ball.Top < 0)
            {
                bally = -bally;
            }

            if (ball.Bounds.IntersectsWith(player.Bounds))
            {
                bally = rnd.Next(5, 12) * -1;

                if (ballx < 0)
                {
                    ballx = rnd.Next(5, 12) * -1;
                }

                else
                {
                    ballx = rnd.Next(5, 12);
                }
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "blocks")
                {
                    if(ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        highscore += 1;

                        bally = -bally;

                        this.Controls.Remove(x); 
                    }

                }
            }

            if(highscore == 18)
            {
                gameOver("Sieg!!! === 15 Punkte ;)");
            }

            if(ball.Top > 580)
            {
                gameOver("Game Over!!!");
            }



        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left) 
            {
                goLeft = true;
            }

            if(e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
        }

        private void BreakOut_Load(object sender, EventArgs e)
        {

        }
    }
}
