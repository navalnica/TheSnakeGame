namespace new_snake
{
    partial class MainForm
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
            this.panel_start = new System.Windows.Forms.Panel();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.panel_highscores = new System.Windows.Forms.Panel();
            this.panel_scores = new System.Windows.Forms.Panel();
            this.btn_changePlayer = new System.Windows.Forms.Button();
            this.label_highscores = new System.Windows.Forms.Label();
            this.btn_restart = new System.Windows.Forms.Button();
            this.lbl_score = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel_game = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_currentScore = new System.Windows.Forms.Label();
            this.panel_start.SuspendLayout();
            this.panel_highscores.SuspendLayout();
            this.panel_game.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_start
            // 
            this.panel_start.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel_start.Controls.Add(this.tb_name);
            this.panel_start.Controls.Add(this.label3);
            this.panel_start.Controls.Add(this.label2);
            this.panel_start.Controls.Add(this.btn_start);
            this.panel_start.Location = new System.Drawing.Point(0, 0);
            this.panel_start.Name = "panel_start";
            this.panel_start.Size = new System.Drawing.Size(514, 576);
            this.panel_start.TabIndex = 0;
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_name.Location = new System.Drawing.Point(113, 313);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(280, 38);
            this.tb_name.TabIndex = 3;
            this.tb_name.TextChanged += new System.EventHandler(this.tb_name_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(142, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter your name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(106, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 76);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome\r\nto the Snake Game";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_start.Location = new System.Drawing.Point(113, 488);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(280, 40);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // panel_highscores
            // 
            this.panel_highscores.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel_highscores.Controls.Add(this.panel_scores);
            this.panel_highscores.Controls.Add(this.btn_changePlayer);
            this.panel_highscores.Controls.Add(this.label_highscores);
            this.panel_highscores.Controls.Add(this.btn_restart);
            this.panel_highscores.Controls.Add(this.lbl_score);
            this.panel_highscores.Controls.Add(this.label1);
            this.panel_highscores.Location = new System.Drawing.Point(0, 0);
            this.panel_highscores.Name = "panel_highscores";
            this.panel_highscores.Size = new System.Drawing.Size(514, 576);
            this.panel_highscores.TabIndex = 2;
            // 
            // panel_scores
            // 
            this.panel_scores.Location = new System.Drawing.Point(61, 122);
            this.panel_scores.Name = "panel_scores";
            this.panel_scores.Size = new System.Drawing.Size(419, 378);
            this.panel_scores.TabIndex = 5;
            // 
            // btn_changePlayer
            // 
            this.btn_changePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_changePlayer.Location = new System.Drawing.Point(260, 521);
            this.btn_changePlayer.Name = "btn_changePlayer";
            this.btn_changePlayer.Size = new System.Drawing.Size(220, 40);
            this.btn_changePlayer.TabIndex = 4;
            this.btn_changePlayer.Text = "Change Player";
            this.btn_changePlayer.UseVisualStyleBackColor = true;
            this.btn_changePlayer.Click += new System.EventHandler(this.btn_changePlayer_Click);
            // 
            // label_highscores
            // 
            this.label_highscores.AutoSize = true;
            this.label_highscores.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_highscores.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_highscores.Location = new System.Drawing.Point(168, 59);
            this.label_highscores.Name = "label_highscores";
            this.label_highscores.Size = new System.Drawing.Size(165, 36);
            this.label_highscores.TabIndex = 3;
            this.label_highscores.Text = "Highscores";
            this.label_highscores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_restart
            // 
            this.btn_restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_restart.Location = new System.Drawing.Point(25, 521);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(220, 40);
            this.btn_restart.TabIndex = 2;
            this.btn_restart.Text = "Restart";
            this.btn_restart.UseVisualStyleBackColor = true;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_score.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_score.Location = new System.Drawing.Point(330, 9);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(35, 38);
            this.lbl_score.TabIndex = 1;
            this.lbl_score.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(124, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Score:";
            // 
            // timer
            // 
            this.timer.Interval = 70;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panel_game
            // 
            this.panel_game.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_game.Controls.Add(this.lbl_currentScore);
            this.panel_game.Controls.Add(this.label4);
            this.panel_game.Controls.Add(this.pictureBox);
            this.panel_game.Location = new System.Drawing.Point(0, 0);
            this.panel_game.Name = "panel_game";
            this.panel_game.Size = new System.Drawing.Size(514, 576);
            this.panel_game.TabIndex = 1;
            this.panel_game.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_game_Paint);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(4, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(506, 506);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(253, 523);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 38);
            this.label4.TabIndex = 1;
            this.label4.Text = "Score:";
            // 
            // lbl_currentScore
            // 
            this.lbl_currentScore.AutoSize = true;
            this.lbl_currentScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_currentScore.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_currentScore.Location = new System.Drawing.Point(371, 523);
            this.lbl_currentScore.Name = "lbl_currentScore";
            this.lbl_currentScore.Size = new System.Drawing.Size(50, 38);
            this.lbl_currentScore.TabIndex = 2;
            this.lbl_currentScore.Text = "---";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 577);
            this.Controls.Add(this.panel_highscores);
            this.Controls.Add(this.panel_game);
            this.Controls.Add(this.panel_start);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Snake Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.panel_start.ResumeLayout(false);
            this.panel_start.PerformLayout();
            this.panel_highscores.ResumeLayout(false);
            this.panel_highscores.PerformLayout();
            this.panel_game.ResumeLayout(false);
            this.panel_game.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_start;
        private System.Windows.Forms.Panel panel_highscores;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_restart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_highscores;
        private System.Windows.Forms.Button btn_changePlayer;
        private System.Windows.Forms.Panel panel_scores;
        private System.Windows.Forms.Panel panel_game;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lbl_currentScore;
        private System.Windows.Forms.Label label4;
    }
}

