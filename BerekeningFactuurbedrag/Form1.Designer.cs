namespace BerekeningFactuurbedrag
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            InkoopprijsLabel = new Label();
            WinstmargeLabel = new Label();
            TotaalLabel = new Label();
            InkoopprijsTextBox = new TextBox();
            WinstmargeTextBox = new TextBox();
            BerekenButton = new Button();
            ResultaatTextBox = new TextBox();
            SuspendLayout();
            // 
            // InkoopprijsLabel
            // 
            InkoopprijsLabel.AutoSize = true;
            InkoopprijsLabel.Location = new Point(12, 9);
            InkoopprijsLabel.Name = "InkoopprijsLabel";
            InkoopprijsLabel.Size = new Size(66, 15);
            InkoopprijsLabel.TabIndex = 0;
            InkoopprijsLabel.Text = "Inkoopprijs";
            // 
            // WinstmargeLabel
            // 
            WinstmargeLabel.AutoSize = true;
            WinstmargeLabel.Location = new Point(12, 38);
            WinstmargeLabel.Name = "WinstmargeLabel";
            WinstmargeLabel.Size = new Size(71, 15);
            WinstmargeLabel.TabIndex = 1;
            WinstmargeLabel.Text = "Winstmarge";
            // 
            // TotaalLabel
            // 
            TotaalLabel.AutoSize = true;
            TotaalLabel.Location = new Point(12, 67);
            TotaalLabel.Name = "TotaalLabel";
            TotaalLabel.Size = new Size(39, 15);
            TotaalLabel.TabIndex = 2;
            TotaalLabel.Text = "Totaal";
            // 
            // InkoopprijsTextBox
            // 
            InkoopprijsTextBox.Location = new Point(89, 5);
            InkoopprijsTextBox.Name = "InkoopprijsTextBox";
            InkoopprijsTextBox.Size = new Size(100, 23);
            InkoopprijsTextBox.TabIndex = 3;
            // 
            // WinstmargeTextBox
            // 
            WinstmargeTextBox.Location = new Point(89, 34);
            WinstmargeTextBox.Name = "WinstmargeTextBox";
            WinstmargeTextBox.Size = new Size(100, 23);
            WinstmargeTextBox.TabIndex = 4;
            // 
            // BerekenButton
            // 
            BerekenButton.Location = new Point(195, 5);
            BerekenButton.Name = "BerekenButton";
            BerekenButton.Size = new Size(75, 82);
            BerekenButton.TabIndex = 6;
            BerekenButton.Text = "Bereken";
            BerekenButton.UseVisualStyleBackColor = true;
            BerekenButton.Click += BerekenButton_Click;
            // 
            // ResultaatTextBox
            // 
            ResultaatTextBox.Location = new Point(89, 63);
            ResultaatTextBox.Name = "ResultaatTextBox";
            ResultaatTextBox.Size = new Size(100, 23);
            ResultaatTextBox.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 98);
            Controls.Add(ResultaatTextBox);
            Controls.Add(BerekenButton);
            Controls.Add(WinstmargeTextBox);
            Controls.Add(InkoopprijsTextBox);
            Controls.Add(TotaalLabel);
            Controls.Add(WinstmargeLabel);
            Controls.Add(InkoopprijsLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label InkoopprijsLabel;
        private Label WinstmargeLabel;
        private Label TotaalLabel;
        private TextBox InkoopprijsTextBox;
        private TextBox WinstmargeTextBox;
        private Button BerekenButton;
        private TextBox ResultaatTextBox;
    }
}
