namespace FiestaBraulio30
{
    public partial class Form1 : Form
    {
        private readonly string[] claves = { "tienes", "que ser", "invitado", "para", "ingresar" };
        private int indice = 0;

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
            indice = 0;
            txtClave.Enabled = true;
            btnVerificar.Enabled = true;
            btnReiniciar.Visible = false;
            MostrarPregunta();
        }

        private void MostrarPregunta()
        {
            lblPregunta.Text = $"Clave {indice + 1} de 5:";
            txtClave.Clear();
            txtClave.Focus();
            lblResultado.Text = "";
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string entrada = txtClave.Text.Trim();

            if (string.IsNullOrEmpty(entrada))
            {
                MessageBox.Show("Escribe la clave para continuar.", "Campo vacío",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClave.Focus();
                return;
            }

           
            if (!entrada.Equals(claves[indice], StringComparison.OrdinalIgnoreCase))
            {
                // CLAVE INCORRECTA → FUERA
                lblResultado.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
                lblResultado.ForeColor = Color.IndianRed;
                lblResultado.Text = "TE EQUIVOCASTE DE FIESTA";
                txtClave.Enabled = false;
                btnVerificar.Enabled = false;
                btnReiniciar.Visible = true;
                return;
            }

           
            indice++;

            if (indice == 5)
            {
                
                lblResultado.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
                lblResultado.ForeColor = Color.LimeGreen;
                lblResultado.Text = "BIENVENIDO A LA FIESTA";
                txtClave.Enabled = false;
                btnVerificar.Enabled = false;
                btnReiniciar.Visible = true;
            }
            else
            {
                MostrarPregunta();
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            Reiniciar();
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnVerificar.PerformClick();
                e.Handled = true;
            }
        }
    }
}