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
        static int[] PACEGame = { 1, 2, 3, };                                      //Integer array named PACE with 3 value places

        int speed = 5;                                                             //Integer called speed holding value of 5
        public int puckXGame = 10;                                                 //Horizontal X speed value for the puck object
        public int puckYGame = 10;                                                 //Vertical Y speed value for the puck object
        public int scoreGame = 7;                                                  //Score for Player 1
        public int cpuPointGame = 7;                                               //Score for the CPU

        public frmAirHockeyCpu()                                                   //Public method containing key event handlers
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(Player1_KeyDown); ;                     //Allowing key bindings for Player 1
            KeyPreview = true;                                                     //Allowing keyboard keys to be used as controls
        }

        void Player1_KeyDown(object sender, KeyEventArgs e)                        //Start of Player 1 control method
        {                                                                          //Start of controls for Player 1
            int x = Player1Game.Location.X;                                        //Declaring x as an integer to store the x-coordinate of Player 1
            int y = Player1Game.Location.Y;                                        //Declaring y as an integer to store the y-coordinate of Player 1

            if (e.KeyCode == Keys.D) x += 10;                                      //Setting D key to move Player 1 10 pixels to the right
            else if (e.KeyCode == Keys.A) x -= 10;                                 //Setting A key to move Player 1 10 pixels to the left
            else if (e.KeyCode == Keys.W) y -= 10;                                 //Setting W key to move Player 1 10 pixels up
            else if (e.KeyCode == Keys.S) y += 10;                                 //Setting S key to move Player 1 10 pixels down

            Player1Game.Location = new Point(x, y);                                //Having Player 1's location be constantly updated in the coordinate plane (x, y)
        }                                                                          //End of controls for Player 1

        private void timerTickGame(object sender, EventArgs e)                     //Method for the timer that contains all main game functions
        {                                                                          //this is the main timer event, this event will trigger every 20 milliseconds
            Random ranNumberGeneratorPuck = new Random();                          //Creating random number generator named ranNumberGeneratorPuck
            int randomNumberPuck;                                                  //Declaring randomNumberPuck as an integer
            randomNumberPuck = ranNumberGeneratorPuck.Next(0, PACEGame.Length);    //Setting randomNumberPuck equal to what number the random number generator selects from the array PACEGame

            Player1ScoreGame.Text = "" + scoreGame;                                //Show Player 1's score on left label
            Player2ScoreGame.Text = "" + cpuPointGame;                             //Show CPU's score on right label

            puckGame.Top -= puckYGame;                                             //Assign the puck TOP to puck Y integer
            puckGame.Left -= puckXGame;                                            //Assign the puck TOP to puck X integer

            CPU.Top += speed;                                                      //Assignment of the CPU top speed integer                              



            if (scoreGame < 5)                                                     //If the score is less than 5
            {                                                                      //Start of CPU code
                if (CPU.Top < 0 || CPU.Top > 527)                                  //If the CPU has reached the top or gone to the bottom of the screen
                {
                    speed = -speed;                                                //Change the speed direction so the paddle moves back up or down
                }
            }
            else                                                                   //Or if score is greater than 5, increase difficulty by enabling tracking on right paddle
            {
                CPU.Top = puckGame.Top + 30;                                       //Have the top of the CPU stay 30 pixels above the top of the puck
            }                                                                      //end of CPU code

            Random ranNumberGeneratorGame = new Random();                          //Creating random number generator named ranNumberGeneratorGame
            int randomNumberGame;                                                  //Declaring randomNumberGame as an integer
            randomNumberGame = ranNumberGeneratorGame.Next(1, 3);                  //Setting randomNumberGame equal to what number the random number generator selects from the value range of 1, 2

            if (puckGame.Left < 0)                                                 //If the puck has gone past Player 1's paddle through the left
            {
                if (randomNumberGame == 1)                                         //If the randomNumberGame integer equals 1
                {
                    puckGame.Left = 560;                                           //Reset the puck to the middle of the screen
                    puckXGame = -puckXGame;                                        //Change the puck's direction
                }
                else if (randomNumberGame == 2)                                    //If the randomNumberGame integer equals 2
                {
                    puckGame.Left = 560;                                           //Reset the puck to the middle of the screen, but leave the direction the same
                }

                cpuPointGame++;                                                    //Add 1 to the CPU's score
                puckXGame = 6;                                                     //Reset the puck's X-value speed to 6
                puckYGame = 6;                                                     //Reset the puck's Y-value speed to 6

            }

            if (puckGame.Left + puckGame.Width > ClientSize.Width)                 //If the puck has gone past player 2's paddle on the right
            {
                if (randomNumberGame == 1)                                         //If the randomNumberGame integer equals 1
                {
                    puckGame.Left = 560;                                           //Reset the puck to the middle of the screen
                    puckXGame = -puckXGame;                                        //Change the puck's direction
                }
                else if (randomNumberGame == 2)                                    //If the randomNumberGame integer equals 2
                {
                    puckGame.Left = 560;                                           //Reset the puck to the middle of the screen, but leave the direction the same
                }

                scoreGame++;                                                       //Add 1 to Player 1's score
                puckXGame = 6;                                                     //Reset the puck's X-value speed to 6
                puckYGame = 6;                                                     //Reset the puck's Y-value speed to 6
            }

            //Controlling the puck


            if (puckGame.Bounds.IntersectsWith(topBarrierGame.Bounds) || puckGame.Bounds.IntersectsWith(bottomBarrierGame.Bounds)) //If the puck reaches either the top barrier or the bottom barrier
            {
                puckYGame = -puckYGame;                                            //Reverse the speed of the puck so it stays within the screen

            }


            if (puckGame.Bounds.IntersectsWith(Player1Game.Bounds) || puckGame.Bounds.IntersectsWith(CPU.Bounds))  //If the puck hits either paddle
            {
                if ((PACEGame[randomNumberPuck]) == 0)                             //If the random number generator selected the 1st value in the array
                {
                    puckXGame = -(Convert.ToInt32((puckXGame) * .5));              //Set the puck's X-value speed to 1/2 times the previous X-value's and convert it into an integer
                }
                else if ((PACEGame[randomNumberPuck]) == 1)                        //Or if the random number generator selected the 2nd value in the array
                {
                    puckXGame = -(Convert.ToInt32((puckXGame) * 1.1));             //Set the puck's X-value speed to 1.1 times the previous X-value's and convert it into an integer
                }
                else if ((PACEGame[randomNumberPuck]) == 2)                        //Or if the random number generator selected the 3rd value in the array
                {
                    puckXGame = -puckXGame;                                        //Set the puck's X-value speed to be equal to the previous X-value's, just in the opposite direction
                }
            }
            else if ((puckGame.Bounds.IntersectsWith(topLeftBarrierGame.Bounds) || puckGame.Bounds.IntersectsWith(bottomLeftBarrierGame.Bounds) || puckGame.Bounds.IntersectsWith(topRightBarrierGame.Bounds) || puckGame.Bounds.IntersectsWith(bottomRightBarrierGame.Bounds))) //If the puck reaches any of the side barriers
            {
                if ((PACEGame[randomNumberPuck]) == 0)                             //If the random number generator selected the 1st value in the array
                {
                    puckXGame = -(Convert.ToInt32((puckXGame) * .5));              //Set the puck's X-value speed to 1/2 times the previous X-value's and convert it into an integer
                }
                else if ((PACEGame[randomNumberPuck]) == 1)                        //Or if the random number generator selected the 2nd value in the array
                {
                    puckXGame = -(Convert.ToInt32((puckXGame) * 1.1));             //Set the puck's X-value speed to 1.1 times the previous X-value's and convert it into an integer
                }
                else if ((PACEGame[randomNumberPuck]) == 2)                        //Or if the random number generator selected the 3rd value in the array
                {
                    puckXGame = -puckXGame;                                        //Set the puck's X-value speed to be equal to the previous X-value's, just in the opposite direction
                }
            }
            //final score and ending of the game

            if (scoreGame > 7)                                                     //If Player 1's score is more than 7
            {
                gameTimerCpu.Stop(); ;                                              //Stop the timer
                string message = "Congratulations, Player 1, you won this game. Do you wish to exit the application?"; //Create a message string applauding Player 1's win and asking whether to quit or go to main menu
                string title = "Close Window";                                     //Create a message string to name the end game pop-up message box
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;               //Creating message box buttons Yes and No
                DialogResult result = MessageBox.Show(message, title, buttons);    //Function to call message, title, and button strings for use in the end game pop-up message box
                if (result == DialogResult.Yes)                                    //If the user pushes the Yes button
                {
                    Application.Exit();                                            //Close the entire application
                }
                else                                                               //Or if the user pushes the No button
                {
                    mainMenu OpenMenu = new mainMenu();                            //Open the main menu again
                    this.Close();                                                  //Close the current game window
                }
            }

            if (cpuPointGame > 7)                                                  //If the CPU's score is more than 7
            {
                gameTimerCpu.Stop();                                              //Stop the timer
                string message = "Congratulations, Player 2, you won this game. Do you wish to exit the application?"; //Create a message string applauding the CPU's win and asking whether to quit or go to main menu
                string title = "Close Window";                                 //Create a message string to name the end game pop-up message box
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;           //Creating message box buttons Yes and No
                DialogResult result = MessageBox.Show(message, title, buttons); //Function to call message, title, and button strings for use in the end game pop-up message box
                if (result == DialogResult.Yes)                                //If the user pushes the Yes button
                {
                    Application.Exit();                                        //Close the entire application
                }
                else                                                           //Or if the user pushes the No button
                {

                    mainMenu OpenMenu = new mainMenu();                        //Open the main menu again
                    this.Close();                                              //Close the current game window
                }

            }


        }
    }
}