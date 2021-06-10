namespace WindowsFormsApp1
{
    partial class Form1
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
            this.labelDesc = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelLineCountDesc = new System.Windows.Forms.Label();
            this.labelLineCount = new System.Windows.Forms.Label();
            this.labelWordCountDesc = new System.Windows.Forms.Label();
            this.labelWordCount = new System.Windows.Forms.Label();
            this.labelWordSortDesc = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelYourWord = new System.Windows.Forms.Label();
            this.labelNumDistinctWordsDesc = new System.Windows.Forms.Label();
            this.labelDistinctWords = new System.Windows.Forms.Label();
            this.labelVocabDesc = new System.Windows.Forms.Label();
            this.labelVocab = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Location = new System.Drawing.Point(12, 36);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(167, 13);
            this.labelDesc.TabIndex = 0;
            this.labelDesc.Text = "Please select a file to be analysed";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(569, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // labelLineCountDesc
            // 
            this.labelLineCountDesc.AutoSize = true;
            this.labelLineCountDesc.Location = new System.Drawing.Point(12, 80);
            this.labelLineCountDesc.Name = "labelLineCountDesc";
            this.labelLineCountDesc.Size = new System.Drawing.Size(61, 13);
            this.labelLineCountDesc.TabIndex = 2;
            this.labelLineCountDesc.Text = "Line Count:";
            // 
            // labelLineCount
            // 
            this.labelLineCount.AutoSize = true;
            this.labelLineCount.Location = new System.Drawing.Point(85, 80);
            this.labelLineCount.Name = "labelLineCount";
            this.labelLineCount.Size = new System.Drawing.Size(13, 13);
            this.labelLineCount.TabIndex = 3;
            this.labelLineCount.Text = "?";
            // 
            // labelWordCountDesc
            // 
            this.labelWordCountDesc.AutoSize = true;
            this.labelWordCountDesc.Location = new System.Drawing.Point(12, 111);
            this.labelWordCountDesc.Name = "labelWordCountDesc";
            this.labelWordCountDesc.Size = new System.Drawing.Size(67, 13);
            this.labelWordCountDesc.TabIndex = 4;
            this.labelWordCountDesc.Text = "Word Count:";
            // 
            // labelWordCount
            // 
            this.labelWordCount.AutoSize = true;
            this.labelWordCount.Location = new System.Drawing.Point(85, 111);
            this.labelWordCount.Name = "labelWordCount";
            this.labelWordCount.Size = new System.Drawing.Size(13, 13);
            this.labelWordCount.TabIndex = 5;
            this.labelWordCount.Text = "?";
            // 
            // labelWordSortDesc
            // 
            this.labelWordSortDesc.AutoSize = true;
            this.labelWordSortDesc.Location = new System.Drawing.Point(306, 36);
            this.labelWordSortDesc.Name = "labelWordSortDesc";
            this.labelWordSortDesc.Size = new System.Drawing.Size(217, 13);
            this.labelWordSortDesc.TabIndex = 6;
            this.labelWordSortDesc.Text = "Add a word to see how many times it occurs:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(309, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 20);
            this.textBox1.TabIndex = 7;
            // 
            // labelYourWord
            // 
            this.labelYourWord.AutoSize = true;
            this.labelYourWord.Location = new System.Drawing.Point(12, 160);
            this.labelYourWord.Name = "labelYourWord";
            this.labelYourWord.Size = new System.Drawing.Size(0, 13);
            this.labelYourWord.TabIndex = 8;
            // 
            // labelNumDistinctWordsDesc
            // 
            this.labelNumDistinctWordsDesc.AutoSize = true;
            this.labelNumDistinctWordsDesc.Location = new System.Drawing.Point(12, 136);
            this.labelNumDistinctWordsDesc.Name = "labelNumDistinctWordsDesc";
            this.labelNumDistinctWordsDesc.Size = new System.Drawing.Size(126, 13);
            this.labelNumDistinctWordsDesc.TabIndex = 9;
            this.labelNumDistinctWordsDesc.Text = "Number of distinct words:";
            // 
            // labelDistinctWords
            // 
            this.labelDistinctWords.AutoSize = true;
            this.labelDistinctWords.Location = new System.Drawing.Point(143, 136);
            this.labelDistinctWords.Name = "labelDistinctWords";
            this.labelDistinctWords.Size = new System.Drawing.Size(13, 13);
            this.labelDistinctWords.TabIndex = 10;
            this.labelDistinctWords.Text = "?";
            // 
            // labelVocabDesc
            // 
            this.labelVocabDesc.AutoSize = true;
            this.labelVocabDesc.Location = new System.Drawing.Point(12, 182);
            this.labelVocabDesc.Name = "labelVocabDesc";
            this.labelVocabDesc.Size = new System.Drawing.Size(86, 13);
            this.labelVocabDesc.TabIndex = 11;
            this.labelVocabDesc.Text = "Vocabulary Size:";
            // 
            // labelVocab
            // 
            this.labelVocab.AutoSize = true;
            this.labelVocab.Location = new System.Drawing.Point(104, 182);
            this.labelVocab.Name = "labelVocab";
            this.labelVocab.Size = new System.Drawing.Size(13, 13);
            this.labelVocab.TabIndex = 12;
            this.labelVocab.Text = "?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 225);
            this.Controls.Add(this.labelVocab);
            this.Controls.Add(this.labelVocabDesc);
            this.Controls.Add(this.labelDistinctWords);
            this.Controls.Add(this.labelNumDistinctWordsDesc);
            this.Controls.Add(this.labelYourWord);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelWordSortDesc);
            this.Controls.Add(this.labelWordCount);
            this.Controls.Add(this.labelWordCountDesc);
            this.Controls.Add(this.labelLineCount);
            this.Controls.Add(this.labelLineCountDesc);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label labelLineCountDesc;
        private System.Windows.Forms.Label labelLineCount;
        private System.Windows.Forms.Label labelWordCountDesc;
        private System.Windows.Forms.Label labelWordCount;
        private System.Windows.Forms.Label labelWordSortDesc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelYourWord;
        private System.Windows.Forms.Label labelNumDistinctWordsDesc;
        private System.Windows.Forms.Label labelDistinctWords;
        private System.Windows.Forms.Label labelVocabDesc;
        private System.Windows.Forms.Label labelVocab;
    }
}

