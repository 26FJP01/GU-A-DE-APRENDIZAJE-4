namespace Problema9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double total = 0;
            if (checkBox1.Checked)
            {
                total += 100;
            }
            if (checkBox2.Checked)
            {
                total += 500;
            }
            if (checkBox3.Checked)
            {
                total += 200;
            }
            if (checkBox4.Checked)
            {
                total += 150;
            }
            if (checkBox5.Checked)
            {
                total += 300;
            }
            if (checkBox6.Checked)
            {
                total += 80;
            }
            textBox1.Text = "$"+total.ToString("N2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
