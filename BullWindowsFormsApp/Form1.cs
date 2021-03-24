using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BullWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public string puzzledWord = "";
        const int wordLenght = 4;
        int stepCount = 0;
        int bullsCount = 0;
        int cowsCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var digits = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Random random = new Random();
            for (int i = 0; i < wordLenght; i++)
            {
                int digitIndex = random.Next(0, digits.Count);
                puzzledWord += digits[digitIndex].ToString();
                digits.RemoveAt(digitIndex);
            }

            puzzledWordLabel.Text = puzzledWord;
        }
    }
}
