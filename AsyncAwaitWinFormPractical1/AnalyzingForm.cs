using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace AsyncAwaitWinFormPractical1
{
    public partial class AnalyzingForm : Form
    {
        private readonly List<bool> Modifiers = new List<bool>();

        private string TextBoxValue;

        StringBuilder Output = new StringBuilder();

        StringBuilder DevOutput = new StringBuilder();

        Dictionary<string, int> Answers = new Dictionary<string, int>();

        public AnalyzingForm()
        {
            InitializeComponent();
        }

        public async Task CountSentences()
        {
            if (Modifiers.ElementAt(0))
            {
                int count = 0;
                foreach (char ch in TextBoxValue)
                {
                    if (ch == '.' || ch == '!' || ch == '?')
                    {
                        count++;
                    }
                }
                DevOutput.Append(Thread.CurrentThread.ManagedThreadId + "\n");
                Answers.Add("Sentences", count);

            }
        }

        public async Task CountSymbols()
        {
            if (Modifiers.ElementAt(1))
            {
                DevOutput.Append(Thread.CurrentThread.ManagedThreadId + "\n");
                Answers.Add("Symbols", TextBoxValue.Length);
            }
        }

        public async Task CountWords()
        {
            if (Modifiers.ElementAt(2))
            {
                DevOutput.Append(Thread.CurrentThread.ManagedThreadId + "\n");
                Answers.Add("Words", TextBoxValue.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).Length);
            }
        }

        public async Task CountQuestionSentences()
        {
            if (Modifiers.ElementAt(3))
            {
                MatchCollection matches = Regex.Matches(TextBoxValue, @"\?");
                DevOutput.Append(Thread.CurrentThread.ManagedThreadId + "\n");
                Answers.Add("QuestionSentences", matches.Count);
            }
        }

        public async Task CountExclamatorySentences()
        {
            if (Modifiers.ElementAt(4))
            {
                MatchCollection matches = Regex.Matches(TextBoxValue, @"\!");
                DevOutput.Append(Thread.CurrentThread.ManagedThreadId + "\n");
                Answers.Add("ExclamatorySentences", matches.Count);
            }
        }

        public AnalyzingForm(List<bool> modifiers, string text)
        {
            Modifiers = modifiers;
            TextBoxValue = text;

            InitializeComponent();
        }

        public async Task FillCheck()
        {
            Parallel.Invoke(() => CountSentences(),
                () => CountSymbols(), 
                () => CountWords(), 
                () => CountQuestionSentences(), 
                () => CountExclamatorySentences()
            );
        }
        private async void AnalyzingForm_Load(object sender, EventArgs e)
        {
            await FillCheck();

            if (Answers.ContainsKey("Sentences"))
            {
                Output.Append($"Sentences - {Answers["Sentences"]}\n");
            }
            if (Answers.ContainsKey("Symbols"))
            {
                Output.Append($"Symbols - {Answers["Symbols"]}\n");
            }
            if (Answers.ContainsKey("Words"))
            {
                Output.Append($"Words - {Answers["Words"]}\n");
            }
            if (Answers.ContainsKey("QuestionSentences"))
            {
                Output.Append($"Question Sentences - {Answers["QuestionSentences"]}\n");
            }
            if (Answers.ContainsKey("ExclamatorySentences"))
            {
                Output.Append($"Exclamatory Sentences - {Answers["ExclamatorySentences"]}\n");
            }


            label1.Visible = false;

            labelOutput.Text = Output.ToString();
            MessageBox.Show(DevOutput.ToString());

            buttonSaveFile.Visible = true;
            buttonSaveFile.Enabled = true;
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("results.txt"))
            {
                sw.WriteLine(Output.ToString());
            }
            MessageBox.Show("Your file was successfully created.");
        }
    }
}
