using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// give access to the Timers namespace
using System.Timers;

namespace WinFormsMathQuiz
{
    public partial class Form1 : Form
    {

        public int iNumberOfQuestions;
        public string sUserName;
        public string sQuestions;
        public int iQuestionsAnswered = 0;
        // public int iDifficultyMultiplier;


        // string and base value related to difficulty
        int nMaxRange = 0;

        // constant for setting difficulty with 1 variable
        const int MAX_BASE = 10;

        // question and # correct counters
        int nCntr = 0;
        int nCorrect = 0;

        // operator picker
        int nOp = 0;

        // operands and solution
        int val1 = 0;
        int val2 = 0;
        int iAnswer = 0;

        // string and int for the response
        //string sResponse = "";
        public int iUserAnswer;

        // boolean for checking valid input
        bool bValid = false;

        // seed the random number generator
        Random rand = new Random();
        List<String> questionList = new List<String>();
        List<Int32> answerList = new List<Int32>();

        public Form1()
        {
            InitializeComponent();

            this.startButton.Click += new EventHandler(StartButton__Click);
            this.submitButton.Click += new EventHandler(SubmitButton__Click);

            this.countdownLabel.Visible = false;

            this.timer.Tick += new EventHandler(Timer__Tick);

            /*
             this.easyRadioButton.CheckedChanged += new EventHandler(EasyRadioButton__CheckedChanged);
             this.mediumRadioButton.CheckedChanged += new EventHandler(MediumRadioButton__CheckedChanged);
             this.hardRadioButton.CheckedChanged += new EventHandler(HardRadioButton__CheckedChanged);
            */

        }

        private void Timer__Tick(object sender, EventArgs e)
        {
            --progressBar1.Value;

            if (this.progressBar1.Value == 0)
            {
                this.wrongPanel.Visible = true;
                this.timer.Stop();

            }
        }

        private void MakeQuestions()
        {


            // initialize correct responses for each time around
            nCorrect = 0;

            //Ask question based on multiplier
            // if they choose easy, then set nMaxRange = MAX_BASE
            // if they choose medium, set nMaxRange = MAX_BASE * 2
            // if they choose hard, set nMaxRange = MAX_BASE * 3

            if (easyRadioButton.Checked)
            {
                nMaxRange = MAX_BASE;
            }
            else if (mediumRadioButton.Checked)
            {
                nMaxRange = MAX_BASE * 2;
            }
            else if (hardRadioButton.Checked)
            {
                nMaxRange = MAX_BASE * 3;
            }


            // ask each question
            for (nCntr = 0; nCntr < iNumberOfQuestions; ++nCntr)
            {

                //Start Timer




                // generate a random number between 0 inclusive and 3 exclusive to get the operation
                nOp = rand.Next(0, 4); //changed 3 to 4 to include division

                val1 = rand.Next(0, nMaxRange) + nMaxRange;
                val2 = rand.Next(0, nMaxRange);

                // if either argument is 0, pick new numbers
                if (val1 == 0 || val2 == 0)
                {
                    // decrement counter to try this one again (because it will be incremented at the top of the loop)
                    --nCntr;
                    continue;
                }

                // if nOp == 0, then addition
                // if nOp == 1, then subtraction
                // if nOp == 2, then division
                // else multiplication
                if (nOp == 0)
                {
                    iAnswer = val1 + val2;
                    sQuestions = $" {val1} + {val2}  ";
                }
                else if (nOp == 1)
                {
                    iAnswer = val1 - val2;
                    sQuestions = $"{val1} - {val2}  ";
                }
                else if (nOp == 2)
                {
                    iAnswer = val1 / val2;
                    sQuestions = $" {val1} / {val2}  ";
                }
                else
                {
                    iAnswer = val1 * val2;
                    sQuestions = $"{val1} * {val2} ";
                }

                // store the question in the questionsList
                // store the answer in the answerList
                questionList.Add(sQuestions);
                answerList.Add(iAnswer);

                questionLabel.Text = questionList[0];


                //Show wrong answer panel if timer runs out



            }
        }
        private void StartButton__Click(object sender, EventArgs e)
        {
            Int32.TryParse(questionNumTextBox.Text, out iNumberOfQuestions);

            //questionLabel.Text = iNumberOfQuestions.ToString();
            sUserName = nameTextBox.Text;

            this.submitButton.Visible = true;
            MakeQuestions();
            this.questionNumTextBox.Visible = false;
            this.startButton.Visible = false;
            this.easyRadioButton.Visible = false;
            this.mediumRadioButton.Visible = false;
            this.hardRadioButton.Visible = false;
            this.secondsTextBox.Visible = false;
            int secondsTimer;
            Int32.TryParse(secondsTextBox.Text, out secondsTimer);
            this.timer.Interval = secondsTimer * 10;
            this.timer.Start();

        }
        private void SubmitButton__Click(object sender, EventArgs e)
        {
            // Stop Timer
            this.timer.Stop();

            Int32.TryParse(this.answerTextBox.Text, out iUserAnswer);

            if (correctPanel.Visible == true || wrongPanel.Visible == true)
            {
                submitButton.Text = "Submit";
                correctPanel.Visible = false;
                wrongPanel.Visible = false;
                if (iNumberOfQuestions - 1 == iQuestionsAnswered)
                {
                    gameOverPanel.Visible = true;
                }
                else
                {
                    this.timer.Start();
                }


            }
            else
            {
                submitButton.Text = "Next Question";
                // if response == answer, output flashy reward and increment # correct
                // else output stark answer
                if (iUserAnswer == answerList[iQuestionsAnswered])
                {
                    correctPanel.Visible = true;

                    // Show flashy reward, and display message with user's name in it
                    congratsLabel.Text = "Good Job " + sUserName + "!!!";
                    ++nCorrect;


                }
                else
                {
                    wrongPanel.Visible = true;
                    //Show wrong answer panel, display the correct answer too
                    sorryLabel.Text = "The right answer was " + answerList[iQuestionsAnswered];
                }


                iQuestionsAnswered++;
                if (iQuestionsAnswered != iNumberOfQuestions)
                {
                    questionLabel.Text = questionList[iQuestionsAnswered];
                }
                else
                {
                    gameOverPanel.Visible = true;
                    gameOver1Label.Text = "You got " + nCorrect + " out of " + iNumberOfQuestions + " questions correct !!!";
                    gameOver2Label.Text = "You got " + (iNumberOfQuestions - nCorrect) + " out of " + iNumberOfQuestions + " questions wrong";

                }


            }


        }

        /*
        private void EasyRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            iDifficultyMultiplier = 2;

        }

        private void MediumRadioButton__CheckedChanged(object sender, EventArgs e)
        {

            iDifficultyMultiplier = 5;
        }
        private void HardRadioButton__CheckedChanged(object sender, EventArgs e)
        {

            iDifficultyMultiplier = 15;
        }
        */

    }
}
