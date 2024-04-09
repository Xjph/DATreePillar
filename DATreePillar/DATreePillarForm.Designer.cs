namespace DATreePillar
{
    partial class DATreePillarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DATreePillarForm));
            InputFileLabel = new Label();
            InputFileTextbox = new TextBox();
            InputFileBrowseButton = new Button();
            AddColumnsButton = new Button();
            OutputText = new TextBox();
            ScaleLabel = new Label();
            ScaleSpinner = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)ScaleSpinner).BeginInit();
            SuspendLayout();
            // 
            // InputFileLabel
            // 
            InputFileLabel.AutoSize = true;
            InputFileLabel.Location = new Point(12, 9);
            InputFileLabel.Name = "InputFileLabel";
            InputFileLabel.Size = new Size(59, 15);
            InputFileLabel.TabIndex = 0;
            InputFileLabel.Text = "Input File:";
            InputFileLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // InputFileTextbox
            // 
            InputFileTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            InputFileTextbox.Location = new Point(77, 6);
            InputFileTextbox.Name = "InputFileTextbox";
            InputFileTextbox.Size = new Size(630, 23);
            InputFileTextbox.TabIndex = 1;
            // 
            // InputFileBrowseButton
            // 
            InputFileBrowseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            InputFileBrowseButton.Location = new Point(713, 5);
            InputFileBrowseButton.Name = "InputFileBrowseButton";
            InputFileBrowseButton.Size = new Size(75, 23);
            InputFileBrowseButton.TabIndex = 2;
            InputFileBrowseButton.Text = "Browse";
            InputFileBrowseButton.UseVisualStyleBackColor = true;
            InputFileBrowseButton.Click += InputFileBrowseButton_Click;
            // 
            // AddColumnsButton
            // 
            AddColumnsButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddColumnsButton.Location = new Point(157, 35);
            AddColumnsButton.Name = "AddColumnsButton";
            AddColumnsButton.Size = new Size(631, 23);
            AddColumnsButton.TabIndex = 3;
            AddColumnsButton.Text = "Add Columns To Trees";
            AddColumnsButton.UseVisualStyleBackColor = true;
            AddColumnsButton.Click += AddColumnsButton_Click;
            // 
            // OutputText
            // 
            OutputText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OutputText.Location = new Point(12, 64);
            OutputText.Name = "OutputText";
            OutputText.ReadOnly = true;
            OutputText.ScrollBars = ScrollBars.Vertical;
            OutputText.Size = new Size(776, 23);
            OutputText.TabIndex = 4;
            // 
            // ScaleLabel
            // 
            ScaleLabel.AutoSize = true;
            ScaleLabel.Location = new Point(12, 39);
            ScaleLabel.Name = "ScaleLabel";
            ScaleLabel.Size = new Size(83, 15);
            ScaleLabel.TabIndex = 5;
            ScaleLabel.Text = "Column Scale:";
            ScaleLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // ScaleSpinner
            // 
            ScaleSpinner.DecimalPlaces = 2;
            ScaleSpinner.Location = new Point(101, 35);
            ScaleSpinner.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            ScaleSpinner.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            ScaleSpinner.Name = "ScaleSpinner";
            ScaleSpinner.Size = new Size(50, 23);
            ScaleSpinner.TabIndex = 6;
            ScaleSpinner.Value = new decimal(new int[] { 24, 0, 0, 131072 });
            // 
            // DATreePillarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 100);
            Controls.Add(ScaleSpinner);
            Controls.Add(ScaleLabel);
            Controls.Add(OutputText);
            Controls.Add(AddColumnsButton);
            Controls.Add(InputFileBrowseButton);
            Controls.Add(InputFileTextbox);
            Controls.Add(InputFileLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DATreePillarForm";
            Text = "DA Tree Columnizer";
            ((System.ComponentModel.ISupportInitialize)ScaleSpinner).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label InputFileLabel;
        private TextBox InputFileTextbox;
        private Button InputFileBrowseButton;
        private Button AddColumnsButton;
        private TextBox OutputText;
        private Label ScaleLabel;
        private NumericUpDown ScaleSpinner;
    }
}
