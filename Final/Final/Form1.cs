using System;
using System.Collections.Generic;
using System.ComponentModel;                                                 //still need to:comment all code, ReadMe file, check spelling
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Final
{

    public partial class frmAirHockey : Form
    {
        static int[] PACE = { 1, 2, 3, };                                      //Integer array named PACE with 3 value places

        public int puckX = 6;                                                  //Horizontal X speed value for the puck object
        public int puckY = 6;                                                  //Vertical Y speed value for the puck object
        public int score = 0;                                                  //Score for Player 1
        public int player2Score = 0;                                           //Score for Player 2

        public frmAirHockey()                                                  //Public method containing key event handlers
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(Player1_KeyDown);                   //Allowing key bindings for Player 1
            KeyDown += new KeyEventHandler(Player2_KeyDown);                   //Allowing key bindings for Player 2
            KeyPreview = true;                                                 //Allowing keyboard keys to be used as controls
        }

        void Player1_KeyDown(object sender, KeyEventArgs e)                    //Start of Player 1 control method
        {                                                                      //Start of controls for Player 1
            int x = Player1.Location.X;                                        //Declaring x as an integer to store the x-coordinate of Player 1
            int y = Player1.Location.Y;                                        //Declaring y as an integer to store the y-coordinate of Player 1

            if (e.KeyCode == Keys.D) x += 10;                                  //Setting D key to move Player 1 10 pixels to the right
            else if (e.KeyCode == Keys.A) x -= 10;                             //Setting A key to move Player 1 10 pixels to the left
            else if (e.KeyCode == Keys.W) y -= 10;                             //Setting W key to move Player 1 10 pixels up
            else if (e.KeyCode == Keys.S) y += 10;                             //Setting S key to move Player 1 10 pixels down

            Player1.Location = new Point(x, y);                                //Having Player 1's location be constantly updated in the coordinate plane (x, y)
        }                                                                      //End of controls for Player 1

        private void Player2_KeyDown(object sender, KeyEventArgs e)            //Start of Player 2 control method
        {                                                                      //Start of controls for Player 2
            int x = Player2.Location.X;                                        //Declaring x as an integer to store the x-coordinate of Player 2
            int y = Player2.Location.Y;                                        //Declaring y as an integer to store the y-coordinate of Player 2

            if (e.KeyCode == Keys.Right) x += 10;                              //Setting right arrow key to move Player 2 10 pixels to the right
            else if (e.KeyCode == Keys.Left) x -= 10;                          //Setting left arrow key to move Player 2 10 pixels to the left
            else if (e.KeyCode == Keys.Up) y -= 10;                            //Setting up arrow key to move Player 2 10 pixels up
            else if (e.KeyCode == Keys.Down) y += 10;                          //Setting down arrow key to move Player 2 10 pixels down

            Player2.Location = new Point(x, y);                                //Having Player 1's location be constantly updated in the coordinate plane (x, y)
        }                                                                      //End of controls for Player 2


        private void timerTick(object sender, EventArgs e)                     //Method for the timer that contains all main game functions
        {                                                                      //This is the main timer event, this event will trigger every 20 milliseconds
            Random ranNumberGeneratorPuck = new Random();                      //Creating random number generator named ranNumberGeneratorPuck
            int randomNumberPuck;                                              //Declaring randomNumberPuck as an integer
            randomNumberPuck = ranNumberGeneratorPuck.Next(0, PACE.Length);    //Setting randomNumberPuck equal to what number the random number generator selects from the array PACE


            Player1Score.Text = "" + score;                                    //Show Player 1 score on left label
            Player2Score.Text = "" + player2Score;                             //Show Player 2 score on right label

            puck.Top -= puckY;                                                 //assign the puck TOP to puck Y integer
            puck.Left -= puckX;                                                //assign the puck TOP to puck X integer


            Random ranNumberGenerator = new Random();                          //Creating random number generator named ranNumberGenerator
            int randomNumber;                                                  //Declaring randomNumberPuck as an integer
            randomNumber = ranNumberGenerator.Next(1, 3);                      //Setting randomNumber equal to what number the random number generator selects from the value range of 1, 2

            if (puck.Left < 0)                                                 //If the puck has gone past Player 1's paddle through the left
            {
                if (randomNumber == 1)                                         //If the randomNumber integer equals 1
                {
                    puck.Left = 560;                                           //Reset the puck to the middle of the screen
                    puckX = -puckX;                                            //Change the puck's direction
                }
                else if (randomNumber == 2)                                    //Or if the randomNumber integer equals 2
                {
                    puck.Left = 560;                                           //Reset the puck to the middle of the screen, but leave the direction the same
                }

                player2Score++;                                                //Add 1 to player 2's score (updating label as well)
                puckX = 6;                                                     //Reset the puck's X-value speed to 6
                puckY = 6;                                                     //Reset the puck's Y-value speed to 6
            }

            if (puck.Left + puck.Width > ClientSize.Width)                     //If the puck has gone past player 2's paddle on the right
            {
                if (randomNumber == 1)                                         //If the randomNumber integer equals 1
                {
                    puck.Left = 560;                                           //Reset the puck to the middle of the screen
                    puckX = -puckX;                                            //Change the puck's direction
                }
                else if (randomNumber == 2)                                    //Or if the randomNumber integer equals 2
                {
                    puck.Left = 560;                                           //Reset the puck to the middle of the screen
                }

                score++;                                                       //Add 1 to player 1's score (updating label as well)
                puckX = 6;                                                     //Reset the puck's X-value speed to 6
                puckY = 6;                                                     //Reset the puck's Y-value speed to 6
            }

            //Controlling the puck                                                              

            if (puck.Bounds.IntersectsWith(topBarrier.Bounds) || puck.Bounds.IntersectsWith(bottomBarrier.Bounds)) //If the puck reaches either the top barrier or the bottom barrier
            {
                puckY = -puckY;                                                //Reverse the Y-value speed of the puck so it stays within the screen

            }


            if (puck.Bounds.IntersectsWith(Player1.Bounds) || puck.Bounds.IntersectsWith(Player2.Bounds)) //If the puck hits either player's paddle  
            {
                if ((PACE[randomNumberPuck]) == 0)                             //If the random number generator selected the 1st value in the array
                {
                    puckX = -(Convert.ToInt32((puckX) * .5));                  //Set the puck's X-value speed to 1/2 times the previous X-value's and convert it into an integer
                }
                else if ((PACE[randomNumberPuck]) == 1)                        //Or if the random number generator selected the 2nd value in the array
                {
                    puckX = -(Convert.ToInt32((puckX) * 1.1));                 //Set the puck's X-value speed to 1.1 times the previous X-value's and convert it into an integer
                }
                else if ((PACE[randomNumberPuck]) == 2)                        //Or if the random number generator selected the 3rd value in the array
                {
                    puckX = -puckX;                                            //Set the puck's X-value speed to be equal to the previous X-value's, just in the opposite direction
                }


            }
            else if ((puck.Bounds.IntersectsWith(topLeftBarrier.Bounds) || puck.Bounds.IntersectsWith(bottomLeftBarrier.Bounds) || puck.Bounds.IntersectsWith(topRightBarrier.Bounds) || puck.Bounds.IntersectsWith(bottomRightBarrier.Bounds))) //If the puck reaches any of the side barriers
            {
                if ((PACE[randomNumberPuck]) == 0)                             //If the random number generator selected the 1st value in the array
                {
                    puckX = -(Convert.ToInt32((puckX) * .5));                  //Set the puck's X-value speed to 1/2 times the previous X-value's and convert it into an integer
                }
                else if ((PACE[randomNumberPuck]) == 1)                        //Or if the random number generator selected the 2nd value in the array
                {
                    puckX = -(Convert.ToInt32((puckX) * 1.1));                 //Set the puck's X-value speed to 1.1 times the previous X-value's and convert it into an integer
                }
                else if ((PACE[randomNumberPuck]) == 2)                        //Or if the random number generator selected the 3rd value in the array
                {
                    puckX = -puckX;                                            //Set the puck's X-value speed to be equal to the previous X-value's, just in the opposite direction
                }

            }
            //final score and ending of the game

            if (score > 7)                                                     //If Player 1's score is more than 7
            {
                gameTimer.Stop();                                              //Stop the timer
                string message = "Congratulations, Player 1, you won this game. Do you wish to exit the application?"; //Create a message string applauding Player 1's win and asking whether to quit or go to main menu
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

            if (player2Score > 7)                                              //If Player 2's score is more than 7
            {
                gameTimer.Stop();                                              //Stop the timer
                string message = "Congratulations, Player 2, you won this game. Do you wish to exit the application?"; //Create a message string applauding Player 2's win and asking whether to quit or go to main menu
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