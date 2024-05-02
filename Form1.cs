using System.Collections;
using System.Collections.Generic;

namespace WinFormsApp15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
    

        }

        private void переклад_Click(object sender, EventArgs e)
        {
          
            listBox1.Items.Add(textBoxWord.Text + "-" + textBoxTranslation.Text);
        }

        private void buttonAdd_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            using (StreamWriter writer = new StreamWriter("dictionary.txt")) { 
                //string line;
           
                foreach(var i in listBox1.Items)
                {
                    writer.WriteLine(i.ToString());
                }

            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            LoadDictionary();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDictionary_TextChanged(object sender, EventArgs e)
        {

        }
        private void LoadDictionary()
        {
           
            listBox1.Items.Clear();

            if (File.Exists("dictionary.txt"))
            {
                using (StreamReader reader = new StreamReader("dictionary.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
    
                            listBox1.Items.Add(line);
                        
                    }
                }
            }
        }


    }
}