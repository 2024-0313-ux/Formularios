using System;
using System.Windows.Forms;

namespace Media100Numeros
{
    public partial class Form1 : Form
    {
        private int contador = 0;
        private double suma = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Iniciar();
        }

        private void Iniciar()
        {
            contador = 0;
            suma = 0;
            rtbNumeros.Clear();
            rtbNumeros.AppendText("=== INGRESO DE 100 NÚMEROS PARA CALCULAR LA MEDIA ===\n\n");
            ActualizarContador();
            txtNumero.Clear();
            txtNumero.Focus();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtNumero.Text, out double numero))
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            contador++;
            suma += numero;

            rtbNumeros.AppendText($"{contador:D3}. {numero,10:N2}\n");

            txtNumero.Clear();

            if (contador >= 100)
            {
                Finalizar();
            }
            else
            {
                ActualizarContador();
                txtNumero.Focus();
            }
        }

        private void ActualizarContador()
        {
            lblContador.Text = $"Número {contador + 1} de 100";
            lblSumaActual.Text = suma.ToString("N2");
        }

        private void Finalizar()
        {
            txtNumero.Enabled = false;
            btnAgregar.Enabled = false;

            double media = Math.Round(suma / 100, 2);

            lblMedia.Text = media.ToString("N2");
            lblMedia.ForeColor = System.Drawing.Color.Gold;

            rtbNumeros.AppendText("\n" + "═".PadRight(45, '═') + "\n");
            rtbNumeros.AppendText($"SUMA TOTAL : {suma:N2}\n");
            rtbNumeros.AppendText($"MEDIA FINAL: {media:N2}\n");
            rtbNumeros.AppendText("═".PadRight(45, '═') + "\n");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNumero.Enabled = true;
            btnAgregar.Enabled = true;
            Iniciar();
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnAgregar.PerformClick();
        }
    }
}
