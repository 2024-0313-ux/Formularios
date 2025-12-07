namespace ejercicio1
{
    public partial class frmEjercicio1 : Form
    {
        public frmEjercicio1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double tarifa, horastrabajadas, horasextra, salario, tarifaextra;
            //Console.WriteLine("ingrese horas trabajadas");
            horastrabajadas = double.Parse(txtHorasTrabajadas.Text);
            Console.WriteLine("ingrese tarifa");
            tarifa = double.Parse(txtTarifa.Text);
            if (horastrabajadas <= 40 && horastrabajadas >= 0)
            {
                salario = horastrabajadas * tarifa;
                labelSalario.Text = salario.ToString();
                //Console.WriteLine("el salario es: " + salario);
            }
            else if (horastrabajadas > 40)
            {
                horasextra = horastrabajadas - 40;
                tarifaextra = tarifa + 0.5 * tarifa;
                salario = horasextra * tarifaextra + 40 * tarifa;
                labelSalario.Text = salario.ToString();
                //Console.WriteLine("el salario es: " + salario);
            }
            else
            {
                MessageBox.Show("las horas trabajadas no pueden ser negativas");
                //Console.WriteLine("las horas trabajadas no pueden ser negativas");

            }


        }
    }
}