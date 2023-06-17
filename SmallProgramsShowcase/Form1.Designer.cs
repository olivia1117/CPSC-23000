namespace SmallProgramsShowcase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            btnExit = new Button();
            menuStrip1 = new MenuStrip();
            helpToolStripMenuItem = new ToolStripMenuItem();
            bMICalculatorToolStripMenuItem = new ToolStripMenuItem();
            passwordGeneratorToolStripMenuItem = new ToolStripMenuItem();
            wordCounterToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(135, 106);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.LightSteelBlue;
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            richTextBox1.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(14, 57);
            richTextBox1.Margin = new Padding(1);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(487, 88);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.Location = new Point(216, 167);
            btnExit.Margin = new Padding(1);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(85, 31);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(40, 40);
            menuStrip1.Items.AddRange(new ToolStripItem[] { helpToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(2, 1, 0, 1);
            menuStrip1.Size = new Size(511, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bMICalculatorToolStripMenuItem, passwordGeneratorToolStripMenuItem, wordCounterToolStripMenuItem, exitToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(37, 22);
            helpToolStripMenuItem.Text = "File";
            // 
            // bMICalculatorToolStripMenuItem
            // 
            bMICalculatorToolStripMenuItem.Name = "bMICalculatorToolStripMenuItem";
            bMICalculatorToolStripMenuItem.Size = new Size(180, 22);
            bMICalculatorToolStripMenuItem.Text = "BMI Calculator";
            bMICalculatorToolStripMenuItem.Click += bMICalculatorToolStripMenuItem_Click;
            // 
            // passwordGeneratorToolStripMenuItem
            // 
            passwordGeneratorToolStripMenuItem.Name = "passwordGeneratorToolStripMenuItem";
            passwordGeneratorToolStripMenuItem.Size = new Size(180, 22);
            passwordGeneratorToolStripMenuItem.Text = "Password Generator";
            passwordGeneratorToolStripMenuItem.Click += passwordGeneratorToolStripMenuItem_Click;
            // 
            // wordCounterToolStripMenuItem
            // 
            wordCounterToolStripMenuItem.Name = "wordCounterToolStripMenuItem";
            wordCounterToolStripMenuItem.Size = new Size(180, 22);
            wordCounterToolStripMenuItem.Text = "Word Counter";
            wordCounterToolStripMenuItem.Click += wordCounterToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(44, 22);
            toolStripMenuItem1.Text = "Help";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(107, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(511, 322);
            Controls.Add(btnExit);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(1);
            Name = "Form1";
            Text = "Small Programs Showcase";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox richTextBox1;
        private Button btnExit;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem bMICalculatorToolStripMenuItem;
        private ToolStripMenuItem passwordGeneratorToolStripMenuItem;
        private ToolStripMenuItem wordCounterToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}