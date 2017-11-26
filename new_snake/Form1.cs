using System;
using System.Drawing;
using System.Windows.Forms;

namespace new_snake
{
    public partial class MainForm : Form
    {
        Snake snake;
        Game game = new Game();
        Brush fieldBrush = Brushes.DarkSlateBlue;
        Brush snakeBrush = Brushes.Turquoise;
        Brush appleBrush = Brushes.Gold;
        Pen fieldBorderPen;
        Rectangle field;

        Graphics panelGraphics;
        Graphics bitmapGraphics;
        Bitmap bitmap;

        int fieldBorderWidth = 4;
        bool directionKeyProcessed = false;
        int hsLabelWidth = 400;
        int hsLabelHeight = 70;
        int hsDistance = 20;
        int scoreLabelsNumber;
        int currentScore;

        public MainForm()
        {
            InitializeComponent();
            InitLogic();
            
            panel_game.BackColor = Color.DarkSlateBlue;
            scoreLabelsNumber = (panel_scores.Height - panel_highscores.Location.Y)
                / (hsLabelHeight + hsDistance);
            field = new Rectangle(0, 0,
                snake.cs * snake.cn + fieldBorderWidth / 2,
                snake.cs * snake.cn + fieldBorderWidth / 2);           
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            fieldBorderPen = new Pen(appleBrush, fieldBorderWidth);

            panelGraphics = panel_game.CreateGraphics();
            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            bitmapGraphics = Graphics.FromImage(bitmap);
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            fieldBorderPen.Dispose();

            panelGraphics.Dispose();
            bitmapGraphics.Dispose();
            bitmap.Dispose();
        }
        
        private void btn_start_Click(object sender, EventArgs e)
        {
            panel_start.Visible = false;
            panel_game.Visible = true;
            panel_highscores.Visible = false;

            string name = tb_name.Text;
            game.curPlayer.Name = name;
            game.Players.Add(game.curPlayer);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            directionKeyProcessed = false;
            currentScore = snake.tail + 1;
            lbl_currentScore.Text = currentScore.ToString();
            if (snake.Move() != 0)
            {
                endCurrentGame();
            }
            panel_game.Invalidate();
        }

        private void endCurrentGame()
        {
            timer.Stop();
            panel_start.Visible = false;
            panel_game.Visible = false;
            panel_highscores.Visible = true;
            
            lbl_score.Text = currentScore.ToString();
            if (currentScore > game.curPlayer.Score)
                game.curPlayer.Score = currentScore;
            game.PlayersSort();
            game.SaveHighscores();

            fillHighscores();
        }

        private void fillHighscores()
        {
            panel_scores.Controls.Clear();
            for (int i = 0; i < game.Players.Count && i < scoreLabelsNumber; i++)
            {
                Label curLabel = new Label();
                curLabel.SetBounds(0, (hsLabelHeight + hsDistance) * i,
                    hsLabelWidth, hsLabelHeight);
                Player tmpPlayer = game.Players[i];

                string caption = (i + 1).ToString() + ". ";
                caption += tmpPlayer.Name + Environment.NewLine;
                caption += "     " + "Score: " + tmpPlayer.Score.ToString();
                caption += "     " +  tmpPlayer.RecordDate.ToShortDateString();
                curLabel.Text = caption;
                curLabel.Font = label_highscores.Font;
                curLabel.ForeColor = label_highscores.ForeColor;

                panel_scores.Controls.Add(curLabel);
            }
        }

        private void panel_game_Paint(object sender, PaintEventArgs e)
        {
            bitmapGraphics.FillRectangle(fieldBrush, field);
            bitmapGraphics.DrawRectangle(fieldBorderPen, 
                pictureBox.ClientRectangle);

            for (int i = 0; i < snake.trail.Count; i++)
            {
                bitmapGraphics.FillRectangle(snakeBrush,
                    snake.trail[i].x * snake.cs + fieldBorderWidth, 
                    snake.trail[i].y * snake.cs + fieldBorderWidth,
                    snake.cs - fieldBorderWidth / 2,
                    snake.cs - fieldBorderWidth / 2);
            }
            bitmapGraphics.FillRectangle(appleBrush, 
                snake.ax * snake.cs + fieldBorderWidth,
                snake.ay * snake.cs + fieldBorderWidth,
                snake.cs - 2, snake.cs - 2);

            pictureBox.Image = bitmap;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (panel_start.Visible == true)
            {
                if (e.KeyCode == Keys.Enter &&
                    btn_start.Enabled == true)
                {
                    btn_start_Click(sender, e);
                }
            }
            if (panel_game.Visible == true)
            {
                if (directionKeyProcessed == false)
                {
                    switch (e.KeyCode)
                    {
                        case Keys.Up:
                            if (snake.vy != 1)
                            {
                                snake.vx = 0; snake.vy = -1;
                            }
                            break;
                        case Keys.Down:
                            if (snake.vy != -1)
                            {
                                snake.vx = 0; snake.vy = 1;
                            }
                            break;
                        case Keys.Left:
                            if (snake.vx != 1)
                            {
                                snake.vx = -1; snake.vy = 0;
                            }
                            break;
                        case Keys.Right:
                            if (snake.vx != -1)
                            {
                                snake.vx = 1; snake.vy = 0;
                            }
                            break;
                    }
                }
                directionKeyProcessed = true;
            }
        }

        private void btn_restart_Click(object sender, EventArgs e)
        {
            panel_start.Visible = false;
            panel_game.Visible = true;
            panel_highscores.Visible = false;

            snake = new Snake();
            currentScore = snake.tail + 1;
            lbl_currentScore.Text = currentScore.ToString();
            timer.Start();
        }
        private void InitLogic()
        {
            panel_start.Visible = true;
            panel_game.Visible = false;
            panel_highscores.Visible = false;
            btn_start.Enabled = false;
            tb_name.Text = "";
            lbl_score.Text = "";
            tb_name.Focus();

            snake = new Snake();
            timer.Start();
        }
        private void tb_name_TextChanged(object sender, EventArgs e)
        {
            string name = tb_name.Text;
            if (!string.IsNullOrEmpty(name))
                btn_start.Enabled = true;
            else
                btn_start.Enabled = false;
        }

        private void btn_changePlayer_Click(object sender, EventArgs e)
        {
            game.curPlayer = new Player();
            InitLogic();
        }
   
    }
}
