namespace SumaDigitos
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
            txtNumero = new TextBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            rtbProceso = new RichTextBox();
            lblTitulo = new Label();
            lblInstruccion = new Label();
            lblResultado = new Label();
            lblSuma = new Label();
            panel = new Panel();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // txtNumero
            // 
            txtNumero.BackColor = Color.FromArgb(50, 55, 80);
            txtNumero.BorderStyle = BorderStyle.FixedSingle;
            txtNumero.Font = new Font("Segoe UI", 18F);
            txtNumero.ForeColor = Color.White;
            txtNumero.Location = new Point(40, 130);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(480, 55);
            txtNumero.TabIndex = 5;
            txtNumero.TextAlign = HorizontalAlignment.Center;
            txtNumero.KeyPress += txtNumero_KeyPress;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(0, 170, 120);
            btnCalcular.FlatAppearance.BorderSize = 0;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnCalcular.ForeColor = Color.White;
            btnCalcular.Location = new Point(40, 200);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(230, 70);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(200, 60, 60);
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(290, 200);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(230, 70);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // rtbProceso
            // 
            rtbProceso.BackColor = Color.FromArgb(40, 45, 65);
            rtbProceso.BorderStyle = BorderStyle.FixedSingle;
            rtbProceso.Font = new Font("Consolas", 12F);
            rtbProceso.ForeColor = Color.LightCyan;
            rtbProceso.Location = new Point(40, 290);
            rtbProceso.Name = "rtbProceso";
            rtbProceso.ReadOnly = true;
            rtbProceso.Size = new Size(480, 130);
            rtbProceso.TabIndex = 2;
            rtbProceso.Text = "";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(100, 200, 255);
            lblTitulo.Location = new Point(40, 26);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(462, 74);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "Suma de Dígitos";
            // 
            // lblInstruccion
            // 
            lblInstruccion.AutoSize = true;
            lblInstruccion.Font = new Font("Segoe UI", 12F);
            lblInstruccion.Location = new Point(40, 100);
            lblInstruccion.Name = "lblInstruccion";
            lblInstruccion.Size = new Size(391, 32);
            lblInstruccion.TabIndex = 6;
            lblInstruccion.Text = "Ingrese un número entero positivo:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 14F);
            lblResultado.Location = new Point(40, 440);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(698, 38);
            lblResultado.TabIndex = 1;
            lblResultado.Text = "Ingrese un número para calcular la suma de sus dígitos";
            // 
            // lblSuma
            // 
            lblSuma.AutoSize = true;
            lblSuma.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblSuma.ForeColor = Color.Gold;
            lblSuma.Location = new Point(754, 414);
            lblSuma.Name = "lblSuma";
            lblSuma.Size = new Size(81, 96);
            lblSuma.TabIndex = 0;
            lblSuma.Text = "0";
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(25, 30, 50);
            panel.Controls.Add(lblSuma);
            panel.Controls.Add(lblResultado);
            panel.Controls.Add(rtbProceso);
            panel.Controls.Add(btnLimpiar);
            panel.Controls.Add(btnCalcular);
            panel.Controls.Add(txtNumero);
            panel.Controls.Add(lblInstruccion);
            panel.Controls.Add(lblTitulo);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Padding = new Padding(40);
            panel.Size = new Size(916, 540);
            panel.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 20, 35);
            ClientSize = new Size(916, 540);
            Controls.Add(panel);
            Font = new Font("Segoe UI", 11F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 10 - Suma de Dígitos";
            Load += Form1_Load;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        private TextBox txtNumero;
        private Button btnCalcular;
        private Button btnLimpiar;
        private RichTextBox rtbProceso;
        private Label lblTitulo;
        private Label lblInstruccion;
        private Label lblResultado;
        private Label lblSuma;
        private Panel panel;
    }
}
