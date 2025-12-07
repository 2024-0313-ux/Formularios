using System;
using System.Windows.Forms;

namespace PrimeraVocal
{
    public partial class Form1 : Form
    {
        private bool vocalEncontrada = false;
        private string primeraVocal = "";

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
            if (vocalEncontrada)
            {
                MessageBox.Show("Ya se encontró la primera vocal. Presiona 'NUEVO' para reiniciar.",
                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string input = txtCaracter.Text.Trim().ToLower();

            if (input.Length == 0)
            {
                MessageBox.Show("Por favor, ingrese al menos un carácter.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tomamos solo el primer carácter ingresado
            char caracter = input[0];

            rtbHistorial.AppendText($"→ {caracter}\n");

            // Verificamos si es vocal
            if ("aeiouáéíóú".Contains(char.ToLower(caracter)))
            {
                vocalEncontrada = true;
                primeraVocal = caracter.ToString().ToUpper();

                // Resaltar la vocal encontrada
                rtbHistorial.SelectionStart = rtbHistorial.Text.Length - 2;
                rtbHistorial.SelectionLength = 1;
                rtbHistorial.SelectionColor = System.Drawing.Color.LimeGreen;
                rtbHistorial.SelectionFont = new System.Drawing.Font(rtbHistorial.Font, System.Drawing.FontStyle.Bold);

                // Mostrar resultado final
                lblResultado.Text = $"¡VOCAL ENCONTRADA!\nLa primera vocal es:";
                lblVocal.Text = primeraVocal;
                lblVocal.ForeColor = System.Drawing.Color.Gold;
                lblVocal.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold);

                txtCaracter.Enabled = false;
                btnIngresar.Enabled = false;
            }

            txtCaracter.Clear();
            txtCaracter.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Reiniciar();
        }

        private void Reiniciar()
        {
            vocalEncontrada = false;
            primeraVocal = "";
            txtCaracter.Enabled = true;
            btnIngresar.Enabled = true;

            rtbHistorial.Clear();
            rtbHistorial.AppendText("Ingresa caracteres uno por uno...\n\n");

            lblResultado.Text = "Esperando la primera vocal...";
            lblVocal.Text = "?";
            lblVocal.ForeColor = System.Drawing.Color.Gray;

            txtCaracter.Clear();
            txtCaracter.Focus();
        }

        private void txtCaracter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnIngresar.PerformClick();
                e.Handled = true;
            }
        }

        private void lblVocal_Click(object sender, EventArgs e)
        {

        }
    }
}