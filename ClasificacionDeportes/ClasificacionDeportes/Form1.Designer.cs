namespace ClasificacionDeportes
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
            txtDeporte = new TextBox();
            btnIngresar = new Button();
            btnReiniciar = new Button();
            lblTitulo = new Label();
            lblContador = new Label();
            lblResultado = new Label();
            rtbResultado = new RichTextBox();
            panel = new Panel();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // txtDeporte
            // 
            txtDeporte.BackColor = Color.FromArgb(40, 45, 70);
            txtDeporte.BorderStyle = BorderStyle.FixedSingle;
            txtDeporte.Font = new Font("Segoe UI", 18F);
            txtDeporte.ForeColor = Color.White;
            txtDeporte.Location = new Point(30, 140);
            txtDeporte.Name = "txtDeporte";
            txtDeporte.Size = new Size(500, 55);
            txtDeporte.TabIndex = 5;
            txtDeporte.KeyPress += txtDeporte_KeyPress;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(0, 170, 120);
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(550, 140);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(180, 50);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnReiniciar
            // 
            btnReiniciar.BackColor = Color.FromArgb(200, 60, 60);
            btnReiniciar.FlatStyle = FlatStyle.Flat;
            btnReiniciar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnReiniciar.ForeColor = Color.White;
            btnReiniciar.Location = new Point(30, 210);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(180, 50);
            btnReiniciar.TabIndex = 3;
            btnReiniciar.Text = "REINICIAR TODO";
            btnReiniciar.UseVisualStyleBackColor = false;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(100, 200, 255);
            lblTitulo.Location = new Point(30, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(936, 65);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "Clasificación por Deporte (400 alumnos)";
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblContador.ForeColor = Color.Yellow;
            lblContador.Location = new Point(30, 90);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(264, 48);
            lblContador.TabIndex = 2;
            lblContador.Text = "Alumno 1/400";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 14F, FontStyle.Italic);
            lblResultado.ForeColor = Color.Cyan;
            lblResultado.Location = new Point(30, 270);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(401, 38);
            lblResultado.TabIndex = 1;
            lblResultado.Text = "Ingrese el deporte del alumno 1";
            // 
            // rtbResultado
            // 
            rtbResultado.BackColor = Color.FromArgb(30, 35, 60);
            rtbResultado.BorderStyle = BorderStyle.FixedSingle;
            rtbResultado.Font = new Font("Consolas", 16F);
            rtbResultado.ForeColor = Color.LightGreen;
            rtbResultado.Location = new Point(30, 320);
            rtbResultado.Name = "rtbResultado";
            rtbResultado.ReadOnly = true;
            rtbResultado.Size = new Size(700, 220);
            rtbResultado.TabIndex = 0;
            rtbResultado.Text = "";
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(20, 25, 45);
            panel.Controls.Add(rtbResultado);
            panel.Controls.Add(lblResultado);
            panel.Controls.Add(lblContador);
            panel.Controls.Add(btnReiniciar);
            panel.Controls.Add(btnIngresar);
            panel.Controls.Add(txtDeporte);
            panel.Controls.Add(lblTitulo);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Padding = new Padding(30);
            panel.Size = new Size(962, 561);
            panel.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 15, 35);
            ClientSize = new Size(962, 561);
            Controls.Add(panel);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 29 - Clasificación por Deporte";
            Load += Form1_Load;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        private TextBox txtDeporte;
        private Button btnIngresar;
        private Button btnReiniciar;
        private Label lblTitulo;
        private Label lblContador;
        private Label lblResultado;
        private RichTextBox rtbResultado;
        private Panel panel;
    }
}