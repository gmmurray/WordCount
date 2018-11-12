using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordCount
{
    public partial class WordCount : Form
    {
        static bool INWORD = true;
        static bool OUTWORD = false;

        public WordCount()
        {
            InitializeComponent();
        }

        public int CountWords(string input)
        {
            int wordCount = 0;
            bool wordStatus = OUTWORD;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ' || input[i] == ',' || input[i] == '\n' || input[i] == '\t')
                {
                    wordStatus = OUTWORD;
                }
                
                else if (wordStatus == OUTWORD)
                {
                    wordStatus = INWORD;
                    wordCount++;
                }
            }

            return wordCount;
        }

        private void btnWords_Click(object sender, EventArgs e)
        {
            string userInput = txtWords.Text;
            int wordCount = CountWords(userInput);
            //MessageBox.Show(wordCount.ToString(), "result");
            wordsResultList.Items.Add("Number of Words in Text Box: " + wordCount.ToString());
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            string fileLocation = @"C:\Users\trini\Desktop\test.txt";
            string fileText = System.IO.File.ReadAllText(fileLocation);
            int wordCount = CountWords(fileText);

            fileResultList.Items.Add("Number of Words in File: " + wordCount.ToString());
            //MessageBox.Show(fileLocation);

        }
    }
}
