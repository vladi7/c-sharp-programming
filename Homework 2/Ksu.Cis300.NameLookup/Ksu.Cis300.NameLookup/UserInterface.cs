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
using System.IO;

namespace Ksu.Cis300.NameLookup
{
    /// <summary>
    /// A GUI for a program that retrieves information about last names in
    /// a sample of US data.
    /// </summary>
    public partial class UserInterface : Form
    {
        /// <summary>
        /// Stores names in array in alphabetic order
        /// </summary>
        private LinkedListCell<NameInformation>[] _names = new LinkedListCell<NameInformation>[26];
        /// <summary>
        /// Constructs a new GUI.
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This method inserts a new cell containing that NameInformation in sorted order by name in the given list. 
        /// It returns a reference to the first cell in the list.
        /// </summary>
        /// <param name="nameInfo">name information that is needed to be insert</param>
        /// <param name="firstCell">a reference to the first cell in a linked list</param>
        /// <returns></returns>
        private LinkedListCell<NameInformation> Insert(NameInformation nameInfo, LinkedListCell<NameInformation> firstCell) 
        {
        LinkedListCell<NameInformation> cell = new LinkedListCell<NameInformation>();
        cell.Data = nameInfo;
        if (firstCell == null)
            {
            cell.Data = nameInfo;
            return cell;
            }
        else if (nameInfo.Name.CompareTo(firstCell.Data.Name) < 0)
            {
                cell.Next = firstCell;
                firstCell = cell;
                return firstCell;
            }
        LinkedListCell<NameInformation> tempCell = firstCell;
        while (tempCell.Next != null)
        {
            if (nameInfo.Name.CompareTo(tempCell.Next.Data.Name) > 0)
            {
                tempCell = tempCell.Next;
            }
            else
            {
                cell.Next = tempCell.Next;
                tempCell.Next = cell;
                return firstCell;
            }
        }
        tempCell.Next=cell;
        return firstCell;        
    }
        /// <summary>
        /// Handles a Click event on the Open Data File button and places all the data by the first name of the last name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxOpen_Click(object sender, EventArgs e)
        {
            if (uxOpenDialog.ShowDialog() == DialogResult.OK)
            {                
                LinkedListCell <NameInformation> tempCell = new LinkedListCell<NameInformation>();
                LinkedListCell<NameInformation>[] arrayOfNames = new LinkedListCell<NameInformation>[26];//each index is a linkedlist corresponding to the letter in alphabet
                try
                {                   
                string fn = uxOpenDialog.FileName;
                tempCell = GetAllInformation(fn);                                       
                    while (tempCell != null)
                        {                         
                        char letter = tempCell.Data.Name[0];
                        int index = letter - 'A';
                        arrayOfNames[index] = Insert(tempCell.Data, arrayOfNames[index]);                                                
                        tempCell = tempCell.Next;
                        }
                _names = arrayOfNames;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        /// <summary>
        /// Handles a Click event on the Get Statistics button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxLookup_Click(object sender, EventArgs e)
        {
            string name = uxName.Text.Trim().ToUpper();
            for(int i = 0; i <26; i++)
            { 
                LinkedListCell<NameInformation> cell = _names[i];
                while (cell != null)
                {
                    if (cell.Data.Name == name)
                    {
                        uxFrequency.Text = cell.Data.Frequency.ToString();
                        uxRank.Text = cell.Data.Rank.ToString();
                        return;
                    }
                    cell = cell.Next;
                }
            }
            MessageBox.Show("Name not found.");
            uxRank.Text = "";
            uxFrequency.Text = "";
        }
        /// <summary>
        /// Reads the given file and forms a linked list from its contents.
        /// </summary>
        /// <param name="fn">The name of the file.</param>
        /// <returns>The linked list containing all the name information.</returns>
        private LinkedListCell<NameInformation> GetAllInformation(string fn)
        {
            LinkedListCell<NameInformation> names = null;
            using (StreamReader input = new StreamReader(fn))
            {
                while (!input.EndOfStream)
                {
                    string name = input.ReadLine().Trim();
                    float freq = Convert.ToSingle(input.ReadLine());
                    int rank = Convert.ToInt32(input.ReadLine());
                    LinkedListCell<NameInformation> cell = new LinkedListCell<NameInformation>();
                    cell.Data = new NameInformation(name, freq, rank);
                    cell.Next = names;
                    names = cell;
                }
            }
            return names;
        }
        /// <summary>
        /// Output all data in sorted order by name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void uxOutput_Click(object sender, EventArgs e)
        {           
                LinkedListCell<NameInformation>[] names = new LinkedListCell<NameInformation>[26];
                _names.CopyTo(names,0);
                if (uxSaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                string fn = uxSaveFileDialog.FileName;
                using (StreamWriter output = new StreamWriter(fn))
                {                  
                    try
                    {
                        for (int j = 0; j <= 25; j++)
                        {
                            while (names[j] != null)
                            {
                                string name = names[j].Data.Name.ToString();
                                string frequency = names[j].Data.Frequency.ToString();
                                string rank = names[j].Data.Rank.ToString();
                                output.WriteLine(name);
                                output.WriteLine(frequency);
                                output.WriteLine(rank);                             
                                names[j] = names[j].Next;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }
        /// <summary>
        /// Counts the number of names that started with the first letter retrieved from the text box named uxFirstLetter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxCount_Click(object sender, EventArgs e)
        {
            LinkedListCell<NameInformation>[] names = new LinkedListCell<NameInformation>[26];
            _names.CopyTo(names, 0);
            try
            {
                string firstLetterString = uxFirstLetter.Text.Trim().ToUpper();
                char firstLetter = firstLetterString[0];
                int count = 0;
                int index = firstLetter - 'A';
                
                if (names[index] == null)
                    {
                        uxCountTextBox.Text = "0";
                    }
                while (names[index] != null) //checks how many letters start with this letter
                {
                names[index] = names[index].Next;
                    count++;
                }
                string txt = count.ToString() + " names begin with " + firstLetterString;
                uxCountTextBox.Text = txt; //updates the uxCountTextBox
            }
            catch (Exception ex)
            {
                MessageBox.Show("Incorrect file");
            }
        }
        private void uxFind_Click(object sender, EventArgs e)
        { 
            int max=0;
            int value = 0;
            int index = 0; 
            LinkedListCell<NameInformation>[] namesLocal = new LinkedListCell<NameInformation>[26];
            _names.CopyTo(namesLocal, 0);
            for (int i = 0; i < 26; i++) 
            {
                try
                {
                    value = 0;
                    while (namesLocal[i] != null) 
                    {
                        namesLocal[i] = namesLocal[i].Next;
                        value++;
                    }
                    if (value > max)
                    {
                        max = value;
                        index = i;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Incorrect input file");
                    return;
                }
            }

            string[] letters = new[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            string txt = "Most frequent first letter: " + letters[index];
            uxFindTextBox.Text = txt;
        }
        private void UserInterface_Load(object sender, EventArgs e)
        {

        }
    }
}
