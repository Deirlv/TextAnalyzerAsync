namespace AsyncAwaitWinFormPractical1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox = new TextBox();
            label1 = new Label();
            buttonAnalyze = new Button();
            checkSentences = new CheckBox();
            checkSymbols = new CheckBox();
            checkWords = new CheckBox();
            checkQuestions = new CheckBox();
            checkExclamatory = new CheckBox();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.Location = new Point(212, 111);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new Size(433, 235);
            textBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(367, 76);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 1;
            label1.Text = "Enter your text below:";
            // 
            // buttonAnalyze
            // 
            buttonAnalyze.Location = new Point(393, 370);
            buttonAnalyze.Name = "buttonAnalyze";
            buttonAnalyze.Size = new Size(75, 23);
            buttonAnalyze.TabIndex = 2;
            buttonAnalyze.Text = "Analyze";
            buttonAnalyze.UseVisualStyleBackColor = true;
            buttonAnalyze.Click += buttonAnalyze_Click;
            // 
            // checkSentences
            // 
            checkSentences.AutoSize = true;
            checkSentences.Location = new Point(675, 165);
            checkSentences.Name = "checkSentences";
            checkSentences.Size = new Size(79, 19);
            checkSentences.TabIndex = 3;
            checkSentences.Text = "Sentences";
            checkSentences.UseVisualStyleBackColor = true;
            // 
            // checkSymbols
            // 
            checkSymbols.AutoSize = true;
            checkSymbols.Location = new Point(675, 190);
            checkSymbols.Name = "checkSymbols";
            checkSymbols.Size = new Size(71, 19);
            checkSymbols.TabIndex = 4;
            checkSymbols.Text = "Symbols";
            checkSymbols.UseVisualStyleBackColor = true;
            // 
            // checkWords
            // 
            checkWords.AutoSize = true;
            checkWords.Location = new Point(675, 215);
            checkWords.Name = "checkWords";
            checkWords.Size = new Size(60, 19);
            checkWords.TabIndex = 5;
            checkWords.Text = "Words";
            checkWords.UseVisualStyleBackColor = true;
            // 
            // checkQuestions
            // 
            checkQuestions.AutoSize = true;
            checkQuestions.Location = new Point(675, 240);
            checkQuestions.Name = "checkQuestions";
            checkQuestions.Size = new Size(145, 19);
            checkQuestions.TabIndex = 6;
            checkQuestions.Text = "Question sentences (?)";
            checkQuestions.UseVisualStyleBackColor = true;
            // 
            // checkExclamatory
            // 
            checkExclamatory.AutoSize = true;
            checkExclamatory.Location = new Point(675, 265);
            checkExclamatory.Name = "checkExclamatory";
            checkExclamatory.Size = new Size(155, 19);
            checkExclamatory.TabIndex = 7;
            checkExclamatory.Text = "Exclamatory sentence (!)";
            checkExclamatory.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 470);
            Controls.Add(checkExclamatory);
            Controls.Add(checkQuestions);
            Controls.Add(checkWords);
            Controls.Add(checkSymbols);
            Controls.Add(checkSentences);
            Controls.Add(buttonAnalyze);
            Controls.Add(label1);
            Controls.Add(textBox);
            Name = "Form1";
            Text = "Text Analyzer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox;
        private Label label1;
        private Button buttonAnalyze;
        private CheckBox checkSentences;
        private CheckBox checkSymbols;
        private CheckBox checkWords;
        private CheckBox checkQuestions;
        private CheckBox checkExclamatory;
    }
}
