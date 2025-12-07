using System;
using System.Windows.Forms;

namespace SumaDigitos
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
            if (!int.TryParse(txtNumero.Text, out int numero) || numero < 0)
            {
                MessageBox.Show("Por favor, ingrese un número entero positivo.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int original = numero;
            int suma = 0;
            rtbProceso.Clear();

            if (numero == 0)
            {
                rtbProceso.AppendText("0 → suma = 0\n");
                lblSuma.Text = "0";
                return;
            }

            while (numero > 0)
            {
                int digito = numero % 10;
                suma += digito;
                rtbProceso.AppendText($"{numero} → dígito: {digito} → suma parcial: {suma}\n");
                numero /= 10;
            }

            lblSuma.Text = suma.ToString();
            lblResultado.Text = $"La suma de los dígitos de {original} es:";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtNumero.Clear();
            rtbProceso.Clear();
            lblSuma.Text = "0";
            lblResultado.Text = "Ingrese un número para calcular la suma de sus dígitos";
            txtNumero.Focus();
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnCalcular.PerformClick();
        }
    }
}
