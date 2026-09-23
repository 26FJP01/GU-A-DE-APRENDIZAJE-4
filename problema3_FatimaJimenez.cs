namespace Problema3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text) && !String.IsNullOrEmpty(textBox3.Text) && !String.IsNullOrEmpty(textBox4.Text)))
            {
                errorProvider1.Clear();
                MessageBox.Show("Datos Enviados");
            }
            if ((String.IsNullOrEmpty(textBox1.Text)))
            {
                errorProvider1.SetError(textBox1, "Ingrese los Nombres");
            }
            if ((String.IsNullOrEmpty(textBox2.Text)))
            {
                errorProvider1.SetError(textBox2, "Ingrese la Edad");
            }
            if ((String.IsNullOrEmpty(textBox3.Text)))
            {
                errorProvider1.SetError(textBox3, "Ingrese el Salario");
            }
            if ((String.IsNullOrEmpty(textBox4.Text)))
            {
                errorProvider1.SetError(textBox4, "Ingrese la Descripcion");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            errorProvider1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
