using System;
using System.Windows.Forms;

namespace DescuentoMonto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDescuento.Text = "$0.00";
            lblTotalPagar.Text = "$0.00";
            lblPorcentaje.Text = "--";
            txtMonto.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtMonto.Text, out double monto) || monto < 0)
            {
                MessageBox.Show("Ingrese un monto válido y positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double descuento = 0;
            string porcentaje = "";

            if (monto > 100)
            {
                descuento = monto * 0.10;
                porcentaje = "10%";
            }
            else if (monto > 0)
            {
                descuento = monto * 0.20;
                porcentaje = "20%";
            }

            double total = monto - descuento;

            lblDescuento.Text = descuento.ToString("C2");
            lblTotalPagar.Text = total.ToString("C2");
            lblPorcentaje.Text = porcentaje;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtMonto.Clear();
            lblDescuento.Text = "$0.00";
            lblTotalPagar.Text = "$0.00";
            lblPorcentaje.Text = "--";
            txtMonto.Focus();
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnCalcular.PerformClick();
        }
    }
}