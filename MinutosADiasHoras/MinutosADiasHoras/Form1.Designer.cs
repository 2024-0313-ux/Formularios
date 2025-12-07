namespace MinutosADiasHoras
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
            txtMinutos = new TextBox();
            lblTitulo = new Label();
            lblInstruccion = new Label();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            lblResultado = new Label();
            lblDiasTitulo = new Label();
            lblHorasTitulo = new Label();
            lblMinutosTitulo = new Label();
            lblDias = new Label();
            lblHoras = new Label();
            lblMinutosRestantes = new Label();
            panel = new Panel();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // txtMinutos
            // 
            txtMinutos.BackColor = Color.FromArgb(50, 50, 80);
            txtMinutos.BorderStyle = BorderStyle.FixedSingle;
            txtMinutos.Font = new Font("Segoe UI", 18F);
            txtMinutos.ForeColor = Color.White;
            txtMinutos.Location = new Point(40, 140);
            txtMinutos.Name = "txtMinutos";
            txtMinutos.Size = new Size(480, 55);
            txtMinutos.TabIndex = 9;
            txtMinutos.TextAlign = HorizontalAlignment.Center;
            txtMinutos.KeyPress += txtMinutos_KeyPress;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(100, 200, 255);
            lblTitulo.Location = new Point(40, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(885, 70);
            lblTitulo.TabIndex = 11;
            lblTitulo.Text = "Minutos → Días + Horas + Minutos";
            // 
            // lblInstruccion
            // 
            lblInstruccion.AutoSize = true;
            lblInstruccion.Font = new Font("Segoe UI", 12F);
            lblInstruccion.Location = new Point(40, 110);
            lblInstruccion.Name = "lblInstruccion";
            lblInstruccion.Size = new Size(334, 32);
            lblInstruccion.TabIndex = 10;
            lblInstruccion.Text = "Ingrese el tiempo en minutos:";
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(0, 170, 130);
            btnCalcular.FlatAppearance.BorderSize = 0;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnCalcular.ForeColor = Color.White;
            btnCalcular.Location = new Point(40, 220);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(230, 70);
            btnCalcular.TabIndex = 8;
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
            btnLimpiar.Location = new Point(290, 220);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(230, 70);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 16F);
            lblResultado.ForeColor = Color.LightBlue;
            lblResultado.Location = new Point(40, 320);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(435, 45);
            lblResultado.TabIndex = 6;
            lblResultado.Text = "Ingrese un valor para calcular";
            // 
            // lblDiasTitulo
            // 
            lblDiasTitulo.AutoSize = true;
            lblDiasTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblDiasTitulo.Location = new Point(28, 370);
            lblDiasTitulo.Name = "lblDiasTitulo";
            lblDiasTitulo.Size = new Size(81, 38);
            lblDiasTitulo.TabIndex = 5;
            lblDiasTitulo.Text = "Días:";
            // 
            // lblHorasTitulo
            // 
            lblHorasTitulo.AutoSize = true;
            lblHorasTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblHorasTitulo.Location = new Point(199, 370);
            lblHorasTitulo.Name = "lblHorasTitulo";
            lblHorasTitulo.Size = new Size(101, 38);
            lblHorasTitulo.TabIndex = 4;
            lblHorasTitulo.Text = "Horas:";
            // 
            // lblMinutosTitulo
            // 
            lblMinutosTitulo.AutoSize = true;
            lblMinutosTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblMinutosTitulo.Location = new Point(402, 370);
            lblMinutosTitulo.Name = "lblMinutosTitulo";
            lblMinutosTitulo.Size = new Size(134, 38);
            lblMinutosTitulo.TabIndex = 3;
            lblMinutosTitulo.Text = "Minutos:";
            // 
            // lblDias
            // 
            lblDias.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblDias.ForeColor = Color.IndianRed;
            lblDias.Location = new Point(110, 360);
            lblDias.Name = "lblDias";
            lblDias.Size = new Size(97, 80);
            lblDias.TabIndex = 2;
            lblDias.Text = "0";
            // 
            // lblHoras
            // 
            lblHoras.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblHoras.ForeColor = Color.Gold;
            lblHoras.Location = new Point(292, 360);
            lblHoras.Name = "lblHoras";
            lblHoras.Size = new Size(107, 75);
            lblHoras.TabIndex = 1;
            lblHoras.Text = "0";
            // 
            // lblMinutosRestantes
            // 
            lblMinutosRestantes.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblMinutosRestantes.ForeColor = Color.LimeGreen;
            lblMinutosRestantes.Location = new Point(533, 361);
            lblMinutosRestantes.Name = "lblMinutosRestantes";
            lblMinutosRestantes.Size = new Size(129, 79);
            lblMinutosRestantes.TabIndex = 0;
            lblMinutosRestantes.Text = "0";
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(30, 30, 50);
            panel.Controls.Add(lblMinutosRestantes);
            panel.Controls.Add(lblHoras);
            panel.Controls.Add(lblDias);
            panel.Controls.Add(lblMinutosTitulo);
            panel.Controls.Add(lblHorasTitulo);
            panel.Controls.Add(lblDiasTitulo);
            panel.Controls.Add(lblResultado);
            panel.Controls.Add(btnLimpiar);
            panel.Controls.Add(btnCalcular);
            panel.Controls.Add(txtMinutos);
            panel.Controls.Add(lblInstruccion);
            panel.Controls.Add(lblTitulo);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Padding = new Padding(40);
            panel.Size = new Size(954, 480);
            panel.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 35);
            ClientSize = new Size(954, 480);
            Controls.Add(panel);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 05 - Minutos a Días, Horas y Minutos";
            Load += Form1_Load;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        private TextBox txtMinutos;
        private Label lblTitulo;
        private Label lblInstruccion;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Label lblResultado;
        private Label lblDiasTitulo;
        private Label lblHorasTitulo;
        private Label lblMinutosTitulo;
        private Label lblDias;
        private Label lblHoras;
        private Label lblMinutosRestantes;
        private Panel panel;
    }
}