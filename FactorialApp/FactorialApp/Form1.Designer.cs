namespace FactorialApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.rtbProceso = new System.Windows.Forms.RichTextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblInstruccion = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();

            this.panel.SuspendLayout();
            this.SuspendLayout();

            // Form1
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 580);
            this.Controls.Add(this.panel);
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.BackColor = System.Drawing.Color.FromArgb(10, 15, 30);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 13 - Factorial de un Número";
            this.Load += new System.EventHandler(this.Form1_Load);

            // panel
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.BackColor = System.Drawing.Color.FromArgb(20, 25, 45);
            this.panel.Padding = new System.Windows.Forms.Padding(40);
            this.panel.Controls.Add(this.lblResultado);
            this.panel.Controls.Add(this.rtbProceso);
            this.panel.Controls.Add(this.btnLimpiar);
            this.panel.Controls.Add(this.btnCalcular);
            this.panel.Controls.Add(this.txtNumero);
            this.panel.Controls.Add(this.lblInstruccion);
            this.panel.Controls.Add(this.lblTitulo);

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(100, 200, 255);
            this.lblTitulo.Location = new System.Drawing.Point(40, 30);
            this.lblTitulo.Text = "¡Factorial!";

            // lblInstruccion
            this.lblInstruccion.AutoSize = true;
            this.lblInstruccion.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblInstruccion.Location = new System.Drawing.Point(40, 110);
            this.lblInstruccion.Text = "Ingrese un número entero positivo:";

            // txtNumero
            this.txtNumero.Location = new System.Drawing.Point(40, 150);
            this.txtNumero.Size = new System.Drawing.Size(520, 55);
            this.txtNumero.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.txtNumero.BackColor = System.Drawing.Color.FromArgb(50, 55, 80);
            this.txtNumero.ForeColor = System.Drawing.Color.White;
            this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);

            // btnCalcular
            this.btnCalcular.Location = new System.Drawing.Point(40, 230);
            this.btnCalcular.Size = new System.Drawing.Size(250, 80);
            this.btnCalcular.Text = "CALCULAR FACTORIAL";
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(0, 170, 100);
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            // btnLimpiar
            this.btnLimpiar.Location = new System.Drawing.Point(310, 230);
            this.btnLimpiar.Size = new System.Drawing.Size(250, 80);
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(200, 60, 60);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            // rtbProceso
            this.rtbProceso.Location = new System.Drawing.Point(40, 340);
            this.rtbProceso.Size = new System.Drawing.Size(520, 120);
            this.rtbProceso.BackColor = System.Drawing.Color.FromArgb(35, 40, 65);
            this.rtbProceso.ForeColor = System.Drawing.Color.LightCyan;
            this.rtbProceso.Font = new System.Drawing.Font("Consolas", 16F);
            this.rtbProceso.ReadOnly = true;
            this.rtbProceso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbProceso.WordWrap = false;

            // lblResultado
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblResultado.ForeColor = System.Drawing.Color.Gold;
            this.lblResultado.Location = new System.Drawing.Point(40, 480);
            this.lblResultado.Text = "1";

            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
        }

        private TextBox txtNumero;
        private Button btnCalcular;
        private Button btnLimpiar;
        private RichTextBox rtbProceso;
        private Label lblTitulo;
        private Label lblInstruccion;
        private Label lblResultado;
        private Panel panel;
    }
}
