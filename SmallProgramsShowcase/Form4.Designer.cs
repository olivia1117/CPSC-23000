namespace SmallProgramsShowcase
{
    partial class Form4
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
            btnCount = new Button();
            btnClose = new Button();
            lbxWords = new ListBox();
            rbxStory = new RichTextBox();
            lblWordCount = new Label();
            SuspendLayout();
            // 
            // btnCount
            // 
            btnCount.BackColor = Color.Lavender;
            btnCount.Location = new Point(157, 172);
            btnCount.Margin = new Padding(1, 1, 1, 1);
            btnCount.Name = "btnCount";
            btnCount.Size = new Size(83, 30);
            btnCount.TabIndex = 0;
            btnCount.Text = "Count";
            btnCount.UseVisualStyleBackColor = false;
            btnCount.Click += btnCount_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Lavender;
            btnClose.Location = new Point(469, 218);
            btnClose.Margin = new Padding(1, 1, 1, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(92, 30);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lbxWords
            // 
            lbxWords.FormattingEnabled = true;
            lbxWords.ItemHeight = 15;
            lbxWords.Location = new Point(437, 20);
            lbxWords.Margin = new Padding(1, 1, 1, 1);
            lbxWords.Name = "lbxWords";
            lbxWords.Size = new Size(153, 184);
            lbxWords.TabIndex = 2;
            // 
            // rbxStory
            // 
            rbxStory.Location = new Point(28, 52);
            rbxStory.Margin = new Padding(1, 1, 1, 1);
            rbxStory.Name = "rbxStory";
            rbxStory.Size = new Size(348, 114);
            rbxStory.TabIndex = 3;
            rbxStory.Text = "";
            // 
            // lblWordCount
            // 
            lblWordCount.AutoSize = true;
            lblWordCount.Location = new Point(28, 17);
            lblWordCount.Margin = new Padding(1, 0, 1, 0);
            lblWordCount.Name = "lblWordCount";
            lblWordCount.Size = new Size(241, 15);
            lblWordCount.TabIndex = 4;
            lblWordCount.Text = "Type your story below, and then press Count";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(610, 273);
            Controls.Add(lblWordCount);
            Controls.Add(rbxStory);
            Controls.Add(lbxWords);
            Controls.Add(btnClose);
            Controls.Add(btnCount);
            Margin = new Padding(1, 1, 1, 1);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCount;
        private Button btnClose;
        private ListBox lbxWords;
        private RichTextBox rbxStory;
        private Label lblWordCount;
    }
}