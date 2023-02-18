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
                    x.BackColor = Color.FromArgb(rnd.Next(256),rnd.Next(256), rnd.Next(256));
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void player_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void mainGameTimerEvent(object sender, EventArgs e)
        {

        }

        private void keyisdown(object sender, KeyEventArgs e)
        {

        }

        private void keyisup(object sender, KeyEventArgs e)
        {

        }
    }
}
