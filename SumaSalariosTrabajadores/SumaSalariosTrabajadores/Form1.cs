using System;
using System.Windows.Forms;

namespace SumaSalariosTrabajadores
{
    public partial class Form1 : Form
    {
        private int contador = 0;
        private int totalTrabajadores;
        private double sumaTotal = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LimpiarTodo();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCantidad.Text, out totalTrabajadores) || totalTrabajadores <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida de trabajadores.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
                return;
            }

            contador = 0;
            sumaTotal = 0;
            rtbDetalle.Clear();
            rtbDetalle.AppendText($"=== SUMA DE SALARIOS DE {totalTrabajadores} TRABAJADORES ===\n\n");

            grupoDatos.Enabled = true;
            btnIniciar.Enabled = false;
            txtCantidad.Enabled = false;
            txtHoras.Focus();
            ActualizarTrabajadorActual();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtHoras.Text, out double horas) || horas < 0)
            {
                MessageBox.Show("Ingrese horas trabajadas válidas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtTarifa.Text, out double tarifa) || tarifa < 0)
            {
                MessageBox.Show("Ingrese una tarifa horaria válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double salario = horas * tarifa;
            sumaTotal += salario;
            contador++;

            rtbDetalle.AppendText($"Trabajador {contador}:\n");
            rtbDetalle.AppendText($"   Horas trabajadas: {horas}\n");
            rtbDetalle.AppendText($"   Tarifa por hora : ${tarifa:F2}\n");
            rtbDetalle.AppendText($"   Salario         : ${salario:F2}\n\n");

            txtHoras.Clear();
            txtTarifa.Clear();

            if (contador >= totalTrabajadores)
            {
                FinalizarCalculo();
            }
            else
            {
                ActualizarTrabajadorActual();
                txtHoras.Focus();
            }
        }

        private void ActualizarTrabajadorActual()
        {
            lblTrabajadorActual.Text = $"Trabajador {contador + 1} de {totalTrabajadores}";
        }

        private void FinalizarCalculo()
        {
            grupoDatos.Enabled = false;
            btnIniciar.Enabled = true;
            txtCantidad.Enabled = true;

            lblResultado.Text = $"SUMA TOTAL DE SALARIOS:";
            lblSumaFinal.Text = $"${sumaTotal:F2}";
            rtbDetalle.AppendText("=====================================\n");
            rtbDetalle.AppendText($"SUMA TOTAL: ${sumaTotal:F2}\n");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTodo();
        }

        private void LimpiarTodo()
        {
            txtCantidad.Clear();
            txtHoras.Clear();
            txtTarifa.Clear();
            rtbDetalle.Clear();
            lblTrabajadorActual.Text = "Esperando cantidad...";
            lblResultado.Text = "Ingrese la cantidad de trabajadores";
            lblSumaFinal.Text = "$0.00";
            grupoDatos.Enabled = false;
            btnIniciar.Enabled = true;
            txtCantidad.Enabled = true;
            txtCantidad.Focus();
        }

        private void txtHoras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) txtTarifa.Focus();
        }

        private void txtTarifa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) btnAgregar.PerformClick();
        }
    }
}
