namespace AsyncAwaitWinFormPractical1
{
    partial class AnalyzingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            labelOutput = new Label();
            buttonSaveFile = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(105, 109);
            label1.Name = "label1";
            label1.Size = new Size(313, 45);
            label1.TabIndex = 0;
            label1.Text = "Analyzing your text...";
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelOutput.Location = new Point(12, 9);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(0, 45);
            labelOutput.TabIndex = 1;
            // 
            // buttonSaveFile
            // 
            buttonSaveFile.Enabled = false;
            buttonSaveFile.Location = new Point(222, 244);
            buttonSaveFile.Name = "buttonSaveFile";
            buttonSaveFile.Size = new Size(75, 23);
            buttonSaveFile.TabIndex = 3;
            buttonSaveFile.Text = "Save to file";
            buttonSaveFile.UseVisualStyleBackColor = true;
            buttonSaveFile.Visible = false;
            buttonSaveFile.Click += buttonSaveFile_Click;
            // 
            // AnalyzingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 287);
            Controls.Add(buttonSaveFile);
            Controls.Add(labelOutput);
            Controls.Add(label1);
            Name = "AnalyzingForm";
            Text = "AnalyzingForm";
            Load += AnalyzingForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelOutput;
        private Button buttonSaveFile;
    }
}