using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathTest
{
    public partial class MathQuiz : Form
    {

        public Player P = new Player();

        /// <summary>
        ///  Create an object to generate random numbers.
        /// </summary>
        Random randomizer = new Random();

        /// <summary>
        ///  This integer variable keeps track of the remaining time.
        /// </summary>
        public int timeLeft;

        /// <summary>
        ///  Internal value for the first addend.
        /// </summary>
        public int addend1;

        /// <summary>
        /// Internal value for the second addend.
        /// </summary>
        public int addend2;

        /// <summary>
        /// Internal value for the first subst value.
        /// </summary>
        public int minuend;

        /// <summary>
        /// Internal value for the second subst value.
        /// </summary>
        public int subtrahend;

        /// <summary>
        /// Internal value for the first multiplication term.
        /// </summary>
        public int multiplicand;

        /// <summary>
        /// Internal value for the second multiplication term.
        /// </summary>
        public int multiplier;

        /// <summary>
        /// Internal value for the first division term.
        /// </summary>
        public int dividend;

        /// <summary>
        /// Internal value for the second division term.
        /// </summary>
        public int divisor;

        public MathQuiz()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Start the quiz by filling in all of the problems
        /// and starting the timer.
        /// </summary>
        public void StartTheQuiz()
        {
            // Fill in the addition problem.
            // Generate two random numbers to add.
            // Store the values in the variables 'addend1' and 'addend2'.
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;

            lbl_addNum1.Text = addend1.ToString();
            lbl_addNum2.Text = addend2.ToString();
            lbl_subsNum1.Text = minuend.ToString();
            lbl_subsNum2.Text = subtrahend.ToString();
            lbl_multNum1.Text = multiplicand.ToString();
            lbl_multNum2.Text = multiplier.ToString();
            lbl_divNum1.Text = dividend.ToString();
            lbl_divNum2.Text = divisor.ToString();

            dom_sum.Value = 0;
            dom_subs.Value = 0;
            dom_mult.Value = 0;
            dom_div.Value = 0;

            // Start the timer.
            timeLeft = 30;
            lbl_timeRemaining.Text = "30 seconds";
            tmr_quizTime.Start();

            btn_submitScore.Enabled = false;
        }

        private void btn_startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            btn_startButton.Enabled = false;
        }

        private void btn_submitScore_Click(object sender, EventArgs e)
        {
            P.Name = txtBox_name.Text;
            P.Score = Convert.ToInt32(lbl_score.Text);
            P.AddNewPlayer( P );

            btn_submitScore.Enabled = false;
        }

        /// <summary>
        /// Manages the reiaining time from the user.
        /// </summary>
        /// <param name="sender">Obect sender.</param>
        /// <param name="e">EventArgs e.</param>
        private void tmr_quizTime_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                // If CheckTheAnswer() return false, keep counting
                // down. Decrease the time left by one second and 
                // display the new time left by updating the 
                // Time Left label.
                timeLeft--;
                lbl_timeRemaining.Text = timeLeft + " seconds";
            }
            else
            {
                // If the user ran out of time, stop the timer, show 
                // a MessageBox, and fill in the answers.
                tmr_quizTime.Stop();
                lbl_timeRemaining.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                dom_sum.Value = addend1 + addend2;
                dom_subs.Value = minuend - subtrahend;
                dom_mult.Value = multiplicand * multiplier;
                dom_div.Value = dividend / divisor;
                btn_startButton.Enabled = true;
                btn_submitScore.Enabled = true;
            }
        }

        /// <summary>
        /// Check the answer to see if the user got everything right.
        /// </summary>
        /// <returns>True if the answer's correct, false otherwise.</returns>
        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == dom_sum.Value)
                && (minuend - subtrahend == dom_subs.Value)
                && (multiplicand * multiplier == dom_mult.Value)
                && (dividend / divisor == dom_div.Value))
                return true;
            else
                return false;
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            // Select the whole answer in the NumericUpDown control.
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void OnTabIndexChanged(object sender, EventArgs e)
        {
            this.tbl_PlayerTableAdapter.Fill(this.scoresDBDataSet.Tbl_Player);
        }

        private void CheckIfGameEnded()
        {
            if (CheckTheAnswer() && tmr_quizTime.Enabled)
            {
                // If CheckTheAnswer() returns true, then the user 
                // got the answer right. Stop the timer  
                // and show a MessageBox.
                tmr_quizTime.Stop();
                MessageBox.Show("You got all the answers right!",
                                "Congratulations!");


                lbl_score.Text = Math.Round(((timeLeft / 30.0) * 100)).ToString();
                btn_startButton.Enabled = true;
                btn_submitScore.Enabled = true;
            }
        }

        private void OnValueChanged(object sender, EventArgs e)
        {
            CheckIfGameEnded();
        }

        private void OnValueChanged(object sender, KeyEventArgs e)
        {
            CheckIfGameEnded();
        }
    }
}
