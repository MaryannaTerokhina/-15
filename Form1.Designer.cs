namespace WinFormsApp15
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
            textBoxDictionary = new TextBox();
            buttonAdd = new Button();
            buttonSave = new Button();
            textBoxWord = new TextBox();
            textBoxTranslation = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            buttonLoad = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // textBoxDictionary
            // 
            textBoxDictionary.Location = new Point(39, 63);
            textBoxDictionary.Name = "textBoxDictionary";
            textBoxDictionary.Size = new Size(150, 31);
            textBoxDictionary.TabIndex = 0;
            textBoxDictionary.TextChanged += textBoxDictionary_TextChanged;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(213, 53);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(186, 51);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "додати переклад";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += переклад_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(345, 276);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(146, 34);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "зберегти";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxWord
            // 
            textBoxWord.Location = new Point(41, 112);
            textBoxWord.Name = "textBoxWord";
            textBoxWord.Size = new Size(287, 31);
            textBoxWord.TabIndex = 7;
            // 
            // textBoxTranslation
            // 
            textBoxTranslation.Location = new Point(43, 149);
            textBoxTranslation.Name = "textBoxTranslation";
            textBoxTranslation.Size = new Size(285, 31);
            textBoxTranslation.TabIndex = 8;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(348, 316);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(143, 34);
            buttonLoad.TabIndex = 9;
            buttonLoad.Text = "завантаження";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(41, 196);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(298, 154);
            listBox1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1223, 854);
            Controls.Add(listBox1);
            Controls.Add(buttonLoad);
            Controls.Add(textBoxTranslation);
            Controls.Add(textBoxWord);
            Controls.Add(buttonSave);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxDictionary);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxDictionary;
        private Button buttonAdd;
        private Button buttonSave;
        private TextBox textBoxWord;
        private TextBox textBoxTranslation;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button buttonLoad;
        private ListBox listBox1;
        private ListView listView1;
    }
}