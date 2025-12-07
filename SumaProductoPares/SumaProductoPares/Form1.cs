namespace SumaProductoPares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Calcular();
        }

        private void Calcular()
        {
            int suma = 0;
            long producto = 1; // Suficiente para este rango

            rtbProceso.Clear();
            rtbProceso.AppendText("NÚMEROS PARES DEL 20 AL 30 (INCLUSIVE)\n\n");

            for (int x = 20; x <= 30; x += 2)
            {
                suma += x;
                producto *= x;

                rtbProceso.AppendText($"{x}");
                if (x < 30) rtbProceso.AppendText(" × ");
            }

            rtbProceso.AppendText($"\n\n{'=',45}\n");
            rtbProceso.AppendText($"Suma      →  {suma:N0}\n");
            rtbProceso.AppendText($"Producto  →  {producto:N0}\n");
            rtbProceso.AppendText($"{'=',45}\n");

            // Resultados grandes y bonitos
            lblSuma.Text = suma.ToString("N0");
            lblProducto.Text = producto.ToString("N0");
            lblCantidad.Text = "6";
        }

        private void btnRecalcular_Click(object sender, EventArgs e)
        {
            Calcular();
        }
    }
}
