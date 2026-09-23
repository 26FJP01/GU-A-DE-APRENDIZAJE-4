namespace Problema8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ApoteF = 0;
            double Aportaciones = 0;
            double Porcentaje = 0;
            double Neto = 0;
            int hijos = Convert.ToInt32(textBox3.Text);

            if (checkBox1.Checked)
            {
                ApoteF += 3.50 * hijos;
            }
            if (checkBox2.Checked)
            {
                ApoteF += 8.00;
            }
            if (checkBox3.Checked)
            {
                ApoteF += 15.00;
            }
            if (checkBox5.Checked)
            {
                Porcentaje += 0.0676;
            }
            if (checkBox6.Checked)
            {
                Porcentaje += 0.0850;
            }

            Aportaciones = ApoteF * Porcentaje;
            Neto = Aportaciones + ApoteF;

            textBox7.Text = ApoteF.ToString();
            textBox6.Text = Aportaciones.ToString();
            textBox5.Text = Neto.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
