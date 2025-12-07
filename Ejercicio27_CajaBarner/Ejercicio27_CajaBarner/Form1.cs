namespace Ejercicio27_CajaBarner
{
    public partial class Form1 : Form
    {
        private const double CAJA_INICIAL = 371.00;
        private double totalEgresos = 0;
        private int contador = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Reiniciar();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtEgreso.Text, out double egreso))
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEgreso.Focus();
                return;
            }

            // Si ingresa -1 → terminar el proceso
            if (egreso == -1)
            {
                FinalizarProceso();
                return;
            }

            // Validar que no sea negativo (excepto -1 que es el fin)
            if (egreso < 0)
            {
                MessageBox.Show("Los egresos deben ser positivos.\nUse -1 solo para terminar.", "Valor inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEgreso.Clear();
                txtEgreso.Focus();
                return;
            }

            contador++;
            totalEgresos += egreso;

            double saldoActual = CAJA_INICIAL - totalEgresos;

            // Mostrar en historial
            rtbHistorial.SelectionColor = Color.White;
            rtbHistorial.AppendText($"Egreso {contador:000}:  ${egreso:F2}");

            if (saldoActual < 0)
            {
                rtbHistorial.SelectionColor = Color.IndianRed;
                rtbHistorial.AppendText($"  → SALDO NEGATIVO: ${saldoActual:F2}\n");
            }
            else
            {
                rtbHistorial.SelectionColor = Color.LightGreen;
                rtbHistorial.AppendText($"  → Saldo restante: ${saldoActual:F2}\n");
            }

            // Auto scroll
            rtbHistorial.SelectionStart = rtbHistorial.Text.Length;
            rtbHistorial.ScrollToCaret();

            // Actualizar etiqueta en tiempo real
            lblSaldo.Text = $"Saldo actual: ${saldoActual:F2}";
            lblSaldo.ForeColor = saldoActual < 0 ? Color.Red : Color.LimeGreen;

            lblContador.Text = $"Egresos registrados: {contador}";

            txtEgreso.Clear();
            txtEgreso.Focus();
        }

        private void FinalizarProceso()
        {
            double saldoFinal = CAJA_INICIAL - totalEgresos;

            btnIngresar.Enabled = false;
            txtEgreso.Enabled = false;

            rtbHistorial.SelectionColor = Color.Yellow;
            rtbHistorial.SelectionFont = new Font("Consolas", 16F, FontStyle.Bold);
            rtbHistorial.AppendText("\n");
            rtbHistorial.AppendText("═══════════════════════════════════════\n");
            rtbHistorial.AppendText("         PROCESO FINALIZADO\n");
            rtbHistorial.AppendText("     (Se ingresó -1)\n\n");
            rtbHistorial.AppendText($"  Caja inicial:        ${CAJA_INICIAL:F2}\n");
            rtbHistorial.AppendText($"  Total egresos:       ${totalEgresos:F2}\n");
            rtbHistorial.SelectionColor = saldoFinal >= 0 ? Color.LimeGreen : Color.IndianRed;
            rtbHistorial.AppendText($"  SALDO FINAL EN CAJA: ${saldoFinal:F2}\n");
            rtbHistorial.AppendText("═══════════════════════════════════════\n");

            lblSaldo.Text = $"SALDO FINAL: ${saldoFinal:F2}";
            lblSaldo.ForeColor = saldoFinal >= 0 ? Color.LimeGreen : Color.Red;
            lblSaldo.Font = new Font(lblSaldo.Font, FontStyle.Bold);

            lblContador.Text = $"¡Finalizado con {contador} egresos!";
            lblContador.ForeColor = Color.Yellow;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            Reiniciar();
        }

        private void Reiniciar()
        {
            totalEgresos = 0;
            contador = 0;

            rtbHistorial.Clear();
            rtbHistorial.SelectionColor = Color.Cyan;
            rtbHistorial.SelectionFont = new Font("Consolas", 14F, FontStyle.Bold);
            rtbHistorial.AppendText("COMPAÑÍA BARNER - CONTROL DE CAJA\n");
            rtbHistorial.AppendText($"Caja inicial del día: ${CAJA_INICIAL:F2}\n");
            rtbHistorial.AppendText("→ Ingrese egresos uno por uno\n");
            rtbHistorial.AppendText("→ Ingrese -1 para terminar\n");
            rtbHistorial.AppendText("────────────────────────────────────\n\n");

            lblContador.Text = "Egresos registrados: 0";
            lblContador.ForeColor = Color.Cyan;
            lblSaldo.Text = $"Saldo actual: ${CAJA_INICIAL:F2}";
            lblSaldo.ForeColor = Color.LimeGreen;

            txtEgreso.Enabled = true;
            btnIngresar.Enabled = true;
            txtEgreso.Clear();
            txtEgreso.Focus();
        }

        private void txtEgreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnIngresar.PerformClick();
                e.Handled = true;
            }
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
