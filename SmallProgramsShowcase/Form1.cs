namespace SmallProgramsShowcase
{
    //this class is the main class that starts the whole series of forms
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }


        //this is for option 4 from the sampler to leave the program s
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //if the user clicks the about button, then this message will be displayed
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\"Small Programs Showcase\" by Olivia Adamic for CPSC 23000 Summer 2023");
        }

        //if user wants to exit the application, then they can click the Exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //these allow for the user to click on each menu option for the 3 subprograms
        //and it will open up their respective forms for BMI, passwords, and word counter
        private void bMICalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void passwordGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void wordCounterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(); 
            f4.Show();  
        }
    }
}