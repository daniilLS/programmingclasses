using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basicapp
{
    public partial class Form1 : Form
    {
        private Random _random = new Random();
        private int _numberToGuess;

        public Form1()
        {
            InitializeComponent();
            massagelable.Text = "press the button to start a new game";


        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            massagelable.Text = "Guess a number from 1 to 100";
            startbutton.Enabled = false;
            _numberToGuess = _random.Next(1, 101);
            
            guessinput.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = guessinput.Text;
            guessinput.Text = "";
            int result =  int.Parse(input);
           
       
            if (result> _numberToGuess)
            {
                massagelable.Text = "too big guess again";

            }
            else if (result<_numberToGuess)
            {
                massagelable.Text = "too small guess again";
            }
            else
            {
                massagelable.Text = "you did it!!! press the start button to start new game";
                startbutton.Enabled = true;
                guessbutton.Enabled = false;
                guessinput.Enabled = false;
            }
          
        }

        private void guessinput_TextChanged(object sender, EventArgs e)
        {
            string input = guessinput.Text;
            int result;
            bool validNumber = int.TryParse(input, out result);
            if (!validNumber || result < 1 || result > 100)
            {
                guessbutton.Enabled = false;

            }
            else
            {
                guessbutton.Enabled = true;

            }
        }
    }
}
