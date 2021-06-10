using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Ryan Good
    /// ID: 1353453
    /// </summary>
    public partial class Form1 : Form
    {
        //Stream reader to read from the file
        StreamReader reader;
        //lists to store all the words and then the distinct words
        List<string> allWordsList = new List<string>();
        List<string> distinctList = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method opens a file, reads in the words and then does calculations on it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //This array is used to store the line data when it is read in
            string[] csvArray;
            //This stores the data of each line
            string line;
            //These hold the amount of lines and words
            int lineCount = 0;
            int WordCount = 0;
            //This holds the input from the user
            string inputtedWord;
            //These hold the number of times your word occurs, the percentage of that, and the size of the vocab
            double numTimesYourWordOccurs = 0;
            double wordOccurPercent = 0;
            double vocabSize;

            //This stores input as a variable
            inputtedWord = textBox1.Text;

            //This will see if the user has clicked OK
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //This sets up the reader to read from the file
                reader = File.OpenText(openFileDialog1.FileName);

                //This will run until the file is out of data
                while (!reader.EndOfStream)
                {
                    //Sets line to be the read in line
                    line = reader.ReadLine();
                    //This makes line all lower case
                    line.ToLower();
                    //This splits the line based on end of word characters and then stores that into the array
                    csvArray = line.Split("?., :;".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                    //This will loop through the array and count the words
                    for (int i = 0; i < csvArray.Length; i++)
                    {
                        //This sees if the current word is the users word
                        if (csvArray[i] == inputtedWord)
                        {
                            //Incements amount of times users word occurs
                            numTimesYourWordOccurs++;
                        }

                        //This adds all the words the list
                        allWordsList.Add(csvArray[i]);
                        //This increases the word count by 1
                        WordCount++;
                    }
                    //This increases the word count by 1
                    lineCount++;                   
                }
                //This closes the reader
                reader.Close();

                //This gets the distinct words from allWordsList and stores them in distinctList
                distinctList.AddRange(allWordsList.Distinct());

                //This calculates the percentage of times the users words occurs
                wordOccurPercent = (numTimesYourWordOccurs / WordCount) * 100;
                //This calculates the vocabulary size
                vocabSize = ((double)distinctList.Count / (double)WordCount) * 100;

                //These output their respective data to labels
                labelLineCount.Text = lineCount.ToString();
                labelWordCount.Text = WordCount.ToString();
                labelDistinctWords.Text = distinctList.Count.ToString();
                labelYourWord.Text = "The word " + inputtedWord + " occured " + numTimesYourWordOccurs + " times or " + wordOccurPercent.ToString("n3") + "%";
                labelVocab.Text = vocabSize.ToString("n3");
            }
        }

        /// <summary>
        /// This method closes the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
