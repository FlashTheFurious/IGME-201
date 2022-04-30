
namespace WinFormsMathQuiz
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.startButton = new System.Windows.Forms.Button();
            this.hardRadioButton = new System.Windows.Forms.RadioButton();
            this.mediumRadioButton = new System.Windows.Forms.RadioButton();
            this.easyRadioButton = new System.Windows.Forms.RadioButton();
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.questionNumTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.correctPanel = new System.Windows.Forms.Panel();
            this.goodPictureBox = new System.Windows.Forms.PictureBox();
            this.congratsLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.questionLabel = new System.Windows.Forms.Label();
            this.wrongPanel = new System.Windows.Forms.Panel();
            this.wrongPictureBox = new System.Windows.Forms.PictureBox();
            this.sorryLabel = new System.Windows.Forms.Label();
            this.countdownLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.secondsTextBox = new System.Windows.Forms.TextBox();
            this.gameOverPanel = new System.Windows.Forms.Panel();
            this.gameOver2Label = new System.Windows.Forms.Label();
            this.gameOver1Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.correctPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goodPictureBox)).BeginInit();
            this.wrongPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wrongPictureBox)).BeginInit();
            this.gameOverPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(-3, 342);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(801, 23);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Value = 100;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.secondsTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.startButton);
            this.splitContainer1.Panel1.Controls.Add(this.hardRadioButton);
            this.splitContainer1.Panel1.Controls.Add(this.mediumRadioButton);
            this.splitContainer1.Panel1.Controls.Add(this.easyRadioButton);
            this.splitContainer1.Panel1.Controls.Add(this.difficultyLabel);
            this.splitContainer1.Panel1.Controls.Add(this.questionNumTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.nameTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.nameLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.wrongPanel);
            this.splitContainer1.Panel2.Controls.Add(this.correctPanel);
            this.splitContainer1.Panel2.Controls.Add(this.submitButton);
            this.splitContainer1.Panel2.Controls.Add(this.answerTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.questionLabel);
            this.splitContainer1.Size = new System.Drawing.Size(801, 334);
            this.splitContainer1.SplitterDistance = 249;
            this.splitContainer1.TabIndex = 1;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(55, 258);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(150, 32);
            this.startButton.TabIndex = 18;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // hardRadioButton
            // 
            this.hardRadioButton.AutoSize = true;
            this.hardRadioButton.Location = new System.Drawing.Point(131, 173);
            this.hardRadioButton.Name = "hardRadioButton";
            this.hardRadioButton.Size = new System.Drawing.Size(48, 17);
            this.hardRadioButton.TabIndex = 17;
            this.hardRadioButton.TabStop = true;
            this.hardRadioButton.Text = "Hard";
            this.hardRadioButton.UseVisualStyleBackColor = true;
            // 
            // mediumRadioButton
            // 
            this.mediumRadioButton.AutoSize = true;
            this.mediumRadioButton.Location = new System.Drawing.Point(131, 150);
            this.mediumRadioButton.Name = "mediumRadioButton";
            this.mediumRadioButton.Size = new System.Drawing.Size(62, 17);
            this.mediumRadioButton.TabIndex = 16;
            this.mediumRadioButton.TabStop = true;
            this.mediumRadioButton.Text = "Medium";
            this.mediumRadioButton.UseVisualStyleBackColor = true;
            // 
            // easyRadioButton
            // 
            this.easyRadioButton.AutoSize = true;
            this.easyRadioButton.Location = new System.Drawing.Point(131, 127);
            this.easyRadioButton.Name = "easyRadioButton";
            this.easyRadioButton.Size = new System.Drawing.Size(48, 17);
            this.easyRadioButton.TabIndex = 15;
            this.easyRadioButton.TabStop = true;
            this.easyRadioButton.Text = "Easy";
            this.easyRadioButton.UseVisualStyleBackColor = true;
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.AutoSize = true;
            this.difficultyLabel.Location = new System.Drawing.Point(15, 126);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(110, 13);
            this.difficultyLabel.TabIndex = 14;
            this.difficultyLabel.Text = "What Difficulty level ?";
            // 
            // questionNumTextBox
            // 
            this.questionNumTextBox.Location = new System.Drawing.Point(131, 82);
            this.questionNumTextBox.Name = "questionNumTextBox";
            this.questionNumTextBox.Size = new System.Drawing.Size(100, 20);
            this.questionNumTextBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "How many Questions? ";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(131, 44);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 11;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(84, 44);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(41, 13);
            this.nameLabel.TabIndex = 10;
            this.nameLabel.Text = "Name: ";
            // 
            // correctPanel
            // 
            this.correctPanel.BackColor = System.Drawing.Color.Lime;
            this.correctPanel.Controls.Add(this.goodPictureBox);
            this.correctPanel.Controls.Add(this.congratsLabel);
            this.correctPanel.Location = new System.Drawing.Point(3, 0);
            this.correctPanel.Name = "correctPanel";
            this.correctPanel.Size = new System.Drawing.Size(545, 250);
            this.correctPanel.TabIndex = 3;
            this.correctPanel.Visible = false;
            // 
            // goodPictureBox
            // 
            this.goodPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("goodPictureBox.Image")));
            this.goodPictureBox.Location = new System.Drawing.Point(-19, -50);
            this.goodPictureBox.Name = "goodPictureBox";
            this.goodPictureBox.Size = new System.Drawing.Size(596, 171);
            this.goodPictureBox.TabIndex = 1;
            this.goodPictureBox.TabStop = false;
            // 
            // congratsLabel
            // 
            this.congratsLabel.AutoSize = true;
            this.congratsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.congratsLabel.Location = new System.Drawing.Point(68, 155);
            this.congratsLabel.Name = "congratsLabel";
            this.congratsLabel.Size = new System.Drawing.Size(387, 55);
            this.congratsLabel.TabIndex = 0;
            this.congratsLabel.Text = "Congratulations !";
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.submitButton.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(3, 293);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(542, 41);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Visible = false;
            // 
            // answerTextBox
            // 
            this.answerTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.answerTextBox.Location = new System.Drawing.Point(3, 150);
            this.answerTextBox.Multiline = true;
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(542, 137);
            this.answerTextBox.TabIndex = 1;
            // 
            // questionLabel
            // 
            this.questionLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.questionLabel.Font = new System.Drawing.Font("Roboto", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(3, 0);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(542, 121);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "4 + 4";
            // 
            // wrongPanel
            // 
            this.wrongPanel.BackColor = System.Drawing.Color.Red;
            this.wrongPanel.Controls.Add(this.gameOverPanel);
            this.wrongPanel.Controls.Add(this.wrongPictureBox);
            this.wrongPanel.Controls.Add(this.sorryLabel);
            this.wrongPanel.Location = new System.Drawing.Point(0, 0);
            this.wrongPanel.Name = "wrongPanel";
            this.wrongPanel.Size = new System.Drawing.Size(545, 287);
            this.wrongPanel.TabIndex = 4;
            this.wrongPanel.Visible = false;
            // 
            // wrongPictureBox
            // 
            this.wrongPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("wrongPictureBox.Image")));
            this.wrongPictureBox.Location = new System.Drawing.Point(136, 0);
            this.wrongPictureBox.Name = "wrongPictureBox";
            this.wrongPictureBox.Size = new System.Drawing.Size(261, 190);
            this.wrongPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wrongPictureBox.TabIndex = 1;
            this.wrongPictureBox.TabStop = false;
            // 
            // sorryLabel
            // 
            this.sorryLabel.BackColor = System.Drawing.Color.Red;
            this.sorryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sorryLabel.Location = new System.Drawing.Point(3, 196);
            this.sorryLabel.Name = "sorryLabel";
            this.sorryLabel.Size = new System.Drawing.Size(542, 94);
            this.sorryLabel.TabIndex = 0;
            this.sorryLabel.Text = "Wrong Answer";
            this.sorryLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sorryLabel.Visible = false;
            // 
            // countdownLabel
            // 
            this.countdownLabel.AutoSize = true;
            this.countdownLabel.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownLabel.Location = new System.Drawing.Point(365, 347);
            this.countdownLabel.Name = "countdownLabel";
            this.countdownLabel.Size = new System.Drawing.Size(10, 15);
            this.countdownLabel.TabIndex = 2;
            this.countdownLabel.Text = " ";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 40);
            this.label1.TabIndex = 19;
            this.label1.Text = "How many seconds should the Timer be for the entire quiz?";
            // 
            // secondsTextBox
            // 
            this.secondsTextBox.Location = new System.Drawing.Point(196, 210);
            this.secondsTextBox.Name = "secondsTextBox";
            this.secondsTextBox.Size = new System.Drawing.Size(35, 20);
            this.secondsTextBox.TabIndex = 20;
            // 
            // gameOverPanel
            // 
            this.gameOverPanel.BackColor = System.Drawing.Color.Silver;
            this.gameOverPanel.Controls.Add(this.gameOver2Label);
            this.gameOverPanel.Controls.Add(this.gameOver1Label);
            this.gameOverPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameOverPanel.Location = new System.Drawing.Point(0, 0);
            this.gameOverPanel.Name = "gameOverPanel";
            this.gameOverPanel.Size = new System.Drawing.Size(545, 287);
            this.gameOverPanel.TabIndex = 3;
            this.gameOverPanel.Visible = false;
            // 
            // gameOver2Label
            // 
            this.gameOver2Label.AutoSize = true;
            this.gameOver2Label.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOver2Label.ForeColor = System.Drawing.Color.Red;
            this.gameOver2Label.Location = new System.Drawing.Point(30, 104);
            this.gameOver2Label.Name = "gameOver2Label";
            this.gameOver2Label.Size = new System.Drawing.Size(480, 35);
            this.gameOver2Label.TabIndex = 1;
            this.gameOver2Label.Text = "You got 3 out of 5 questions correct!";
            // 
            // gameOver1Label
            // 
            this.gameOver1Label.AutoSize = true;
            this.gameOver1Label.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOver1Label.ForeColor = System.Drawing.Color.Lime;
            this.gameOver1Label.Location = new System.Drawing.Point(30, 27);
            this.gameOver1Label.Name = "gameOver1Label";
            this.gameOver1Label.Size = new System.Drawing.Size(480, 35);
            this.gameOver1Label.TabIndex = 0;
            this.gameOver1Label.Text = "You got 3 out of 5 questions correct!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 366);
            this.Controls.Add(this.countdownLabel);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "Math Quiz";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.correctPanel.ResumeLayout(false);
            this.correctPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goodPictureBox)).EndInit();
            this.wrongPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wrongPictureBox)).EndInit();
            this.gameOverPanel.ResumeLayout(false);
            this.gameOverPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.RadioButton hardRadioButton;
        private System.Windows.Forms.RadioButton mediumRadioButton;
        private System.Windows.Forms.RadioButton easyRadioButton;
        private System.Windows.Forms.Label difficultyLabel;
        private System.Windows.Forms.TextBox questionNumTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Panel correctPanel;
        private System.Windows.Forms.PictureBox goodPictureBox;
        private System.Windows.Forms.Label congratsLabel;
        private System.Windows.Forms.Panel wrongPanel;
        private System.Windows.Forms.PictureBox wrongPictureBox;
        private System.Windows.Forms.Label sorryLabel;
        private System.Windows.Forms.Label countdownLabel;
        public System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox secondsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel gameOverPanel;
        private System.Windows.Forms.Label gameOver2Label;
        private System.Windows.Forms.Label gameOver1Label;
    }
}

