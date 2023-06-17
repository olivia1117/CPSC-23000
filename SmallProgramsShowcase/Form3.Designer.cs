namespace SmallProgramsShowcase
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
            lblFile = new Label();
            tbxFile = new TextBox();
            btnBrowse = new Button();
            lbxPasswords = new ListBox();
            btnGenerate = new Button();
            btnClose = new Button();
            lblPasswords = new Label();
            tbxNumPasswords = new TextBox();
            SuspendLayout();
            // 
            // lblFile
            // 
            lblFile.AutoSize = true;
            lblFile.Location = new Point(15, 16);
            lblFile.Margin = new Padding(1, 0, 1, 0);
            lblFile.Name = "lblFile";
            lblFile.Size = new Size(106, 15);
            lblFile.TabIndex = 0;
            lblFile.Text = "Enter name of file: ";
            lblFile.Click += label1_Click;
            // 
            // tbxFile
            // 
            tbxFile.Location = new Point(137, 19);
            tbxFile.Margin = new Padding(1, 1, 1, 1);
            tbxFile.Name = "tbxFile";
            tbxFile.Size = new Size(267, 23);
            tbxFile.TabIndex = 1;
            tbxFile.TextChanged += tbxFile_TextChanged;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(429, 16);
            btnBrowse.Margin = new Padding(1, 1, 1, 1);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(79, 23);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // lbxPasswords
            // 
            lbxPasswords.FormattingEnabled = true;
            lbxPasswords.ItemHeight = 15;
            lbxPasswords.Location = new Point(24, 93);
            lbxPasswords.Margin = new Padding(1, 1, 1, 1);
            lbxPasswords.Name = "lbxPasswords";
            lbxPasswords.Size = new Size(195, 214);
            lbxPasswords.TabIndex = 3;
            lbxPasswords.SelectedIndexChanged += lbxPasswords_SelectedIndexChanged;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(267, 55);
            btnGenerate.Margin = new Padding(1, 1, 1, 1);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(242, 24);
            btnGenerate.TabIndex = 4;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(328, 190);
            btnClose.Margin = new Padding(1, 1, 1, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(105, 30);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblPasswords
            // 
            lblPasswords.AutoSize = true;
            lblPasswords.BorderStyle = BorderStyle.FixedSingle;
            lblPasswords.Location = new Point(15, 55);
            lblPasswords.Margin = new Padding(1, 0, 1, 0);
            lblPasswords.Name = "lblPasswords";
            lblPasswords.Size = new Size(94, 17);
            lblPasswords.TabIndex = 6;
            lblPasswords.Text = "# of passwords: ";
            // 
            // tbxNumPasswords
            // 
            tbxNumPasswords.Location = new Point(124, 56);
            tbxNumPasswords.Margin = new Padding(1, 1, 1, 1);
            tbxNumPasswords.Name = "tbxNumPasswords";
            tbxNumPasswords.Size = new Size(121, 23);
            tbxNumPasswords.TabIndex = 7;
            tbxNumPasswords.TextChanged += tbxNumPasswords_TextChanged;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(529, 333);
            Controls.Add(tbxNumPasswords);
            Controls.Add(lblPasswords);
            Controls.Add(btnClose);
            Controls.Add(btnGenerate);
            Controls.Add(lbxPasswords);
            Controls.Add(btnBrowse);
            Controls.Add(tbxFile);
            Controls.Add(lblFile);
            Margin = new Padding(1, 1, 1, 1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFile;
        private TextBox tbxFile;
        private Button btnBrowse;
        private ListBox lbxPasswords;
        private Button btnGenerate;
        private Button btnClose;
        private Label lblPasswords;
        private TextBox tbxNumPasswords;
    }
}