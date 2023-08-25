namespace RandomLig
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
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "player" && textBox2.Text == "1234") //you login with player username and 1234 password
            {
                Form2 oyun = new Form2();
                oyun.Show();
                this.Hide();
            }
        }
    }
}