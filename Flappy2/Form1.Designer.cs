
namespace Flappy
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.scoreText = new System.Windows.Forms.Label();
            this.mario = new System.Windows.Forms.PictureBox();
            this.ground1 = new System.Windows.Forms.PictureBox();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.ground2 = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.Moccasin;
            this.scoreText.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.Location = new System.Drawing.Point(148, 571);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(122, 37);
            this.scoreText.TabIndex = 6;
            this.scoreText.Text = "Score: 0";
            // 
            // mario
            // 
            this.mario.Image = global::Flappy.Properties.Resources.MARIO;
            this.mario.Location = new System.Drawing.Point(155, 377);
            this.mario.Name = "mario";
            this.mario.Size = new System.Drawing.Size(75, 100);
            this.mario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mario.TabIndex = 8;
            this.mario.TabStop = false;
            // 
            // ground1
            // 
            this.ground1.Image = global::Flappy.Properties.Resources.ground;
            this.ground1.Location = new System.Drawing.Point(-373, 541);
            this.ground1.Name = "ground1";
            this.ground1.Size = new System.Drawing.Size(655, 126);
            this.ground1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground1.TabIndex = 5;
            this.ground1.TabStop = false;
            // 
            // flappyBird
            // 
            this.flappyBird.Image = global::Flappy.Properties.Resources.FlappyBird;
            this.flappyBird.Location = new System.Drawing.Point(34, 215);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(65, 49);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.flappyBird.TabIndex = 3;
            this.flappyBird.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.Image = global::Flappy.Properties.Resources.pipeTop;
            this.pipeTop.Location = new System.Drawing.Point(403, -12);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(100, 189);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pipeTop.TabIndex = 1;
            this.pipeTop.TabStop = false;
            // 
            // ground2
            // 
            this.ground2.Image = global::Flappy.Properties.Resources.ground;
            this.ground2.Location = new System.Drawing.Point(276, 541);
            this.ground2.Name = "ground2";
            this.ground2.Size = new System.Drawing.Size(655, 126);
            this.ground2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground2.TabIndex = 7;
            this.ground2.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.Image = global::Flappy.Properties.Resources.pipeBottom;
            this.pipeBottom.Location = new System.Drawing.Point(279, 360);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(109, 193);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pipeBottom.TabIndex = 2;
            this.pipeBottom.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(539, 630);
            this.Controls.Add(this.mario);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.ground1);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.ground2);
            this.Controls.Add(this.pipeBottom);
            this.Name = "Form1";
            this.Text = "Flappy Bird";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.mario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.PictureBox ground1;
        private System.Windows.Forms.PictureBox ground2;
        private System.Windows.Forms.PictureBox mario;
    }
}

