namespace Final
{
    partial class frmAirHockey
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
            this.Player1 = new System.Windows.Forms.PictureBox();
            this.puck = new System.Windows.Forms.PictureBox();
            this.Player2 = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.Player1Score = new System.Windows.Forms.Label();
            this.Player2Score = new System.Windows.Forms.Label();
            this.centerLine = new System.Windows.Forms.PictureBox();
            this.topLeftBarrier = new System.Windows.Forms.PictureBox();
            this.bottomLeftBarrier = new System.Windows.Forms.PictureBox();
            this.topRightBarrier = new System.Windows.Forms.PictureBox();
            this.bottomRightBarrier = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centerLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topLeftBarrier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomLeftBarrier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topRightBarrier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomRightBarrier)).BeginInit();
            this.SuspendLayout();
            // 
            // Player1
            // 
            this.Player1.BackColor = System.Drawing.Color.Red;
            this.Player1.Location = new System.Drawing.Point(41, 279);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(27, 127);
            this.Player1.TabIndex = 0;
            this.Player1.TabStop = false;
            // 
            // puck
            // 
            this.puck.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.puck.Location = new System.Drawing.Point(510, 347);
            this.puck.Name = "puck";
            this.puck.Size = new System.Drawing.Size(27, 27);
            this.puck.TabIndex = 1;
            this.puck.TabStop = false;
            // 
            // Player2
            // 
            this.Player2.BackColor = System.Drawing.Color.ForestGreen;
            this.Player2.Location = new System.Drawing.Point(1076, 279);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(27, 127);
            this.Player2.TabIndex = 2;
            this.Player2.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.timerTick);
            // 
            // Player1Score
            // 
            this.Player1Score.AutoSize = true;
            this.Player1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1Score.ForeColor = System.Drawing.Color.Red;
            this.Player1Score.Location = new System.Drawing.Point(34, 0);
            this.Player1Score.Name = "Player1Score";
            this.Player1Score.Size = new System.Drawing.Size(55, 37);
            this.Player1Score.TabIndex = 3;
            this.Player1Score.Text = "00";
            // 
            // Player2Score
            // 
            this.Player2Score.AutoSize = true;
            this.Player2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2Score.ForeColor = System.Drawing.Color.ForestGreen;
            this.Player2Score.Location = new System.Drawing.Point(1048, 0);
            this.Player2Score.Name = "Player2Score";
            this.Player2Score.Size = new System.Drawing.Size(55, 37);
            this.Player2Score.TabIndex = 4;
            this.Player2Score.Text = "00";
            // 
            // centerLine
            // 
            this.centerLine.BackColor = System.Drawing.SystemColors.Desktop;
            this.centerLine.Location = new System.Drawing.Point(563, 0);
            this.centerLine.Name = "centerLine";
            this.centerLine.Size = new System.Drawing.Size(16, 647);
            this.centerLine.TabIndex = 5;
            this.centerLine.TabStop = false;
            // 
            // topLeftBarrier
            // 
            this.topLeftBarrier.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.topLeftBarrier.Location = new System.Drawing.Point(-1, 0);
            this.topLeftBarrier.Name = "topLeftBarrier";
            this.topLeftBarrier.Size = new System.Drawing.Size(40, 161);
            this.topLeftBarrier.TabIndex = 6;
            this.topLeftBarrier.TabStop = false;
            // 
            // bottomLeftBarrier
            // 
            this.bottomLeftBarrier.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.bottomLeftBarrier.Location = new System.Drawing.Point(-1, 486);
            this.bottomLeftBarrier.Name = "bottomLeftBarrier";
            this.bottomLeftBarrier.Size = new System.Drawing.Size(40, 161);
            this.bottomLeftBarrier.TabIndex = 7;
            this.bottomLeftBarrier.TabStop = false;
            // 
            // topRightBarrier
            // 
            this.topRightBarrier.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.topRightBarrier.Location = new System.Drawing.Point(1098, 0);
            this.topRightBarrier.Name = "topRightBarrier";
            this.topRightBarrier.Size = new System.Drawing.Size(40, 161);
            this.topRightBarrier.TabIndex = 8;
            this.topRightBarrier.TabStop = false;
            // 
            // bottomRightBarrier
            // 
            this.bottomRightBarrier.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.bottomRightBarrier.Location = new System.Drawing.Point(1098, 486);
            this.bottomRightBarrier.Name = "bottomRightBarrier";
            this.bottomRightBarrier.Size = new System.Drawing.Size(40, 161);
            this.bottomRightBarrier.TabIndex = 9;
            this.bottomRightBarrier.TabStop = false;
            // 
            // frmAirHockey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1137, 646);
            this.Controls.Add(this.bottomRightBarrier);
            this.Controls.Add(this.topRightBarrier);
            this.Controls.Add(this.bottomLeftBarrier);
            this.Controls.Add(this.topLeftBarrier);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.puck);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.centerLine);
            this.Controls.Add(this.Player1Score);
            this.Controls.Add(this.Player2Score);
            this.Name = "frmAirHockey";
            this.Text = "Air Hockey";
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centerLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topLeftBarrier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomLeftBarrier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topRightBarrier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomRightBarrier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player1;
        private System.Windows.Forms.PictureBox puck;
        private System.Windows.Forms.PictureBox Player2;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label Player1Score;
        private System.Windows.Forms.Label Player2Score;
        private System.Windows.Forms.PictureBox centerLine;
        private System.Windows.Forms.PictureBox topLeftBarrier;
        private System.Windows.Forms.PictureBox bottomLeftBarrier;
        private System.Windows.Forms.PictureBox topRightBarrier;
        private System.Windows.Forms.PictureBox bottomRightBarrier;
    }
}

