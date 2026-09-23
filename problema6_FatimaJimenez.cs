namespace Problema6
{
    public partial class Form1 : Form
    {
        private bool encendido = false;
        private int canal = 1;
        private int volumen = 1;
        public Form1()
        {
            InitializeComponent();
            ActualizarPantalla();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int grosor = 5;
            Color colorBorde = Color.Black;

            ControlPaint.DrawBorder(
                e.Graphics,
                panel1.ClientRectangle,
                colorBorde,
                grosor,
                ButtonBorderStyle.Solid,
                colorBorde,
                grosor,
                ButtonBorderStyle.Solid,
                colorBorde,
                grosor,
                ButtonBorderStyle.Solid,
                colorBorde,
                grosor,
                ButtonBorderStyle.Solid);
        }

        private void ActualizarPantalla()
        {
            if (encendido)
            {
                textBox1.Text = $"CANAL:{canal:D2}";
                textBox2.Text = $"VOLUMEN:{volumen:D2}";
            }
            else
            {
                textBox1.Text = "CANAL:OFF";
                textBox2.Text = "VOLUMEN:OFF";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            encendido = !encendido;
            ActualizarPantalla();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (encendido && volumen < 100)
            {
                volumen++;
                ActualizarPantalla();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (encendido && volumen > 0)
            {
                volumen--;
                ActualizarPantalla();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (encendido)
            {
                canal++;
                if (canal > 99) canal = 1;
                ActualizarPantalla();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (encendido)
            {
                canal--;
                if (canal < 1) canal = 99;
                ActualizarPantalla();
            }
        }
    }
}
