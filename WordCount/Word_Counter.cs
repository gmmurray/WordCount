using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordCount
{
    static class Word_Counter
    {
        /// <summary>
        /// Count Words in a String – Counts the number of individual words in a string. For added complexity read these strings in from a text file and generate a summary.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WordCount());
        }
    }
}
