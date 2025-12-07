namespace EcuacionCuadratica
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
            txtA = new TextBox();
            txtB = new TextBox();
            txtC = new TextBox();
            lblA = new Label();
            lblB = new Label();
            lblC = new Label();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            rtbResultado = new RichTextBox();
            lblTitulo = new Label();
            lblEstado = new Label();
            panel = new Panel();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // txtA
            // 
            txtA.BackColor = Color.FromArgb(40, 45, 70);
            txtA.Font = new Font("Segoe UI", 16F);
            txtA.ForeColor = Color.White;
            txtA.Location = new Point(312, 112);
            txtA.Name = "txtA";
            txtA.Size = new Size(300, 50);
            txtA.TabIndex = 9;
            txtA.TextAlign = HorizontalAlignment.Center;
            txtA.KeyPress += txtCoef_KeyPress;
            // 
            // txtB
            // 
            txtB.BackColor = Color.FromArgb(40, 45, 70);
            txtB.Font = new Font("Segoe UI", 16F);
            txtB.ForeColor = Color.White;
            txtB.Location = new Point(312, 168);
            txtB.Name = "txtB";
            txtB.Size = new Size(300, 50);
            txtB.TabIndex = 7;
            txtB.TextAlign = HorizontalAlignment.Center;
            txtB.KeyPress += txtCoef_KeyPress;
            // 
            // txtC
            // 
            txtC.BackColor = Color.FromArgb(40, 45, 70);
            txtC.Font = new Font("Segoe UI", 16F);
            txtC.ForeColor = Color.White;
            txtC.Location = new Point(312, 224);
            txtC.Name = "txtC";
            txtC.Size = new Size(300, 50);
            txtC.TabIndex = 5;
            txtC.TextAlign = HorizontalAlignment.Center;
            txtC.KeyPress += txtCoef_KeyPress;
            // 
            // lblA
            // 
            lblA.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblA.ForeColor = Color.Cyan;
            lblA.Location = new Point(40, 117);
            lblA.Name = "lblA";
            lblA.Size = new Size(201, 60);
            lblA.TabIndex = 8;
            lblA.Text = "Coeficiente a:";
            // 
            // lblB
            // 
            lblB.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblB.ForeColor = Color.Cyan;
            lblB.Location = new Point(55, 172);
            lblB.Name = "lblB";
            lblB.Size = new Size(214, 52);
            lblB.TabIndex = 6;
            lblB.Text = "Coeficiente b:";
            // 
            // lblC
            // 
            lblC.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblC.ForeColor = Color.Cyan;
            lblC.Location = new Point(58, 232);
            lblC.Name = "lblC";
            lblC.Size = new Size(206, 42);
            lblC.TabIndex = 4;
            lblC.Text = "Coeficiente c:";
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(0, 170, 120);
            btnCalcular.FlatAppearance.BorderSize = 0;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnCalcular.ForeColor = Color.White;
            btnCalcular.Location = new Point(40, 320);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(230, 70);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(200, 60, 60);
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(290, 320);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(230, 70);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // rtbResultado
            // 
            rtbResultado.BackColor = Color.FromArgb(30, 35, 60);
            rtbResultado.BorderStyle = BorderStyle.FixedSingle;
            rtbResultado.Font = new Font("Consolas", 14F);
            rtbResultado.ForeColor = Color.LightCyan;
            rtbResultado.Location = new Point(40, 420);
            rtbResultado.Name = "rtbResultado";
            rtbResultado.ReadOnly = true;
            rtbResultado.Size = new Size(700, 160);
            rtbResultado.TabIndex = 1;
            rtbResultado.Text = "";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(100, 200, 255);
            lblTitulo.Location = new Point(40, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(329, 74);
            lblTitulo.TabIndex = 10;
            lblTitulo.Text = "Ejercicio 18";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblEstado.ForeColor = Color.Gray;
            lblEstado.Location = new Point(40, 590);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(167, 28);
            lblEstado.TabIndex = 0;
            lblEstado.Text = "Esperando datos...";
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(20, 25, 50);
            panel.Controls.Add(lblEstado);
            panel.Controls.Add(rtbResultado);
            panel.Controls.Add(btnLimpiar);
            panel.Controls.Add(btnCalcular);
            panel.Controls.Add(lblC);
            panel.Controls.Add(txtC);
            panel.Controls.Add(lblB);
            panel.Controls.Add(txtB);
            panel.Controls.Add(lblA);
            panel.Controls.Add(txtA);
            panel.Controls.Add(lblTitulo);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Padding = new Padding(40);
            panel.Size = new Size(780, 620);
            panel.TabIndex = 0;
            // 
            // Form1
            // 
            BackColor = Color.FromArgb(15, 20, 40);
            ClientSize = new Size(780, 620);
            Controls.Add(panel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 18 - Soluciones de la Ecuación Cuadrática";
            Load += Form1_Load;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtC;
        private Label lblA;
        private Label lblB;
        private Label lblC;
        private Button btnCalcular;
        private Button btnLimpiar;
        private RichTextBox rtbResultado;
        private Label lblTitulo;
        private Label lblEstado;
        private Panel panel;
    }
}

