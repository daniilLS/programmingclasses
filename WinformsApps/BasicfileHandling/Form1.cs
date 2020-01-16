using System;
using System.IO;
using System.Windows.Forms;

namespace BasicfileHandling
{
    public partial class Form1 : Form
    {
        private string _path = @"C:\Users\W59920\Desktop\Sample.txt";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
          contentTextBox.Text = File.ReadAllText(_path);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            File.WriteAllText(_path, contentTextBox.Text);
        }
    }
}
