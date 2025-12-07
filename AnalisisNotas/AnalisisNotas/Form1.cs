using System;
using System.Windows.Forms;

namespace AnalisisNotas
{
    public partial class Form1 : Form
    {
        private int cantidadAprobadas = 0;
        private int cantidadDesaprobadas = 0;
        private double sumaTotal = 0;
        private double sumaAprobadas = 0;
        private double sumaDesaprobadas = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LimpiarTodo();
        }

        private void btnAgregarNota_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtNota.Text, out double nota) || nota < 0 || nota > 20)
            {
                MessageBox.Show("Por favor, ingrese una nota válida entre 0 y 20.", "Nota inválida",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Acumular
            sumaTotal += nota;

            if (nota <= 10.5)
            {
                cantidadDesaprobadas++;
                sumaDesaprobadas += nota;
                rtbNotas.AppendText($"[DESAPROBADO] {nota}\n");
            }
            else
            {
                cantidadAprobadas++;
                sumaAprobadas += nota;
                rtbNotas.AppendText($"[APROBADO]    {nota}\n");
            }

            txtNota.Clear();
            txtNota.Focus();
            ActualizarContadores();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            MostrarResultados();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarTodo();
        }

        private void ActualizarContadores()
        {
            lblContAprobadas.Text = cantidadAprobadas.ToString();
            lblContDesaprobadas.Text = cantidadDesaprobadas.ToString();
            int total = cantidadAprobadas + cantidadDesaprobadas;
            lblTotalNotas.Text = total.ToString();
        }

        private void MostrarResultados()
        {
            int total = cantidadAprobadas + cantidadDesaprobadas;

            if (total == 0)
            {
                MessageBox.Show("No se ingresaron notas.", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            double promedioGeneral = Math.Round(sumaTotal / total, 1);

            double promAprobadas = cantidadAprobadas > 0 ? Math.Round(sumaAprobadas / cantidadAprobadas, 1) : 0;
            double promDesaprobadas = cantidadDesaprobadas > 0 ? Math.Round(sumaDesaprobadas / cantidadDesaprobadas, 1) : 0;

            lblPromAprobadas.Text = promAprobadas.ToString("F1");
            lblPromDesaprobadas.Text = promDesaprobadas.ToString("F1");
            lblPromedioFinal.Text = promedioGeneral.ToString("F1");

            // Cambiar color según promedio
            if (promedioGeneral >= 10.5)
                lblPromedioFinal.ForeColor = System.Drawing.Color.LimeGreen;
            else
                lblPromedioFinal.ForeColor = System.Drawing.Color.IndianRed;
        }

        private void LimpiarTodo()
        {
            cantidadAprobadas = 0;
            cantidadDesaprobadas = 0;
            sumaTotal = 0;
            sumaAprobadas = 0;
            sumaDesaprobadas = 0;

            rtbNotas.Clear();
            txtNota.Clear();

            lblContAprobadas.Text = "0";
            lblContDesaprobadas.Text = "0";
            lblTotalNotas.Text = "0";
            lblPromAprobadas.Text = "0.0";
            lblPromDesaprobadas.Text = "0.0";
            lblPromedioFinal.Text = "0.0";
            lblPromedioFinal.ForeColor = System.Drawing.Color.White;

            txtNota.Focus();
        }

        private void txtNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnAgregarNota.PerformClick();
        }

        private void grupoResultados_Enter(object sender, EventArgs e)
        {

        }
    }
}