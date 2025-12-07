namespace CalculoSalario
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
            txtHoras = new TextBox();
            txtTarifa = new TextBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            lblTitulo = new Label();
            lblHoras = new Label();
            lblTarifa = new Label();
            lblResultado = new Label();
            lblSalario = new Label();
            panel = new Panel();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // txtHoras
            // 
            txtHoras.BackColor = Color.FromArgb(50, 55, 80);
            txtHoras.BorderStyle = BorderStyle.FixedSingle;
            txtHoras.Font = new Font("Segoe UI", 16F);
            txtHoras.ForeColor = Color.White;
            txtHoras.Location = new Point(40, 157);
            txtHoras.Name = "txtHoras";
            txtHoras.Size = new Size(420, 50);
            txtHoras.TabIndex = 7;
            txtHoras.TextAlign = HorizontalAlignment.Center;
            txtHoras.KeyPress += txtHoras_KeyPress;
            // 
            // txtTarifa
            // 
            txtTarifa.BackColor = Color.FromArgb(50, 55, 80);
            txtTarifa.BorderStyle = BorderStyle.FixedSingle;
            txtTarifa.Font = new Font("Segoe UI", 16F);
            txtTarifa.ForeColor = Color.White;
            txtTarifa.Location = new Point(40, 254);
            txtTarifa.Name = "txtTarifa";
            txtTarifa.Size = new Size(420, 50);
            txtTarifa.TabIndex = 5;
            txtTarifa.TextAlign = HorizontalAlignment.Center;
            txtTarifa.KeyPress += txtTarifa_KeyPress;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(0, 170, 100);
            btnCalcular.FlatAppearance.BorderSize = 0;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnCalcular.ForeColor = Color.White;
            btnCalcular.Location = new Point(40, 310);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(200, 60);
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
            btnLimpiar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(260, 310);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(200, 60);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(100, 200, 255);
            lblTitulo.Location = new Point(40, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(498, 74);
            lblTitulo.TabIndex = 8;
            lblTitulo.Text = "Cálculo de Salario";
            // 
            // lblHoras
            // 
            lblHoras.AutoSize = true;
            lblHoras.Font = new Font("Segoe UI", 12F);
            lblHoras.Location = new Point(40, 120);
            lblHoras.Name = "lblHoras";
            lblHoras.Size = new Size(195, 32);
            lblHoras.TabIndex = 6;
            lblHoras.Text = "Horas trabajadas:";
            // 
            // lblTarifa
            // 
            lblTarifa.AutoSize = true;
            lblTarifa.Font = new Font("Segoe UI", 12F);
            lblTarifa.Location = new Point(40, 210);
            lblTarifa.Name = "lblTarifa";
            lblTarifa.Size = new Size(207, 32);
            lblTarifa.TabIndex = 4;
            lblTarifa.Text = "Tarifa por hora ($):";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblResultado.Location = new Point(40, 390);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(425, 45);
            lblResultado.TabIndex = 1;
            lblResultado.Text = "El salario del trabajador es:";
            // 
            // lblSalario
            // 
            lblSalario.AutoSize = true;
            lblSalario.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            lblSalario.ForeColor = Color.Gold;
            lblSalario.Location = new Point(498, 371);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(202, 86);
            lblSalario.TabIndex = 0;
            lblSalario.Text = "$0.00";
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(30, 35, 55);
            panel.Controls.Add(lblSalario);
            panel.Controls.Add(lblResultado);
            panel.Controls.Add(btnLimpiar);
            panel.Controls.Add(btnCalcular);
            panel.Controls.Add(lblTarifa);
            panel.Controls.Add(txtTarifa);
            panel.Controls.Add(lblHoras);
            panel.Controls.Add(txtHoras);
            panel.Controls.Add(lblTitulo);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Padding = new Padding(40);
            panel.Size = new Size(725, 487);
            panel.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 25, 40);
            ClientSize = new Size(725, 487);
            Controls.Add(panel);
            Font = new Font("Segoe UI", 11F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 08 - Cálculo de Salario";
            Load += Form1_Load;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        private TextBox txtHoras;
        private TextBox txtTarifa;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Label lblTitulo;
        private Label lblHoras;
        private Label lblTarifa;
        private Label lblResultado;
        private Label lblSalario;
        private Panel panel;
    }
}