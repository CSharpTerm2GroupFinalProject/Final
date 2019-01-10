namespace Final
{
    partial class frmAirHockeyCpu
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
            this.components = new System.ComponentModel.Container();
            this.centerLine = new System.Windows.Forms.PictureBox();
            this.topRightBarrierGame = new System.Windows.Forms.PictureBox();
            this.bottomRightBarrierGame = new System.Windows.Forms.PictureBox();
            this.bottomLeftBarrierGame = new System.Windows.Forms.PictureBox();
            this.topLeftBarrierGame = new System.Windows.Forms.PictureBox();
            this.puckGame = new System.Windows.Forms.PictureBox();
            this.Player1 = new System.Windows.Forms.PictureBox();
            this.CPU = new System.Windows.Forms.PictureBox();
            this.Player1ScoreGame = new System.Windows.Forms.Label();
            this.Player2ScoreGame = new System.Windows.Forms.Label();
            this.gameTimerCpu = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.centerLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topRightBarrierGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomRightBarrierGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomLeftBarrierGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topLeftBarrierGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puckGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).BeginInit();
            this.SuspendLayout();
            // 
            // centerLine
            // 
            this.centerLine.BackColor = System.Drawing.SystemColors.Desktop;
            this.centerLine.Location = new System.Drawing.Point(563, 0);
            this.centerLine.Name = "centerLine";
            this.centerLine.Size = new System.Drawing.Size(16, 647);
            this.centerLine.TabIndex = 12;
            this.centerLine.TabStop = false;
            // 
            // topRightBarrierGame
            // 
            this.topRightBarrierGame.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.topRightBarrierGame.Location = new System.Drawing.Point(1100, 0);
            this.topRightBarrierGame.Name = "topRightBarrierGame";
            this.topRightBarrierGame.Size = new System.Drawing.Size(40, 161);
            this.topRightBarrierGame.TabIndex = 11;
            this.topRightBarrierGame.TabStop = false;
            // 
            // bottomRightBarrierGame
            // 
            this.bottomRightBarrierGame.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.bottomRightBarrierGame.Location = new System.Drawing.Point(1100, 487);
            this.bottomRightBarrierGame.Name = "bottomRightBarrierGame";
            this.bottomRightBarrierGame.Size = new System.Drawing.Size(40, 161);
            this.bottomRightBarrierGame.TabIndex = 10;
            this.bottomRightBarrierGame.TabStop = false;
            // 
            // bottomLeftBarrierGame
            // 
            this.bottomLeftBarrierGame.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.bottomLeftBarrierGame.Location = new System.Drawing.Point(0, 487);
            this.bottomLeftBarrierGame.Name = "bottomLeftBarrierGame";
            this.bottomLeftBarrierGame.Size = new System.Drawing.Size(40, 161);
            this.bottomLeftBarrierGame.TabIndex = 8;
            this.bottomLeftBarrierGame.TabStop = false;
            // 
            // topLeftBarrierGame
            // 
            this.topLeftBarrierGame.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.topLeftBarrierGame.Location = new System.Drawing.Point(0, 0);
            this.topLeftBarrierGame.Name = "topLeftBarrierGame";
            this.topLeftBarrierGame.Size = new System.Drawing.Size(40, 161);
            this.topLeftBarrierGame.TabIndex = 7;
            this.topLeftBarrierGame.TabStop = false;
            // 
            // puckGame
            // 
            this.puckGame.BackColor = System.Drawing.SystemColors.HotTrack;
            this.puckGame.Image = global::Final.Properties.Resources.TestGreenDot;
            this.puckGame.Location = new System.Drawing.Point(510, 347);
            this.puckGame.Name = "puckGame";
            this.puckGame.Size = new System.Drawing.Size(27, 27);
            this.puckGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.puckGame.TabIndex = 13;
            this.puckGame.TabStop = false;
            // 
            // Player1
            // 
            this.Player1.BackColor = System.Drawing.Color.Red;
            this.Player1.Location = new System.Drawing.Point(41, 279);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(27, 127);
            this.Player1.TabIndex = 14;
            this.Player1.TabStop = false;
            // 
            // CPU
            // 
            this.CPU.BackColor = System.Drawing.Color.ForestGreen;
            this.CPU.Location = new System.Drawing.Point(1079, 279);
            this.CPU.Name = "CPU";
            this.CPU.Size = new System.Drawing.Size(27, 127);
            this.CPU.TabIndex = 15;
            this.CPU.TabStop = false;
            // 
            // Player1ScoreGame
            // 
            this.Player1ScoreGame.AutoSize = true;
            this.Player1ScoreGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1ScoreGame.ForeColor = System.Drawing.Color.Red;
            this.Player1ScoreGame.Location = new System.Drawing.Point(34, 0);
            this.Player1ScoreGame.Name = "Player1ScoreGame";
            this.Player1ScoreGame.Size = new System.Drawing.Size(55, 37);
            this.Player1ScoreGame.TabIndex = 16;
            this.Player1ScoreGame.Text = "00";
            // 
            // Player2ScoreGame
            // 
            this.Player2ScoreGame.AutoSize = true;
            this.Player2ScoreGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2ScoreGame.ForeColor = System.Drawing.Color.ForestGreen;
            this.Player2ScoreGame.Location = new System.Drawing.Point(1051, 0);
            this.Player2ScoreGame.Name = "Player2ScoreGame";
            this.Player2ScoreGame.Size = new System.Drawing.Size(55, 37);
            this.Player2ScoreGame.TabIndex = 17;
            this.Player2ScoreGame.Text = "00";
            // 
            // gameTimerCpu
            // 
            this.gameTimerCpu.Enabled = true;
            this.gameTimerCpu.Interval = 20;
            this.gameTimerCpu.Tick += new System.EventHandler(this.timerTickGame);
            // 
            // frmAirHockeyCpu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1137, 646);
            this.Controls.Add(this.CPU);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.puckGame);
            this.Controls.Add(this.centerLine);
            this.Controls.Add(this.topRightBarrierGame);
            this.Controls.Add(this.bottomRightBarrierGame);
            this.Controls.Add(this.bottomLeftBarrierGame);
            this.Controls.Add(this.topLeftBarrierGame);
            this.Controls.Add(this.Player1ScoreGame);
            this.Controls.Add(this.Player2ScoreGame);
            this.DoubleBuffered = true;
            this.Name = "frmAirHockeyCpu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Air Hockey";
            ((System.ComponentModel.ISupportInitialize)(this.centerLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topRightBarrierGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomRightBarrierGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomLeftBarrierGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topLeftBarrierGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puckGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox topLeftBarrierGame;
        private System.Windows.Forms.PictureBox bottomLeftBarrierGame;
        private System.Windows.Forms.PictureBox bottomRightBarrierGame;
        private System.Windows.Forms.PictureBox topRightBarrierGame;
        private System.Windows.Forms.PictureBox centerLine;
        private System.Windows.Forms.PictureBox puckGame;
        private System.Windows.Forms.PictureBox Player1;
        private System.Windows.Forms.PictureBox CPU;
        private System.Windows.Forms.Label Player1ScoreGame;
        private System.Windows.Forms.Label Player2ScoreGame;
        private System.Windows.Forms.Timer gameTimerCpu;
    }
}