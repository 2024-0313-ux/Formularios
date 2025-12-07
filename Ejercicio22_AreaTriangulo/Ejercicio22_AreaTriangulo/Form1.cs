namespace Ejercicio22_AreaTriangulo
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
            if (!double.TryParse(txtLadoA.Text, out double a) ||
                !double.TryParse(txtLadoB.Text, out double b) ||
                !double.TryParse(txtLadoC.Text, out double c))
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos en todos los lados.",
                    "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (a <= 0 || b <= 0 || c <= 0)
            {
                MessageBox.Show("Los lados deben ser mayores que cero.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar desigualdad triangular
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                MessageBox.Show("Los lados ingresados NO forman un triángulo válido.\n" +
                                "La suma de dos lados debe ser mayor que el tercer lado.",
                                "Triángulo imposible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double s = (a + b + c) / 2.0; // semiperímetro
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            area = Math.Round(area, 2);

            // Mostrar resultados
            rtbResultado.Clear();
            rtbResultado.SelectionFont = new Font("Consolas", 16F, FontStyle.Bold);
            rtbResultado.SelectionColor = Color.Cyan;
            rtbResultado.AppendText("RESULTADO\n\n");

            rtbResultado.SelectionFont = new Font("Consolas", 14F);
            rtbResultado.SelectionColor = Color.White;
            rtbResultado.AppendText($"Lado a = {a}\n");
            rtbResultado.AppendText($"Lado b = {b}\n");
            rtbResultado.AppendText($"Lado c = {c}\n\n");
            rtbResultado.AppendText($"Semiperímetro (s) = {s}\n\n");

            rtbResultado.SelectionColor = Color.LimeGreen;
            rtbResultado.SelectionFont = new Font("Consolas", 18F, FontStyle.Bold);
            rtbResultado.AppendText($"Área del triángulo = {area} u²");

            lblEstado.Text = "¡Cálculo completado!";
            lblEstado.ForeColor = Color.LightGreen;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtLadoA.Clear();
            txtLadoB.Clear();
            txtLadoC.Clear();
            rtbResultado.Clear();
            lblEstado.Text = "Listo para calcular";
            lblEstado.ForeColor = Color.Gray;
            txtLadoA.Focus();
        }

        private void txtLado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnCalcular.PerformClick();
                e.Handled = true;
            }
        }
    }
}

