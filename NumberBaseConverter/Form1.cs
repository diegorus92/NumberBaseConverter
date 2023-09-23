namespace NumberBaseConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            long binaryNumber = long.Parse(textBox1.Text.Trim());

            label3.Text = BaseConverter.FromBinaryToDecimal(binaryNumber).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int decimalNumber = int.Parse(textBox2.Text.Trim());

            label6.Text = BaseConverter.FromDecimalToBinary(decimalNumber);
        }
    }
}