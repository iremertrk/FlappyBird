namespace FlappyBird
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Zemin = new System.Windows.Forms.PictureBox();
            this.ScoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.TopScoreText = new System.Windows.Forms.Label();
            this.flappyBird = new System.Windows.Forms.Panel();
            this.BoruAlt = new System.Windows.Forms.PictureBox();
            this.BoruUst = new System.Windows.Forms.PictureBox();
            this.BoruUst2 = new System.Windows.Forms.PictureBox();
            this.BoruAlt2 = new System.Windows.Forms.PictureBox();
            this.BoruUst3 = new System.Windows.Forms.PictureBox();
            this.BoruAlt3 = new System.Windows.Forms.PictureBox();
            this.BoruUst4 = new System.Windows.Forms.PictureBox();
            this.BoruUst5 = new System.Windows.Forms.PictureBox();
            this.BoruAlt4 = new System.Windows.Forms.PictureBox();
            this.BoruAlt5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Zemin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruAlt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruUst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruUst2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruAlt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruUst3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruAlt3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruUst4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruUst5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruAlt4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruAlt5)).BeginInit();
            this.SuspendLayout();
            // 
            // Zemin
            // 
            this.Zemin.Image = ((System.Drawing.Image)(resources.GetObject("Zemin.Image")));
            this.Zemin.Location = new System.Drawing.Point(-2, 469);
            this.Zemin.Name = "Zemin";
            this.Zemin.Size = new System.Drawing.Size(1621, 108);
            this.Zemin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Zemin.TabIndex = 0;
            this.Zemin.TabStop = false;
            // 
            // ScoreText
            // 
            this.ScoreText.AccessibleName = "";
            this.ScoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ScoreText.Location = new System.Drawing.Point(12, 495);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(209, 35);
            this.ScoreText.TabIndex = 1;
            this.ScoreText.Text = "Score:0";
            this.ScoreText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // TopScoreText
            // 
            this.TopScoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TopScoreText.Location = new System.Drawing.Point(12, 541);
            this.TopScoreText.Name = "TopScoreText";
            this.TopScoreText.Size = new System.Drawing.Size(209, 24);
            this.TopScoreText.TabIndex = 2;
            this.TopScoreText.Text = "Top Score:    ";
            // 
            // flappyBird
            // 
            this.flappyBird.BackColor = System.Drawing.Color.Transparent;
            this.flappyBird.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flappyBird.BackgroundImage")));
            this.flappyBird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flappyBird.Location = new System.Drawing.Point(49, 101);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(50, 40);
            this.flappyBird.TabIndex = 6;
            this.flappyBird.Paint += new System.Windows.Forms.PaintEventHandler(this.flappyBird_Paint);
            // 
            // BoruAlt
            // 
            this.BoruAlt.Image = ((System.Drawing.Image)(resources.GetObject("BoruAlt.Image")));
            this.BoruAlt.Location = new System.Drawing.Point(590, 357);
            this.BoruAlt.Name = "BoruAlt";
            this.BoruAlt.Size = new System.Drawing.Size(85, 184);
            this.BoruAlt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoruAlt.TabIndex = 0;
            this.BoruAlt.TabStop = false;
            // 
            // BoruUst
            // 
            this.BoruUst.Image = ((System.Drawing.Image)(resources.GetObject("BoruUst.Image")));
            this.BoruUst.Location = new System.Drawing.Point(395, 1);
            this.BoruUst.Name = "BoruUst";
            this.BoruUst.Size = new System.Drawing.Size(90, 206);
            this.BoruUst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoruUst.TabIndex = 0;
            this.BoruUst.TabStop = false;
            // 
            // BoruUst2
            // 
            this.BoruUst2.Image = ((System.Drawing.Image)(resources.GetObject("BoruUst2.Image")));
            this.BoruUst2.Location = new System.Drawing.Point(771, -83);
            this.BoruUst2.Name = "BoruUst2";
            this.BoruUst2.Size = new System.Drawing.Size(90, 247);
            this.BoruUst2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoruUst2.TabIndex = 0;
            this.BoruUst2.TabStop = false;
            // 
            // BoruAlt2
            // 
            this.BoruAlt2.Image = ((System.Drawing.Image)(resources.GetObject("BoruAlt2.Image")));
            this.BoruAlt2.Location = new System.Drawing.Point(871, 357);
            this.BoruAlt2.Name = "BoruAlt2";
            this.BoruAlt2.Size = new System.Drawing.Size(85, 184);
            this.BoruAlt2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoruAlt2.TabIndex = 0;
            this.BoruAlt2.TabStop = false;
            // 
            // BoruUst3
            // 
            this.BoruUst3.Image = ((System.Drawing.Image)(resources.GetObject("BoruUst3.Image")));
            this.BoruUst3.Location = new System.Drawing.Point(1097, 1);
            this.BoruUst3.Name = "BoruUst3";
            this.BoruUst3.Size = new System.Drawing.Size(90, 186);
            this.BoruUst3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoruUst3.TabIndex = 0;
            this.BoruUst3.TabStop = false;
            // 
            // BoruAlt3
            // 
            this.BoruAlt3.Image = ((System.Drawing.Image)(resources.GetObject("BoruAlt3.Image")));
            this.BoruAlt3.Location = new System.Drawing.Point(1149, 311);
            this.BoruAlt3.Name = "BoruAlt3";
            this.BoruAlt3.Size = new System.Drawing.Size(85, 184);
            this.BoruAlt3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoruAlt3.TabIndex = 0;
            this.BoruAlt3.TabStop = false;
            // 
            // BoruUst4
            // 
            this.BoruUst4.Image = ((System.Drawing.Image)(resources.GetObject("BoruUst4.Image")));
            this.BoruUst4.Location = new System.Drawing.Point(1379, -108);
            this.BoruUst4.Name = "BoruUst4";
            this.BoruUst4.Size = new System.Drawing.Size(90, 272);
            this.BoruUst4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoruUst4.TabIndex = 0;
            this.BoruUst4.TabStop = false;
            // 
            // BoruUst5
            // 
            this.BoruUst5.Image = ((System.Drawing.Image)(resources.GetObject("BoruUst5.Image")));
            this.BoruUst5.Location = new System.Drawing.Point(1705, -24);
            this.BoruUst5.Name = "BoruUst5";
            this.BoruUst5.Size = new System.Drawing.Size(90, 211);
            this.BoruUst5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoruUst5.TabIndex = 0;
            this.BoruUst5.TabStop = false;
            // 
            // BoruAlt4
            // 
            this.BoruAlt4.Image = ((System.Drawing.Image)(resources.GetObject("BoruAlt4.Image")));
            this.BoruAlt4.Location = new System.Drawing.Point(1479, 332);
            this.BoruAlt4.Name = "BoruAlt4";
            this.BoruAlt4.Size = new System.Drawing.Size(85, 209);
            this.BoruAlt4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoruAlt4.TabIndex = 0;
            this.BoruAlt4.TabStop = false;
            // 
            // BoruAlt5
            // 
            this.BoruAlt5.Image = ((System.Drawing.Image)(resources.GetObject("BoruAlt5.Image")));
            this.BoruAlt5.Location = new System.Drawing.Point(1757, 413);
            this.BoruAlt5.Name = "BoruAlt5";
            this.BoruAlt5.Size = new System.Drawing.Size(85, 82);
            this.BoruAlt5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoruAlt5.TabIndex = 0;
            this.BoruAlt5.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1543, 574);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.TopScoreText);
            this.Controls.Add(this.ScoreText);
            this.Controls.Add(this.Zemin);
            this.Controls.Add(this.BoruAlt5);
            this.Controls.Add(this.BoruAlt3);
            this.Controls.Add(this.BoruAlt4);
            this.Controls.Add(this.BoruUst5);
            this.Controls.Add(this.BoruAlt2);
            this.Controls.Add(this.BoruUst4);
            this.Controls.Add(this.BoruUst3);
            this.Controls.Add(this.BoruUst2);
            this.Controls.Add(this.BoruAlt);
            this.Controls.Add(this.BoruUst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kuş Uçurma";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Zemin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruAlt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruUst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruUst2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruAlt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruUst3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruAlt3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruUst4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruUst5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruAlt4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruAlt5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Zemin;
        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label TopScoreText;
        private System.Windows.Forms.Panel flappyBird;
        private System.Windows.Forms.PictureBox BoruAlt;
        private System.Windows.Forms.PictureBox BoruUst;
        private System.Windows.Forms.PictureBox BoruUst2;
        private System.Windows.Forms.PictureBox BoruAlt2;
        private System.Windows.Forms.PictureBox BoruUst3;
        private System.Windows.Forms.PictureBox BoruAlt3;
        private System.Windows.Forms.PictureBox BoruUst4;
        private System.Windows.Forms.PictureBox BoruUst5;
        private System.Windows.Forms.PictureBox BoruAlt4;
        private System.Windows.Forms.PictureBox BoruAlt5;
    }
}

