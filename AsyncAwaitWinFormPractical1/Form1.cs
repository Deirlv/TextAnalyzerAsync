namespace AsyncAwaitWinFormPractical1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAnalyze_Click(object sender, EventArgs e)
        {
            AnalyzingForm analyzingForm = new AnalyzingForm(new List<bool> { 
                checkSentences.Checked,
                checkSymbols.Checked,
                checkWords.Checked,
                checkQuestions.Checked,
                checkExclamatory.Checked
            }, textBox.Text);

            analyzingForm.ShowDialog();
        }
    }
}
