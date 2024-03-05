namespace assignment7
{
    public partial class Form1 : Form
    {
        int[] dice = new int[6];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = 0;
            }
            for (int i = 0; i < 6000; i++)
            {
                Random random = new Random();
                int randomNumber = random.Next(1, 7);

                if (randomNumber == 1)
                {
                    dice[0]++;
                }
                else if (randomNumber == 2)
                {
                    dice[1]++;
                }
                else if (randomNumber == 3)
                {
                    dice[2]++;
                }
                else if (randomNumber == 4)
                {
                    dice[3]++;
                }
                else if (randomNumber == 5)
                {
                    dice[4]++;
                }
                else
                {
                    dice[5]++;
                }
            }
        }

        private void btnThrow_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++) 
            {
                txtNumberOfThrows.Text += ($"Number of throws of value {i+1} = {dice[i]}");
                txtNumberOfThrows.Text += Environment.NewLine;
            }
            btnThrow.Enabled = false;
        }
    }
}