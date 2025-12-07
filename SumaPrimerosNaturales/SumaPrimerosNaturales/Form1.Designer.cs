namespace SumaPrimerosNaturales
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
            txtN = new TextBox();
            lblTitulo = new Label();
            lblInstruccion = new Label();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            rtbProceso = new RichTextBox();
            lblResultado = new Label();
            lblSuma = new Label();
            panel = new Panel();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // txtN
            // 
            txtN.BackColor = Color.FromArgb(50, 50, 80);
            txtN.BorderStyle = BorderStyle.FixedSingle;
            txtN.Font = new Font("Segoe UI", 18F);
            txtN.ForeColor = Color.White;
            txtN.Location = new Point(40, 140);
            txtN.Name = "txtN";
            txtN.Size = new Size(520, 55);
            txtN.TabIndex = 5;
            txtN.TextAlign = HorizontalAlignment.Center;
            txtN.KeyPress += txtN_KeyPress;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(100, 200, 255);
            lblTitulo.Location = new Point(40, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(613, 70);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "Suma 1 + 2 + 3 + ... + N";
            // 
            // lblInstruccion
            // 
            lblInstruccion.AutoSize = true;
            lblInstruccion.Font = new Font("Segoe UI", 12F);
            lblInstruccion.Location = new Point(40, 110);
            lblInstruccion.Name = "lblInstruccion";
            lblInstruccion.Size = new Size(241, 32);
            lblInstruccion.TabIndex = 6;
            lblInstruccion.Text = "Ingrese el valor de N:";
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(0, 170, 130);
            btnCalcular.FlatAppearance.BorderSize = 0;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnCalcular.ForeColor = Color.White;
            btnCalcular.Location = new Point(40, 210);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(250, 70);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "CALCULAR SUMA";
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
            btnLimpiar.Location = new Point(310, 210);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(250, 70);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // rtbProceso
            // 
            rtbProceso.BackColor = Color.FromArgb(40, 40, 60);
            rtbProceso.BorderStyle = BorderStyle.FixedSingle;
            rtbProceso.Font = new Font("Consolas", 11F);
            rtbProceso.ForeColor = Color.LightGreen;
            rtbProceso.Location = new Point(40, 300);
            rtbProceso.Name = "rtbProceso";
            rtbProceso.ReadOnly = true;
            rtbProceso.Size = new Size(520, 150);
            rtbProceso.TabIndex = 2;
            rtbProceso.Text = "";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 14F);
            lblResultado.Location = new Point(12, 469);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(483, 38);
            lblResultado.TabIndex = 1;
            lblResultado.Text = "Ingrese un valor para calcular la suma";
            // 
            // lblSuma
            // 
            lblSuma.AutoSize = true;
            lblSuma.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblSuma.ForeColor = Color.Gold;
            lblSuma.Location = new Point(588, 460);
            lblSuma.Name = "lblSuma";
            lblSuma.Size = new Size(64, 74);
            lblSuma.TabIndex = 0;
            lblSuma.Text = "0";
            lblSuma.Click += lblSuma_Click;
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(30, 30, 50);
            panel.Controls.Add(lblSuma);
            panel.Controls.Add(lblResultado);
            panel.Controls.Add(rtbProceso);
            panel.Controls.Add(btnLimpiar);
            panel.Controls.Add(btnCalcular);
            panel.Controls.Add(txtN);
            panel.Controls.Add(lblInstruccion);
            panel.Controls.Add(lblTitulo);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Padding = new Padding(40);
            panel.Size = new Size(730, 560);
            panel.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 35);
            ClientSize = new Size(730, 560);
            Controls.Add(panel);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 06 - Suma de los N primeros números naturales";
            Load += Form1_Load;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        private TextBox txtN;
        private Label lblTitulo;
        private Label lblInstruccion;
        private Button btnCalcular;
        private Button btnLimpiar;
        private RichTextBox rtbProceso;
        private Label lblResultado;
        private Label lblSuma;
        private Panel panel;
    }
}