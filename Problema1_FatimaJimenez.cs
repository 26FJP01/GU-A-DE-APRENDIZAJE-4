namespace Problema1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dia = this.textBox1.Text;
            int mes = Convert.ToInt32(textBox2.Text);
            string año = this.textBox3.Text;
            string MES = "";

            switch (mes)
            {
                case 1:
                    MES = "Enero";
                    break;
                case 2:
                    MES = "Febrero";
                    break;
                case 3:
                    MES = "Marzo";
                    break;
                case 4:
                    MES = "Abril";
                    break;
                case 5:
                    MES = "Mayo";
                    break;
                case 6:
                    MES = "Junio";
                    break;
                case 7:
                    MES = "Julio";
                    break;
                case 8:
                    MES = "Agosto";
                    break;
                case 9:
                    MES = "Septiembre";
                    break;
                case 10:
                    MES = "Octubre";
                    break;
                case 11:
                    MES = "Noviembre";
                    break;
                case 12:
                    MES = "Diciembre";
                    break;
                default:
                    MessageBox.Show("Ingrese un valor del 1 al 12,  cerrando Programa...", "Error");
                    Application.Exit();
                    break;

            }
            label4.Text = $"{dia} de {MES} de {año}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            label4.Text = "...";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
