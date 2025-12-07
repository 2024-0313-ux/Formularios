namespace Ejercicio24_CirculoEsfera
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
            txtRadio = new TextBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            rtbResultado = new RichTextBox();
            lblTitulo = new Label();
            lblEstado = new Label();
            panel = new Panel();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // txtRadio
            // 
            txtRadio.BackColor = Color.FromArgb(40, 45, 70);
            txtRadio.Font = new Font("Segoe UI", 32F);
            txtRadio.ForeColor = Color.White;
            txtRadio.Location = new Point(40, 140);
            txtRadio.Name = "txtRadio";
            txtRadio.Size = new Size(720, 93);
            txtRadio.TabIndex = 4;
            txtRadio.TextAlign = HorizontalAlignment.Center;
            txtRadio.KeyPress += txtRadio_KeyPress;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(0, 170, 120);
            btnCalcular.FlatAppearance.BorderSize = 0;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            btnCalcular.ForeColor = Color.White;
            btnCalcular.Location = new Point(40, 260);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(560, 100);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "CALCULAR TODO";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(200, 60, 60);
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(620, 260);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(175, 100);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // rtbResultado
            // 
            rtbResultado.BackColor = Color.FromArgb(30, 35, 60);
            rtbResultado.BorderStyle = BorderStyle.FixedSingle;
            rtbResultado.Font = new Font("Consolas", 15F);
            rtbResultado.ForeColor = Color.LightCyan;
            rtbResultado.Location = new Point(40, 380);
            rtbResultado.Name = "rtbResultado";
            rtbResultado.ReadOnly = true;
            rtbResultado.Size = new Size(720, 220);
            rtbResultado.TabIndex = 1;
            rtbResultado.Text = "";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(100, 200, 255);
            lblTitulo.Location = new Point(40, 40);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(308, 70);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "Ejercicio 24";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            lblEstado.ForeColor = Color.Gray;
            lblEstado.Location = new Point(40, 620);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(174, 32);
            lblEstado.TabIndex = 0;
            lblEstado.Text = "Ingrese el radio";
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(20, 25, 45);
            panel.Controls.Add(lblEstado);
            panel.Controls.Add(rtbResultado);
            panel.Controls.Add(btnLimpiar);
            panel.Controls.Add(btnCalcular);
            panel.Controls.Add(txtRadio);
            panel.Controls.Add(lblTitulo);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Padding = new Padding(40);
            panel.Size = new Size(881, 660);
            panel.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 15, 35);
            ClientSize = new Size(881, 660);
            Controls.Add(panel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 24 - Circunferencia, Círculo y Esfera";
            Load += Form1_Load;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.RichTextBox rtbResultado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Panel panel;
    }
}