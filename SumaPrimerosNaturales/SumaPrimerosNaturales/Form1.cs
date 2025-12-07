using System;
using System.Windows.Forms;

namespace SumaPrimerosNaturales
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
            if (!int.TryParse(txtN.Text, out int n) || n <= 0)
            {
                MessageBox.Show("Por favor, ingrese un número entero positivo.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            long suma = 0;
            rtbProceso.Clear();

            for (int i = 1; i <= n; i++)
            {
                suma += i;
                rtbProceso.AppendText($"n{i}: {i}\n");
            }

            lblSuma.Text = suma.ToString();
            lblResultado.Text = $"La suma de los {n} primeros números naturales es:";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTodo();
        }

        private void LimpiarTodo()
        {
            txtN.Clear();
            rtbProceso.Clear();
            lblSuma.Text = "0";
            lblResultado.Text = "Ingrese un valor para calcular la suma";
            txtN.Focus();
        }

        private void txtN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnCalcular.PerformClick();
        }

        private void lblSuma_Click(object sender, EventArgs e)
        {

        }
    }
}