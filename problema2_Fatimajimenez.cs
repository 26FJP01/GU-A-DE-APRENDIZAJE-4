namespace Problema2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Gerente":
                    textBox2.Text = $"Q 5000.00";
                    break;
                case "Administrador":
                    textBox2.Text = $"Q 4500.00";
                    break;
                case "Secretaria":
                    textBox2.Text = $"Q 3500.00";
                    break;
                case "Contador":
                    textBox2.Text = $"Q 4000.00";
                    break;
                default:
                    MessageBox.Show("Seleccione una opcion Valida", "Error");
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = -1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
