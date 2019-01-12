using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class frmAirHockeyCpu : Form
    {
        static int[] PACE = { 1, 2, 3, };

        int speed = 5; //integer called speed holding value of 5                      //CPU code
        public int puckXGame = 10; //horizontal X speed value for the puck object
        public int puckYGame = 10; //vertical Y speed value for the puck object
        public int scoreGame = 9; //score for the player
        public int cpuPointGame = 9;// score for the CPU

        public frmAirHockeyCpu()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(Player1_KeyDown);
            // KeyDown += new KeyEventHandler(Player2_KeyDown);
            KeyPreview = true;
        }

        void Player1_KeyDown(object sender, KeyEventArgs e)                    //Start of controls for Player 1
        {
            int x = Player1Game.Location.X;
            int y = Player1Game.Location.Y;

            if (e.KeyCode == Keys.D) x += 10;
            else if (e.KeyCode == Keys.A) x -= 10;
            else if (e.KeyCode == Keys.W) y -= 10;
            else if (e.KeyCode == Keys.S) y += 10;

            Player1Game.Location = new Point(x, y);
        }                                                                   //End of controls for Player

        private void timerTickGame(object sender, EventArgs e)
        {
            //this is the main timer event, this event will trigger every 20 milliseconds
            Random ranNumberGeneratorPuck = new Random();
            int randomNumberPuck;
            randomNumberPuck = ranNumberGeneratorPuck.Next(0, PACE.Length);

            Player1ScoreGame.Text = "" + scoreGame; //show Player 1 score on left label
            Player2ScoreGame.Text = "" + cpuPointGame; //show Player 2 score on right label

            puckGame.Top -= puckYGame; //assign the puck TOP to puck Y integer
            puckGame.Left -= puckXGame; //assign the puck TOP to puck X integer

            CPU.Top += speed; //assignment of the CPU top speed integer                               //CPU code
            
            //if the score is less than 5
            
            if (scoreGame < 5)                                                                                //start of CPU code
            {
                //if Player 2 has reached the top or gone to the bottom of the screen
                if (CPU.Top < 0 || CPU.Top > 527)
                {
                    //change the speed direction so the paddle moves back up or down
                    speed = -speed;
                }
            }
            else //if score is greater than 5, increase difficulty by enabling tracking on right paddle
            {
                CPU.Top = puckGame.Top + 30;
            }                                                                                          //end of CPU code

            //check the score
            Random ranNumberGenerator = new Random();                                                       //test for random puck spawn after score
            int randomNumber;
            randomNumber = ranNumberGenerator.Next(1, 3);
            //if the puck has gone past Player 1's paddle through the left
            if (puckGame.Left < 0)
            {
                if (randomNumber == 1)
                {
                    puckGame.Left = 560; //reset the puck to the middle of the screen
                    puckXGame = -puckXGame; //change the puck's direction
                }
                else if (randomNumber == 2)
                {
                    puckGame.Left = 560; //reset the puck to the middle of the screen
                }

                cpuPointGame++; //add 1 to player 2's score
                puckXGame = 6;
                puckYGame = 6;
            }

            //if the puck has gone past player 2's paddle on the right


            if (puckGame.Left + puckGame.Width > ClientSize.Width)
            {
                if (randomNumber == 1)
                {
                    puckGame.Left = 560; //reset the puck to the middle of the screen
                    puckXGame = -puckXGame; //change the puck's direction
                }
                else if (randomNumber == 2)
                {
                    puckGame.Left = 560; //reset the puck to the middle of the screen
                }

                scoreGame++; //add 1 to player 1's score
                puckXGame = 6;
                puckYGame = 6;
            }





            //controlling the puck





            //if the puck either reaches the top of the screen or the bottom
            if (puckGame.Bounds.IntersectsWith(topBarrierGame.Bounds) || puckGame.Bounds.IntersectsWith(bottomBarrierGame.Bounds))
            {
                puckYGame = -puckYGame; //reverse the speed of the puck so it stays within the screen

            }

            //if the puck hits either paddle
            if (puckGame.Bounds.IntersectsWith(Player1Game.Bounds) || puckGame.Bounds.IntersectsWith(CPU.Bounds))      //collision stuff
            {
                if ((PACE[randomNumberPuck]) == 0)
                {
                    puckXGame = -(Convert.ToInt32((puckXGame) * .5));
                }
                else if ((PACE[randomNumberPuck]) == 1)
                {
                    puckXGame = -(Convert.ToInt32((puckXGame) * 1.1));
                }
                else if ((PACE[randomNumberPuck]) == 2)
                {
                    puckXGame = -(Convert.ToInt32((puckXGame) * 1));
                }


            }
            else if ((puckGame.Bounds.IntersectsWith(topLeftBarrierGame.Bounds) || puckGame.Bounds.IntersectsWith(bottomLeftBarrierGame.Bounds) || puckGame.Bounds.IntersectsWith(topRightBarrierGame.Bounds) || puckGame.Bounds.IntersectsWith(bottomRightBarrierGame.Bounds)))
            {
                if ((PACE[randomNumberPuck]) == 0)
                {
                    puckXGame = -(Convert.ToInt32((puckXGame) * .5));
                }
                else if ((PACE[randomNumberPuck]) == 1)
                {
                    puckXGame = -(Convert.ToInt32((puckXGame) * 1.1));
                }
                else if ((PACE[randomNumberPuck]) == 2)
                {
                    puckXGame = -(Convert.ToInt32((puckXGame) * 1));
                }

            }

            //final score and ending the game
            
            //if Player 1's score is more than 9, stop the timer and show a winning message box for Player 1
            if (scoreGame > 9)
            {
                gameTimerCpu.Stop();
                string message = "Congratulations, Player 1, you won this game. Do you wish to exit the application?";
                string title = "Close Window";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    mainMenu OpenMenu = new mainMenu();
                    this.Close();
                }
            }
            //if Player 2's score is more than 9, stop the timer and show a winning message box for Player 2
            if (cpuPointGame > 9)
            {
                gameTimerCpu.Stop();
                string message = "Congratulations, Player 2, you won this game. Do you wish to exit the application?";
                string title = "Close Window";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {

                    mainMenu OpenMenu = new mainMenu();
                    this.Close();
                }

            }


        }
    }
}
