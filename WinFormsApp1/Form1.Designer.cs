namespace WinFormsApp1
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
            bgnValue = new NumericUpDown();
            button1 = new Button();
            label1 = new Label();
            ResultLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)bgnValue).BeginInit();
            SuspendLayout();
            // 
            // bgnValue
            // 
            bgnValue.DecimalPlaces = 2;
            bgnValue.Location = new Point(54, 47);
            bgnValue.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            bgnValue.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            bgnValue.Name = "bgnValue";
            bgnValue.Size = new Size(120, 23);
            bgnValue.TabIndex = 0;
            bgnValue.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // button1
            // 
            button1.Location = new Point(180, 47);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Convert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(277, 49);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 2;
            label1.Text = "BGN To EUR";
            // 
            // ResultLabel
            // 
            ResultLabel.BackColor = Color.PaleGreen;
            ResultLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            ResultLabel.Location = new Point(54, 91);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(293, 29);
            ResultLabel.TabIndex = 3;
            ResultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ResultLabel);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(bgnValue);
            Name = "Form1";
            Text = "CurrencyConverterByAlex";
            ((System.ComponentModel.ISupportInitialize)bgnValue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown bgnValue;
        private Button button1;
        private Label label1;
        private Label ResultLabel;
    }
}
