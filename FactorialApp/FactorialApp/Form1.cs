using System;
using System.Windows.Forms;
using System.Numerics; // Para BigInteger (soporta factoriales muy grandes)

namespace FactorialApp
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
            if (!int.TryParse(txtNumero.Text, out int n) || n < 0)
            {
                MessageBox.Show("Por favor, ingrese un número entero no negativo.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (n == 0 || n == 1)
            {
                lblResultado.Text = "1";
                MostrarProceso(n, "1");
                return;
            }

            BigInteger factorial = 1;
            string proceso = "";

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                proceso += i.ToString();
                if (i < n) proceso += " × ";
            }

            lblResultado.Text = factorial.ToString("N0"); // Formato con separadores de miles
            MostrarProceso(n, proceso);
        }

        private void MostrarProceso(int n, string operacion)
        {
            rtbProceso.Clear();
            rtbProceso.SelectionFont = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            rtbProceso.AppendText($"{n}! = ");
            rtbProceso.SelectionFont = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular);
            rtbProceso.AppendText(operacion);
            rtbProceso.AppendText("\n\n= ");
            rtbProceso.SelectionFont = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            rtbProceso.SelectionColor = System.Drawing.Color.Gold;
            rtbProceso.AppendText(lblResultado.Text);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtNumero.Clear();
            rtbProceso.Clear();
            lblResultado.Text = "1";
            txtNumero.Focus();
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnCalcular.PerformClick();
        }
    }
}