namespace DescuentoSueldo
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
            lblSueldoNeto.Text = "$0.00";
            txtSueldo.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtSueldo.Text, out double sueldo) || sueldo < 0)
            {
                MessageBox.Show("Por favor, ingrese un sueldo válido y positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double descuento = 0;

            if (sueldo <= 1000)
                descuento = sueldo * 0.10;
            else if (sueldo <= 2000)
                descuento = 1000 * 0.10 + (sueldo - 1000) * 0.05;
            else
                descuento = 1000 * 0.10 + 1000 * 0.05 + (sueldo - 2000) * 0.03;

            double sueldoNeto = sueldo - descuento;

            lblDescuento.Text = descuento.ToString("C2");
            lblSueldoNeto.Text = sueldoNeto.ToString("C2");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtSueldo.Clear();
            lblDescuento.Text = "$0.00";
            lblSueldoNeto.Text = "$0.00";
            txtSueldo.Focus();
        }

        private void txtSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnCalcular.PerformClick();
        }
    }
}
