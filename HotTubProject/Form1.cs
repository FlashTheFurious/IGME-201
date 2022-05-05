using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotTubProject
{
    public partial class Form1 : Form
    {

        // These booleans let the method FacilityChangeButton__Click know
        // which facility we are updating.
        // This allows me to use the same method and same panel to update all the facilities
        // instead of making a separate method and panel for each of them.
        // This demonstrates polymorphism
        public bool bHotTubUpdating = false;
        public bool bLapPoolUpdating = false;
        public bool bDivingPoolUpdating = false;
        public bool bRecreationalUpdating = false;

        // Reference to form2, we pass in the form2 in form1's constructor
        Form2 form2;

        public Form1(Form2 form2)
        {
            InitializeComponent();

            // Assigning the passed form to the variable
            this.form2 = form2;
            // Show the second form
            form2.Show();

            //Event Handlers for all buttons
            this.recPoolUpdateButton.Click += new EventHandler(RecPoolUpdateButton__Click);
            this.lapPoolScheduleButton.Click += new EventHandler(LapPoolScheduleButton__Click);
            this.lapPoolUpdateButton.Click += new EventHandler(LapPoolUpdateButton__Click);
            this.divingPoolScheduleButton.Click += new EventHandler(DivingPoolScheduleButton__Click);
            this.divingPoolUpdateButton.Click += new EventHandler(DivingPoolUpdateButton__Click);
            this.hotTubUpdateButton.Click += new EventHandler(HotTubUpdateButton__Click);
            this.facilityChangeButton.Click += new EventHandler(FacilityChangeButton__Click);
            this.submitScheduleButton.Click += new EventHandler(SubmitScheduleButton__Click);

        }

        // Checks which facility is being updated
        // Changes the text values of the Labels on the user's side
        private void SubmitScheduleButton__Click(object sender, EventArgs e)
        {

            if (bDivingPoolUpdating)
            {
                form2.divingPoolReservedLabel.Text = this.reserveScheduleTextBox.Text;
                form2.divingPoolReopenLabel.Text = this.reopenScheduleTextBox.Text;
                bDivingPoolUpdating = false;
            }
            else if (bLapPoolUpdating)
            {
                form2.lapPoolCloseTimeLabel.Text = this.reserveScheduleTextBox.Text;
                form2.lapPoolReopenTimeLabel.Text = this.reopenScheduleTextBox.Text;
                bLapPoolUpdating = false;
            }


            schedulePanel.Visible = false;
        }

        private void FacilityChangeButton__Click(object sender, EventArgs e)
        {
            // The first set of if and else if blocks check which facility is being updated
            // The second set of if and else if blocks check the radio buttons for 'Open' and 'Closed'
            // and update the images accordingly on the user side

            if (bHotTubUpdating)
            {
                if (this.openRadioButton.Checked)
                {
                    form2.hotTubClosedPictureBox.Visible = false;
                    form2.hotTubOpenPictureBox.Visible = true;
                }
                else if (this.closedRadioButton.Checked)
                {
                    form2.hotTubOpenPictureBox.Visible = false;
                    form2.hotTubClosedPictureBox.Visible = true;
                }
                // We finished updating this facility, so set bHotTubUpdating to false
                bHotTubUpdating = false;
            }
            else if (bRecreationalUpdating)
            {
                if (this.openRadioButton.Checked)
                {
                    form2.recPoolClosedPictureBox.Visible = false;
                    form2.recPoolOpenPictureBox.Visible = true;
                }
                else if (this.closedRadioButton.Checked)
                {
                    form2.recPoolOpenPictureBox.Visible = false;
                    form2.recPoolClosedPictureBox.Visible = true;
                }
                // We finished updating this facility, so set bRecreationalUpdating to false
                bRecreationalUpdating = false;
            }
            else if (bDivingPoolUpdating)
            {
                if (this.openRadioButton.Checked)
                {
                    form2.divingPoolClosedPictureBox.Visible = false;
                    form2.divingPoolOpenPictureBox.Visible = true;
                }
                else if (this.closedRadioButton.Checked)
                {
                    form2.divingPoolOpenPictureBox.Visible = false;
                    form2.divingPoolClosedPictureBox.Visible = true;
                }
                // We finished updating this facility, so set bDivingPoolUpdating to false
                bDivingPoolUpdating = false;
            }
            else if (bLapPoolUpdating)
            {
                if (this.openRadioButton.Checked)
                {
                    form2.lapPoolClosedPictureBox.Visible = false;
                    form2.lapPoolOpenPictureBox.Visible = true;
                }
                else if (this.closedRadioButton.Checked)
                {
                    form2.lapPoolOpenPictureBox.Visible = false;
                    form2.lapPoolClosedPictureBox.Visible = true;
                }
                // We finished updating this facility, so set bLapPoolUpdating to false
                bLapPoolUpdating = false;
            }
            // Hide this panel when we're done
            this.facilityUpdatePanel.Visible = false;
        }


        private void RecPoolUpdateButton__Click(object sender, EventArgs e)
        {
            this.facilityUpdatePanel.Visible = true;
            this.facilityLabel.Text = "Is the Recreational Pool currently Open or Closed? ";
            bRecreationalUpdating = true;
        }
        private void LapPoolScheduleButton__Click(object sender, EventArgs e)
        {
            bLapPoolUpdating = true;
            schedulePanel.Visible = true;


        }
        private void LapPoolUpdateButton__Click(object sender, EventArgs e)
        {
            this.facilityUpdatePanel.Visible = true;
            this.facilityLabel.Text = "Is the Lap Pool currently Open or Closed? ";
            bLapPoolUpdating = true;

        }
        private void DivingPoolScheduleButton__Click(object sender, EventArgs e)
        {
            bDivingPoolUpdating = true;
            schedulePanel.Visible = true;

        }
        private void DivingPoolUpdateButton__Click(object sender, EventArgs e)
        {
            this.facilityUpdatePanel.Visible = true;
            this.facilityLabel.Text = "Is the Diving Pool currently Open or Closed? ";
            bDivingPoolUpdating = true;
        }
        private void HotTubUpdateButton__Click(object sender, EventArgs e)
        {
            this.facilityUpdatePanel.Visible = true;
            this.facilityLabel.Text = "Is the Hot Tub currently Open or Closed? ";
            bHotTubUpdating = true;

        }

    }
}
