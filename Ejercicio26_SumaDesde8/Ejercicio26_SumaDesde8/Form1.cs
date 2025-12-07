namespace Ejercicio26_SumaDesde8
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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNumero.Text, out int n))
            {
                MessageBox.Show("Por favor, ingrese un número entero válido.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumero.Focus();
                return;
            }

            if (n < 8)
            {
                MessageBox.Show("Error: el número ingresado debe ser mayor o igual a 8.", "Valor inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumero.SelectAll();
                txtNumero.Focus();
                return;
            }

            long suma = 0;
            string serie = "";

            for (int i = 8; i <= n; i++)
            {
                suma += i;
                serie += i.ToString();
                if (i < n)
                    serie += " + ";
            }

            // Mostrar la serie completa
            rtbSerie.Clear();
            rtbSerie.SelectionFont = new Font("Consolas", 18F, FontStyle.Regular);
            rtbSerie.SelectionColor = Color.White;
            rtbSerie.AppendText(serie + " = ");

            rtbSerie.SelectionColor = Color.LimeGreen;
            rtbSerie.SelectionFont = new Font("Consolas", 24F, FontStyle.Bold);
            rtbSerie.AppendText(suma.ToString("N0"));

            // Resultado final
            lblResultado.Text = $"La suma desde 8 hasta {n} es: {suma:N0}";
            lblResultado.ForeColor = Color.Yellow;

            lblEstado.Text = "Cálculo completado";
            lblEstado.ForeColor = Color.LightGreen;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtNumero.Clear();
            rtbSerie.Clear();
            lblResultado.Text = "La suma será mostrada aquí";
            lblResultado.ForeColor = Color.Gray;
            lblEstado.Text = "Ingrese un número ≥ 8";
            lblEstado.ForeColor = Color.Gray;
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
