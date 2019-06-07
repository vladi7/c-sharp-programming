/* UserInterface.cs
 * Author: Vladislav Dubrovenski 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ksu.Cis300.Sort;
using System.IO;
using System.Text.RegularExpressions;
namespace Homework5
{
    public partial class uxTextAnalyzer : Form
    {
        public uxTextAnalyzer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Attempts to get to get file names from the user, places any names provided into the text box 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxText1_Click(object sender, EventArgs e)
        {
            OpenFileDialog uxOpenFileDialog = new OpenFileDialog();
            uxOpenFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (uxOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fn = uxOpenFileDialog.FileName;
                uxTextBox1.Text = fn;
                uxTextBox1.Enabled = true;
                if (uxTextBox1.Text != "" && uxTextBox2.Text != "")
                {
                    uxAnalyzeTexts.Enabled = true;
                }
            }          
        }

        /// <summary>
        /// Attempts to get to get file names from the user, places any names provided into the text box 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxText2_Click(object sender, EventArgs e)
        {
            OpenFileDialog uxOpenFileDialog = new OpenFileDialog();
            uxOpenFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (uxOpenFileDialog.ShowDialog() == DialogResult.OK)
            { 
                string fn = uxOpenFileDialog.FileName;
                uxTextBox2.Text = fn;
                uxTextBox2.Enabled = true;
                if (uxTextBox1.Text != "" && uxTextBox2.Text != "")
                {
                    uxAnalyzeTexts.Enabled = true;
                }
            }        
        }

        /// <summary>
        /// Processes the file, gets the 50 words having the highest combined frequency, computes and displays the difference measure.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxAnalyzeTexts_Click(object sender, EventArgs e)
        {
            WordStruct st;
            Dictionary<string,Word> words = new Dictionary<string,Word>(); //dictionary
            Word temp = null;
            int[] totalWords = new int[2]; //total number of words in both files
            MinPriorityQueue<float, WordStruct> priorityQueue = null;
             //processing file 1
            using (StreamReader input1 = new StreamReader(uxTextBox1.Text))
            {
                while (!input1.EndOfStream)
                {
                    string line = input1.ReadLine().ToLower();
                    string [] wordsFromLine = Regex.Split(line, "[^abcdefghijklmnopqrstuvwxyz]+");
                    foreach (string s in wordsFromLine)
                    {
                        if (s != "")
                        {
                            bool value = words.TryGetValue(s, out temp);
                            if (value == false)
                            {
                                temp = new Word(s, 2);
                                words.Add(s, temp); 
                            }
                            temp.Increment(0);
                            totalWords[0]++;
                        }
                    }
                }
            }
            //end of processing file 1

            //processing file 2
            using (StreamReader input2 = new StreamReader(uxTextBox2.Text))
            {
                while (!input2.EndOfStream)
                {
                    string line = input2.ReadLine().ToLower();
                    string[] wordsFromLine = Regex.Split(line, "[^abcdefghijklmnopqrstuvwxyz]+");
                    foreach (string s in wordsFromLine)
                    {
                        if (s != "")
                        {
                            bool value = words.TryGetValue(s, out temp);
                            if (value == false)
                            {
                                temp = new Word(s, 2);
                                words.Add(s, temp);
                               
                            }
                            temp.Increment(1);
                            totalWords[1]++;
                        }
                    }
                }
            }
            //end of processing file 2
            priorityQueue = new MinPriorityQueue<float, WordStruct>();
            //Getting the Words with Highest Combined Frequencies
            foreach (KeyValuePair<string, Word> pair in words)
            {
                 st = new WordStruct(pair.Value, totalWords);
                float combinedFrequency = (st[0] / (float)totalWords[0] + st[1] / (float)totalWords[1]);
               
                priorityQueue.Add(st, combinedFrequency);
                if (priorityQueue.Count > 50)
                {
                    priorityQueue.RemoveMinimumPriority();
                }
            }
            float underTheRoot = 0;
            //Computing the Difference Measure
            while (priorityQueue.Count != 0)
            {
                float wordFr = priorityQueue.MininumPriority;
                WordStruct word = priorityQueue.RemoveMinimumPriority();
                float x = word[0];
                float y = word[1];
                float toTheSecond = (x - y) * (x - y);
                underTheRoot += toTheSecond;
            }
            float differenceMeasure = 100 * (float)Math.Sqrt(underTheRoot);
            MessageBox.Show("Difference measure:" + differenceMeasure);
        }
    }
}
