using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE20Dom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //This should be the very first statement , ALWAYS
            InitializeComponent();


            try
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
                    @"SOFTWARE\\WOW6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION",
                    true);
                key.SetValue(Application.ExecutablePath.Replace(Application.StartupPath + "\\", ""), 12001, Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();
            }
            catch
            {

            }

            // add the delegate method to be called after the webpage loads, set this up before Navigate()
            this.webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(this.WebBrowser1__DocumentCompleted);


            // if you want to use example.html from a local folder (saved in c:\temp for example):
            // this.webBrowser1.Navigate("c:\\temp\\example.html");

            // or if you want to use the URL  (only use one of these Navigate() statements)
            this.webBrowser1.Navigate("people.rit.edu/dxsigm/example.html");


        }

        private void WebBrowser1__DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser wb = (WebBrowser)sender;
            HtmlElementCollection htmlElementCollection;
            HtmlElement htmlElement;

            //Select and change innerText of the first h1 element
            htmlElementCollection = wb.Document.GetElementsByTagName("h1");
            htmlElementCollection[0].InnerText = "My UFO Page";


            //Select and change innerText of the collection of h2 elements
            htmlElementCollection = wb.Document.GetElementsByTagName("h2");
            htmlElementCollection[0].InnerText = "My UFO Info Page";
            htmlElementCollection[1].InnerText = "My UFO Pictures";
            htmlElementCollection[2].InnerText = " ";

            //Select Body of the html page
            htmlElement = wb.Document.Body;
            //Always choose to add styles, instead of setting them
            htmlElement.Style += "color: #a00000; font-family: sans-serif; ";

            //Change innerHtml and style for the first paragraph in the collection array
            htmlElementCollection = wb.Document.GetElementsByTagName("p");
            htmlElementCollection[0].InnerHtml = "<a href='http://www.nuforc.org'> Report your UFO Sightings here </a> ";
            htmlElementCollection[0].Style += "color:green; font-weight:bold; font-size:2em; text-transform:uppercase; text-shadow:3px 2px #A4";

            htmlElementCollection[1].InnerText = " ";

            //Create a new img element and set its attributes. 
            HtmlElement imgHtmlElement = wb.Document.CreateElement("img");
            imgHtmlElement.SetAttribute("src", "data:image/jpeg;base64,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");
            imgHtmlElement.SetAttribute("title", "Its sooner than you think");

            //Select the last paragraph by ID
            htmlElement = wb.Document.GetElementById("lastParagraph");
            // Insert the following element right after this element begins i.e, in the beginning
            htmlElement.InsertAdjacentElement(HtmlElementInsertionOrientation.AfterBegin, imgHtmlElement);

            HtmlElement footerElement = wb.Document.CreateElement("footerElement");
            footerElement.InnerHtml = " &copy 2022, Tarnav Aryan Bhasin";

            //Select Body of the html page
            htmlElement = wb.Document.Body;
            htmlElement.InsertAdjacentElement(HtmlElementInsertionOrientation.BeforeEnd, footerElement);
        }
    }
}
