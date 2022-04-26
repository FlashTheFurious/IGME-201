using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorstUI
{
    public partial class Form3 : Form
    {
        public string sFinalAnswer;
        public int iFinalAnswer;
        public int iFirstNumber;
        public int iSecondNumber;

        Form1 localForm1;
        Form2 localForm2;


        public Form3(Form1 form1, Form2 form2)
        {
            InitializeComponent();

            this.localForm1 = form1;
            this.localForm2 = form2;

            this.Show();
            this.calculateButton.Click += new EventHandler(CalculateButton__Click);
        }

        private void CalculateButton__Click(object sender, EventArgs e)
        {
            iFirstNumber = int.Parse(localForm1.form1NumberLabel.Text);
            iSecondNumber = int.Parse(localForm2.form2NumberLabel.Text);

            // Purposely switched around the operations, this was not a coding mistake. It was a bad design decision :)

            if (plusRadioButton.Checked)
            {
                iFinalAnswer = iFirstNumber - iSecondNumber;
            }
            else if (minusRadioButton.Checked)
            {
                iFinalAnswer = iFirstNumber + iSecondNumber;
            }
            else if (divideRadioButton.Checked)
            {
                iFinalAnswer = iFirstNumber * iSecondNumber;
            }
            else if (multiplyRadioButton.Checked)
            {
                iFinalAnswer = iFirstNumber / iSecondNumber;
            }

            sFinalAnswer = iFinalAnswer.ToString();
            this.answerLabel.Text = sFinalAnswer;
        }


    }
}
