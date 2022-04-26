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

            this.BHPictureBox.MouseLeave += new EventHandler(BHPictureBox__MouseLeave);
            this.FDRPictureBox.MouseLeave += new EventHandler(FDRPictureBox__MouseLeave);
            this.WJCPictureBox.MouseLeave += new EventHandler(WJCPictureBox__MouseLeave);
            this.JBPictureBox.MouseLeave += new EventHandler(JBPictureBox__MouseLeave);
            this.FPPictureBox.MouseLeave += new EventHandler(FPPictureBox__MouseLeave);
            this.GWBPictureBox.MouseLeave += new EventHandler(GWBPictureBox__MouseLeave);
            this.BOPictureBox.MouseLeave += new EventHandler(BOPictureBox__MouseLeave);
            this.JFKPictureBox.MouseLeave += new EventHandler(JFKPictureBox__MouseLeave);
            this.WMKPictureBox.MouseLeave += new EventHandler(WMKPictureBox__MouseLeave);
            this.RRPictureBox.MouseLeave += new EventHandler(RRPictureBox__MouseLeave);
            this.DDEPictureBox.MouseLeave += new EventHandler(DDEPictureBox__MouseLeave);
            this.MVBPictureBox.MouseLeave += new EventHandler(MVBPictureBox__MouseLeave);
            this.GWPictureBox.MouseLeave += new EventHandler(GWPictureBox__MouseLeave);
            this.JAPictureBox.MouseLeave += new EventHandler(JAPictureBox__MouseLeave);
            this.TRPictureBox.MouseLeave += new EventHandler(TRPictureBox__MouseLeave);
            this.TJPictureBox.MouseLeave += new EventHandler(TJPictureBox__MouseLeave);

            this.BHPictureBox.MouseHover += new EventHandler(BHPictureBox__MouseHover);
            this.FDRPictureBox.MouseHover += new EventHandler(FDRPictureBox__MouseHover);
            this.WJCPictureBox.MouseHover += new EventHandler(WJCPictureBox__MouseHover);
            this.JBPictureBox.MouseHover += new EventHandler(JBPictureBox__MouseHover);
            this.FPPictureBox.MouseHover += new EventHandler(FPPictureBox__MouseHover);
            this.GWBPictureBox.MouseHover += new EventHandler(GWBPictureBox__MouseHover);
            this.BOPictureBox.MouseHover += new EventHandler(BOPictureBox__MouseHover);
            this.JFKPictureBox.MouseHover += new EventHandler(JFKPictureBox__MouseHover);
            this.WMKPictureBox.MouseHover += new EventHandler(WMKPictureBox__MouseHover);
            this.RRPictureBox.MouseHover += new EventHandler(RRPictureBox__MouseHover);
            this.DDEPictureBox.MouseHover += new EventHandler(DDEPictureBox__MouseHover);
            this.MVBPictureBox.MouseHover += new EventHandler(MVBPictureBox__MouseHover);
            this.GWPictureBox.MouseHover += new EventHandler(GWPictureBox__MouseHover);
            this.JAPictureBox.MouseHover += new EventHandler(JAPictureBox__MouseHover);
            this.TRPictureBox.MouseHover += new EventHandler(TRPictureBox__MouseHover);
            this.TJPictureBox.MouseHover += new EventHandler(TJPictureBox__MouseHover);


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

        private void BHPictureBox__MouseLeave(object sender, EventArgs e)
        {
            BHPictureBox.Height = 230;
            BHPictureBox.Width = 169;
        }
        private void FDRPictureBox__MouseLeave(object sender, EventArgs e)
        {
            FDRPictureBox.Height = 230;
            FDRPictureBox.Width = 169;
        }
        private void WJCPictureBox__MouseLeave(object sender, EventArgs e)
        {
            WJCPictureBox.Height = 230;
            WJCPictureBox.Width = 169;
        }
        private void JBPictureBox__MouseLeave(object sender, EventArgs e)
        {
            JBPictureBox.Height = 230;
            JBPictureBox.Width = 169;
        }
        private void FPPictureBox__MouseLeave(object sender, EventArgs e)
        {
            FPPictureBox.Height = 230;
            FPPictureBox.Width = 169;
        }
        private void GWBPictureBox__MouseLeave(object sender, EventArgs e)
        {
            GWBPictureBox.Height = 230;
            GWBPictureBox.Width = 169;
        }
        private void BOPictureBox__MouseLeave(object sender, EventArgs e)
        {
            BOPictureBox.Height = 230;
            BOPictureBox.Width = 169;
        }
        private void JFKPictureBox__MouseLeave(object sender, EventArgs e)
        {
            JFKPictureBox.Height = 230;
            JFKPictureBox.Width = 169;
        }
        private void WMKPictureBox__MouseLeave(object sender, EventArgs e)
        {
            WMKPictureBox.Height = 230;
            WMKPictureBox.Width = 169;
        }
        private void RRPictureBox__MouseLeave(object sender, EventArgs e)
        {
            RRPictureBox.Height = 230;
            RRPictureBox.Width = 169;
        }
        private void DDEPictureBox__MouseLeave(object sender, EventArgs e)
        {
            DDEPictureBox.Height = 230;
            DDEPictureBox.Width = 169;
        }
        private void MVBPictureBox__MouseLeave(object sender, EventArgs e)
        {
            MVBPictureBox.Height = 230;
            MVBPictureBox.Width = 169;
        }
        private void GWPictureBox__MouseLeave(object sender, EventArgs e)
        {
            GWPictureBox.Height = 230;
            GWPictureBox.Width = 169;
        }
        private void JAPictureBox__MouseLeave(object sender, EventArgs e)
        {
            JAPictureBox.Height = 230;
            JAPictureBox.Width = 169;
        }
        private void TRPictureBox__MouseLeave(object sender, EventArgs e)
        {
            TRPictureBox.Height = 230;
            TRPictureBox.Width = 169;
        }
        private void TJPictureBox__MouseLeave(object sender, EventArgs e)
        {
            TJPictureBox.Height = 230;
            TJPictureBox.Width = 169;
        }


        private void BHPictureBox__MouseHover(object sender, EventArgs e)
        {
            BHPictureBox.Height = 350;
            BHPictureBox.Width = 280;

        }
        private void FDRPictureBox__MouseHover(object sender, EventArgs e)
        {
            FDRPictureBox.Height = 350;
            FDRPictureBox.Width = 280;
        }
        private void JBPictureBox__MouseHover(object sender, EventArgs e)
        {
            JBPictureBox.Height = 350;
            JBPictureBox.Width = 280;
        }
        private void WJCPictureBox__MouseHover(object sender, EventArgs e)
        {
            WJCPictureBox.Height = 350;
            WJCPictureBox.Width = 280;
        }
        private void FPPictureBox__MouseHover(object sender, EventArgs e)
        {
            FPPictureBox.Height = 350;
            FPPictureBox.Width = 280;

        }
        private void BOPictureBox__MouseHover(object sender, EventArgs e)
        {
            BOPictureBox.Height = 350;
            BOPictureBox.Width = 280;
        }
        private void GWBPictureBox__MouseHover(object sender, EventArgs e)
        {
            GWBPictureBox.Height = 350;
            GWBPictureBox.Width = 280;
        }
        private void JFKPictureBox__MouseHover(object sender, EventArgs e)
        {
            JFKPictureBox.Height = 350;
            JFKPictureBox.Width = 280;
        }
        private void WMKPictureBox__MouseHover(object sender, EventArgs e)
        {
            WMKPictureBox.Height = 350;
            WMKPictureBox.Width = 280;
        }
        private void RRPictureBox__MouseHover(object sender, EventArgs e)
        {
            RRPictureBox.Height = 350;
            RRPictureBox.Width = 280;
        }
        private void DDEPictureBox__MouseHover(object sender, EventArgs e)
        {
            DDEPictureBox.Height = 350;
            DDEPictureBox.Width = 280;
        }
        private void MVBPictureBox__MouseHover(object sender, EventArgs e)
        {
            MVBPictureBox.Height = 350;
            MVBPictureBox.Width = 280;
        }
        private void GWPictureBox__MouseHover(object sender, EventArgs e)
        {
            GWPictureBox.Height = 350;
            GWPictureBox.Width = 280;
        }
        private void JAPictureBox__MouseHover(object sender, EventArgs e)
        {
            JAPictureBox.Height = 350;
            JAPictureBox.Width = 280;
        }
        private void TRPictureBox__MouseHover(object sender, EventArgs e)
        {
            TRPictureBox.Height = 350;
            TRPictureBox.Width = 280;
        }
        private void TJPictureBox__MouseHover(object sender, EventArgs e)
        {
            TJPictureBox.Height = 350;
            TJPictureBox.Width = 280;
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
            this.williamJClintonRadioButton.Visible = true;
            this.barackObamaRadioButton.Visible = true;
            this.franklinPierceRadioButton.Visible = true;
            this.franklinDRooseveltRadioButton.Visible = true;
            this.jamesBuchananRadioButton.Visible = true;
            this.johnFKennedyRadioButton.Visible = true;
            this.martinVanBurenRadioButton.Visible = true;
        }
        private void RepublicanRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            AllPresidentsInvisible();
            this.williamMcKinleyRadioButton.Visible = true;
            this.benjaminHarrisonRadioButton.Visible = true;
            this.dwightDEisenhowerRadioButton.Visible = true;
            this.georgeWBushRadioButton.Visible = true;
            this.ronaldReaganRadioButton.Visible = true;
            this.theodoreRooseveltRadioButton.Visible = true;
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
