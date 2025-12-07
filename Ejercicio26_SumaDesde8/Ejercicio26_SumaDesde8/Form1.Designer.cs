namespace Ejercicio26_SumaDesde8
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
            txtNumero = new TextBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            rtbSerie = new RichTextBox();
            lblTitulo = new Label();
            lblInstruccion = new Label();
            lblResultado = new Label();
            lblEstado = new Label();
            panel = new Panel();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // txtNumero
            // 
            txtNumero.BackColor = Color.FromArgb(40, 45, 70);
            txtNumero.Font = new Font("Segoe UI", 36F);
            txtNumero.ForeColor = Color.White;
            txtNumero.Location = new Point(30, 150);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(840, 103);
            txtNumero.TabIndex = 6;
            txtNumero.TextAlign = HorizontalAlignment.Center;
            txtNumero.KeyPress += txtNumero_KeyPress;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(0, 170, 120);
            btnCalcular.FlatAppearance.BorderSize = 0;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            btnCalcular.ForeColor = Color.White;
            btnCalcular.Location = new Point(30, 260);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(620, 100);
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
            btnLimpiar.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(670, 260);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(200, 100);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // rtbSerie
            // 
            rtbSerie.BackColor = Color.FromArgb(30, 35, 60);
            rtbSerie.BorderStyle = BorderStyle.FixedSingle;
            rtbSerie.Font = new Font("Consolas", 18F);
            rtbSerie.ForeColor = Color.LightCyan;
            rtbSerie.Location = new Point(30, 380);
            rtbSerie.Name = "rtbSerie";
            rtbSerie.ReadOnly = true;
            rtbSerie.Size = new Size(840, 140);
            rtbSerie.TabIndex = 2;
            rtbSerie.Text = "";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(100, 200, 255);
            lblTitulo.Location = new Point(30, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(745, 74);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "Ejercicio 26 - Suma desde 8";
            // 
            // lblInstruccion
            // 
            lblInstruccion.AutoSize = true;
            lblInstruccion.Font = new Font("Segoe UI", 16F);
            lblInstruccion.ForeColor = Color.LightGray;
            lblInstruccion.Location = new Point(30, 100);
            lblInstruccion.Name = "lblInstruccion";
            lblInstruccion.Size = new Size(597, 45);
            lblInstruccion.TabIndex = 5;
            lblInstruccion.Text = "Ingrese el número final N (debe ser ≥ 8):";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblResultado.ForeColor = Color.Gray;
            lblResultado.Location = new Point(30, 540);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(602, 60);
            lblResultado.TabIndex = 1;
            lblResultado.Text = "La suma será mostrada aquí";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            lblEstado.ForeColor = Color.Gray;
            lblEstado.Location = new Point(30, 590);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(252, 32);
            lblEstado.TabIndex = 0;
            lblEstado.Text = "Ingrese un número ≥ 8";
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(15, 20, 40);
            panel.Controls.Add(lblEstado);
            panel.Controls.Add(lblResultado);
            panel.Controls.Add(rtbSerie);
            panel.Controls.Add(btnLimpiar);
            panel.Controls.Add(btnCalcular);
            panel.Controls.Add(lblInstruccion);
            panel.Controls.Add(txtNumero);
            panel.Controls.Add(lblTitulo);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Padding = new Padding(30);
            panel.Size = new Size(973, 640);
            panel.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 30);
            ClientSize = new Size(973, 640);
            Controls.Add(panel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 26 - Suma desde 8 hasta N";
            Load += Form1_Load;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.RichTextBox rtbSerie;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblInstruccion;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Panel panel;
    }
}