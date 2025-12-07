namespace Ejercicio20_CuboRaiz
{
    public partial class Form1 : Form
    {
        private int contador = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Reiniciar();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtNumero.Text, out double numero))
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Si el usuario ingresa 0 → terminar
            if (numero == 0)
            {
                FinalizarProceso();
                return;
            }

            // Validar número negativo para raíz real
            if (numero < 0)
            {
                MessageBox.Show("La raíz cuadrada de un número negativo no es real.\nSe mostrará solo el cubo.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            contador++;

            double cubo = Math.Pow(numero, 3);
            double raiz = numero >= 0 ? Math.Round(Math.Sqrt(numero), 2) : double.NaN;

            // Actualizar contador
            lblContador.Text = $"PROCESO N° {contador}";
            lblContador.ForeColor = Color.Cyan;

            // Mostrar resultados
            rtbResultado.Clear();
            rtbResultado.SelectionColor = Color.LightGreen;
            rtbResultado.AppendText($"PROCESO N° {contador}\n\n");
            rtbResultado.SelectionColor = Color.White;
            rtbResultado.AppendText($"Número ingresado: {numero}\n");
            rtbResultado.AppendText($"Cubo:             {cubo}\n");

            if (numero >= 0)
            {
                rtbResultado.SelectionColor = Color.Yellow;
                rtbResultado.AppendText($"Raíz cuadrada:    {raiz}\n");
            }
            else
            {
                rtbResultado.SelectionColor = Color.IndianRed;
                rtbResultado.AppendText("Raíz cuadrada:    No es real (número negativo)\n");
            }

            // Preparar siguiente ingreso
            txtNumero.Clear();
            txtNumero.Focus();
        }

        private void FinalizarProceso()
        {
            rtbResultado.Clear();
            rtbResultado.SelectionColor = Color.Yellow;
            rtbResultado.AppendText("══════════════════════════════\n");
            rtbResultado.AppendText("     FINAL DEL PROCESO\n");
            rtbResultado.AppendText("   (Se ingresó el número 0)\n");
            rtbResultado.AppendText("══════════════════════════════\n");

            lblContador.Text = "¡PROCESO FINALIZADO!";
            lblContador.ForeColor = Color.LimeGreen;

            txtNumero.Enabled = false;
            btnCalcular.Enabled = false;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            Reiniciar();
        }

        private void Reiniciar()
        {
            contador = 0;
            lblContador.Text = "PROCESO N° 1";
            lblContador.ForeColor = Color.Cyan;
            rtbResultado.Clear();
            txtNumero.Clear();
            txtNumero.Enabled = true;
            btnCalcular.Enabled = true;
            txtNumero.Focus();
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnCalcular.PerformClick();
                e.Handled = true;
            }
        }
    }
}