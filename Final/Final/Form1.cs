using System;
using System.Collections.Generic;
using System.ComponentModel;                                                 //still need to: Make it ask if user is done, comment all code, ReadMe file, check spelling, add a loop, add an array
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Final                                                                        //As of now, Player 2 is in manual mode, not CPU mode
{
    
    public partial class frmAirHockey : Form
    {
        
        //bool goUp; //boolean to be used to detect player up position
        //bool goDown; //boolean to be used to detect player down position
        //int speed = 5; //integer called speed holding value of 5                      //CPU code
        public int puckX = 10; //horizontal X speed value for the puck object
        public int puckY = 10; //vertical Y speed value for the puck object
        public int score = 9; //score for the player
        public int cpuPoint = 9;// score for the CPU

        string[] list = Directory.GetFiles(@"C:Users\nn137422\Deskptop\Final\Final\Final\Resources", "*.PNG", "*.png");
        PictureBox[] pictureBoxes = new PictureBox[list.Length];

        public frmAirHockey()
        {
            
            InitializeComponent();
            KeyDown += new KeyEventHandler(Player1_KeyDown);
            KeyDown += new KeyEventHandler(Player2_KeyDown);
            KeyPreview = true;
        }

        void Player1_KeyDown(object sender, KeyEventArgs e)                    //Start of controls for Player 1
        {
            int x = Player1.Location.X;
            int y = Player1.Location.Y;

            if (e.KeyCode == Keys.D) x += 10;
            else if (e.KeyCode == Keys.A) x -= 10;
            else if (e.KeyCode == Keys.W) y -= 10;
            else if (e.KeyCode == Keys.S) y += 10;

            Player1.Location = new Point(x, y);
        }                                                                   //End of controls for Player 1

       

        private void Player2_KeyDown(object sender, KeyEventArgs e)         //Start of controls for Player 2
        {
            int x = Player2.Location.X;
            int y = Player2.Location.Y;

            if (e.KeyCode == Keys.Right) x += 10;
            else if (e.KeyCode == Keys.Left) x -= 10;
            else if (e.KeyCode == Keys.Up) y -= 10;
            else if (e.KeyCode == Keys.Down) y += 10;

            Player2.Location = new Point(x, y);
        }                                                                //End of controls for Player 2

        private void timerTick(object sender, EventArgs e)
        {
            //this is the main timer event, this event will trigger every 20 milliseconds

            Player1Score.Text = "" + score; //show Player 1 score on left label
            Player2Score.Text = "" + cpuPoint; //show Player 2 score on right label

            puck.Top -= puckY; //assign the puck TOP to puck Y integer
            puck.Left -= puckX; //assign the puck TOP to puck Y integer

            //Player2.Top += speed; //assignment of the CPU top speed integer                               //CPU code





            //if the score is less than 5





            /*if (score < 5)                                                                                //start of CPU code
            {
                //if Player 2 has reached the top or gone to the bottom of the screen
                if (Player2.Top < 0 || Player2.Top > 527)
                {
                    //change the speed direction so the paddle moves back up or down
                    speed = -speed;
                }
            }
            else //if score is greater than 5, increase difficulty by enabling tracking on right paddle
            {
                Player2.Top = puck.Top + 30;
            }*/                                                                                             //end of CPU code

            //check the score
            Random ranNumberGenerator = new Random();                                                       //test for random puck spawn after score
            int randomNumber;
            randomNumber = ranNumberGenerator.Next(1, 3);
            //if the puck has gone past Player 1's paddle through the left
            if (puck.Left < 0)
            {
                if (randomNumber == 1)
                {
                    puck.Left = 560; //reset the puck to the middle of the screen
                    puckX = -puckX; //change the puck's direction
                    puckX -= 2; //increase the speed
                }
                else if (randomNumber == 2)
                {
                    puck.Left = 560; //reset the puck to the middle of the screen
                    puckX -= 2; //increase the speed
                    
                }
                
                cpuPoint++; //add 1 to player 2's score
            }

            //if the puck has gone past player 2's paddle on the right
            
            
            if (puck.Left + puck.Width > ClientSize.Width)
            {
                if (randomNumber == 1)
                {
                    puck.Left = 560; //reset the puck to the middle of the screen
                    puckX = -puckX; //change the puck's direction
                    puckX -= 2; //increase the speed
                }
                else if (randomNumber == 2)
                {
                    puck.Left = 560; //reset the puck to the middle of the screen
                    puckX -= 2; //increase the speed
                }
                
                score++; //add 1 to player 1's score
            }

                                                                                                

            

            //controlling the puck





            //if the puck either reaches the top of the screen or the bottom
            if (puck.Top < 0 || puck.Top + puck.Height > ClientSize.Height)
            {
                puckY = -puckY; //reverse the speed of the puck so it stays within the screen
            }


            //if the puck hits either paddle
            if (puck.Bounds.IntersectsWith(Player1.Bounds) || puck.Bounds.IntersectsWith(Player2.Bounds))      //collision stuff
            {
                //puckY = -puckY; //bounce the puck in the other direction 
                puckX = -puckX; //bounce the puck in the other direction
                
            }
            else if ((puck.Bounds.IntersectsWith(topLeftBarrier.Bounds) || puck.Bounds.IntersectsWith(bottomLeftBarrier.Bounds) || puck.Bounds.IntersectsWith(topRightBarrier.Bounds) || puck.Bounds.IntersectsWith(bottomRightBarrier.Bounds)))
            {
                puckX = -puckX; //bounce the puck in the other direction
                //puckY = -puckY; //bounce the puck in the other direction
            }



            //final score and ending the game





            //if Player 1's score is more than 9
            //stop the timer and show a winning message box for Player 1
            if (score > 9)
            {
                gameTimer.Stop();
                string message = "Congratulations, Player 1, you won this game. Do you wish to exit the application?";
                string title = "Close Window";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {
                    // Do something  
                }
            }
            //if Player 2's score is more than 9
            //stop the timer and show a winning message box for Player 2
            if (cpuPoint > 9)
            {
                gameTimer.Stop();
                string message = "Congratulations, Player 2, you won this game. Do you wish to exit the application?";
                string title = "Close Window";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    this.Close();
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
