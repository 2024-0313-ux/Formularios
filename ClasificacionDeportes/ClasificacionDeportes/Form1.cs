namespace ClasificacionDeportes
{
    public partial class Form1 : Form
    {
        int voley = 0, futbol = 0, basquet = 0, ajedrez = 0;
        int contador = 1;
        const int TOTAL_ALUMNOS = 400;  

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Reiniciar();
        }

        private void Reiniciar()
        {
            voley = futbol = basquet = ajedrez = 0;
            contador = 1;
            ActualizarContador();
            txtDeporte.Clear();
            txtDeporte.Focus();
            lblResultado.Text = "Ingrese el deporte del alumno 1";
            MostrarResultados();
        }

        private void ActualizarContador()
        {
            this.Text = $"Ejercicio 29 - Alumno {contador} de {TOTAL_ALUMNOS}";
            lblContador.Text = $"Alumno {contador}/{TOTAL_ALUMNOS}";
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string deporte = txtDeporte.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(deporte))
            {
                MessageBox.Show("Por favor, ingrese un deporte.", "Campo vacío",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDeporte.Focus();
                return;
            }

            bool valido = true;
            switch (deporte)
            {
                case "voley":
                case "vóley":
                case "volley":
                    voley++;
                    break;
                case "futbol":
                case "fútbol":
                case "futból":
                    futbol++;
                    break;
                case "basquet":
                case "básquet":
                case "basket":
                case "basquetbol":
                    basquet++;
                    break;
                case "ajedrez":
                    ajedrez++;
                    break;
                default:
                    valido = false;
                    break;
            }

            if (!valido)
            {
                MessageBox.Show($"Error: '{txtDeporte.Text}' no es un deporte válido.\n\nDeportes válidos:\n• Fútbol\n• Vóley\n• Básquet\n• Ajedrez",
                    "Deporte no reconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDeporte.SelectAll();
                txtDeporte.Focus();
                return;
            }

            contador++;

            if (contador > TOTAL_ALUMNOS)
            {
                txtDeporte.Enabled = false;
                btnIngresar.Enabled = false;
                lblResultado.Text = "¡Encuesta completada! 400 alumnos registrados.";
                lblResultado.ForeColor = Color.LimeGreen;
            }
            else
            {
                ActualizarContador();
                lblResultado.Text = $"Deporte registrado: {txtDeporte.Text.ToUpper()}";
                lblResultado.ForeColor = Color.Cyan;
            }

            txtDeporte.Clear();
            txtDeporte.Focus();
            MostrarResultados();
        }

        private void MostrarResultados()
        {
            rtbResultado.Clear();
            rtbResultado.SelectionFont = new Font("Consolas", 16F, FontStyle.Bold);
            rtbResultado.SelectionColor = Color.Cyan;
            rtbResultado.AppendText("  RESULTADOS PARCIALES\n");
            rtbResultado.AppendText("══════════════════════════\n\n");

            rtbResultado.SelectionFont = new Font("Consolas", 15F);
            rtbResultado.SelectionColor = Color.LightGreen;
            rtbResultado.AppendText($" Fútbol     : {futbol,3} alumnos\n");
            rtbResultado.AppendText($" Vóley      : {voley,3} alumnos\n");
            rtbResultado.AppendText($" Básquet    : {basquet,3} alumnos\n");
            rtbResultado.AppendText($" Ajedrez    : {ajedrez,3} alumnos\n\n");

            rtbResultado.SelectionColor = Color.Yellow;
            rtbResultado.AppendText($" Total      : {futbol + voley + basquet + ajedrez,3} / {TOTAL_ALUMNOS}");
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            Reiniciar();
            txtDeporte.Enabled = true;
            btnIngresar.Enabled = true;
        }

        private void txtDeporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnIngresar.PerformClick();
                e.Handled = true;
            }
        }
    }
}
