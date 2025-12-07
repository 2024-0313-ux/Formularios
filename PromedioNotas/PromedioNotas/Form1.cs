namespace PromedioNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNota1.Focus();
            lblPromedio.Text = "00.00";
            lblResultado.Text = "Esperando notas...";
            lblResultado.ForeColor = Color.Gray;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtNota1.Text, out double n1) ||
                !double.TryParse(txtNota2.Text, out double n2))
            {
                MessageBox.Show("Por favor, ingrese solo números válidos.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (n1 < 0 || n1 > 20 || n2 < 0 || n2 > 20)
            {
                lblPromedio.Text = "--";
                lblResultado.Text = "ERROR: Notas deben estar entre 0 y 20";
                lblResultado.ForeColor = Color.IndianRed;
                rtbDetalle.Text = "Escala vigesimal (0 - 20)\nNotas inválidas detectadas.";
                return;
            }

            double promedio = (n1 + n2) / 2.0;

            lblPromedio.Text = promedio.ToString("00.00");

            if (promedio >= 10.5)
            {
                lblResultado.Text = "APROBADO";
                lblResultado.ForeColor = Color.LimeGreen;
            }
            else
            {
                lblResultado.Text = "DESAPROBADO";
                lblResultado.ForeColor = Color.IndianRed;
            }

            rtbDetalle.Clear();
            rtbDetalle.SelectionFont = new Font("Consolas", 14F, FontStyle.Bold);
            rtbDetalle.AppendText($"Nota 1    : {n1,5:00.00}\n");
            rtbDetalle.AppendText($"Nota 2    : {n2,5:00.00}\n");
            rtbDetalle.AppendText("────────────────\n");
            rtbDetalle.SelectionColor = promedio >= 10.5 ? Color.LimeGreen : Color.IndianRed;
            rtbDetalle.AppendText($"Promedio  : {promedio,5:00.00} → {lblResultado.Text}");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota1.Focus();
            lblPromedio.Text = "00.00";
            lblResultado.Text = "Esperando notas...";
            lblResultado.ForeColor = Color.Gray;
            rtbDetalle.Clear();
        }

        private void txtNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtNota1.Focused) txtNota2.Focus();
                else btnCalcular.PerformClick();
                e.Handled = true;
            }
        }
    }
}