namespace ParteFraccionaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtNumero.Text, out double numero))
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumero.Focus();
                txtNumero.SelectAll();
                return;
            }

            double parteEntera = Math.Truncate(numero);
            bool tieneFraccionaria = numero != parteEntera;

            // Mostrar número con formato
            lblNumeroIngresado.Text = numero.ToString("N6");

            // Resultado principal
            if (tieneFraccionaria)
            {
                lblResultado.Text = "TIENE parte fraccionaria";
                lblResultado.ForeColor = Color.IndianRed;
                
            }
            else
            {
                lblResultado.Text = "NO tiene parte fraccionaria";
                lblResultado.ForeColor = Color.LimeGreen;
               
            }

            // Detalle en el RichTextBox
            rtbDetalle.Clear();
            rtbDetalle.SelectionFont = new Font("Consolas", 14F);
            rtbDetalle.SelectionColor = Color.LightCyan;

            rtbDetalle.AppendText($"Número ingresado : {numero:N6}\n");
            rtbDetalle.AppendText($"Parte entera     : {parteEntera:N0}\n");
            rtbDetalle.AppendText("Parte fraccionaria: ");

            if (tieneFraccionaria)
                rtbDetalle.SelectionColor = Color.IndianRed;
            else
                rtbDetalle.SelectionColor = Color.LimeGreen;

            rtbDetalle.AppendText(tieneFraccionaria ? "SÍ existe\n" : "NO existe\n");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtNumero.Clear();
            lblNumeroIngresado.Text = "0.000000";
            lblResultado.Text = "Esperando número...";
            lblResultado.ForeColor = Color.Gray;
            rtbDetalle.Clear();
            picIcono.Image = null;
            txtNumero.Focus();
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir Enter para verificar
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnVerificar.PerformClick();
                e.Handled = true;
                return;
            }

            // Permitir solo números, signo -, punto y coma
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '.' &&
                e.KeyChar != ',' &&
                e.KeyChar != '-')
            {
                e.Handled = true;
            }

            // Permitir solo un punto o coma
            if ((e.KeyChar == '.' || e.KeyChar == ',') && txtNumero.Text.Contains(".") || txtNumero.Text.Contains(","))
            {
                e.Handled = true;
            }
        }
    }
}
 