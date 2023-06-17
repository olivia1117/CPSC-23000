namespace SmallProgramsShowcase
{
    partial class Form2
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
            richTextBox1 = new RichTextBox();
            tbxWeight = new TextBox();
            tbxHeight = new TextBox();
            lblBMI = new Label();
            tbxBMI = new TextBox();
            lblStatus = new Label();
            tbxStatus = new TextBox();
            btnCalculateBMI = new Button();
            btnCloseBMI = new Button();
            lblWeight = new Label();
            lblHeight = new Label();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.AliceBlue;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Margin = new Padding(1);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(326, 53);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "Enter your weight in pounds and height in inches below. Then click Calculate.\n";
            // 
            // tbxWeight
            // 
            tbxWeight.Location = new Point(117, 74);
            tbxWeight.Margin = new Padding(1);
            tbxWeight.Name = "tbxWeight";
            tbxWeight.Size = new Size(62, 23);
            tbxWeight.TabIndex = 2;
            // 
            // tbxHeight
            // 
            tbxHeight.Location = new Point(115, 118);
            tbxHeight.Margin = new Padding(1);
            tbxHeight.Name = "tbxHeight";
            tbxHeight.Size = new Size(63, 23);
            tbxHeight.TabIndex = 4;
            // 
            // lblBMI
            // 
            lblBMI.AutoSize = true;
            lblBMI.Location = new Point(30, 168);
            lblBMI.Margin = new Padding(1, 0, 1, 0);
            lblBMI.Name = "lblBMI";
            lblBMI.Size = new Size(78, 15);
            lblBMI.TabIndex = 5;
            lblBMI.Text = "Your BMI is ...";
            // 
            // tbxBMI
            // 
            tbxBMI.AllowDrop = true;
            tbxBMI.Location = new Point(133, 168);
            tbxBMI.Margin = new Padding(1);
            tbxBMI.Name = "tbxBMI";
            tbxBMI.Size = new Size(106, 23);
            tbxBMI.TabIndex = 6;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(30, 207);
            lblStatus.Margin = new Padding(1, 0, 1, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(88, 15);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Your status is ...";
            // 
            // tbxStatus
            // 
            tbxStatus.Location = new Point(138, 207);
            tbxStatus.Margin = new Padding(1);
            tbxStatus.Name = "tbxStatus";
            tbxStatus.Size = new Size(101, 23);
            tbxStatus.TabIndex = 8;
            // 
            // btnCalculateBMI
            // 
            btnCalculateBMI.Location = new Point(231, 97);
            btnCalculateBMI.Margin = new Padding(1);
            btnCalculateBMI.Name = "btnCalculateBMI";
            btnCalculateBMI.Size = new Size(82, 25);
            btnCalculateBMI.TabIndex = 9;
            btnCalculateBMI.Text = "Calculate";
            btnCalculateBMI.UseVisualStyleBackColor = true;
            btnCalculateBMI.Click += btnCalculateBMI_Click;
            // 
            // btnCloseBMI
            // 
            btnCloseBMI.Location = new Point(117, 258);
            btnCloseBMI.Margin = new Padding(1);
            btnCloseBMI.Name = "btnCloseBMI";
            btnCloseBMI.Size = new Size(90, 23);
            btnCloseBMI.TabIndex = 10;
            btnCloseBMI.Text = "Close";
            btnCloseBMI.UseVisualStyleBackColor = true;
            btnCloseBMI.Click += btnCloseBMI_Click;
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Location = new Point(30, 74);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(66, 15);
            lblWeight.TabIndex = 11;
            lblWeight.Text = "Weight (lb)";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(30, 118);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(64, 15);
            lblHeight.TabIndex = 12;
            lblHeight.Text = "Height (in)";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(331, 302);
            Controls.Add(lblHeight);
            Controls.Add(lblWeight);
            Controls.Add(btnCloseBMI);
            Controls.Add(btnCalculateBMI);
            Controls.Add(tbxStatus);
            Controls.Add(lblStatus);
            Controls.Add(tbxBMI);
            Controls.Add(lblBMI);
            Controls.Add(tbxHeight);
            Controls.Add(tbxWeight);
            Controls.Add(richTextBox1);
            Margin = new Padding(1);
            Name = "Form2";
            Text = "BMI Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private TextBox tbxWeight;
        private TextBox tbxHeight;
        private Label lblBMI;
        private TextBox tbxBMI;
        private Label lblStatus;
        private TextBox tbxStatus;
        private Button btnCalculateBMI;
        private Button btnCloseBMI;
        private Label lblWeight;
        private Label lblHeight;
    }
}