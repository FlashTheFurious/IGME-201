
namespace WorstUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textPanel = new System.Windows.Forms.Panel();
            this.form1NumberLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.clearCheckBox2 = new System.Windows.Forms.CheckBox();
            this.clearCheckBox1 = new System.Windows.Forms.CheckBox();
            this.number0button = new System.Windows.Forms.Button();
            this.number3button = new System.Windows.Forms.Button();
            this.number2button = new System.Windows.Forms.Button();
            this.number6button = new System.Windows.Forms.Button();
            this.number4button = new System.Windows.Forms.Button();
            this.number5button = new System.Windows.Forms.Button();
            this.number7button = new System.Windows.Forms.Button();
            this.number9button = new System.Windows.Forms.Button();
            this.number8button = new System.Windows.Forms.Button();
            this.number1button = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.textPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.clearButton);
            this.splitContainer1.Panel2.Controls.Add(this.clearCheckBox2);
            this.splitContainer1.Panel2.Controls.Add(this.clearCheckBox1);
            this.splitContainer1.Panel2.Controls.Add(this.number0button);
            this.splitContainer1.Panel2.Controls.Add(this.number3button);
            this.splitContainer1.Panel2.Controls.Add(this.number2button);
            this.splitContainer1.Panel2.Controls.Add(this.number6button);
            this.splitContainer1.Panel2.Controls.Add(this.number4button);
            this.splitContainer1.Panel2.Controls.Add(this.number5button);
            this.splitContainer1.Panel2.Controls.Add(this.number7button);
            this.splitContainer1.Panel2.Controls.Add(this.number9button);
            this.splitContainer1.Panel2.Controls.Add(this.number8button);
            this.splitContainer1.Panel2.Controls.Add(this.number1button);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 147;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 147);
            this.panel1.TabIndex = 0;
            // 
            // textPanel
            // 
            this.textPanel.Controls.Add(this.label1);
            this.textPanel.Controls.Add(this.progressBar1);
            this.textPanel.Controls.Add(this.form1NumberLabel);
            this.textPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textPanel.Location = new System.Drawing.Point(0, 0);
            this.textPanel.Name = "textPanel";
            this.textPanel.Size = new System.Drawing.Size(800, 147);
            this.textPanel.TabIndex = 0;
            // 
            // form1NumberLabel
            // 
            this.form1NumberLabel.Location = new System.Drawing.Point(3, 46);
            this.form1NumberLabel.Name = "form1NumberLabel";
            this.form1NumberLabel.Size = new System.Drawing.Size(794, 101);
            this.form1NumberLabel.TabIndex = 0;
            this.form1NumberLabel.Text = "label1";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(173, 208);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(437, 88);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "Clear (currently not visible)";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Visible = false;
            // 
            // clearCheckBox2
            // 
            this.clearCheckBox2.AutoSize = true;
            this.clearCheckBox2.Font = new System.Drawing.Font("NSimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearCheckBox2.Location = new System.Drawing.Point(12, 250);
            this.clearCheckBox2.Name = "clearCheckBox2";
            this.clearCheckBox2.Size = new System.Drawing.Size(156, 16);
            this.clearCheckBox2.TabIndex = 11;
            this.clearCheckBox2.Text = "Check 2 boxes to clear";
            this.clearCheckBox2.UseVisualStyleBackColor = true;
            // 
            // clearCheckBox1
            // 
            this.clearCheckBox1.AutoSize = true;
            this.clearCheckBox1.Font = new System.Drawing.Font("SS Nickson One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearCheckBox1.Location = new System.Drawing.Point(652, 208);
            this.clearCheckBox1.Name = "clearCheckBox1";
            this.clearCheckBox1.Size = new System.Drawing.Size(136, 19);
            this.clearCheckBox1.TabIndex = 10;
            this.clearCheckBox1.Text = "Check 2 boxes to clear";
            this.clearCheckBox1.UseVisualStyleBackColor = true;
            // 
            // number0button
            // 
            this.number0button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.number0button.Location = new System.Drawing.Point(617, 51);
            this.number0button.Name = "number0button";
            this.number0button.Size = new System.Drawing.Size(180, 142);
            this.number0button.TabIndex = 9;
            this.number0button.Text = "0";
            this.number0button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.number0button.UseVisualStyleBackColor = false;
            // 
            // number3button
            // 
            this.number3button.BackColor = System.Drawing.SystemColors.Highlight;
            this.number3button.Location = new System.Drawing.Point(321, 154);
            this.number3button.Name = "number3button";
            this.number3button.Size = new System.Drawing.Size(289, 39);
            this.number3button.TabIndex = 8;
            this.number3button.Text = "3";
            this.number3button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.number3button.UseVisualStyleBackColor = false;
            // 
            // number2button
            // 
            this.number2button.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.number2button.Location = new System.Drawing.Point(321, 103);
            this.number2button.Name = "number2button";
            this.number2button.Size = new System.Drawing.Size(289, 44);
            this.number2button.TabIndex = 7;
            this.number2button.Text = "2";
            this.number2button.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.number2button.UseVisualStyleBackColor = false;
            // 
            // number6button
            // 
            this.number6button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.number6button.Location = new System.Drawing.Point(139, 103);
            this.number6button.Name = "number6button";
            this.number6button.Size = new System.Drawing.Size(175, 90);
            this.number6button.TabIndex = 6;
            this.number6button.Text = "6";
            this.number6button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.number6button.UseVisualStyleBackColor = false;
            // 
            // number4button
            // 
            this.number4button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.number4button.Location = new System.Drawing.Point(0, 62);
            this.number4button.Name = "number4button";
            this.number4button.Size = new System.Drawing.Size(132, 131);
            this.number4button.TabIndex = 5;
            this.number4button.Text = "4";
            this.number4button.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.number4button.UseVisualStyleBackColor = false;
            // 
            // number5button
            // 
            this.number5button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.number5button.Location = new System.Drawing.Point(607, 4);
            this.number5button.Name = "number5button";
            this.number5button.Size = new System.Drawing.Size(190, 40);
            this.number5button.TabIndex = 4;
            this.number5button.Text = "5";
            this.number5button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.number5button.UseVisualStyleBackColor = false;
            // 
            // number7button
            // 
            this.number7button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.number7button.Location = new System.Drawing.Point(356, 4);
            this.number7button.Name = "number7button";
            this.number7button.Size = new System.Drawing.Size(254, 100);
            this.number7button.TabIndex = 3;
            this.number7button.Text = "7";
            this.number7button.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.number7button.UseVisualStyleBackColor = false;
            // 
            // number9button
            // 
            this.number9button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.number9button.Location = new System.Drawing.Point(268, 3);
            this.number9button.Name = "number9button";
            this.number9button.Size = new System.Drawing.Size(66, 41);
            this.number9button.TabIndex = 2;
            this.number9button.Text = "9";
            this.number9button.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.number9button.UseVisualStyleBackColor = false;
            // 
            // number8button
            // 
            this.number8button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.number8button.Location = new System.Drawing.Point(173, 3);
            this.number8button.Name = "number8button";
            this.number8button.Size = new System.Drawing.Size(98, 101);
            this.number8button.TabIndex = 1;
            this.number8button.Text = "8";
            this.number8button.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.number8button.UseVisualStyleBackColor = false;
            // 
            // number1button
            // 
            this.number1button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.number1button.Location = new System.Drawing.Point(0, 3);
            this.number1button.Name = "number1button";
            this.number1button.Size = new System.Drawing.Size(132, 53);
            this.number1button.TabIndex = 0;
            this.number1button.Text = "1";
            this.number1button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.number1button.UseVisualStyleBackColor = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(3, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(794, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Clear Progress";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "First Number";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.textPanel.ResumeLayout(false);
            this.textPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.CheckBox clearCheckBox2;
        private System.Windows.Forms.CheckBox clearCheckBox1;
        private System.Windows.Forms.Button number0button;
        private System.Windows.Forms.Button number3button;
        private System.Windows.Forms.Button number2button;
        private System.Windows.Forms.Button number6button;
        private System.Windows.Forms.Button number4button;
        private System.Windows.Forms.Button number5button;
        private System.Windows.Forms.Button number7button;
        private System.Windows.Forms.Button number9button;
        private System.Windows.Forms.Button number8button;
        private System.Windows.Forms.Button number1button;
        private System.Windows.Forms.Panel textPanel;
        public System.Windows.Forms.Label form1NumberLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

