namespace MinutosADiasHoras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LimpiarTodo();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMinutos.Text, out int tiempo) || tiempo < 0)
            {
                MessageBox.Show("Por favor, ingrese un número positivo de minutos.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int dias = tiempo / 1440;
            int resto = tiempo % 1440;
            int horas = resto / 60;
            int minutos = resto % 60;

            lblDias.Text = dias.ToString();
            lblHoras.Text = horas.ToString();
            lblMinutosRestantes.Text = minutos.ToString();

            lblResultado.Text = $"{dias} día(s), {horas} hora(s) y {minutos} minuto(s)";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTodo();
        }

        private void LimpiarTodo()
        {
            txtMinutos.Clear();
            lblDias.Text = "0";
            lblHoras.Text = "0";
            lblMinutosRestantes.Text = "0";
            lblResultado.Text = "Ingrese un valor para calcular";
            txtMinutos.Focus();
        }

        private void txtMinutos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnCalcular.PerformClick();
        }
    }
}