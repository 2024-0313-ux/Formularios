namespace EcuacionCuadratica
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
            if (!double.TryParse(txtA.Text, out double a) ||
                !double.TryParse(txtB.Text, out double b) ||
                !double.TryParse(txtC.Text, out double c))
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            rtbResultado.Clear();

            if (a == 0)
            {
                rtbResultado.SelectionColor = Color.IndianRed;
                rtbResultado.AppendText("ERROR: Esta no es una ecuación cuadrática.\n");
                rtbResultado.AppendText("El coeficiente 'a' debe ser diferente de 0.");
                lblEstado.Text = "Error";
                lblEstado.ForeColor = Color.IndianRed;
                return;
            }

            double disc = Math.Pow(b, 2) - 4 * a * c;

            // Mostrar ecuación y discriminante
            rtbResultado.AppendText($"Ecuación: {a:N3}x² + {b:N3}x + {c:N3} = 0\n");
            rtbResultado.AppendText($"Discriminante = {disc:N4}\n\n");

            if (disc > 0)
            {
                double s1 = Math.Round((-b + Math.Sqrt(disc)) / (2 * a), 2);
                double s2 = Math.Round((-b - Math.Sqrt(disc)) / (2 * a), 2);
                rtbResultado.SelectionColor = Color.LimeGreen;
                rtbResultado.AppendText("El discriminante es positivo y se han obtenido las siguientes soluciones:\n");
                rtbResultado.SelectionColor = Color.Cyan;
                rtbResultado.AppendText($"x1 = {s1}   y   x2 = {s2}\n");
            }
            else if (disc == 0)
            {
                double s3 = Math.Round(-b / (2 * a), 2);
                rtbResultado.SelectionColor = Color.Yellow;
                rtbResultado.AppendText("El discriminante es 0, se obtiene la siguiente solución:\n");
                rtbResultado.SelectionColor = Color.Cyan;
                rtbResultado.AppendText($"x = {s3}\n");
            }
            else
            {
                double raiz1 = Math.Round(-b / (2 * a), 3);
                double raizima1 = Math.Round(Math.Sqrt(-disc) / (2 * a), 4);
                double raizima2 = Math.Round(-Math.Sqrt(-disc) / (2 * a), 4);
                rtbResultado.SelectionColor = Color.IndianRed;
                rtbResultado.AppendText($"Discriminante = {disc:N4}\n");
                rtbResultado.AppendText("Se obtienen las siguientes raíces imaginarias:\n");
                rtbResultado.SelectionColor = Color.Cyan;
                rtbResultado.AppendText($"x1 = {raiz1} + i({raizima1})\n");
                rtbResultado.AppendText($"x2 = {raiz1} + i({raizima2})\n");
            }

            lblEstado.Text = "¡Listo!";
            lblEstado.ForeColor = Color.LightGreen;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            rtbResultado.Clear();
            lblEstado.Text = "Esperando datos...";
            lblEstado.ForeColor = Color.Gray;
            txtA.Focus();
        }

        private void txtCoef_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnCalcular.PerformClick();
                e.Handled = true;
            }
        }
    }
}