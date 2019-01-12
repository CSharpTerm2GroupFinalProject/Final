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
    public partial class mainMenu : Form
    {
        //public int counter = 1;       
        private frmAirHockey frmAirHockey;                                 //Calling 2 Player game form
        private frmAirHockeyCpu frmAirHockeyCpu;                           //Calling 1 Player game form
        public mainMenu()
        {
            InitializeComponent();
        }

        private void btn1PlayerCpu_Click(object sender, EventArgs e)       //Private method for 1 player game button
        {
            frmAirHockeyCpu = new frmAirHockeyCpu();                       //Create 1 player game form
            frmAirHockeyCpu.Show();                                        //Show 1 player game form
        }

        private void btn2PlayerGame_Click(object sender, EventArgs e)      //Private method for 2 player game button
        {
            frmAirHockey = new frmAirHockey();                             //Create 2 player game form
            frmAirHockey.Show();                                           //Show 2 player game form
        }

        private void btnQuit_Click(object sender, EventArgs e)             //Private method for quit button
        {
            Application.Exit();                                            
        }
    }
}
