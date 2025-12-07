namespace Ejercicio19_Calculadora10Veces
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
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            lblNum1 = new Label();
            lblNum2 = new Label();
            btnSiguiente = new Button();
            btnReiniciar = new Button();
            rtbResultado = new RichTextBox();
            lblTitulo = new Label();
            lblContador = new Label();
            panel = new Panel();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // txtNum1
            // 
            txtNum1.BackColor = Color.FromArgb(40, 45, 70);
            txtNum1.Font = new Font("Segoe UI", 18F);
            txtNum1.ForeColor = Color.White;
            txtNum1.Location = new Point(30, 190);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(350, 55);
            txtNum1.TabIndex = 7;
            txtNum1.TextAlign = HorizontalAlignment.Center;
            txtNum1.KeyPress += txtNum_KeyPress;
            // 
            // txtNum2
            // 
            txtNum2.BackColor = Color.FromArgb(40, 45, 70);
            txtNum2.Font = new Font("Segoe UI", 18F);
            txtNum2.ForeColor = Color.White;
            txtNum2.Location = new Point(30, 290);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(350, 55);
            txtNum2.TabIndex = 5;
            txtNum2.TextAlign = HorizontalAlignment.Center;
            txtNum2.KeyPress += txtNum_KeyPress;
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Font = new Font("Segoe UI", 14F);
            lblNum1.ForeColor = Color.LightGray;
            lblNum1.Location = new Point(33, 145);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(339, 38);
            lblNum1.TabIndex = 6;
            lblNum1.Text = "Ingrese el primer número:";
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Font = new Font("Segoe UI", 14F);
            lblNum2.ForeColor = Color.LightGray;
            lblNum2.Location = new Point(16, 248);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(364, 38);
            lblNum2.TabIndex = 4;
            lblNum2.Text = "Ingrese el segundo número:";
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackColor = Color.FromArgb(0, 170, 120);
            btnSiguiente.FlatAppearance.BorderSize = 0;
            btnSiguiente.FlatStyle = FlatStyle.Flat;
            btnSiguiente.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnSiguiente.ForeColor = Color.White;
            btnSiguiente.Location = new Point(30, 370);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(350, 70);
            btnSiguiente.TabIndex = 3;
            btnSiguiente.Text = "SIGUIENTE PROCESO";
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnReiniciar
            // 
            btnReiniciar.BackColor = Color.FromArgb(200, 60, 60);
            btnReiniciar.FlatAppearance.BorderSize = 0;
            btnReiniciar.FlatStyle = FlatStyle.Flat;
            btnReiniciar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnReiniciar.ForeColor = Color.White;
            btnReiniciar.Location = new Point(400, 370);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(150, 70);
            btnReiniciar.TabIndex = 2;
            btnReiniciar.Text = "REINICIAR";
            btnReiniciar.UseVisualStyleBackColor = false;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // rtbResultado
            // 
            rtbResultado.BackColor = Color.FromArgb(30, 35, 60);
            rtbResultado.BorderStyle = BorderStyle.FixedSingle;
            rtbResultado.Font = new Font("Consolas", 14F);
            rtbResultado.ForeColor = Color.LightCyan;
            rtbResultado.Location = new Point(30, 460);
            rtbResultado.Name = "rtbResultado";
            rtbResultado.ReadOnly = true;
            rtbResultado.Size = new Size(740, 140);
            rtbResultado.TabIndex = 1;
            rtbResultado.Text = "";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(100, 200, 255);
            lblTitulo.Location = new Point(30, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(647, 70);
            lblTitulo.TabIndex = 8;
            lblTitulo.Text = "Ejercicio 19 - 10 Procesos";
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblContador.ForeColor = Color.Cyan;
            lblContador.Location = new Point(30, 100);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(328, 45);
            lblContador.TabIndex = 0;
            lblContador.Text = "PROCESO N° 1 de 10";
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(20, 25, 45);
            panel.Controls.Add(lblContador);
            panel.Controls.Add(rtbResultado);
            panel.Controls.Add(btnReiniciar);
            panel.Controls.Add(btnSiguiente);
            panel.Controls.Add(lblNum2);
            panel.Controls.Add(txtNum2);
            panel.Controls.Add(lblNum1);
            panel.Controls.Add(txtNum1);
            panel.Controls.Add(lblTitulo);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Padding = new Padding(30);
            panel.Size = new Size(800, 620);
            panel.TabIndex = 0;
            // 
            // Form1
            // 
            BackColor = Color.FromArgb(10, 15, 35);
            ClientSize = new Size(800, 620);
            Controls.Add(panel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 19 - Calculadora 10 Procesos";
            Load += Form1_Load;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.RichTextBox rtbResultado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Panel panel;
    }
}