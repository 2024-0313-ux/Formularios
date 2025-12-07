namespace SegundosAMinutos
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
            txtSegundos = new TextBox();
            lblTitulo = new Label();
            lblInstruccion = new Label();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            lblResultado = new Label();
            lblMinutosTitulo = new Label();
            lblMinutos = new Label();
            lblFaltanTitulo = new Label();
            lblFaltan = new Label();
            panel = new Panel();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // txtSegundos
            // 
            txtSegundos.BackColor = Color.FromArgb(55, 55, 80);
            txtSegundos.BorderStyle = BorderStyle.FixedSingle;
            txtSegundos.Font = new Font("Segoe UI", 16F);
            txtSegundos.ForeColor = Color.White;
            txtSegundos.Location = new Point(40, 130);
            txtSegundos.Name = "txtSegundos";
            txtSegundos.Size = new Size(440, 50);
            txtSegundos.TabIndex = 7;
            txtSegundos.TextAlign = HorizontalAlignment.Center;
            txtSegundos.KeyPress += txtSegundos_KeyPress;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(100, 200, 255);
            lblTitulo.Location = new Point(40, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(503, 65);
            lblTitulo.TabIndex = 9;
            lblTitulo.Text = "Segundos → Minutos";
            // 
            // lblInstruccion
            // 
            lblInstruccion.AutoSize = true;
            lblInstruccion.Font = new Font("Segoe UI", 11F);
            lblInstruccion.Location = new Point(40, 100);
            lblInstruccion.Name = "lblInstruccion";
            lblInstruccion.Size = new Size(317, 30);
            lblInstruccion.TabIndex = 8;
            lblInstruccion.Text = "Ingrese el tiempo en segundos:";
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(0, 170, 120);
            btnCalcular.FlatAppearance.BorderSize = 0;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCalcular.ForeColor = Color.White;
            btnCalcular.Location = new Point(40, 200);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(200, 60);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(200, 70, 70);
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(280, 200);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(200, 60);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 13F);
            lblResultado.ForeColor = Color.LightCyan;
            lblResultado.Location = new Point(40, 290);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(349, 36);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "Ingrese un valor para calcular";
            // 
            // lblMinutosTitulo
            // 
            lblMinutosTitulo.AutoSize = true;
            lblMinutosTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMinutosTitulo.Location = new Point(40, 340);
            lblMinutosTitulo.Name = "lblMinutosTitulo";
            lblMinutosTitulo.Size = new Size(242, 32);
            lblMinutosTitulo.TabIndex = 3;
            lblMinutosTitulo.Text = "Minutos completos:";
            // 
            // lblMinutos
            // 
            lblMinutos.AutoSize = true;
            lblMinutos.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblMinutos.ForeColor = Color.Lime;
            lblMinutos.Location = new Point(260, 335);
            lblMinutos.Name = "lblMinutos";
            lblMinutos.Size = new Size(50, 48);
            lblMinutos.TabIndex = 2;
            lblMinutos.Text = "--";
            // 
            // lblFaltanTitulo
            // 
            lblFaltanTitulo.AutoSize = true;
            lblFaltanTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblFaltanTitulo.Location = new Point(40, 380);
            lblFaltanTitulo.Name = "lblFaltanTitulo";
            lblFaltanTitulo.Size = new Size(365, 32);
            lblFaltanTitulo.TabIndex = 1;
            lblFaltanTitulo.Text = "Para el próximo minuto faltan:";
            // 
            // lblFaltan
            // 
            lblFaltan.AutoSize = true;
            lblFaltan.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblFaltan.ForeColor = Color.Orange;
            lblFaltan.Location = new Point(398, 367);
            lblFaltan.Name = "lblFaltan";
            lblFaltan.Size = new Size(50, 48);
            lblFaltan.TabIndex = 0;
            lblFaltan.Text = "--";
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(35, 35, 55);
            panel.Controls.Add(lblFaltan);
            panel.Controls.Add(lblFaltanTitulo);
            panel.Controls.Add(lblMinutos);
            panel.Controls.Add(lblMinutosTitulo);
            panel.Controls.Add(lblResultado);
            panel.Controls.Add(btnLimpiar);
            panel.Controls.Add(btnCalcular);
            panel.Controls.Add(txtSegundos);
            panel.Controls.Add(lblInstruccion);
            panel.Controls.Add(lblTitulo);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Padding = new Padding(40);
            panel.Size = new Size(520, 440);
            panel.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 40);
            ClientSize = new Size(520, 440);
            Controls.Add(panel);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 04 - Segundos a Minutos";
            Load += Form1_Load;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        private TextBox txtSegundos;
        private Label lblTitulo;
        private Label lblInstruccion;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Label lblResultado;
        private Label lblMinutosTitulo;
        private Label lblMinutos;
        private Label lblFaltanTitulo;
        private Label lblFaltan;
        private Panel panel;
    }
}