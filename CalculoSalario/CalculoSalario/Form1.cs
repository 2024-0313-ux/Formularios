using System;
using System.Windows.Forms;

namespace CalculoSalario
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
            if (!double.TryParse(txtHoras.Text, out double horas) || horas < 0)
            {
                MessageBox.Show("Por favor, ingrese horas trabajadas válidas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtTarifa.Text, out double tarifa) || tarifa < 0)
            {
                MessageBox.Show("Por favor, ingrese una tarifa horaria válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double salario = horas * tarifa;

            lblSalario.Text = salario.ToString("C2"); // Formato moneda con 2 decimales
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtHoras.Clear();
            txtTarifa.Clear();
            lblSalario.Text = "$0.00";
            txtHoras.Focus();
        }

        private void txtHoras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                txtTarifa.Focus();
        }

        private void txtTarifa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnCalcular.PerformClick();
        }
    }
}