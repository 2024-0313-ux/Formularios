namespace Ejercicio25_Restaurant130Consumos
{
    public partial class Form1 : Form
    {
        private int contador = 0;
        private double totalGeneral = 0;
        private const double LIMITE_DESCUENTO = 130.00;
        private const double PORCENTAJE_DESCUENTO = 0.15;

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
            if (!double.TryParse(txtConsumo.Text, out double consumo) || consumo < 0)
            {
                MessageBox.Show("Por favor, ingrese un consumo válido (número positivo).", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            contador++;

            double descuento = 0;
            double consumoFinal = consumo;

            if (consumo > LIMITE_DESCUENTO)
            {
                descuento = consumo * PORCENTAJE_DESCUENTO;
                consumoFinal = consumo - descuento;
            }

            totalGeneral += consumoFinal;

            // Actualizar interfaz
            lblContador.Text = $"Consumo N° {contador} de 130";
            lblContador.ForeColor = contador == 130 ? Color.LimeGreen : Color.Cyan;

            // Agregar al historial
            rtbHistorial.SelectionColor = Color.White;
            rtbHistorial.AppendText($"Consumo {contador:000}: ${consumo:F2}");

            if (descuento > 0)
            {
                rtbHistorial.SelectionColor = Color.Yellow;
                rtbHistorial.AppendText($" → Descuento15% = ${descuento:F2}");
                rtbHistorial.SelectionColor = Color.LimeGreen;
                rtbHistorial.AppendText($" → Paga: ${consumoFinal:F2}\n");
            }
            else
            {
                rtbHistorial.SelectionColor = Color.LightGray;
                rtbHistorial.AppendText($" → Sin descuento → Paga: ${consumoFinal:F2}\n");
            }

            // Auto-scroll al final
            rtbHistorial.SelectionStart = rtbHistorial.Text.Length;
            rtbHistorial.ScrollToCaret();

            // Actualizar total parcial
            lblTotalParcial.Text = $"Total acumulado: ${totalGeneral:F2}";

            // Limpiar campo para siguiente
            txtConsumo.Clear();
            txtConsumo.Focus();

            // Si se completaron los 130
            if (contador >= 130)
            {
                FinalizarProceso();
            }
        }

        private void FinalizarProceso()
        {
            btnIngresar.Enabled = false;
            txtConsumo.Enabled = false;

            rtbHistorial.SelectionColor = Color.Yellow;
            rtbHistorial.SelectionFont = new Font("Consolas", 16F, FontStyle.Bold);
            rtbHistorial.AppendText("\n════════════════════════════════\n");
            rtbHistorial.AppendText("     ¡130 CONSUMOS COMPLETADOS!\n");
            rtbHistorial.AppendText($"    TOTAL FINAL A PAGAR: ${totalGeneral:F2}\n");
            rtbHistorial.AppendText("════════════════════════════════\n");

            lblContador.Text = "¡PROCESO FINALIZADO!";
            lblContador.ForeColor = Color.LimeGreen;
            lblTotalParcial.ForeColor = Color.Yellow;
            lblTotalParcial.Font = new Font(lblTotalParcial.Font, FontStyle.Bold);
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            Reiniciar();
        }

        private void Reiniciar()
        {
            contador = 0;
            totalGeneral = 0;
            rtbHistorial.Clear();
            lblContador.Text = "Consumo N° 1 de 130";
            lblContador.ForeColor = Color.Cyan;
            lblTotalParcial.Text = "Total acumulado: $0.00";
            lblTotalParcial.ForeColor = Color.White;
            txtConsumo.Enabled = true;
            btnIngresar.Enabled = true;
            txtConsumo.Clear();
            txtConsumo.Focus();

            rtbHistorial.SelectionColor = Color.Cyan;
            rtbHistorial.SelectionFont = new Font("Consolas", 14F, FontStyle.Bold);
            rtbHistorial.AppendText("RESTAURANT - 130 CONSUMOS\n");
            rtbHistorial.AppendText("Descuento del 15% si el consumo > $130\n");
            rtbHistorial.AppendText("────────────────────────────────────\n\n");
        }

        private void txtConsumo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnIngresar.PerformClick();
                e.Handled = true;
            }
        }
    }
}
