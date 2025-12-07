namespace Ejercicio23_Hipotenusa
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
            if (!double.TryParse(txtCatetoA.Text, out double a) ||
                !double.TryParse(txtCatetoB.Text, out double b))
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos en ambos catetos.",
                    "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (a <= 0 || b <= 0)
            {
                MessageBox.Show("Los catetos deben ser mayores que cero.", "Valor inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Teorema de Pitágoras: h = √(a² + b²)
            double hipotenusa = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            hipotenusa = Math.Round(hipotenusa, 2);

            // Mostrar resultado con estilo
            rtbResultado.Clear();
            rtbResultado.SelectionFont = new Font("Consolas", 16F, FontStyle.Bold);
            rtbResultado.SelectionColor = Color.Cyan;
            rtbResultado.AppendText("CÁLCULO DE HIPOTENUSA\n\n");

            rtbResultado.SelectionFont = new Font("Consolas", 14F);
            rtbResultado.SelectionColor = Color.White;
            rtbResultado.AppendText($"Cateto a = {a}\n");
            
            rtbResultado.AppendText($"Cateto b = {b}\n\n");

            rtbResultado.SelectionColor = Color.Yellow;
            rtbResultado.AppendText($"h = √(a² + b²)\n");
            rtbResultado.AppendText($"h = √({a}² + {b}²) = √({Math.Pow(a, 2)} + {Math.Pow(b, 2)}) = √({Math.Pow(a, 2) + Math.Pow(b, 2):F2})\n\n");

            rtbResultado.SelectionColor = Color.LimeGreen;
            rtbResultado.SelectionFont = new Font("Consolas", 22F, FontStyle.Bold);
            rtbResultado.AppendText($"HIPOTENUSA = {hipotenusa} unidades");

            lblEstado.Text = "¡Cálculo exitoso!";
            lblEstado.ForeColor = Color.LightGreen;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtCatetoA.Clear();
            txtCatetoB.Clear();
            rtbResultado.Clear();
            lblEstado.Text = "Ingrese los catetos";
            lblEstado.ForeColor = Color.Gray;
            txtCatetoA.Focus();
        }

        private void txtCateto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnCalcular.PerformClick();
                e.Handled = true;
            }
        }
    }
}