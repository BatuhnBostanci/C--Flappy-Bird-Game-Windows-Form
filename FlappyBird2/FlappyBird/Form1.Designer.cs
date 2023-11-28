namespace FlappyBird
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flapyBird = new System.Windows.Forms.PictureBox();
            this.BoruUst = new System.Windows.Forms.PictureBox();
            this.BoruAlt = new System.Windows.Forms.PictureBox();
            this.Zemin = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.flapyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruUst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruAlt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zemin)).BeginInit();
            this.SuspendLayout();
            // 
            // flapyBird
            // 
            this.flapyBird.Image = ((System.Drawing.Image)(resources.GetObject("flapyBird.Image")));
            this.flapyBird.Location = new System.Drawing.Point(12, 256);
            this.flapyBird.Name = "flapyBird";
            this.flapyBird.Size = new System.Drawing.Size(81, 64);
            this.flapyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flapyBird.TabIndex = 0;
            this.flapyBird.TabStop = false;
            this.flapyBird.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BoruUst
            // 
            this.BoruUst.Image = ((System.Drawing.Image)(resources.GetObject("BoruUst.Image")));
            this.BoruUst.Location = new System.Drawing.Point(496, 0);
            this.BoruUst.Name = "BoruUst";
            this.BoruUst.Size = new System.Drawing.Size(100, 144);
            this.BoruUst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoruUst.TabIndex = 0;
            this.BoruUst.TabStop = false;
            this.BoruUst.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // BoruAlt
            // 
            this.BoruAlt.Image = ((System.Drawing.Image)(resources.GetObject("BoruAlt.Image")));
            this.BoruAlt.Location = new System.Drawing.Point(389, 457);
            this.BoruAlt.Name = "BoruAlt";
            this.BoruAlt.Size = new System.Drawing.Size(100, 186);
            this.BoruAlt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoruAlt.TabIndex = 0;
            this.BoruAlt.TabStop = false;
            // 
            // Zemin
            // 
            this.Zemin.Image = ((System.Drawing.Image)(resources.GetObject("Zemin.Image")));
            this.Zemin.Location = new System.Drawing.Point(-1, 625);
            this.Zemin.Name = "Zemin";
            this.Zemin.Size = new System.Drawing.Size(609, 71);
            this.Zemin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Zemin.TabIndex = 0;
            this.Zemin.TabStop = false;
            this.Zemin.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Location = new System.Drawing.Point(27, 696);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(44, 13);
            this.scoreText.TabIndex = 1;
            this.scoreText.Text = "Score:0";
            this.scoreText.Click += new System.EventHandler(this.label1_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(608, 708);
            this.Controls.Add(this.flapyBird);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.Zemin);
            this.Controls.Add(this.BoruAlt);
            this.Controls.Add(this.BoruUst);
            this.Name = "Form1";
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdows);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gemakeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.flapyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruUst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruAlt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zemin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flapyBird;
        private System.Windows.Forms.PictureBox BoruUst;
        private System.Windows.Forms.PictureBox BoruAlt;
        private System.Windows.Forms.PictureBox Zemin;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
    }
}

