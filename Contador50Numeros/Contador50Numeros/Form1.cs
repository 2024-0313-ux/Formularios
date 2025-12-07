using System;
using System.Windows.Forms;

namespace Contador50Numeros
{
    public partial class Form1 : Form
    {
        private int contador = 0;
        private int pares = 0, impares = 0, positivos = 0, negativos = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IniciarConteo();
        }

        private void IniciarConteo()
        {
            contador = 0;
            pares = impares = positivos = negativos = 0;
            rtbNumeros.Clear();
            rtbNumeros.AppendText("=== INGRESO DE 50 NÚMEROS NATURALES ===\n\n");
            ActualizarContador();
            txtNumero.Focus();
            txtNumero.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNumero.Text, out int numero))
            {
                MessageBox.Show("Por favor, ingrese un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            contador++;

            // Clasificación
            if (numero % 2 == 0) pares++; else impares++;
            if (numero > 0) positivos++; else if (numero < 0) negativos++; else positivos++; // 0 se cuenta como positivo

            // Mostrar en pantalla
            string paridad = (numero % 2 == 0) ? "PAR" : "IMPAR";
            string signo = (numero > 0) ? "POSITIVO" : (numero < 0) ? "NEGATIVO" : "CERO";
            rtbNumeros.AppendText($"{contador:D2}. {numero,6} → {paridad} | {signo}\n");

            txtNumero.Clear();

            if (contador >= 50)
            {
                FinalizarConteo();
            }
            else
            {
                ActualizarContador();
                txtNumero.Focus();
            }
        }

        private void ActualizarContador()
        {
            lblContador.Text = $"Número {contador + 1} de 50";
        }

        private void FinalizarConteo()
        {
            txtNumero.Enabled = false;
            btnAgregar.Enabled = false;

            lblPares.Text = pares.ToString();
            lblImpares.Text = impares.ToString();
            lblPositivos.Text = positivos.ToString();
            lblNegativos.Text = negativos.ToString();

            rtbNumeros.AppendText("\n" + "═".PadRight(40, '═') + "\n");
            rtbNumeros.AppendText($"PARES      : {pares}\n");
            rtbNumeros.AppendText($"IMPARES    : {impares}\n");
            rtbNumeros.AppendText($"POSITIVOS  : {positivos}\n");
            rtbNumeros.AppendText($"NEGATIVOS  : {negativos}\n");
            rtbNumeros.AppendText("═".PadRight(40, '═') + "\n");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNumero.Enabled = true;
            btnAgregar.Enabled = true;
            IniciarConteo();
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnAgregar.PerformClick();
        }

        private void lblPares_Click(object sender, EventArgs e)
        {

        }
    }
}
