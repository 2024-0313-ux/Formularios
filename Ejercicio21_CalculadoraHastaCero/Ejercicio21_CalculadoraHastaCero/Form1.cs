namespace Ejercicio21_CalculadoraHastaCero
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
            // Validar primer número
            if (!double.TryParse(txtNum1.Text, out double num1))
            {
                MessageBox.Show("Ingrese un número válido en el primer campo.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNum1.Focus();
                return;
            }

            // Si el primer número es 0 → TERMINAR
            if (num1 == 0)
            {
                FinalizarProceso();
                return;
            }

            // Validar segundo número
            if (!double.TryParse(txtNum2.Text, out double num2))
            {
                MessageBox.Show("Ingrese un número válido en el segundo campo.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNum2.Focus();
                return;
            }

            contador++;

            double suma = num1 + num2;
            double resta = num1 - num2;
            double multiplicacion = num1 * num2;

            // Mostrar resultados
            lblContador.Text = $"PROCESO N° {contador}";
            lblContador.ForeColor = Color.Cyan;

            rtbResultado.Clear();
            rtbResultado.SelectionColor = Color.LightGreen;
            rtbResultado.AppendText($"PROCESO N° {contador}\n\n");
            rtbResultado.SelectionColor = Color.White;
            rtbResultado.AppendText($"Primer número : {num1}\n");
            rtbResultado.AppendText($"Segundo número: {num2}\n\n");
            rtbResultado.AppendText($"Suma          : {num1} + {num2} = {suma}\n");
            rtbResultado.AppendText($"Resta         : {num1} - {num2} = {resta}\n");
            rtbResultado.AppendText($"Multiplicación: {num1} × {num2} = {multiplicacion}\n");

            if (num2 != 0)
            {
                double division = Math.Round(num1 / num2, 2);
                rtbResultado.AppendText($"División      : {num1} ÷ {num2} = {division}\n");
            }
            else
            {
                rtbResultado.SelectionColor = Color.IndianRed;
                rtbResultado.AppendText("División      : No se puede dividir por cero\n");
            }

            // Preparar siguiente proceso
            txtNum1.Clear();
            txtNum2.Clear();
            txtNum1.Focus();
        }

        private void FinalizarProceso()
        {
            rtbResultado.Clear();
            rtbResultado.SelectionColor = Color.Yellow;
            rtbResultado.SelectionFont = new Font("Consolas", 16F, FontStyle.Bold);
            rtbResultado.AppendText("══════════════════════════════\n");
            rtbResultado.AppendText("     FINAL DEL PROCESO\n");
            rtbResultado.AppendText(" (Primer número ingresado = 0)\n");
            rtbResultado.AppendText("══════════════════════════════\n");

            lblContador.Text = "¡PROCESO FINALIZADO!";
            lblContador.ForeColor = Color.LimeGreen;

            txtNum1.Enabled = false;
            txtNum2.Enabled = false;
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
            txtNum1.Clear();
            txtNum2.Clear();
            txtNum1.Enabled = true;
            txtNum2.Enabled = true;
            btnCalcular.Enabled = true;
            txtNum1.Focus();
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtNum1.Focused)
                    txtNum2.Focus();
                else if (txtNum2.Focused)
                    btnCalcular.PerformClick();
                e.Handled = true;
            }
        }
    }
}