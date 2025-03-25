using System.Data;

namespace juegos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string ObtenerSeleccionComputadora()
        {
            Random random = new Random();
            int indice = random.Next(3);
            switch (indice)
            {
                case 0: return "Piedra";
                case 1: return "Papel";
                case 2: return "Tijera";
                default: return "Piedra";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialization code here, if needed
        }

        private void button3_Click(object sender, EventArgs e) // Papel
        {
            papel.Visible = true;
            piedra.Visible = false;
            tijera.Visible = false;
        }

        private void pi_Click(object sender, EventArgs e) // Piedra
        {
            papel.Visible = false;
            piedra.Visible = true;
            tijera.Visible = false;
        }

        private void ti_Click(object sender, EventArgs e) // Tijera
        {
            papel.Visible = false;
            piedra.Visible = false;
            tijera.Visible = true;
        }

        private void pelea_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            string seleccionUsuario = "";
            if (piedra.Visible) seleccionUsuario = "Piedra";
            else if (papel.Visible) seleccionUsuario = "Papel";
            else if (tijera.Visible) seleccionUsuario = "Tijera";
            else
            {
                MessageBox.Show("Por favor, selecciona una opción.");
                return;
            }

            string seleccionComputadora = ObtenerSeleccionComputadora();
            MostrarImagenComputadora(seleccionComputadora); // Mostrar la imagen

            string resultado = DeterminarGanador(seleccionUsuario, seleccionComputadora);

            // Mostrar el resultado en labels
            label3.Text = $"Tu elección: {seleccionUsuario}";
            label4.Text = $"Elección de la computadora: {seleccionComputadora}";
            label5.Text = $"Resultado: {resultado}";
        }

        private string DeterminarGanador(string usuario, string computadora)
        {
            if (usuario == computadora) return "Empate";
            if ((usuario == "Piedra" && computadora == "Tijera") ||
                (usuario == "Papel" && computadora == "Piedra") ||
                (usuario == "Tijera" && computadora == "Papel"))
                return "Ganaste";
            else
                return "Perdiste";
        }

        private void MostrarImagenComputadora(string seleccion)
        {
            switch (seleccion)
            {
                case "Piedra":
                    piedra2.Visible = true;
                    papel2.Visible = false;
                    tijera2.Visible = false;
                    break;
                case "Papel":
                    papel2.Visible = true;
                    piedra2.Visible = false;
                    tijera2.Visible = false;
                    break;
                case "Tijera":
                    tijera2.Visible = true;
                    piedra2.Visible = false;
                    papel2.Visible = false;
                    break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            piedra.Visible = false;
            papel.Visible = false;
            tijera.Visible = false;
            piedra2.Visible = false;
            papel2.Visible = false;
            tijera2.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}