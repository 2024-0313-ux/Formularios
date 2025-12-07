namespace SegundosAMinutos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblResultado.Text = "Ingrese un valor para calcular";
            lblMinutos.Text = "--";
            lblFaltan.Text = "--";
            txtSegundos.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtSegundos.Text, out int segundos) || segundos <= 0)
            {
                MessageBox.Show("Por favor, ingrese un número positivo de segundos.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int minutosCompletos = segundos / 60;
            int segundosRestantes = segundos % 60;
            int faltanParaMinuto = 60 - segundosRestantes;

            if (segundos < 60)
            {
                lblResultado.Text = $"Le faltan {faltanParaMinuto} segundos para completar 1 minuto";
                lblMinutos.Text = "0";
                lblFaltan.Text = faltanParaMinuto.ToString();
            }
            else
            {
                lblResultado.Text = $"Equivale a {minutosCompletos} minuto(s) completo(s)";
                lblMinutos.Text = minutosCompletos.ToString();
                if (segundosRestantes == 0)
                    lblFaltan.Text = "0 (exacto)";
                else
                    lblFaltan.Text = $"{segundosRestantes} → faltan {faltanParaMinuto}";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtSegundos.Clear();
            lblResultado.Text = "Ingrese un valor para calcular";
            lblMinutos.Text = "--";
            lblFaltan.Text = "--";
            txtSegundos.Focus();
        }

        private void txtSegundos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnCalcular.PerformClick();
        }
    }
}