namespace Ejercicio21_CalculadoraHastaCero
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
            btnCalcular = new Button();
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
            txtNum1.Font = new Font("Segoe UI", 24F);
            txtNum1.ForeColor = Color.White;
            txtNum1.Location = new Point(30, 160);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(720, 71);
            txtNum1.TabIndex = 5;
            txtNum1.TextAlign = HorizontalAlignment.Center;
            txtNum1.KeyPress += txtNum_KeyPress;
            // 
            // txtNum2
            // 
            txtNum2.BackColor = Color.FromArgb(40, 45, 70);
            txtNum2.Font = new Font("Segoe UI", 24F);
            txtNum2.ForeColor = Color.White;
            txtNum2.Location = new Point(30, 240);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(720, 71);
            txtNum2.TabIndex = 4;
            txtNum2.TextAlign = HorizontalAlignment.Center;
            txtNum2.KeyPress += txtNum_KeyPress;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(0, 170, 120);
            btnCalcular.FlatAppearance.BorderSize = 0;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnCalcular.ForeColor = Color.White;
            btnCalcular.Location = new Point(30, 320);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(520, 90);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "CALCULAR OPERACIONES";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnReiniciar
            // 
            btnReiniciar.BackColor = Color.FromArgb(200, 60, 60);
            btnReiniciar.FlatAppearance.BorderSize = 0;
            btnReiniciar.FlatStyle = FlatStyle.Flat;
            btnReiniciar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnReiniciar.ForeColor = Color.White;
            btnReiniciar.Location = new Point(570, 320);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(180, 90);
            btnReiniciar.TabIndex = 2;
            btnReiniciar.Text = "REINICIAR";
            btnReiniciar.UseVisualStyleBackColor = false;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // rtbResultado
            // 
            rtbResultado.BackColor = Color.FromArgb(30, 35, 60);
            rtbResultado.BorderStyle = BorderStyle.FixedSingle;
            rtbResultado.Font = new Font("Consolas", 15F);
            rtbResultado.ForeColor = Color.LightCyan;
            rtbResultado.Location = new Point(30, 430);
            rtbResultado.Name = "rtbResultado";
            rtbResultado.ReadOnly = true;
            rtbResultado.Size = new Size(740, 160);
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
            lblTitulo.Size = new Size(308, 70);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "Ejercicio 21";
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblContador.ForeColor = Color.Cyan;
            lblContador.Location = new Point(30, 100);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(264, 48);
            lblContador.TabIndex = 0;
            lblContador.Text = "PROCESO N° 1";
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(20, 25, 45);
            panel.Controls.Add(lblContador);
            panel.Controls.Add(rtbResultado);
            panel.Controls.Add(btnReiniciar);
            panel.Controls.Add(btnCalcular);
            panel.Controls.Add(txtNum2);
            panel.Controls.Add(txtNum1);
            panel.Controls.Add(lblTitulo);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Padding = new Padding(30);
            panel.Size = new Size(912, 620);
            panel.TabIndex = 0;
            // 
            // Form1
            // 
            BackColor = Color.FromArgb(10, 15, 35);
            ClientSize = new Size(912, 620);
            Controls.Add(panel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 21 - Calculadora (hasta primer número 0)";
            Load += Form1_Load;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.RichTextBox rtbResultado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Panel panel;
    }
}