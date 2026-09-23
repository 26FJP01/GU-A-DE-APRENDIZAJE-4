namespace Problema5
{
    public partial class Form1 : Form
    {
        private bool bloqMayusActivo = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            string textoTecla = boton.Text;

            if (bloqMayusActivo)
            {
                textBox1.Text += textoTecla.ToUpper();
            }
            else
            {
                textBox1.Text += textoTecla.ToLower();
            }
        }

        private void BloqMayus_Click(object sender, EventArgs e)
        {
            bloqMayusActivo = !bloqMayusActivo;
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
