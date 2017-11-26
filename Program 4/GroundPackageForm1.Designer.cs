namespace Program_4
{
    partial class Prog4
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
            this.groundPackageListBox = new System.Windows.Forms.ListBox();
            this.addPackageButton = new System.Windows.Forms.Button();
            this.sendToButton = new System.Windows.Forms.Button();
            this.sendFromButton = new System.Windows.Forms.Button();
            this.originZipTxtBox = new System.Windows.Forms.TextBox();
            this.destinationZipTxtBox = new System.Windows.Forms.TextBox();
            this.weightTxtBox = new System.Windows.Forms.TextBox();
            this.lengthTxtBox = new System.Windows.Forms.TextBox();
            this.widthTxtBox = new System.Windows.Forms.TextBox();
            this.heightTxtBox = new System.Windows.Forms.TextBox();
            this.originZipLabel = new System.Windows.Forms.Label();
            this.destinationZipLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.detailsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groundPackageListBox
            // 
            this.groundPackageListBox.FormattingEnabled = true;
            this.groundPackageListBox.Location = new System.Drawing.Point(254, 12);
            this.groundPackageListBox.Name = "groundPackageListBox";
            this.groundPackageListBox.Size = new System.Drawing.Size(139, 160);
            this.groundPackageListBox.TabIndex = 8;
            // 
            // addPackageButton
            // 
            this.addPackageButton.Location = new System.Drawing.Point(12, 190);
            this.addPackageButton.Name = "addPackageButton";
            this.addPackageButton.Size = new System.Drawing.Size(90, 23);
            this.addPackageButton.TabIndex = 7;
            this.addPackageButton.Text = "Add Package";
            this.addPackageButton.UseVisualStyleBackColor = true;
            this.addPackageButton.Click += new System.EventHandler(this.addPackageButton_Click);
            // 
            // sendToButton
            // 
            this.sendToButton.Location = new System.Drawing.Point(399, 71);
            this.sendToButton.Name = "sendToButton";
            this.sendToButton.Size = new System.Drawing.Size(92, 23);
            this.sendToButton.TabIndex = 10;
            this.sendToButton.Text = "Send to UofL";
            this.sendToButton.UseVisualStyleBackColor = true;
            this.sendToButton.Click += new System.EventHandler(this.sendToButton_Click);
            // 
            // sendFromButton
            // 
            this.sendFromButton.Location = new System.Drawing.Point(399, 103);
            this.sendFromButton.Name = "sendFromButton";
            this.sendFromButton.Size = new System.Drawing.Size(92, 23);
            this.sendFromButton.TabIndex = 11;
            this.sendFromButton.Text = "Send From UofL";
            this.sendFromButton.UseVisualStyleBackColor = true;
            this.sendFromButton.Click += new System.EventHandler(this.sendFromButton_Click);
            // 
            // originZipTxtBox
            // 
            this.originZipTxtBox.Location = new System.Drawing.Point(125, 22);
            this.originZipTxtBox.Name = "originZipTxtBox";
            this.originZipTxtBox.Size = new System.Drawing.Size(100, 20);
            this.originZipTxtBox.TabIndex = 1;
            // 
            // destinationZipTxtBox
            // 
            this.destinationZipTxtBox.Location = new System.Drawing.Point(125, 48);
            this.destinationZipTxtBox.Name = "destinationZipTxtBox";
            this.destinationZipTxtBox.Size = new System.Drawing.Size(100, 20);
            this.destinationZipTxtBox.TabIndex = 2;
            // 
            // weightTxtBox
            // 
            this.weightTxtBox.Location = new System.Drawing.Point(125, 152);
            this.weightTxtBox.Name = "weightTxtBox";
            this.weightTxtBox.Size = new System.Drawing.Size(100, 20);
            this.weightTxtBox.TabIndex = 6;
            // 
            // lengthTxtBox
            // 
            this.lengthTxtBox.Location = new System.Drawing.Point(125, 74);
            this.lengthTxtBox.Name = "lengthTxtBox";
            this.lengthTxtBox.Size = new System.Drawing.Size(100, 20);
            this.lengthTxtBox.TabIndex = 3;
            // 
            // widthTxtBox
            // 
            this.widthTxtBox.Location = new System.Drawing.Point(125, 100);
            this.widthTxtBox.Name = "widthTxtBox";
            this.widthTxtBox.Size = new System.Drawing.Size(100, 20);
            this.widthTxtBox.TabIndex = 4;
            // 
            // heightTxtBox
            // 
            this.heightTxtBox.Location = new System.Drawing.Point(125, 126);
            this.heightTxtBox.Name = "heightTxtBox";
            this.heightTxtBox.Size = new System.Drawing.Size(100, 20);
            this.heightTxtBox.TabIndex = 5;
            // 
            // originZipLabel
            // 
            this.originZipLabel.AutoSize = true;
            this.originZipLabel.Location = new System.Drawing.Point(9, 25);
            this.originZipLabel.Name = "originZipLabel";
            this.originZipLabel.Size = new System.Drawing.Size(80, 13);
            this.originZipLabel.TabIndex = 10;
            this.originZipLabel.Text = "Origin Zip Code";
            // 
            // destinationZipLabel
            // 
            this.destinationZipLabel.AutoSize = true;
            this.destinationZipLabel.Location = new System.Drawing.Point(9, 50);
            this.destinationZipLabel.Name = "destinationZipLabel";
            this.destinationZipLabel.Size = new System.Drawing.Size(106, 13);
            this.destinationZipLabel.TabIndex = 11;
            this.destinationZipLabel.Text = "Destination Zip Code";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(9, 77);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(80, 13);
            this.lengthLabel.TabIndex = 12;
            this.lengthLabel.Text = "Length (inches)";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(9, 103);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(75, 13);
            this.widthLabel.TabIndex = 13;
            this.widthLabel.Text = "Width (inches)";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(9, 129);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(78, 13);
            this.heightLabel.TabIndex = 14;
            this.heightLabel.Text = "Height (inches)";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(9, 155);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(85, 13);
            this.weightLabel.TabIndex = 15;
            this.weightLabel.Text = "Weight (pounds)";
            // 
            // detailsButton
            // 
            this.detailsButton.Location = new System.Drawing.Point(399, 40);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(92, 23);
            this.detailsButton.TabIndex = 9;
            this.detailsButton.Text = "Details";
            this.detailsButton.UseVisualStyleBackColor = true;
            this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
            // 
            // Prog4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 223);
            this.Controls.Add(this.detailsButton);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.destinationZipLabel);
            this.Controls.Add(this.originZipLabel);
            this.Controls.Add(this.heightTxtBox);
            this.Controls.Add(this.widthTxtBox);
            this.Controls.Add(this.lengthTxtBox);
            this.Controls.Add(this.weightTxtBox);
            this.Controls.Add(this.destinationZipTxtBox);
            this.Controls.Add(this.originZipTxtBox);
            this.Controls.Add(this.sendFromButton);
            this.Controls.Add(this.sendToButton);
            this.Controls.Add(this.addPackageButton);
            this.Controls.Add(this.groundPackageListBox);
            this.Name = "Prog4";
            this.Text = "Program 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox groundPackageListBox;
        private System.Windows.Forms.Button addPackageButton;
        private System.Windows.Forms.Button sendToButton;
        private System.Windows.Forms.Button sendFromButton;
        private System.Windows.Forms.TextBox originZipTxtBox;
        private System.Windows.Forms.TextBox destinationZipTxtBox;
        private System.Windows.Forms.TextBox weightTxtBox;
        private System.Windows.Forms.TextBox lengthTxtBox;
        private System.Windows.Forms.TextBox widthTxtBox;
        private System.Windows.Forms.TextBox heightTxtBox;
        private System.Windows.Forms.Label originZipLabel;
        private System.Windows.Forms.Label destinationZipLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Button detailsButton;
    }
}

