
namespace WorstUI
{
    partial class Form3
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
            this.plusRadioButton = new System.Windows.Forms.RadioButton();
            this.minusRadioButton = new System.Windows.Forms.RadioButton();
            this.multiplyRadioButton = new System.Windows.Forms.RadioButton();
            this.divideRadioButton = new System.Windows.Forms.RadioButton();
            this.calculateButton = new System.Windows.Forms.Button();
            this.answerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Red;
            this.splitContainer1.Panel1.Controls.Add(this.calculateButton);
            this.splitContainer1.Panel1.Controls.Add(this.divideRadioButton);
            this.splitContainer1.Panel1.Controls.Add(this.multiplyRadioButton);
            this.splitContainer1.Panel1.Controls.Add(this.minusRadioButton);
            this.splitContainer1.Panel1.Controls.Add(this.plusRadioButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.splitContainer1.Panel2.Controls.Add(this.answerLabel);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 396;
            this.splitContainer1.TabIndex = 0;
            // 
            // plusRadioButton
            // 
            this.plusRadioButton.AutoSize = true;
            this.plusRadioButton.Checked = true;
            this.plusRadioButton.Font = new System.Drawing.Font("Chiller", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusRadioButton.Location = new System.Drawing.Point(52, 89);
            this.plusRadioButton.Name = "plusRadioButton";
            this.plusRadioButton.Size = new System.Drawing.Size(113, 47);
            this.plusRadioButton.TabIndex = 0;
            this.plusRadioButton.TabStop = true;
            this.plusRadioButton.Text = "Plus +";
            this.plusRadioButton.UseVisualStyleBackColor = true;
            // 
            // minusRadioButton
            // 
            this.minusRadioButton.AutoSize = true;
            this.minusRadioButton.Font = new System.Drawing.Font("MV Boli", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusRadioButton.Location = new System.Drawing.Point(265, 89);
            this.minusRadioButton.Name = "minusRadioButton";
            this.minusRadioButton.Size = new System.Drawing.Size(73, 20);
            this.minusRadioButton.TabIndex = 1;
            this.minusRadioButton.Text = "Minus -";
            this.minusRadioButton.UseVisualStyleBackColor = true;
            // 
            // multiplyRadioButton
            // 
            this.multiplyRadioButton.AutoSize = true;
            this.multiplyRadioButton.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyRadioButton.Location = new System.Drawing.Point(52, 195);
            this.multiplyRadioButton.Name = "multiplyRadioButton";
            this.multiplyRadioButton.Size = new System.Drawing.Size(138, 25);
            this.multiplyRadioButton.TabIndex = 2;
            this.multiplyRadioButton.Text = "Multiply X";
            this.multiplyRadioButton.UseVisualStyleBackColor = true;
            // 
            // divideRadioButton
            // 
            this.divideRadioButton.AutoSize = true;
            this.divideRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideRadioButton.Location = new System.Drawing.Point(265, 195);
            this.divideRadioButton.Name = "divideRadioButton";
            this.divideRadioButton.Size = new System.Drawing.Size(82, 22);
            this.divideRadioButton.TabIndex = 3;
            this.divideRadioButton.Text = "Divide /";
            this.divideRadioButton.UseVisualStyleBackColor = true;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.calculateButton.Location = new System.Drawing.Point(13, 275);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(367, 163);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            // 
            // answerLabel
            // 
            this.answerLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(140)))));
            this.answerLabel.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerLabel.ForeColor = System.Drawing.Color.Yellow;
            this.answerLabel.Location = new System.Drawing.Point(3, 0);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(397, 450);
            this.answerLabel.TabIndex = 0;
            this.answerLabel.Text = "label1";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form3";
            this.Text = "Final Answer";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.RadioButton divideRadioButton;
        private System.Windows.Forms.RadioButton multiplyRadioButton;
        private System.Windows.Forms.RadioButton minusRadioButton;
        private System.Windows.Forms.RadioButton plusRadioButton;
        private System.Windows.Forms.Label answerLabel;
    }
}