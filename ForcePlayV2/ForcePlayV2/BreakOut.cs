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
        //Festlegen der relevanten Variabeln

        bool goLeft;
        bool goRight;
        bool isGameOver;

        int ballx;
        int highscore;
        int bally;
        int playerSpeed;

        Random rnd = new Random(); // Die Random-Klasse für zufällige PictureBox - Farben
        
        PictureBox[] blockArray; // Array für alle PictureBoxen um sie platzieren zu können

        public BreakOut()
        {
            InitializeComponent();

            // Die PictureBoxen werden platziert
            PlaceBlocks();
        }
        /// <summary>
        /// setupGame lädt das Spiel und legt die Farben der PictureBoxen fest. 
        /// Zudem wird der Highscore ausgegeben.
        /// Wichtige Parameter werden festgelegt.
        /// </summary>
        private void setupGame()
        {
            isGameOver = false;
            highscore = 0;
            ballx = 5;  
            bally = 5;  
            playerSpeed = 12;

            score.Text = $"Score: {highscore}";

            ball.Left = 376;
            ball.Top = 328;

            player.Left = 347;

            // Gametimer startet
            gameTimer.Start();

            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "blocks")
                {
                    x.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                }
            }
        }
        /// <summary>
        /// Das Ende des Spiel wird in gameOver festgelet.
        /// Message gibt die dazugehörigen Szenarien aus -> Game Over | win
        /// </summary>
        /// <param name="message"></param>
        private void gameOver(string message)
        {
            isGameOver = true;
            gameTimer.Stop();

            score.Text = $"Score: {highscore} {message}";
        }
        /// <summary>
        /// Alle 15 PictureBoxen werde durch feste Parameter platziert. 
        /// Das Spielfeld wird somit voll. 
        /// </summary>
        private void PlaceBlocks()
        {
            // Es gibt 15 PictureBoxen im Spiel
            blockArray = new PictureBox[15];

            int a = 0;

            int top = 50;
            int left = 100;

            // PictureBoxen werden platziert
            for(int i = 0; i < blockArray.Length; i++)
            {
                blockArray[i] = new PictureBox();
                blockArray[i].Height = 32;
                blockArray[i].Width = 100;
                blockArray[i].Tag = "blocks";
                blockArray[i].BackColor = Color.White;

                if(a == 5)
                {
                    top = top + 50;
                    left = 100;
                    a = 0;
                }

                if(a < 5)
                {
                    a++;
                    blockArray[i].Left = left;
                    blockArray[i].Top = top;
                    this.Controls.Add(blockArray[i]);
                    left = left + 130;
                }
            }
            setupGame();
        }
        /// <summary>
        /// Die PictureBoxen werden gelöscht
        /// </summary>
        private void removeBlocks()
        {
            foreach(PictureBox x in blockArray)
            {
                this.Controls.Remove(x);
            }

        }

        private void player_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// In mainGameTimerEvent werden die Funktionalitäten des Spiels festgehalten
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainGameTimerEvent(object sender, EventArgs e)
        {

            score.Text = $"Score: {highscore}";

            // Bewegung links
            if (goLeft == true && player.Left > 0)
            {
                player.Left -= playerSpeed;
            }

            // Bewegung rechts
            if (goRight == true && player.Left < 700)
            {
                player.Left += playerSpeed;
            }

            // Ball bewegt sich
            ball.Left += ballx;
            ball.Top += bally;

            // Grenzen des Ball in X-Richtung
            if (ball.Left < 0 || ball.Left > 775)
            {
                ballx = -ballx;
            }

            // Grenzen des Balls in Y-Richtung (Nur obere Grenze)
            if (ball.Top < 0)
            {
                bally = -bally;
            }

            // Interaktionen mit dem Spieler
            if (ball.Bounds.IntersectsWith(player.Bounds))
            {
                ball.Top = 436;

                // Ballgeschwindigkeit ist zufällig bei jeder Interaktion
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

            // Highscore wird beim Kontakt zwischen Ball und PictureBox erhöht
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "blocks")
                {
                    if(ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        highscore += 1;

                        bally = -bally;

                        // Block wird bei Kontakt mit Ball enfernt
                        this.Controls.Remove(x); 
                    }

                }
            }

            // Siegbedingung
            if(highscore == 15)
            {
                gameOver("Sieg!!! === 15 Punkte ;) >>> ENT");
            }

            // Loserbedingung
            if(ball.Top > 580)
            {
                gameOver("Game Over!!! >>> ENT");
            }



        }

        // Mit Pfeiltasten lässt sich der Player steuern.
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

        // Die obere und untere Pfeiltasten werden verboten.
        // Bewegung nur in X-Achse möglich.
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

            if(e.KeyCode == Keys.Enter && isGameOver == true)
            {
                removeBlocks();
                PlaceBlocks();
            }
        }

        private void BreakOut_Load(object sender, EventArgs e)
        {

        }
    }
}
