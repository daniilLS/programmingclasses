using System;
using System.Windows.Forms;

namespace Basicapp
{
    public partial class Form1 : Form
    {
        private Random _random = new Random();
        private int _numberToGuess;
        private int _numberOfGuesses;

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
            _numberOfGuesses = 0;
           
            GuessNumberLable.Text = _numberOfGuesses.ToString();
            guessHistory.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _numberOfGuesses++;
            GuessNumberLable.Text = _numberOfGuesses.ToString();

            string input = guessinput.Text;
            guessinput.Text = "";
            int result =  int.Parse(input);
           
       
            if (result> _numberToGuess)
            {
                massagelable.Text = "too big guess again";
                guessHistory.Items.Add(result.ToString()+ "+");

            }
            else if (result<_numberToGuess)
            {
                massagelable.Text = "too small guess again";
                guessHistory.Items.Add(result.ToString()+ "-");
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
