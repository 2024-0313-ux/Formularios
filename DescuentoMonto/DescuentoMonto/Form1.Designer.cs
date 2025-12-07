namespace DescuentoMonto
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
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblDescTitulo = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblTotalTitulo = new System.Windows.Forms.Label();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();

            this.panel.SuspendLayout();
            this.SuspendLayout();

            // Form1
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 420);
            this.Controls.Add(this.panel);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 45);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 03 - Descuento por Monto";
            this.Load += new System.EventHandler(this.Form1_Load);

            // panel
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.BackColor = System.Drawing.Color.FromArgb(40, 40, 60);
            this.panel.Padding = new System.Windows.Forms.Padding(40);
            this.panel.Controls.Add(this.lblPorcentaje);
            this.panel.Controls.Add(this.lblTotalPagar);
            this.panel.Controls.Add(this.lblTotalTitulo);
            this.panel.Controls.Add(this.lblDescuento);
            this.panel.Controls.Add(this.lblDescTitulo);
            this.panel.Controls.Add(this.btnLimpiar);
            this.panel.Controls.Add(this.btnCalcular);
            this.panel.Controls.Add(this.txtMonto);
            this.panel.Controls.Add(this.lblMonto);
            this.panel.Controls.Add(this.lblTitulo);

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(100, 200, 255);
            this.lblTitulo.Location = new System.Drawing.Point(40, 30);
            this.lblTitulo.Text = "Calculadora de Descuento";

            // lblMonto
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(40, 110);
            this.lblMonto.Text = "Ingrese el monto:";

            // txtMonto
            this.txtMonto.Location = new System.Drawing.Point(40, 140);
            this.txtMonto.Size = new System.Drawing.Size(420, 40);
            this.txtMonto.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtMonto.BackColor = System.Drawing.Color.FromArgb(55, 55, 75);
            this.txtMonto.ForeColor = System.Drawing.Color.White;
            this.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);

            // btnCalcular
            this.btnCalcular.Location = new System.Drawing.Point(40, 210);
            this.btnCalcular.Size = new System.Drawing.Size(200, 60);
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(0, 170, 90);
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            // btnLimpiar
            this.btnLimpiar.Location = new System.Drawing.Point(260, 210);
            this.btnLimpiar.Size = new System.Drawing.Size(200, 60);
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(180, 60, 60);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            // lblDescTitulo
            this.lblDescTitulo.AutoSize = true;
            this.lblDescTitulo.Location = new System.Drawing.Point(40, 300);
            this.lblDescTitulo.Text = "Descuento aplicado:";

            // lblDescuento
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblDescuento.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblDescuento.Location = new System.Drawing.Point(280, 295);
            this.lblDescuento.Text = "$0.00";

            // lblPorcentaje
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.lblPorcentaje.ForeColor = System.Drawing.Color.Gold;
            this.lblPorcentaje.Location = new System.Drawing.Point(40, 280);
            this.lblPorcentaje.Text = "--";

            // lblTotalTitulo
            this.lblTotalTitulo.AutoSize = true;
            this.lblTotalTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalTitulo.Location = new System.Drawing.Point(40, 340);
            this.lblTotalTitulo.Text = "Total a pagar:";

            // lblTotalPagar
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTotalPagar.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblTotalPagar.Location = new System.Drawing.Point(240, 330);
            this.lblTotalPagar.Text = "$0.00";

            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
        }

        private TextBox txtMonto;
        private Label lblTitulo;
        private Label lblMonto;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Label lblDescTitulo;
        private Label lblDescuento;
        private Label lblTotalTitulo;
        private Label lblTotalPagar;
        private Label lblPorcentaje;
        private Panel panel;
    }
}