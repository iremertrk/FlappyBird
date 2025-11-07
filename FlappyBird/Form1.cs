using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        int boruHızı = 10;
        int gravity = 2;
        int verticalVelocity = 0;
        int score = 0;
        bool gamePaused = false;
        bool gameStarted = false;
        Random random = new Random();

        private SoundPlayer jump;
        private SoundPlayer gameOver;
        private List<int> topScores;

        // Kuş animasyonu için gerekli değişkenler
        private List<Image> birdImages;
        private int currentBirdImageIndex = 0;
        private Timer birdAnimationTimer;

        public Form1()
        {
            InitializeComponent();
            topScores = new List<int>();
            LoadTopScores();
            gameTimer.Interval = 40;

            gameOver = new SoundPlayer(Properties.Resources.gameOver);
            jump = new SoundPlayer(Properties.Resources.jump);

            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();

            // Kuş animasyon görsellerini yükle
            birdImages = new List<Image>
        {
            Properties.Resources.kus1,
            Properties.Resources.kus2,
            Properties.Resources.kus3
        };

            // Animasyon timerını ayarla
            birdAnimationTimer = new Timer();
            birdAnimationTimer.Interval = 100; // Her 100ms'de bir animasyon karesini değiştir
            birdAnimationTimer.Tick += new EventHandler(BirdAnimationTimer_Tick);
            birdAnimationTimer.Start();
        }

        private void BirdAnimationTimer_Tick(object sender, EventArgs e)
        {
            // Animasyon karesini değiştir
            currentBirdImageIndex = (currentBirdImageIndex + 1) % birdImages.Count;
            flappyBird.Invalidate(); // Kuşun yeniden çizilmesini tetikle
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            if (!gameStarted || gamePaused) return;

            verticalVelocity += gravity;
            flappyBird.Top += verticalVelocity;
            MovePipes();
            ScoreText.Text = "Score: " + score;

            if (CheckCollision())
            {
                endGame();
            }
            
            if (score > 0 && score % 5 == 0)
            {
                boruHızı += 3;
                // alttakini acarsan kus buyur belli scorelardan sonra 
                //flappyBird.Size = new Size(flappyBird.Width + score/8, flappyBird.Height + score/8);
                score++;
            }

            if (flappyBird.Top < -25)
            {
                endGame();
            }
        }

        private void MovePipes()
        {
            MovePipe(BoruAlt, BoruUst);
            MovePipe(BoruAlt2, BoruUst2);
            MovePipe(BoruAlt3, BoruUst3);
            MovePipe(BoruAlt4, BoruUst4);
            MovePipe(BoruAlt5, BoruUst5);
        }

        private void MovePipe(PictureBox bottomPipe, PictureBox topPipe)
        {
            bottomPipe.Left -= boruHızı;
            topPipe.Left -= boruHızı;

            if (bottomPipe.Left < -150)
            {
                bottomPipe.Left = this.Width + 150;
                topPipe.Left = bottomPipe.Left;
                score++;
            }
        }

        private bool CheckCollision()
        {
            Rectangle birdRect = new Rectangle(flappyBird.Left + 5, flappyBird.Top + 5, flappyBird.Width - 10, flappyBird.Height - 10);

            return birdRect.IntersectsWith(BoruAlt.Bounds) ||
                   birdRect.IntersectsWith(BoruUst.Bounds) ||
                   birdRect.IntersectsWith(BoruAlt2.Bounds) ||
                   birdRect.IntersectsWith(BoruUst2.Bounds) ||
                   birdRect.IntersectsWith(BoruAlt3.Bounds) ||
                   birdRect.IntersectsWith(BoruUst3.Bounds) ||
                   birdRect.IntersectsWith(BoruAlt4.Bounds) ||
                   birdRect.IntersectsWith(BoruUst4.Bounds) ||
                   birdRect.IntersectsWith(BoruAlt5.Bounds) ||
                   birdRect.IntersectsWith(BoruUst5.Bounds) ||
                   birdRect.IntersectsWith(Zemin.Bounds);
        }

        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (!gameStarted)
                {
                    gameStarted = true;
                    gameTimer.Start();
                }
                else if (!gamePaused)
                {
                    verticalVelocity = -15;
                    jump.Play();
                }
            }
        }

        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            // No changes needed for key up event in this scenario
        }

        private void endGame()
        {
            gameTimer.Stop();
            gameOver.Play();
            ScoreText.Text = "GAME OVER!";
            gamePaused = true;
            gameStarted = false;

            this.KeyPreview = false;

            UpdateTopScores(score);
            SaveTopScores();
           

            string topScoresText = string.Join(Environment.NewLine, topScores.Take(10).Select((s, i) => $"{i + 1}. {s}"));
            string message = $"Your score: {score}\nTop scores:\n{topScoresText}\nDo you want to restart?";

            DialogResult result = MessageBox.Show(message, "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            this.KeyPreview = true;

            if (result == DialogResult.Yes)
            {
                RestartGame();
            }
            else
            {
                this.Close();
            }

            TopScoreText.Text = "Top Score: " + topScores.FirstOrDefault();
        }

        private void RestartGame()
        {
            score = 0;
            boruHızı = 10;
            gravity = 2;
            verticalVelocity = 0;
            gamePaused = false;
            gameStarted = false;

            BoruAlt.Left = this.Width + 150;
            BoruUst.Left = this.Width + 150;
            BoruAlt2.Left = this.Width + 450;
            BoruUst2.Left = this.Width + 450;
            BoruAlt3.Left = this.Width + 750;
            BoruUst3.Left = this.Width + 750;
            BoruAlt4.Left = this.Width + 1050;
            BoruUst4.Left = this.Width + 1050;
            BoruAlt5.Left = this.Width + 1350;
            BoruUst5.Left = this.Width + 1350;
            flappyBird.Top = this.Height / 2;

            ScoreText.Text = "Press SPACE to start";
        }

        private void LoadTopScores()
        {
             // Clear the existing scores to ensure no duplicates

            if (!string.IsNullOrEmpty(Properties.Settings.Default.TopScores))
            {
                string[] scoreStrings = Properties.Settings.Default.TopScores.Split(',');

                foreach (string scoreString in scoreStrings)
                {
                    if (int.TryParse(scoreString, out int score))
                    {
                        topScores.Add(score);
                    }
                    else
                    {
                        // Handle invalid entry if needed, e.g., log the issue
                        Console.WriteLine($"Invalid score entry: {scoreString}");
                    }
                }

                // Ensure the list is sorted after loading
                topScores = topScores.OrderByDescending(s => s).ToList();
            }
        }


        private void SaveTopScores()
        {
            Properties.Settings.Default.TopScores = string.Join(",", topScores);
            Properties.Settings.Default.Save();
        }

        private void UpdateTopScores(int newScore)
        {
            topScores.Add(newScore);
            topScores = topScores.OrderByDescending(s => s).Take(5).ToList();
        }

        private void flappyBird_Paint(object sender, PaintEventArgs e)
        {
            // Kuşun mevcut animasyon karesini çiz
            e.Graphics.DrawImage(birdImages[currentBirdImageIndex], 0, 0, flappyBird.Width, flappyBird.Height);
        }
    }

    public class DoubleBufferedPictureBox : PictureBox
    {
        public DoubleBufferedPictureBox()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            this.UpdateStyles();
        }
    }


}
