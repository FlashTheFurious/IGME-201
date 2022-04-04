
namespace MDIGIFFinder
{
    partial class SearchForm
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
            this.searchTermTextBox = new System.Windows.Forms.TextBox();
            this.maxItemsTextBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.maxItemLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchTermTextBox
            // 
            this.searchTermTextBox.Location = new System.Drawing.Point(95, 25);
            this.searchTermTextBox.Name = "searchTermTextBox";
            this.searchTermTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchTermTextBox.TabIndex = 0;
            // 
            // maxItemsTextBox
            // 
            this.maxItemsTextBox.Location = new System.Drawing.Point(95, 67);
            this.maxItemsTextBox.Name = "maxItemsTextBox";
            this.maxItemsTextBox.Size = new System.Drawing.Size(100, 20);
            this.maxItemsTextBox.TabIndex = 1;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(18, 28);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(71, 13);
            this.searchLabel.TabIndex = 2;
            this.searchLabel.Text = "Search Term:";
            // 
            // maxItemLabel
            // 
            this.maxItemLabel.AutoSize = true;
            this.maxItemLabel.Location = new System.Drawing.Point(28, 70);
            this.maxItemLabel.Name = "maxItemLabel";
            this.maxItemLabel.Size = new System.Drawing.Size(61, 13);
            this.maxItemLabel.TabIndex = 3;
            this.maxItemLabel.Text = "Max Items: ";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(31, 110);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(120, 110);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // SearchForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(244, 164);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.maxItemLabel);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.maxItemsTextBox);
            this.Controls.Add(this.searchTermTextBox);
            this.Name = "SearchForm";
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTermTextBox;
        private System.Windows.Forms.TextBox maxItemsTextBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label maxItemLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}