using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Most_Frequent_Character
{
    public partial class frmMostFrequentCharacter : Form
    {
        public frmMostFrequentCharacter()
        {
            InitializeComponent();
        }

        private void btnSeeMostFreqChar_Click(object sender, EventArgs e)
        {
            string entry = tboxEntryWord.Text.Trim();

            List<char> charListUnique = new List<char>();

            for(int i = 0; i < entry.Length; i++)
            {
                char c = entry[i];

                if(charListUnique.IndexOf(c) == -1)
                {
                    charListUnique.Add(c);
                }
            }

            List<int> countList = new List<int>();

            foreach(char c in charListUnique)
            {
                int count = CountChar(c, entry);
                countList.Add(count);

            }

            int max = FindMax(countList);

            int position = countList.IndexOf(max);

            char mostFreqcharacter = charListUnique[position];

            lblOutMostFreqChar.Text = String.Format("The most frequent character in the string is {0} with {1} occurrences", mostFreqcharacter.ToString(), max.ToString());
        }

        private int FindMax(List<int> countList)
        {
            int max = countList[0];

            for(int i = 1; i < countList.Count; i++)
            {
                if (countList[i] > max)
                {
                    max = countList[i];
                }
            }
            return max;
        }

        private int CountChar(char c, string entry)
        {
            int count = 0;
            for(int i = 0; i < entry.Length ; i++)
            {
                char s = entry[i];

                if(c == s)
                {
                    count++;
                }

            }
            return count;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tboxEntryWord.Text = "";
            lblOutMostFreqChar.Text = "";

            tboxEntryWord.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
