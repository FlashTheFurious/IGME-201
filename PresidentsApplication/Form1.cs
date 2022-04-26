using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresidentsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



            this.williamJClintonRadioButton.CheckedChanged += new EventHandler(WilliamJClintonRadioButton__CheckedChanged);
            this.williamMcKinleyRadioButton.CheckedChanged += new EventHandler(WilliamMcKinleyRadioButton__CheckedChanged);
            this.barackObamaRadioButton.CheckedChanged += new EventHandler(BarackObamaRadioButton__CheckedChanged);
            this.benjaminHarrisonRadioButton.CheckedChanged += new EventHandler(BenjaminHarrisonRadioButton__CheckedChanged);
            this.dwightDEisenhowerRadioButton.CheckedChanged += new EventHandler(DwightDEisenhowerRadioButton__CheckedChanged);
            this.franklinDRooseveltRadioButton.CheckedChanged += new EventHandler(FranklinDRooseveltRadioButton__CheckedChanged);
            this.franklinPierceRadioButton.CheckedChanged += new EventHandler(FranklinPierceRadioButton__CheckedChanged);



            this.georgeWashingtonRadioButton.CheckedChanged += new EventHandler(GeorgeWashingtonRadioButton__CheckedChanged);
            this.georgeWBushRadioButton.CheckedChanged += new EventHandler(GeorgeWBushRadioButton__CheckedChanged);
            this.jamesBuchananRadioButton.CheckedChanged += new EventHandler(JamesBuchananRadioButton__CheckedChanged);
            this.johnAdamsRadioButton.CheckedChanged += new EventHandler(JohnAdamsRadioButton__CheckedChanged);
            this.johnFKennedyRadioButton.CheckedChanged += new EventHandler(JohnFKennedyRadioButton__CheckedChanged);
            this.thomasJeffersonRadioButton.CheckedChanged += new EventHandler(ThomasJeffersonRadioButton__CheckedChanged);
            this.ronaldReaganRadioButton.CheckedChanged += new EventHandler(RonaldReaganRadioButton__CheckedChanged);
            this.martinVanBurenRadioButton.CheckedChanged += new EventHandler(MartinVanBurenRadioButton__CheckedChanged);
            this.theodoreRooseveltRadioButton.CheckedChanged += new EventHandler(TheodoreRooseveltRadioButton__CheckedChanged);


            this.democratRadioButton.CheckedChanged += new EventHandler(DemocratRadioButton__CheckedChanged);
            this.republicanRadioButton.CheckedChanged += new EventHandler(RepublicanRadioButton__CheckedChanged);
            this.democratRepublicanRadioButton.CheckedChanged += new EventHandler(DemocratRepublicanRadioButton__CheckedChanged);
            this.federalistRadioButton.CheckedChanged += new EventHandler(FederalistRadioButton__CheckedChanged);
            this.allRadioButton.CheckedChanged += new EventHandler(AllRadioButton__CheckedChanged);
        }
        private void AllPresidentsInvisible()
        {
            this.williamJClintonRadioButton.Visible = false;
            this.williamMcKinleyRadioButton.Visible = false;
            this.barackObamaRadioButton.Visible = false;
            this.benjaminHarrisonRadioButton.Visible = false;
            this.dwightDEisenhowerRadioButton.Visible = false;
            this.franklinDRooseveltRadioButton.Visible = false;
            this.franklinPierceRadioButton.Visible = false;

            this.georgeWashingtonRadioButton.Visible = false;
            this.georgeWBushRadioButton.Visible = false;
            this.jamesBuchananRadioButton.Visible = false;
            this.johnAdamsRadioButton.Visible = false;
            this.johnFKennedyRadioButton.Visible = false;
            this.thomasJeffersonRadioButton.Visible = false;
            this.ronaldReaganRadioButton.Visible = false;
            this.martinVanBurenRadioButton.Visible = false;
            this.theodoreRooseveltRadioButton.Visible = false;

        }
        private void DemocratRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            AllPresidentsInvisible();
            this.williamJClintonRadioButton.Visible = false;
            this.barackObamaRadioButton.Visible = false;
            this.franklinPierceRadioButton.Visible = false;
            this.franklinDRooseveltRadioButton.Visible = false;
            this.jamesBuchananRadioButton.Visible = false;
            this.johnFKennedyRadioButton.Visible = false;
            this.martinVanBurenRadioButton.Visible = false;
        }
        private void RepublicanRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            AllPresidentsInvisible();
            this.williamMcKinleyRadioButton.Visible = false;
            this.benjaminHarrisonRadioButton.Visible = false;
            this.dwightDEisenhowerRadioButton.Visible = false;
            this.georgeWBushRadioButton.Visible = false;
            this.ronaldReaganRadioButton.Visible = false;
            this.theodoreRooseveltRadioButton.Visible = false;
        }
        private void DemocratRepublicanRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            AllPresidentsInvisible();
            this.thomasJeffersonRadioButton.Visible = true;

        }
        private void FederalistRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            AllPresidentsInvisible();
            this.johnAdamsRadioButton.Visible = true;
            this.georgeWashingtonRadioButton.Visible = true;
        }
        private void AllRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            this.williamJClintonRadioButton.Visible = true;
            this.williamMcKinleyRadioButton.Visible = true;
            this.barackObamaRadioButton.Visible = true;
            this.benjaminHarrisonRadioButton.Visible = true;
            this.dwightDEisenhowerRadioButton.Visible = true;
            this.franklinDRooseveltRadioButton.Visible = true;
            this.franklinPierceRadioButton.Visible = true;


            this.georgeWashingtonRadioButton.Visible = true;
            this.georgeWBushRadioButton.Visible = true;
            this.jamesBuchananRadioButton.Visible = true;
            this.johnAdamsRadioButton.Visible = true;
            this.johnFKennedyRadioButton.Visible = true;
            this.thomasJeffersonRadioButton.Visible = true;
            this.ronaldReaganRadioButton.Visible = true;
            this.martinVanBurenRadioButton.Visible = true;
            this.theodoreRooseveltRadioButton.Visible = true;
        }

        private void WilliamJClintonRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            //Navigate and groupBox text changed
            this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Bill_Clinton");
            this.groupBox1.Text = "https://en.m.wikipedia.org/wiki/Bill_Clinton";

            //Images display
            this.WJCPictureBox.Visible = true;
            this.WJCPictureBox.BringToFront();

        }

        private void WilliamMcKinleyRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/William_McKinley");
            this.groupBox1.Text = "https://en.m.wikipedia.org/wiki/William_McKinley";
            this.WMKPictureBox.Visible = true;
            this.WMKPictureBox.BringToFront();
        }
        private void BarackObamaRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Barack_Obama");
            this.groupBox1.Text = "https://en.m.wikipedia.org/wiki/Barack_Obama";
            this.BOPictureBox.Visible = true;
            this.BOPictureBox.BringToFront();

        }
        private void BenjaminHarrisonRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Benjamin_Harrison");
            this.groupBox1.Text = "https://en.m.wikipedia.org/wiki/Benjamin_Harrison";

            this.BHPictureBox.Visible = true;
            this.BHPictureBox.BringToFront();

        }
        private void DwightDEisenhowerRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Dwight_D._Eisenhower");
            this.groupBox1.Text = "https://en.m.wikipedia.org/wiki/Dwight_D._Eisenhower";
            this.DDEPictureBox.Visible = true;
            this.DDEPictureBox.BringToFront();


        }
        private void FranklinDRooseveltRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Franklin_D._Roosevelt");
            this.groupBox1.Text = "https://en.m.wikipedia.org/wiki/Franklin_D._Roosevelt";

            this.FDRPictureBox.Visible = true;
            this.FDRPictureBox.BringToFront();
        }
        private void FranklinPierceRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Franklin_Pierce");

            this.groupBox1.Text = "https://en.m.wikipedia.org/wiki/Franklin_Pierce";

            this.FPPictureBox.Visible = true;
            this.FPPictureBox.BringToFront();

        }
        private void GeorgeWashingtonRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/George_Washington");

            this.groupBox1.Text = "https://en.m.wikipedia.org/wiki/George_Washington";

            this.GWPictureBox.Visible = true;
            this.GWPictureBox.BringToFront();
        }
        private void GeorgeWBushRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/George_W._Bush");

            this.groupBox1.Text = "https://en.m.wikipedia.org/wiki/George_W._Bush";

            this.GWBPictureBox.Visible = true;
            this.GWBPictureBox.BringToFront();
        }
        private void JamesBuchananRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/James_Buchanan");

            this.groupBox1.Text = "https://en.m.wikipedia.org/wiki/James_Buchanan";

            this.JBPictureBox.Visible = true;
            this.JBPictureBox.BringToFront();
        }
        private void JohnAdamsRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/John_Adams");

            this.groupBox1.Text = "https://en.m.wikipedia.org/wiki/John_Adams";

            this.JAPictureBox.Visible = true;
            this.JAPictureBox.BringToFront();
        }
        private void JohnFKennedyRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/John_F._Kennedy");

            this.groupBox1.Text = "https://en.m.wikipedia.org/wiki/John_F._Kennedy";

            this.JFKPictureBox.Visible = true;
            this.JFKPictureBox.BringToFront();
        }
        private void ThomasJeffersonRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Thomas_Jefferson");

            this.groupBox1.Text = "https://en.m.wikipedia.org/wiki/Thomas_Jefferson";

            this.TJPictureBox.Visible = true;
            this.TJPictureBox.BringToFront();
        }
        private void RonaldReaganRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Ronald_Reagan");

            this.groupBox1.Text = "https://en.m.wikipedia.org/wiki/Ronald_Reagan";

            this.RRPictureBox.Visible = true;
            this.RRPictureBox.BringToFront();
        }
        private void MartinVanBurenRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Martin_Van_Buren");

            this.groupBox1.Text = "https://en.m.wikipedia.org/wiki/Martin_Van_Buren";

            this.MVBPictureBox.Visible = true;
            this.MVBPictureBox.BringToFront();
        }
        private void TheodoreRooseveltRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Theodore_Roosevelt");

            this.groupBox1.Text = "https://en.m.wikipedia.org/wiki/Theodore_Roosevelt";

            this.TRPictureBox.Visible = true;
            this.TRPictureBox.BringToFront();
        }
    }
}
