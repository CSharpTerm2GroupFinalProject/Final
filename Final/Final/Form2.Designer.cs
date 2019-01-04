namespace Final
{
    partial class mainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn1PlayerCpu = new System.Windows.Forms.Button();
            this.btn2PlayerGame = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1PlayerCpu
            // 
            this.btn1PlayerCpu.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn1PlayerCpu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn1PlayerCpu.Location = new System.Drawing.Point(325, 142);
            this.btn1PlayerCpu.Name = "btn1PlayerCpu";
            this.btn1PlayerCpu.Size = new System.Drawing.Size(122, 49);
            this.btn1PlayerCpu.TabIndex = 0;
            this.btn1PlayerCpu.Text = "1 Player CPU Game";
            this.btn1PlayerCpu.UseVisualStyleBackColor = false;
            this.btn1PlayerCpu.Click += new System.EventHandler(this.btn1PlayerCpu_Click);
            // 
            // btn2PlayerGame
            // 
            this.btn2PlayerGame.Location = new System.Drawing.Point(325, 226);
            this.btn2PlayerGame.Name = "btn2PlayerGame";
            this.btn2PlayerGame.Size = new System.Drawing.Size(122, 46);
            this.btn2PlayerGame.TabIndex = 1;
            this.btn2PlayerGame.Text = "2 Player Game";
            this.btn2PlayerGame.UseVisualStyleBackColor = true;
            this.btn2PlayerGame.Click += new System.EventHandler(this.btn2PlayerGame_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(325, 319);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(122, 46);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.Text = "Quit Application";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btn2PlayerGame);
            this.Controls.Add(this.btn1PlayerCpu);
            this.Name = "mainMenu";
            this.Text = "Air Hockey Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1PlayerCpu;
        private System.Windows.Forms.Button btn2PlayerGame;
        private System.Windows.Forms.Button btnQuit;
    }
}