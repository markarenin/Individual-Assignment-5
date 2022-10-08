namespace Individual_Assignment_5
{
    public partial class Form1 : Form
    {
        private int random_int;
        private int tries = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            newgame();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            check((int)numericUpDown1.Value);
        }

        private void check(int value)
        {
            tries++;
            if (value == random_int)
            {
                MessageBox.Show($"Wow! Congratulations, you guessed the number! You computer will not turn into a cake 😊 \nAttempts to guess: {tries}");
                tries = 0;
                newgame();
            }
            else if (value > random_int)
            {
                label3.Text = "Too high, try again.";
            }
            else
            {
                label3.Text = "Too low, try again.";
            }
            label2.Text = $"Attempts to guess: {tries}";
            numericUpDown1.Focus();
            numericUpDown1.Select(0, 3);
        }

        private void newgame()
        {
            random_int = new Random().Next(0, 100);
            numericUpDown1.Value = 0;
            label3.Text = "";
            label2.Text = "Attempts to guess: 0";
        }


        private void numericUpDown1_KeyUp(object sender, KeyPressEventArgs e)
        {

            if (13 == e.KeyChar)
            {
                numericUpDown1.Validate();
                check((int)numericUpDown1.Value);
            }
        }
    }
}