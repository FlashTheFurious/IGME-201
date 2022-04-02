using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyEditorPE21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.newToolStripMenuItem.Click += new EventHandler(NewToolStripMenuItem__Click);
            this.openToolStripMenuItem.Click += new EventHandler(OpenToolStripMenuItem__Click);
            this.saveToolStripMenuItem.Click += new EventHandler(SaveToolStripMenuItem__Click);
            this.exitToolStripMenuItem.Click += new EventHandler(ExitToolStripMenuItem__Click);


            this.copyToolStripMenuItem.Click += new EventHandler(CopyToolStripMenuItem__Click);
            this.cutToolStripMenuItem.Click += new EventHandler(CutToolStripMenuItem__Click);
            this.pasteToolStripMenuItem.Click += new EventHandler(PasteToolStripMenuItem__Click);

            this.boldToolStripMenuItem.Click += new EventHandler(BoldToolStripMenuItem__Click);
            this.italicsToolStripMenuItem.Click += new EventHandler(ItalicsToolStripMenuItem__Click);
            this.underlineToolStripMenuItem.Click += new EventHandler(UnderlineToolStripMenuItem__Click);

            this.mSSansSerifToolStripMenuItem.Click += new EventHandler(MSSansSerifToolStripMenuItem__Click);
            this.timesNewRomanToolStripMenuItem.Click += new EventHandler(TimesNewRomanToolStripMenuItem__Click);

            this.toolStrip.ItemClicked += new ToolStripItemClickedEventHandler(ToolStrip__ItemClicked);

            this.richTextBox.SelectionChanged += new EventHandler(RichTextBox__SelectionChanged);

            this.Text = "My Editor";
        }



        private void RichTextBox__SelectionChanged(object sender, EventArgs e)
        {
            //This will set the text icon flag on or off, based on the value of richTextBox.SelectionFont.Bold  , or Italics/Underline
            if (this.richTextBox.SelectionFont != null)
            {
                this.boldToolStripButton.Checked = richTextBox.SelectionFont.Bold;
                this.italicsToolStripButton.Checked = richTextBox.SelectionFont.Italic;
                this.underlineToolStripButton.Checked = richTextBox.SelectionFont.Underline;

                //Adding this code personally to make sure context menu also gets checked and unchecked
                this.boldToolStripMenuItem.Checked = richTextBox.SelectionFont.Bold;
                this.italicsToolStripMenuItem.Checked = richTextBox.SelectionFont.Italic;
                this.underlineToolStripMenuItem.Checked = richTextBox.SelectionFont.Underline;
            }

            this.colorToolStripButton.BackColor = richTextBox.SelectionColor;
        }

        private void MSSansSerifToolStripMenuItem__Click(object sender, EventArgs e)
        {
            Font newFont = new Font("MS Sans Serif", richTextBox.SelectionFont.Size, richTextBox.SelectionFont.Style);

            richTextBox.SelectionFont = newFont;
        }

        private void TimesNewRomanToolStripMenuItem__Click(object sender, EventArgs e)
        {
            Font newFont = new Font("Times New Roman", richTextBox.SelectionFont.Size, richTextBox.SelectionFont.Style);

            richTextBox.SelectionFont = newFont;
        }


        private void BoldToolStripMenuItem__Click(object sender, EventArgs e)
        {
            //We still have to worry about multiple fonts being selected at the same time
            FontStyle fontStyle = FontStyle.Bold;
            Font selectionFont = null;

            //If there are multiple fonts selected, this will return null
            selectionFont = richTextBox.SelectionFont;

            if (selectionFont == null)
            {
                selectionFont = richTextBox.Font;
            }

            //Allows us to toggle bold on and off
            SetSelectionFont(fontStyle, !selectionFont.Bold);
        }
        private void ItalicsToolStripMenuItem__Click(object sender, EventArgs e)
        {
            FontStyle fontStyle = FontStyle.Italic;
            Font selectionFont = null;

            //If there are multiple fonts selected, this will return null
            selectionFont = richTextBox.SelectionFont;

            if (selectionFont == null)
            {
                selectionFont = richTextBox.Font;
            }

            //Allows us to toggle bold on and off
            SetSelectionFont(fontStyle, !selectionFont.Italic);
        }
        private void UnderlineToolStripMenuItem__Click(object sender, EventArgs e)
        {
            FontStyle fontStyle = FontStyle.Underline;
            Font selectionFont = null;

            //If there are multiple fonts selected, this will return null
            selectionFont = richTextBox.SelectionFont;

            if (selectionFont == null)
            {
                selectionFont = richTextBox.Font;
            }

            //Allows us to toggle bold on and off
            SetSelectionFont(fontStyle, !selectionFont.Underline);
        }









        private void NewToolStripMenuItem__Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
            this.Text = "My Editor";
        }

        private void OpenToolStripMenuItem__Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                RichTextBoxStreamType richTextBoxStreamType = RichTextBoxStreamType.RichText;

                if (openFileDialog.FileName.ToLower().Contains(".txt"))
                {
                    richTextBoxStreamType = RichTextBoxStreamType.PlainText;
                }

                richTextBox.LoadFile(openFileDialog.FileName, richTextBoxStreamType);

                this.Text = "MyEditor (" + openFileDialog.FileName + ")";
            }
        }

        private void SaveToolStripMenuItem__Click(object sender, EventArgs e)
        {

            //IF they have a file open already, default to the filename that is already open
            saveFileDialog.FileName = openFileDialog.FileName;


            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                RichTextBoxStreamType richTextBoxStreamType = RichTextBoxStreamType.RichText;

                if (saveFileDialog.FileName.ToLower().Contains(".txt"))
                {
                    richTextBoxStreamType = RichTextBoxStreamType.PlainText;
                }

                richTextBox.SaveFile(saveFileDialog.FileName, richTextBoxStreamType);

                this.Text = "MyEditor (" + saveFileDialog.FileName + ")";
            }
        }

        private void ExitToolStripMenuItem__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CopyToolStripMenuItem__Click(object sender, EventArgs e)
        {
            richTextBox.Copy();
        }
        private void CutToolStripMenuItem__Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }
        private void PasteToolStripMenuItem__Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }

        private void ToolStrip__ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            FontStyle fontStyle = FontStyle.Regular;

            ToolStripButton toolStripButton = null;

            if (e.ClickedItem == this.boldToolStripButton)
            {
                fontStyle = FontStyle.Bold;
                toolStripButton = this.boldToolStripButton;
            }
            else if (e.ClickedItem == this.italicsToolStripButton)
            {
                fontStyle = FontStyle.Italic;
                toolStripButton = this.italicsToolStripButton;

            }
            else if (e.ClickedItem == this.underlineToolStripButton)
            {
                fontStyle = FontStyle.Underline;
                toolStripButton = this.underlineToolStripButton;

            }
            else if (e.ClickedItem == this.colorToolStripButton)
            {

                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox.SelectionColor = colorDialog.Color;
                    colorToolStripButton.BackColor = colorDialog.Color;
                }
            }
            if (fontStyle != FontStyle.Regular)
            {
                //Set checked property to its inverse
                toolStripButton.Checked = !toolStripButton.Checked;

                //Change the selected font for the selected text
                SetSelectionFont(fontStyle, toolStripButton.Checked);
            }

        }
        private void SetSelectionFont(FontStyle fontStyle, bool bSet)
        {
            Font newFont = null;
            Font selectionFont = null;

            selectionFont = richTextBox.SelectionFont;

            //If our selected font contains multiple fonts, selectionFont will be null
            if (selectionFont == null)
            {
                //To prevent errors, default the selection font to the richTextBox font
                selectionFont = richTextBox.Font;
            }

            if (bSet)
            {
                newFont = new Font(selectionFont, selectionFont.Style | fontStyle);
            }
            else
            {

                newFont = new Font(selectionFont, selectionFont.Style & ~fontStyle);
            }

            this.richTextBox.SelectionFont = newFont;
        }






    }
}

