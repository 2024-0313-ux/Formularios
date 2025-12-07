namespace PromedioNotas
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
            txtNota1 = new TextBox();
            txtNota2 = new TextBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            lblTitulo = new Label();
            lblPromedio = new Label();
            lblResultado = new Label();
            rtbDetalle = new RichTextBox();
            panel = new Panel();
            labelNota2 = new Label();
            labelNota1 = new Label();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // txtNota1
            // 
            txtNota1.BackColor = Color.FromArgb(50, 55, 80);
            txtNota1.BorderStyle = BorderStyle.FixedSingle;
            txtNota1.Font = new Font("Segoe UI", 24F);
            txtNota1.ForeColor = Color.White;
            txtNota1.Location = new Point(40, 136);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(300, 71);
            txtNota1.TabIndex = 8;
            txtNota1.TextAlign = HorizontalAlignment.Center;
            txtNota1.KeyPress += txtNota_KeyPress;
            // 
            // txtNota2
            // 
            txtNota2.BackColor = Color.FromArgb(50, 55, 80);
            txtNota2.BorderStyle = BorderStyle.FixedSingle;
            txtNota2.Font = new Font("Segoe UI", 24F);
            txtNota2.ForeColor = Color.White;
            txtNota2.Location = new Point(40, 241);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(300, 71);
            txtNota2.TabIndex = 7;
            txtNota2.TextAlign = HorizontalAlignment.Center;
            txtNota2.KeyPress += txtNota_KeyPress;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(0, 170, 120);
            btnCalcular.FlatAppearance.BorderSize = 0;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnCalcular.ForeColor = Color.White;
            btnCalcular.Location = new Point(40, 320);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(300, 80);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "CALCULAR PROMEDIO";
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
            btnLimpiar.Location = new Point(360, 323);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(140, 80);
            btnLimpiar.TabIndex = 5;
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
            lblTitulo.Size = new Size(653, 74);
            lblTitulo.TabIndex = 9;
            lblTitulo.Text = "Promedio de Dos Notas";
            // 
            // lblPromedio
            // 
            lblPromedio.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            lblPromedio.ForeColor = Color.Cyan;
            lblPromedio.Location = new Point(360, 104);
            lblPromedio.Name = "lblPromedio";
            lblPromedio.Size = new Size(340, 127);
            lblPromedio.TabIndex = 4;
            lblPromedio.Text = "00.00";
            lblPromedio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblResultado
            // 
            lblResultado.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblResultado.ForeColor = Color.Gray;
            lblResultado.Location = new Point(353, 241);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(340, 79);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "Esperando notas...";
            lblResultado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rtbDetalle
            // 
            rtbDetalle.BackColor = Color.FromArgb(35, 40, 65);
            rtbDetalle.BorderStyle = BorderStyle.FixedSingle;
            rtbDetalle.Font = new Font("Consolas", 16F);
            rtbDetalle.ForeColor = Color.LightCyan;
            rtbDetalle.Location = new Point(40, 420);
            rtbDetalle.Name = "rtbDetalle";
            rtbDetalle.ReadOnly = true;
            rtbDetalle.Size = new Size(660, 120);
            rtbDetalle.TabIndex = 2;
            rtbDetalle.Text = "";
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(20, 25, 45);
            panel.Controls.Add(labelNota2);
            panel.Controls.Add(labelNota1);
            panel.Controls.Add(rtbDetalle);
            panel.Controls.Add(lblResultado);
            panel.Controls.Add(lblPromedio);
            panel.Controls.Add(btnLimpiar);
            panel.Controls.Add(btnCalcular);
            panel.Controls.Add(txtNota2);
            panel.Controls.Add(txtNota1);
            panel.Controls.Add(lblTitulo);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Padding = new Padding(40);
            panel.Size = new Size(780, 560);
            panel.TabIndex = 0;
            // 
            // labelNota2
            // 
            labelNota2.AutoSize = true;
            labelNota2.Font = new Font("Segoe UI", 14F);
            labelNota2.ForeColor = Color.LightGray;
            labelNota2.Location = new Point(40, 200);
            labelNota2.Name = "labelNota2";
            labelNota2.Size = new Size(274, 38);
            labelNota2.TabIndex = 0;
            labelNota2.Text = "Segunda nota (0-20):";
            // 
            // labelNota1
            // 
            labelNota1.AutoSize = true;
            labelNota1.Font = new Font("Segoe UI", 14F);
            labelNota1.ForeColor = Color.LightGray;
            labelNota1.Location = new Point(52, 104);
            labelNota1.Name = "labelNota1";
            labelNota1.Size = new Size(262, 38);
            labelNota1.TabIndex = 1;
            labelNota1.Text = "Primera nota (0-20):";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 15, 30);
            ClientSize = new Size(780, 560);
            Controls.Add(panel);
            Font = new Font("Segoe UI", 11F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 28 - Promedio de Notas";
            Load += Form1_Load;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        private TextBox txtNota1;
        private TextBox txtNota2;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Label lblTitulo;
        private Label lblPromedio;
        private Label lblResultado;
        private RichTextBox rtbDetalle;
        private Panel panel;
        private Label labelNota1;
        private Label labelNota2;
    }
}