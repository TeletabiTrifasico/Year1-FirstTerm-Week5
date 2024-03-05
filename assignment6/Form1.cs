namespace assignment6
{
    public partial class Form1 : Form
    {
        int[] arr = new int[20];

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            int comparisonNumber = Convert.ToInt32(txtbxComparisonNumber.Text);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= comparisonNumber)
                {
                    arr[i] += 10;
                }
                else
                {
                    arr[i] -= 5;
                }
                txtTableAfter.Text += ($"Element {i:00} = {arr[i].ToString()}");
                txtTableAfter.Text += Environment.NewLine;
            }
            btnCompare.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < 20; i++)
            {
                Random random = new Random();
                arr[i] = random.Next(0, 500);
                txtTableBefore.Text += ($"Element {i:00} = {arr[i].ToString()}");
                txtTableBefore.Text += Environment.NewLine;
            }
        }
    }
}