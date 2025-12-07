namespace Ejercicio20_CuboRaiz
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.rtbResultado = new System.Windows.Forms.RichTextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblContador = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();

            this.panel.SuspendLayout();
            this.SuspendLayout();

            // panel
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.BackColor = System.Drawing.Color.FromArgb(20, 25, 45);
            this.panel.Padding = new System.Windows.Forms.Padding(30);
            this.panel.Controls.Add(this.lblContador);
            this.panel.Controls.Add(this.rtbResultado);
            this.panel.Controls.Add(this.btnReiniciar);
            this.panel.Controls.Add(this.btnCalcular);
            this.panel.Controls.Add(this.txtNumero);
            this.panel.Controls.Add(this.lblTitulo);

            // Form1
            this.ClientSize = new System.Drawing.Size(760, 580);
            this.Controls.Add(this.panel);
            this.Text = "Ejercicio 20 - Cubo y Raíz Cuadrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = System.Drawing.Color.FromArgb(10, 15, 35);
            this.Load += new System.EventHandler(this.Form1_Load);

            // Título
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(100, 200, 255);
            this.lblTitulo.Location = new System.Drawing.Point(30, 30);
            this.lblTitulo.Text = "Ejercicio 20";

            // Contador
            this.lblContador.AutoSize = true;
            this.lblContador.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblContador.ForeColor = System.Drawing.Color.Cyan;
            this.lblContador.Location = new System.Drawing.Point(30, 100);
            this.lblContador.Text = "PROCESO N° 1";

            // Campo de número
            this.txtNumero.Location = new System.Drawing.Point(30, 160);
            this.txtNumero.Size = new System.Drawing.Size(460, 70);
            this.txtNumero.Font = new System.Drawing.Font("Segoe UI", 28F);
            this.txtNumero.BackColor = System.Drawing.Color.FromArgb(40, 45, 70);
            this.txtNumero.ForeColor = System.Drawing.Color.White;
            this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);

            // Botón Calcular
            this.btnCalcular.Location = new System.Drawing.Point(30, 250);
            this.btnCalcular.Size = new System.Drawing.Size(460, 90);
            this.btnCalcular.Text = "CALCULAR CUBO Y RAÍZ";
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(0, 170, 120);
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            // Botón Reiniciar
            this.btnReiniciar.Location = new System.Drawing.Point(510, 250);
            this.btnReiniciar.Size = new System.Drawing.Size(180, 90);
            this.btnReiniciar.Text = "REINICIAR";
            this.btnReiniciar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnReiniciar.BackColor = System.Drawing.Color.FromArgb(200, 60, 60);
            this.btnReiniciar.ForeColor = System.Drawing.Color.White;
            this.btnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReiniciar.FlatAppearance.BorderSize = 0;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);

            // Área de resultados
            this.rtbResultado.Location = new System.Drawing.Point(30, 360);
            this.rtbResultado.Size = new System.Drawing.Size(700, 180);
            this.rtbResultado.BackColor = System.Drawing.Color.FromArgb(30, 35, 60);
            this.rtbResultado.ForeColor = System.Drawing.Color.LightCyan;
            this.rtbResultado.Font = new System.Drawing.Font("Consolas", 16F);
            this.rtbResultado.ReadOnly = true;
            this.rtbResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.RichTextBox rtbResultado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Panel panel;
    }
}