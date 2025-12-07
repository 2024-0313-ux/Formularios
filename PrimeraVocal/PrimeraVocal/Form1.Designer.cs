namespace PrimeraVocal
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
            txtCaracter = new TextBox();
            btnIngresar = new Button();
            btnNuevo = new Button();
            rtbHistorial = new RichTextBox();
            lblTitulo = new Label();
            lblInstruccion = new Label();
            lblResultado = new Label();
            lblVocal = new Label();
            panel = new Panel();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // txtCaracter
            // 
            txtCaracter.BackColor = Color.FromArgb(50, 55, 80);
            txtCaracter.BorderStyle = BorderStyle.FixedSingle;
            txtCaracter.Font = new Font("Segoe UI", 24F);
            txtCaracter.ForeColor = Color.White;
            txtCaracter.Location = new Point(30, 140);
            txtCaracter.Name = "txtCaracter";
            txtCaracter.Size = new Size(400, 71);
            txtCaracter.TabIndex = 5;
            txtCaracter.TextAlign = HorizontalAlignment.Center;
            txtCaracter.KeyPress += txtCaracter_KeyPress;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(0, 170, 120);
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(450, 140);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(70, 55);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "→";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(200, 70, 70);
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(30, 617);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(490, 60);
            btnNuevo.TabIndex = 3;
            btnNuevo.Text = "NUEVO INTENTO";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // rtbHistorial
            // 
            rtbHistorial.BackColor = Color.FromArgb(35, 40, 65);
            rtbHistorial.BorderStyle = BorderStyle.FixedSingle;
            rtbHistorial.Font = new Font("Consolas", 16F);
            rtbHistorial.ForeColor = Color.LightGray;
            rtbHistorial.Location = new Point(30, 220);
            rtbHistorial.Name = "rtbHistorial";
            rtbHistorial.ReadOnly = true;
            rtbHistorial.Size = new Size(490, 160);
            rtbHistorial.TabIndex = 2;
            rtbHistorial.Text = "";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(100, 200, 255);
            lblTitulo.Location = new Point(30, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(451, 86);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "Primera Vocal";
            // 
            // lblInstruccion
            // 
            lblInstruccion.AutoSize = true;
            lblInstruccion.Font = new Font("Segoe UI", 12F);
            lblInstruccion.Location = new Point(30, 100);
            lblInstruccion.Name = "lblInstruccion";
            lblInstruccion.Size = new Size(815, 32);
            lblInstruccion.TabIndex = 6;
            lblInstruccion.Text = "Ingresa caracteres (uno por uno). Se detendrá al encontrar la primera vocal:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblResultado.Location = new Point(30, 400);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(453, 45);
            lblResultado.TabIndex = 1;
            lblResultado.Text = "Esperando la primera vocal...";
            // 
            // lblVocal
            // 
            lblVocal.AutoSize = true;
            lblVocal.Font = new Font("Segoe UI", 72F, FontStyle.Bold);
            lblVocal.ForeColor = Color.Gray;
            lblVocal.Location = new Point(519, 400);
            lblVocal.Name = "lblVocal";
            lblVocal.Size = new Size(143, 191);
            lblVocal.TabIndex = 0;
            lblVocal.Text = "?";
            lblVocal.Click += lblVocal_Click;
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(20, 25, 45);
            panel.Controls.Add(lblVocal);
            panel.Controls.Add(lblResultado);
            panel.Controls.Add(rtbHistorial);
            panel.Controls.Add(btnNuevo);
            panel.Controls.Add(btnIngresar);
            panel.Controls.Add(txtCaracter);
            panel.Controls.Add(lblInstruccion);
            panel.Controls.Add(lblTitulo);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Padding = new Padding(30);
            panel.Size = new Size(880, 677);
            panel.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 15, 30);
            ClientSize = new Size(880, 677);
            Controls.Add(panel);
            Font = new Font("Segoe UI", 11F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 16 - Primera Vocal";
            Load += Form1_Load;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        private TextBox txtCaracter;
        private Button btnIngresar;
        private Button btnNuevo;
        private RichTextBox rtbHistorial;
        private Label lblTitulo;
        private Label lblInstruccion;
        private Label lblResultado;
        private Label lblVocal;
        private Panel panel;
    }
}
