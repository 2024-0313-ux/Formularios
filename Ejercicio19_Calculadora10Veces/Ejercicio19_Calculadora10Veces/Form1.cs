namespace Ejercicio19_Calculadora10Veces
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
            ReiniciarProceso();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtNum1.Text, out double num1) ||
                !double.TryParse(txtNum2.Text, out double num2))
            {
                MessageBox.Show("Por favor, ingrese números válidos.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            contador++;
            lblContador.Text = $"PROCESO N° {contador} de 10";
            lblContador.ForeColor = Color.Cyan;

            double suma = num1 + num2;
            double resta = num1 - num2;
            double multiplicacion = num1 * num2;
            double division = num2 != 0 ? Math.Round(num1 / num2, 2) : 0;

            rtbResultado.Clear();
            rtbResultado.SelectionColor = Color.LightGreen;
            rtbResultado.AppendText($"RESULTADOS DEL PROCESO {contador}:\n\n");
            rtbResultado.SelectionColor = Color.White;
            rtbResultado.AppendText($"Suma:          {num1} + {num2} = {suma}\n");
            rtbResultado.AppendText($"Resta:         {num1} - {num2} = {resta}\n");
            rtbResultado.AppendText($"Multiplicación: {num1} × {num2} = {multiplicacion}\n");

            if (num2 != 0)
            {
                rtbResultado.AppendText($"División:      {num1} ÷ {num2} = {division}\n");
            }
            else
            {
                rtbResultado.SelectionColor = Color.IndianRed;
                rtbResultado.AppendText("División:      No se puede dividir por cero\n");
            }

          
            txtNum1.Clear();
            txtNum2.Clear();
            txtNum1.Focus();

           
            if (contador >= 10)
            {
                FinalizarProceso();
            }
        }

        private void FinalizarProceso()
        {
            btnSiguiente.Enabled = false;
            txtNum1.Enabled = false;
            txtNum2.Enabled = false;

            rtbResultado.SelectionColor = Color.Yellow;
            rtbResultado.AppendText("\n════════════════════════════\n");
            rtbResultado.AppendText("  ¡PROCESO FINALIZADO!\n");
            rtbResultado.AppendText("  Se completaron 10 cálculos.\n");
            rtbResultado.AppendText("════════════════════════════\n");

            lblContador.Text = "¡10 procesos completados!";
            lblContador.ForeColor = Color.LimeGreen;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            ReiniciarProceso();
        }

        private void ReiniciarProceso()
        {
            contador = 0;
            lblContador.Text = "PROCESO N° 1 de 10";
            lblContador.ForeColor = Color.Cyan;
            rtbResultado.Clear();
            txtNum1.Clear();
            txtNum2.Clear();
            txtNum1.Enabled = true;
            txtNum2.Enabled = true;
            btnSiguiente.Enabled = true;
            txtNum1.Focus();
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtNum1.Focused) txtNum2.Focus();
                else if (txtNum2.Focused) btnSiguiente.PerformClick();
                e.Handled = true;
            }
        }
    }
}