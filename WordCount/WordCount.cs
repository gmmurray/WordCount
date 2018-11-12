using System;
using System.IO;
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
            openFile.Filter = "Text Files|*.txt";
            openFile.Title = "Select a Text File";

            openFile.ShowDialog();
            string fullPath = openFile.FileName;

            int wordCount = CountWords(System.IO.File.ReadAllText(fullPath));
            fileResultList.Items.Add("Number of Words in " + Path.GetFileName(fullPath) + ": " + wordCount.ToString());
        }

    }
}
