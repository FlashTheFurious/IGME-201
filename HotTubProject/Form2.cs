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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            //Mouse Hover events
            lapPoolClosedPictureBox.MouseHover += new EventHandler(LapPoolClosedPictureBox__MouseHover);
            lapPoolOpenPictureBox.MouseHover += new EventHandler(LapPoolOpenPictureBox__MouseHover);
            divingPoolClosedPictureBox.MouseHover += new EventHandler(DivingPoolClosedPictureBox__MouseHover);
            divingPoolOpenPictureBox.MouseHover += new EventHandler(DivingPoolOpenPictureBox__MouseHover);

            //Mouse Leave events
            lapPoolClosedPictureBox.MouseLeave += new EventHandler(LapPoolClosedPictureBox__MouseLeave);
            lapPoolOpenPictureBox.MouseLeave += new EventHandler(LapPoolOpenPictureBox__MouseLeave);
            divingPoolClosedPictureBox.MouseLeave += new EventHandler(DivingPoolClosedPictureBox__MouseLeave);
            divingPoolOpenPictureBox.MouseLeave += new EventHandler(DivingPoolOpenPictureBox__MouseLeave);       

        }

        private void LapPoolClosedPictureBox__MouseHover(object sender, EventArgs e)
        {
            lapPoolPanel.Visible = true;

        }
        private void LapPoolOpenPictureBox__MouseHover(object sender, EventArgs e)
        {
            lapPoolPanel.Visible = true;
        }
        private void DivingPoolClosedPictureBox__MouseHover(object sender, EventArgs e)
        {
            divingPoolPanel.Visible = true;
        }
        private void DivingPoolOpenPictureBox__MouseHover(object sender, EventArgs e)
        {
            divingPoolPanel.Visible = true;
        }
        private void LapPoolClosedPictureBox__MouseLeave(object sender, EventArgs e)
        {
            lapPoolPanel.Visible = false;

        }
        private void LapPoolOpenPictureBox__MouseLeave(object sender, EventArgs e)
        {
            lapPoolPanel.Visible = false;
        }
        private void DivingPoolClosedPictureBox__MouseLeave(object sender, EventArgs e)
        {
            divingPoolPanel.Visible = false;

        }
        private void DivingPoolOpenPictureBox__MouseLeave(object sender, EventArgs e)
        {
            divingPoolPanel.Visible = false;


        }                                                                                   

    }
}
