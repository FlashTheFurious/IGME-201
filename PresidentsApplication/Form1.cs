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

            this.webBrowser1.Navigated += new WebBrowserNavigatedEventHandler(WebBrowser1__Navigated);

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

        }

        private void WebBrowser1__Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {

        }



    }
}
