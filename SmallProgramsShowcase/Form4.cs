using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallProgramsShowcase
{
    //this is the final menu option which is the word counter
    //the user can type in a story and then have their words counted
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        //if the user wants out of the program, they can click close
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        //when they click Count, then all this stuff will get triggered to start counting
        //and then store the results in the list box
        private void btnCount_Click(object sender, EventArgs e)
        {
            string[] parts;
            string[] separators = { " ", "\n", "\t", "\r", "\r\n", ".", ","};
            Dictionary<string, int> frequencies = new Dictionary<string, int>();
            Dictionary<string, int> total = new Dictionary<string, int>();

            string words = rbxStory.Text; //this stores our text
            words.ToLower(); //lowercase all words
            parts = words.Split(separators, StringSplitOptions.RemoveEmptyEntries); //split at spaces and other wonky chars
            Array.Sort(parts); //sorting alphabetically

            foreach(string word in parts)
            {
                //check if the word is already in the dictionary and update the count value if it is
                if (frequencies.ContainsKey(word))
                {
                    frequencies[word] += 1;

                }
                //if the word isn't already there, then we gotta add it
                //and then make the value 1 to start
                else
                {
                    frequencies[word] = 1;
                }
            }

            //using another foreach loop to wittle down the number of pairs
            //going to check each pair from previous dictionary and then be 
            //able to combine pairs that contain the same words into one total
            //so there aren't any duplicates
            foreach (var pair in frequencies)
            {
                //this functions almost the same as the previous loop to check each key 
                if (total.ContainsKey(pair.Key))
                {
                    total[pair.Key] += pair.Value;
                }
                else
                {
                    total[pair.Key] = pair.Value;
                }
            }

            //looping through each new pair to display it inside the lbxWords box
            foreach (var pair in total)
            {
                string items = pair.Key + " " + pair.Value;
                items.ToLower(); 
                lbxWords.Items.Add(items); 
            }

        }
    }
}
