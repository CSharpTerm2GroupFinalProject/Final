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
        public int counter = 1;

        private frmAirHockey frmAirHockey;
        public mainMenu()
        {
            InitializeComponent();
        }

        private void btn1PlayerCpu_Click(object sender, EventArgs e)
        {

        }

        private void btn2PlayerGame_Click(object sender, EventArgs e)
        {
            do
            {
                this.Visible = false;
                frmAirHockey = new frmAirHockey();
                frmAirHockey.Show();
            }while(counter == 2);
            frmAirHockey.Visible = false;
            this.Visible = true;
            
            

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
