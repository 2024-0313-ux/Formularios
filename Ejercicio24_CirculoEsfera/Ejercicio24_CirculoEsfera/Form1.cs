namespace Ejercicio24_CirculoEsfera
{
    public partial class Form1 : Form
    {
        private const double PI = 3.141592653589793; // más preciso que 3.14

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
            if (!double.TryParse(txtRadio.Text, out double radio) || radio <= 0)
            {
                MessageBox.Show("Por favor, ingrese un radio válido mayor que cero.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double longitud = 2 * PI * radio;
            double area = PI * Math.Pow(radio, 2);
            double volumen = (4.0 / 3.0) * PI * Math.Pow(radio, 3);

            // Redondear a 2 decimales
            longitud = Math.Round(longitud, 2);
            area = Math.Round(area, 2);
            volumen = Math.Round(volumen, 2);

            // Mostrar resultados con estilo
            rtbResultado.Clear();
            rtbResultado.SelectionFont = new Font("Consolas", 16F, FontStyle.Bold);
            rtbResultado.SelectionColor = Color.Cyan;
            rtbResultado.AppendText("RESULTADOS\n\n");

            rtbResultado.SelectionFont = new Font("Consolas", 15F);
            rtbResultado.SelectionColor = Color.White;
            rtbResultado.AppendText($"Radio ingresado: {radio}\n\n");

            rtbResultado.SelectionColor = Color.Yellow;
            rtbResultado.AppendText($"Longitud de la circunferencia:\n");
            rtbResultado.SelectionColor = Color.LimeGreen;
            rtbResultado.AppendText($"   L = 2πr = {longitud} unidades\n\n");

            rtbResultado.SelectionColor = Color.Yellow;
            rtbResultado.AppendText($"Área del círculo:\n");
            rtbResultado.SelectionColor = Color.LimeGreen;
            rtbResultado.AppendText($"   A = πr² = {area} u²\n\n");

            rtbResultado.SelectionColor = Color.Yellow;
            rtbResultado.AppendText($"Volumen de la esfera:\n");
            rtbResultado.SelectionColor = Color.LimeGreen;
            rtbResultado.AppendText($"   V = (4/3)πr³ = {volumen} u³\n");

            lblEstado.Text = "¡Cálculo completado!";
            lblEstado.ForeColor = Color.LightGreen;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtRadio.Clear();
            rtbResultado.Clear();
            lblEstado.Text = "Ingrese el radio";
            lblEstado.ForeColor = Color.Gray;
            txtRadio.Focus();
        }

        private void txtRadio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnCalcular.PerformClick();
                e.Handled = true;
            }
        }
    }
}
