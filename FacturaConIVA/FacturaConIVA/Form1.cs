using System;
using System.Windows.Forms;

namespace FacturaConIVA
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
            if (!double.TryParse(txtPrecio.Text, out double precio) || precio <= 0)
            {
                MessageBox.Show("Ingrese un precio válido mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double precioVenta = precio * cantidad;
            double iva = Math.Round(precioVenta * 0.15, 2);
            double precioBruto = precioVenta + iva;
            double descuento = (precioBruto >= 50) ? Math.Round(precioBruto * 0.05, 2) : 0;
            double totalPagar = precioBruto - descuento;

            // Mostrar resultados
            lblPrecioVenta.Text = precioVenta.ToString("C2");
            lblIVA.Text = iva.ToString("C2");
            lblPrecioBruto.Text = precioBruto.ToString("C2");
            lblDescuento.Text = descuento.ToString("C2");
            lblTotalPagar.Text = totalPagar.ToString("C2");

            // Resaltar descuento si aplica
            if (descuento > 0)
            {
                lblDescuento.ForeColor = System.Drawing.Color.LimeGreen;
                lblDescuento.Text = $"-{descuento.ToString("C2")} (5% aplicado)";
            }
            else
            {
                lblDescuento.ForeColor = System.Drawing.Color.Gray;
                lblDescuento.Text = "$0.00 (sin descuento)";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtPrecio.Clear();
            txtCantidad.Clear();
            lblPrecioVenta.Text = "$0.00";
            lblIVA.Text = "$0.00";
            lblPrecioBruto.Text = "$0.00";
            lblDescuento.Text = "$0.00 (sin descuento)";
            lblDescuento.ForeColor = System.Drawing.Color.Gray;
            lblTotalPagar.Text = "$0.00";
            txtPrecio.Focus();
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) txtCantidad.Focus();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) btnCalcular.PerformClick();
        }

        private void lblDescuento_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalPagar_Click(object sender, EventArgs e)
        {

        }
    }
}