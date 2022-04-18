using System;
using System.Windows.Forms;

namespace Flappy
{
    public partial class Form1 : Form
    {
        // Variables start here
        int pipeSpeed; // default pipe speed defined with an integer
        int pipeTopSpeed; // default pipe speed defined with an integer
        int pipeBotSpeed; // default pipe speed defined with an integer
        int v0; // default gravity speed defined with an integer
        int score; // default score integer set to 0
        float t;
        int g;
        Random random;
        // variable ends

        public Form1()
        {
            InitializeComponent();
            initGame();
        }

        void initGame()
        {
            pipeSpeed = 10;
            pipeTopSpeed = 0;
            pipeBotSpeed = 0;
            v0 = 5;
            score = 0;
            scoreText.Text = "Score: 0";
            t = 0;
            g = 10;
            flappyBird.Top = this.Width / 2;
            pipeTop.Left = this.Right;
            pipeBottom.Left = this.Right;
            ground1.Left = this.Left;
            ground2.Left = ground1.Right - 1;
            ground2.Top = ground1.Top;
            random = new Random();
            choosePipesToMove();
            gameTimer.Interval = 30;
            gameTimer.Start();
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            // this is the game key is up event thats linked to the main form
            if (e.KeyCode == Keys.Space)
            {
                // if the space key is released then gravity is set back to 15
                t = 0;
            }

        }

        private void endGame()
        {
            // this is the game end function, this function will when the bird touches the ground or the pipes
            gameTimer.Stop(); // stop the main timer
            scoreText.Text += " Game over!!!"; // show the game over text on the score text, += is used to add the new string of text next to the score instead of overriding it

            DialogResult result = MessageBox.Show("Хотите попробовать еще?", "Конец игры", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                initGame();
            else
                Close();
        }

        private void moveBird()
        {
            int v = (int)(-v0 + g * t * t);
            // link the flappy bird picture box to the gravity, += means it will add the speed of gravity to the picture boxes top location so it will move down
            flappyBird.Top += v;

            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
               flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
               flappyBird.Bounds.IntersectsWith(ground1.Bounds) ||
               flappyBird.Bounds.IntersectsWith(ground2.Bounds) ||
               flappyBird.Top < 0)
            {
                // if any of the conditions are met from above then we will run the end game function
                endGame();
            }
        }

        private void moveGround()
        {
            ground1.Left -= pipeSpeed;
            ground2.Left -= pipeSpeed;

            if (ground1.Right < 0)
                ground1.Left = ground2.Right - 30;
            if (ground2.Right < 0)
                ground2.Left = ground1.Right - 30;
        }

        private void choosePipesToMove()
        {
            switch (random.Next(3))
            {
                case 0:
                    pipeTopSpeed = pipeSpeed;
                    pipeBotSpeed = 0;
                    break;
                case 1:
                    pipeTopSpeed = 0;
                    pipeBotSpeed = pipeSpeed;
                    break;
                case 2:
                    pipeTopSpeed = pipeSpeed;
                    pipeBotSpeed = pipeSpeed;
                    break;
            }
        }

        private void movePipes()
        {
            pipeBottom.Left -= pipeBotSpeed; 
            pipeTop.Left -= pipeTopSpeed;
            

            if (pipeBottom.Right < 0 || pipeTop.Right < 0)
            {
                // if the bottom pipes location is -150 then we will reset it back to 800 and add 1 to the score
                pipeBottom.Left = this.Right;
                pipeTop.Left = this.Right;
                score++;
                scoreText.Text = "Score: " + score; // show the current score on the score text label

                choosePipesToMove();
            }
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            t += gameTimer.Interval / 1000f;
            moveBird();
            movePipes();
            moveGround();

            // if score is greater then 5 then we will increase the pipe speed to 15
            if (score > 5)
                pipeSpeed = 15;
        }
    }
}