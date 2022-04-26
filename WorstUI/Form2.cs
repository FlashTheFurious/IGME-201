using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace WorstUI
{
    public partial class Form2 : Form
    {
        public string secondNumber = "";
        BackgroundWorker bgw = new BackgroundWorker();

        public Form2()
        {
            InitializeComponent();


            this.number0button.Click += new EventHandler(Number0button__Click);
            this.number1button.Click += new EventHandler(Number1button__Click);
            this.number2button.Click += new EventHandler(Number2button__Click);
            this.number3button.Click += new EventHandler(Number3button__Click);
            this.number4button.Click += new EventHandler(Number4button__Click);
            this.number5button.Click += new EventHandler(Number5button__Click);
            this.number6button.Click += new EventHandler(Number6button__Click);
            this.number7button.Click += new EventHandler(Number7button__Click);
            this.number8button.Click += new EventHandler(Number8button__Click);
            this.number9button.Click += new EventHandler(Number9button__Click);
            this.clearCheckBox1.CheckedChanged += new EventHandler(ClearCheckBox1__CheckedChanged);
            this.clearCheckBox2.CheckedChanged += new EventHandler(ClearCheckBox2__CheckedChanged);
            this.clearButton.Click += new EventHandler(ClearButton__Click);


            this.Show();

        }

        private void ClearButton__Click(object sender, EventArgs e)
        {
            bgw.DoWork += new DoWorkEventHandler(bgw_DoWork);
            bgw.ProgressChanged += new ProgressChangedEventHandler(bgw_ProgressChanged);
            bgw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgw_RunWorkerCompleted);
            bgw.WorkerReportsProgress = true;
            bgw.RunWorkerAsync();
        }

        void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            int total = 57; //some number (this is your variable to change)!!

            for (int i = 0; i <= total; i++) //some number (total)
            {
                System.Threading.Thread.Sleep(100);
                int percents = (i * 100) / total;
                bgw.ReportProgress(percents, i);
                //2 arguments:
                //1. procenteges (from 0 t0 100) - i do a calcumation 
                //2. some current value!
            }
        }

        void bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            label1.Text = String.Format("Progress: {0} %", e.ProgressPercentage);
        }

        void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //do the code when bgv completes its work
            MessageBox.Show("Input has been cleared");
            secondNumber = "";
            this.form2NumberLabel.Text = "";
        }

        /*
        private void ClearButton__Click(object sender, EventArgs e)
        {
            MessageBox.Show("Input has been cleared");
            secondNumber = "";
            this.form2NumberLabel.Text = "";
        }
        */
        private void ClearCheckBox1__CheckedChanged(object sender, EventArgs e)
        {
            if (clearCheckBox1.Checked && clearCheckBox2.Checked)
            {
                this.clearButton.Visible = true;
                this.clearButton.Text = "Clear";
            }
            else
            {
                this.clearButton.Visible = false;
            }
        }

        private void ClearCheckBox2__CheckedChanged(object sender, EventArgs e)
        {
            if (clearCheckBox1.Checked && clearCheckBox2.Checked)
            {
                this.clearButton.Visible = true;
                this.clearButton.Text = "Clear";
            }
            else
            {
                this.clearButton.Visible = false;
            }
        }
        private void Number0button__Click(object sender, EventArgs e)
        {
            secondNumber += 0;
            this.form2NumberLabel.Text = secondNumber;
            this.form2NumberLabel.Visible = true;
            if (this.number0button.BackColor == Color.Linen)
            {
                this.number0button.BackColor = Color.OliveDrab;
            }
            else
            {
                this.number0button.BackColor = Color.Linen;
            }

        }

        private void Number1button__Click(object sender, EventArgs e)
        {
            secondNumber += 1; this.form2NumberLabel.Text = secondNumber;
            this.form2NumberLabel.Visible = true;

            if (this.number1button.BackColor == Color.Teal)
            {
                this.number1button.BackColor = Color.Lime;
            }
            else
            {
                this.number1button.BackColor = Color.Teal;
            }

        }

        private void Number2button__Click(object sender, EventArgs e)
        {
            secondNumber += 2; this.form2NumberLabel.Text = secondNumber;
            this.form2NumberLabel.Visible = false;

            if (this.number2button.BackColor == Color.RoyalBlue)
            {
                this.number2button.BackColor = Color.Lavender;
            }
            else
            {
                this.number2button.BackColor = Color.RoyalBlue;
            }
        }

        private void Number3button__Click(object sender, EventArgs e)
        {
            secondNumber += 3; this.form2NumberLabel.Text = secondNumber;
            this.form2NumberLabel.Visible = true;

            if (this.number3button.BackColor == Color.DarkSeaGreen)
            {
                this.number3button.BackColor = Color.BlanchedAlmond;
            }
            else
            {
                this.number3button.BackColor = Color.DarkSeaGreen;
            }
        }

        private void Number4button__Click(object sender, EventArgs e)
        {
            secondNumber += 4; this.form2NumberLabel.Text = secondNumber;
            this.form2NumberLabel.Visible = true;

            if (this.number4button.BackColor == Color.Plum)
            {
                this.number4button.BackColor = Color.Crimson;
            }
            else
            {
                this.number4button.BackColor = Color.Plum;
            }
        }

        private void Number5button__Click(object sender, EventArgs e)
        {
            secondNumber += 5; this.form2NumberLabel.Text = secondNumber;
            this.form2NumberLabel.Visible = false;

            if (this.number5button.BackColor == Color.RoyalBlue)
            {
                this.number5button.BackColor = Color.OliveDrab;
            }
            else
            {
                this.number5button.BackColor = Color.RoyalBlue;
            }
        }

        private void Number6button__Click(object sender, EventArgs e)
        {
            secondNumber += 6; this.form2NumberLabel.Text = secondNumber;
            this.form2NumberLabel.Visible = true;
            if (this.number6button.BackColor == Color.Crimson)
            {
                this.number6button.BackColor = Color.LimeGreen;
            }
            else
            {
                this.number6button.BackColor = Color.Crimson;
            }
        }

        private void Number7button__Click(object sender, EventArgs e)
        {
            secondNumber += 7; this.form2NumberLabel.Text = secondNumber;
            this.form2NumberLabel.Visible = true;

            if (this.number7button.BackColor == Color.Firebrick)
            {
                this.number7button.BackColor = Color.Cyan;
            }
            else
            {
                this.number7button.BackColor = Color.Firebrick;
            }
        }

        private void Number8button__Click(object sender, EventArgs e)
        {
            secondNumber += 8; this.form2NumberLabel.Text = secondNumber;
            this.form2NumberLabel.Visible = true;

            if (this.number8button.BackColor == Color.IndianRed)
            {
                this.number8button.BackColor = Color.Indigo;
            }
            else
            {
                this.number8button.BackColor = Color.IndianRed;
            }
        }

        private void Number9button__Click(object sender, EventArgs e)
        {
            secondNumber += 9; this.form2NumberLabel.Text = secondNumber;
            this.form2NumberLabel.Visible = false;
            if (this.number9button.BackColor == Color.Magenta)
            {
                this.number9button.BackColor = Color.Gold;
            }
            else
            {
                this.number9button.BackColor = Color.Magenta;
            }
        }
    }
}
