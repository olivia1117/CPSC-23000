using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using static System.Windows.Forms.LinkLabel;

namespace SmallProgramsShowcase
{
    //this class is responsible for generating the passwords
    public partial class Form3 : Form
    {
        List<string> words = new List<string>();
        bool isClicked = false;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void tbxFile_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            
            //this block opens up the file  
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.InitialDirectory = tbxFile.Text;
            dlgOpen.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.RestoreDirectory = true;
            String fname;

            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                fname = dlgOpen.FileName;

                using (StreamReader reader = new StreamReader(fname))
                {
                    String text = "";
                    string[] parts;
                    while (!reader.EndOfStream)
                    {
                        text = text + " " + reader.ReadLine(); //reading the lines 
                        text.Trim(); //trimming and splitting the lines
                        parts = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                       //adding each part to the words list
                        foreach (string part in parts)
                        {
                            words.Add(part);
                        }


                    }
                    reader.Close();
                    tbxFile.Text = fname;//setting the textbox to show the name of the file path 
                  
                    //MessageBox.Show(text, "Text read from " + fname);

                }
            }



        }

        

        private void tbxNumPasswords_TextChanged(object sender, EventArgs e)
        {

        }

        //when the user clicks the generate button, then the passwords will appear in the list box
        private void btnGenerate_Click(object sender, EventArgs e)
        {

            isClicked = true; 
            //checking if it's been clicked
            if (isClicked.Equals(true))
            {
                int numPasswords = Convert.ToInt32(tbxNumPasswords.Text);

                string word1 = "";
                string word2 = "";
                string word3 = "";
                string password;

               
                Random rnd = new Random();


                //keeps generating 3 random words until it reaches the number of passwords
                //the user specifies
                for (int i = 0; i < numPasswords; i++)
                {

                    word1 = words[rnd.Next(words.Count)].Replace("s", "$").Replace("i", "!");
                    word2 = words[rnd.Next(words.Count)].Replace("s", "$").Replace("i", "!").ToUpper();
                    word3 = words[rnd.Next(words.Count)].Replace("s", "$").Replace("i", "!");
                    password = word1 + word2 + word3;  //combing all 3 random and modified words into one password string
                    lbxPasswords.Items.Add(password); //adding this password to the lbxPasswords list box to appear to the user
                    //WriteLine(password);



                }
            }


        }



        private void lbxPasswords_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
        //if user clicks close, then the program closes
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}

