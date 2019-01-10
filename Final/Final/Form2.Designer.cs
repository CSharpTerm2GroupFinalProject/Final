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
            this.lblPlayer1Up = new System.Windows.Forms.Label();
            this.lblPlayer1Left = new System.Windows.Forms.Label();
            this.lblPlayer1Down = new System.Windows.Forms.Label();
            this.lblPlayer1Right = new System.Windows.Forms.Label();
            this.lblPlayer2Up = new System.Windows.Forms.Label();
            this.lblPlayer2Left = new System.Windows.Forms.Label();
            this.lblPlayer2Down = new System.Windows.Forms.Label();
            this.lblPlayer2Right = new System.Windows.Forms.Label();
            this.lblPlayer1Controls = new System.Windows.Forms.Label();
            this.Player2Controls = new System.Windows.Forms.Label();
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
            // lblPlayer1Up
            // 
            this.lblPlayer1Up.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPlayer1Up.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Up.Location = new System.Drawing.Point(98, 279);
            this.lblPlayer1Up.Name = "lblPlayer1Up";
            this.lblPlayer1Up.Size = new System.Drawing.Size(44, 44);
            this.lblPlayer1Up.TabIndex = 3;
            this.lblPlayer1Up.Text = "W";
            this.lblPlayer1Up.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayer1Left
            // 
            this.lblPlayer1Left.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPlayer1Left.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Left.Location = new System.Drawing.Point(26, 335);
            this.lblPlayer1Left.Name = "lblPlayer1Left";
            this.lblPlayer1Left.Size = new System.Drawing.Size(44, 44);
            this.lblPlayer1Left.TabIndex = 4;
            this.lblPlayer1Left.Text = "A";
            this.lblPlayer1Left.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayer1Down
            // 
            this.lblPlayer1Down.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPlayer1Down.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Down.Location = new System.Drawing.Point(98, 335);
            this.lblPlayer1Down.Name = "lblPlayer1Down";
            this.lblPlayer1Down.Size = new System.Drawing.Size(44, 44);
            this.lblPlayer1Down.TabIndex = 5;
            this.lblPlayer1Down.Text = "S";
            this.lblPlayer1Down.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayer1Right
            // 
            this.lblPlayer1Right.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPlayer1Right.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Right.Location = new System.Drawing.Point(166, 335);
            this.lblPlayer1Right.Name = "lblPlayer1Right";
            this.lblPlayer1Right.Size = new System.Drawing.Size(44, 44);
            this.lblPlayer1Right.TabIndex = 6;
            this.lblPlayer1Right.Text = "D";
            this.lblPlayer1Right.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayer2Up
            // 
            this.lblPlayer2Up.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPlayer2Up.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2Up.Location = new System.Drawing.Point(647, 279);
            this.lblPlayer2Up.Name = "lblPlayer2Up";
            this.lblPlayer2Up.Size = new System.Drawing.Size(44, 44);
            this.lblPlayer2Up.TabIndex = 7;
            this.lblPlayer2Up.Text = "↑";
            this.lblPlayer2Up.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayer2Left
            // 
            this.lblPlayer2Left.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPlayer2Left.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2Left.Location = new System.Drawing.Point(576, 335);
            this.lblPlayer2Left.Name = "lblPlayer2Left";
            this.lblPlayer2Left.Size = new System.Drawing.Size(44, 44);
            this.lblPlayer2Left.TabIndex = 8;
            this.lblPlayer2Left.Text = "←";
            this.lblPlayer2Left.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayer2Down
            // 
            this.lblPlayer2Down.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPlayer2Down.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2Down.Location = new System.Drawing.Point(647, 335);
            this.lblPlayer2Down.Name = "lblPlayer2Down";
            this.lblPlayer2Down.Size = new System.Drawing.Size(44, 44);
            this.lblPlayer2Down.TabIndex = 9;
            this.lblPlayer2Down.Text = "↓";
            this.lblPlayer2Down.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayer2Right
            // 
            this.lblPlayer2Right.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPlayer2Right.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2Right.Location = new System.Drawing.Point(716, 335);
            this.lblPlayer2Right.Name = "lblPlayer2Right";
            this.lblPlayer2Right.Size = new System.Drawing.Size(44, 44);
            this.lblPlayer2Right.TabIndex = 10;
            this.lblPlayer2Right.Text = "→";
            this.lblPlayer2Right.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayer1Controls
            // 
            this.lblPlayer1Controls.AutoSize = true;
            this.lblPlayer1Controls.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPlayer1Controls.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Controls.Location = new System.Drawing.Point(12, 226);
            this.lblPlayer1Controls.Name = "lblPlayer1Controls";
            this.lblPlayer1Controls.Size = new System.Drawing.Size(212, 29);
            this.lblPlayer1Controls.TabIndex = 11;
            this.lblPlayer1Controls.Text = "Player 1\'s Controls";
            // 
            // Player2Controls
            // 
            this.Player2Controls.AutoSize = true;
            this.Player2Controls.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Player2Controls.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2Controls.Location = new System.Drawing.Point(558, 226);
            this.Player2Controls.Name = "Player2Controls";
            this.Player2Controls.Size = new System.Drawing.Size(212, 29);
            this.Player2Controls.TabIndex = 12;
            this.Player2Controls.Text = "Player 2\'s Controls";
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Player2Controls);
            this.Controls.Add(this.lblPlayer1Controls);
            this.Controls.Add(this.lblPlayer2Right);
            this.Controls.Add(this.lblPlayer2Down);
            this.Controls.Add(this.lblPlayer2Left);
            this.Controls.Add(this.lblPlayer2Up);
            this.Controls.Add(this.lblPlayer1Right);
            this.Controls.Add(this.lblPlayer1Down);
            this.Controls.Add(this.lblPlayer1Left);
            this.Controls.Add(this.lblPlayer1Up);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btn2PlayerGame);
            this.Controls.Add(this.btn1PlayerCpu);
            this.Name = "mainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Air Hockey Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1PlayerCpu;
        private System.Windows.Forms.Button btn2PlayerGame;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblPlayer1Up;
        private System.Windows.Forms.Label lblPlayer1Left;
        private System.Windows.Forms.Label lblPlayer1Down;
        private System.Windows.Forms.Label lblPlayer1Right;
        private System.Windows.Forms.Label lblPlayer2Up;
        private System.Windows.Forms.Label lblPlayer2Left;
        private System.Windows.Forms.Label lblPlayer2Down;
        private System.Windows.Forms.Label lblPlayer2Right;
        private System.Windows.Forms.Label lblPlayer1Controls;
        private System.Windows.Forms.Label Player2Controls;
    }
}