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

        private void CheckButton_Click(object sender, EventArgs e)
        {
            string userWord = userAnswerTextBox.Text;
            bullsCountLabel.Text = "Быков = " + bullsCount;
            cowsCountLabel.Text = "Коров = " + cowsCount;
            if (!IsValid(userWord))
            {
                return;
            }
            stepCount++;
            bullsCount = CalculateBullsCount(userWord);
            cowsCount = CalculateCowsCount(userWord);
            historyDataGridView.Rows.Add(stepCount, userWord, bullsCount, cowsCount);
            if (bullsCount == wordLenght)
            {
                MessageBox.Show($"Поздравляем! Вы угаладали число {puzzledWord} с {stepCount} раза");
                CheckButton.Enabled = false;
                userAnswerTextBox.Enabled = false;
                historyDataGridView.Enabled = false;

            }
        }

        private bool IsValid(string userWord)
        {
            if (userWord.Length != wordLenght)
            {
                MessageBox.Show("Строка должна быть длинной 4");
                return false;
            }
            for (int i = 0; i < wordLenght; i++)
            {
                if (!char.IsDigit(userWord[i]))
                {
                    MessageBox.Show("Введите число");
                    return false;
                }
            }
            for (int i = 0; i < userWord.Length; i++)
            {
                for (int k = i + 1; k < userWord.Length; k++)
                {
                    if (userWord[i] == userWord[k])
                    {
                        MessageBox.Show($"Цифра {i} повтораяется раза");
                        return false;
                    }
                }
            }
            return true;
        }
        private int CalculateCowsCount(string userWord)
        {
            int cowsCount = 0;
            for (int i = 0; i < wordLenght; i++)
            {
                for (int k = 0; k < wordLenght; k++)
                {
                    if (i == k)
                    {
                        continue;
                    }
                    if (puzzledWord[i] == userWord[k])
                    {
                        cowsCount++;
                    }
                }
            }
            return cowsCount;
        }
        private int CalculateBullsCount(string userWord)
        {
            int bullsCount = 0;
            for (int i = 0; i < wordLenght; i++)
            {
                if (puzzledWord[i] == userWord[i])
                {
                    bullsCount++;
                }
            }
            return bullsCount;
        }
    }
}
}
