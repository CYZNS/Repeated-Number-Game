using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repeated_Number_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int timer=10;
        private struct stGameInfo
        {
            public int[,] Matrix;
            public int numOfRounds ;
            public int roundCounter;
            public int playerWins;

            public stGameInfo(int rounds =1)
            {
                Matrix = new int[0, 0]; 
                numOfRounds =0;
                roundCounter = 0;
                playerWins = 0;
            }
        }
        stGameInfo gameInfo = new stGameInfo();

        private Random rnd = new Random();

        private int generateRandomNumber()
        {
            return rnd.Next(0,10);
        }
        private int[,] setNumberMatrix()
        {
            int[,] matrix = new int[5, 5];
            for(int i=0;i<=4;i++)
            {
                for(int j=0;j<=4;j++)
                {
                    matrix[i,j] = generateRandomNumber();
                }
            }
            return matrix;
            
        }
        private void setLabelNumbers()
        {
            
            int[,]matrix = gameInfo.Matrix;
            var gameButtons =GamePanel.Controls.OfType<Button>().OrderBy(b => b.Name).ToArray();

            int index = 0;
            for (int i = 0; i <= 4; i++)
            {
                for (int j = 0; j <= 4; j++)
                {
                    gameButtons[index].Text = matrix[i,j].ToString();
                    index++;
                }
            }
        }
        private int numberRepetetion(int[,]numberMatrix,int number)
        {
            int counter = 0;
            for(int i = 0; i < numberMatrix.GetLength(0); i++)
            {                  
                for( int j = 0; j < numberMatrix.GetLength(1); j++)
                {
                    if(numberMatrix[i,j] == number)
                        counter++;
                }
            }
            return counter;
        }
        private void prepareToStart()
        {
            btnStart.Enabled = false;
            txtChoice.Enabled = true;
            txtChoice.Focus();
            lbTimer.Visible = true;
            pictureBox1.Visible = true;
            nd1.Enabled = false;
            GamePanel.Visible = true;
            
        }
        private void prepareToEnd()
        {
            GamePanel.Visible = false;
            btnStart.Enabled = true;
            txtChoice.Enabled = false;
            pictureBox1.Visible = false;
            lbTimer.Visible = false;
            nd1.Enabled = true;
            btnCheck.Enabled = false;
            gameInfo.roundCounter = 0;
            lbNumber.Text = "";
            label2.Text = "";
            txtChoice.Text = "";


        }
        private void setStartInfo()
        {
            txtChoice.Text = "";

            gameInfo.Matrix = setNumberMatrix();
            setLabelNumbers();
            lbNumber.Text = generateRandomNumber().ToString();
            GamePanel.Visible = (GamePanel.Visible == false) ? true : true;

            resetTimer();

        }
        private void resetTimer()
        {
            timer = 10;
            lbTimer.Text = timer.ToString();

            timer1.Start();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            gameInfo.numOfRounds = (int)nd1.Value;
            setStartInfo();
            prepareToStart();
            
            label2.Text =$"Round {gameInfo.roundCounter+1}";
           


        }
        private void txtChoice_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtChoice.Text))
            {
                btnCheck.Enabled = true;
            }
            else
                btnCheck.Enabled = false;
        }
        private void setTransparentLabel(PictureBox picture, Label label)
        {
            label.Parent = picture;
            label.BackColor = Color.Transparent;

            // to center the label 
            label.Location = new Point(
                (picture.Width - label.Width) / 2,
                (picture.Height - label.Height) / 2
            );
        }
        private void checkAnswer(int userAnswer,int correctAnswer,int number)
        {
            
            if (userAnswer == correctAnswer)
            {
                MessageBox.Show("Correct Answer!");
                gameInfo.playerWins++;
            }
            else
            {
                MessageBox.Show($"sorry you failed \n correct answer : {correctAnswer} ");
            }
        }
        private void checkEndGame()
        {
            if (gameInfo.roundCounter == gameInfo.numOfRounds)
            {

                if (gameInfo.playerWins > gameInfo.numOfRounds - gameInfo.playerWins)
                {
                    MessageBox.Show("Congrats You Won!");
                }
                else
                {
                    MessageBox.Show("You Lost!");
                }
                prepareToEnd();
               
            }
            else
            {
                label2.Text = $"Round {gameInfo.roundCounter + 1}";
               setStartInfo();

            }

            

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            setTransparentLabel(pictureBox1,lbTimer);
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            int number = Convert.ToInt32(lbNumber.Text);
            int correctAnswer = numberRepetetion(gameInfo.Matrix,number);
            int userAnswer = Convert.ToInt32(txtChoice.Text);

           checkAnswer(userAnswer,correctAnswer,number);

            gameInfo.roundCounter++;
            

            checkEndGame();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer--;
            lbTimer.Text = timer.ToString();

            if (timer <= 0)
            {
                timer1.Stop();
                GamePanel.Visible = false;
                timer = 10;

            }


            }
    }
}
