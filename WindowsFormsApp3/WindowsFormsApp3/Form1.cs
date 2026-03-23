using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private OpenFileDialog openFileDialog;

        public Form1()
        {
            InitializeComponent();
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            this.Text = "Анализатор текста";
            this.StartPosition = FormStartPosition.CenterScreen;

            btnSelectFile.Click += new EventHandler(btnSelectFile_Click);
            btnAnalyze.Click += new EventHandler(btnAnalyze_Click);

            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textFileName.Text = openFileDialog.FileName;
            }
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textFileName.Text))
            {
                MessageBox.Show("Пожалуйста, выберите файл для анализа!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtSampleSize.Text, out int sampleSize) || sampleSize <= 0)
            {
                MessageBox.Show("Введите корректное положительное число!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                AnalyzeFile(textFileName.Text, sampleSize);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AnalyzeFile(string filePath, int sampleSize)
        {
            string text = File.ReadAllText(filePath, System.Text.Encoding.UTF8);
            int totalFileChars = text.Length;

            string result = "";
            result += $"Всего символов в файле: {totalFileChars}\r\n";

            if (text.Length >= sampleSize)
            {
                text = text.Substring(0, sampleSize);
            }
            else
            {
                result += $"Ошибка: в файле только {text.Length} символов, а вы хотите анализировать {sampleSize} символов\r\n";
                txtResult.Text = result;
                return;
            }

            int totalChars = text.Length;
            Dictionary<char, int> letterCount = new Dictionary<char, int>();

            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    char lowerChar = char.ToLower(c);
                    if (letterCount.ContainsKey(lowerChar))
                    {
                        letterCount[lowerChar]++;
                    }
                    else
                    {
                        letterCount[lowerChar] = 1;
                    }
                }
            }

            int totalLetters = 0;
            foreach (int count in letterCount.Values)
            {
                totalLetters += count;
            }

            result += $"Всего букв в выборке: {totalLetters}\r\n";
            result += "\r\nВероятность появления каждой буквы:\r\n";
            result += "-" + new string('-', 95) + "\r\n";
            result += "| Буква\t\tСколько раз\tВероятность\t| \r\n";
            result += "-" + new string('-', 95) + "\r\n";

            List<KeyValuePair<char, int>> sortedLetters = new List<KeyValuePair<char, int>>(letterCount);
            sortedLetters.Sort((x, y) => y.Value.CompareTo(x.Value));

            foreach (var item in sortedLetters)
            {
                char letter = item.Key;
                int count = item.Value;
                double probability = (count / (double)totalLetters) * 100;
                result += $"|      {letter}\t\t{count}\t\t{probability:F2}%\t\t| \r\n";
            }

            result += "-" + new string('-', 95) + "\r\n";

            txtResult.Text = result;
        }
    }
}