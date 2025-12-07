namespace Media100Numeros
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
            txtNumero = new TextBox();
            btnAgregar = new Button();
            btnNuevo = new Button();
            rtbNumeros = new RichTextBox();
            lblTitulo = new Label();
            lblContador = new Label();
            lblSumaActual = new Label();
            lblMedia = new Label();
            panel = new Panel();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // txtNumero
            // 
            txtNumero.BackColor = Color.FromArgb(50, 55, 80);
            txtNumero.BorderStyle = BorderStyle.FixedSingle;
            txtNumero.Font = new Font("Segoe UI", 22F);
            txtNumero.ForeColor = Color.White;
            txtNumero.Location = new Point(30, 140);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(500, 66);
            txtNumero.TabIndex = 6;
            txtNumero.TextAlign = HorizontalAlignment.Center;
            txtNumero.KeyPress += txtNumero_KeyPress;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(0, 170, 120);
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(550, 140);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(130, 55);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(200, 70, 70);
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(30, 210);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(650, 60);
            btnNuevo.TabIndex = 3;
            btnNuevo.Text = "NUEVO CÁLCULO";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // rtbNumeros
            // 
            rtbNumeros.BackColor = Color.FromArgb(35, 40, 65);
            rtbNumeros.BorderStyle = BorderStyle.FixedSingle;
            rtbNumeros.Font = new Font("Consolas", 11F);
            rtbNumeros.ForeColor = Color.LightCyan;
            rtbNumeros.Location = new Point(30, 290);
            rtbNumeros.Name = "rtbNumeros";
            rtbNumeros.ReadOnly = true;
            rtbNumeros.Size = new Size(650, 240);
            rtbNumeros.TabIndex = 2;
            rtbNumeros.Text = "";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(100, 200, 255);
            lblTitulo.Location = new Point(37, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(643, 74);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "Media de 100 Números";
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblContador.ForeColor = Color.Cyan;
            lblContador.Location = new Point(33, 92);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(279, 45);
            lblContador.TabIndex = 5;
            lblContador.Text = "Número 1 de 100";
            // 
            // lblSumaActual
            // 
            lblSumaActual.AutoSize = true;
            lblSumaActual.Font = new Font("Segoe UI", 14F);
            lblSumaActual.Location = new Point(30, 550);
            lblSumaActual.Name = "lblSumaActual";
            lblSumaActual.Size = new Size(232, 38);
            lblSumaActual.TabIndex = 1;
            lblSumaActual.Text = "Suma actual: 0.00";
            // 
            // lblMedia
            // 
            lblMedia.AutoSize = true;
            lblMedia.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblMedia.ForeColor = Color.Gold;
            lblMedia.Location = new Point(30, 580);
            lblMedia.Name = "lblMedia";
            lblMedia.Size = new Size(183, 96);
            lblMedia.TabIndex = 0;
            lblMedia.Text = "0.00";
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(20, 25, 45);
            panel.Controls.Add(lblMedia);
            panel.Controls.Add(lblSumaActual);
            panel.Controls.Add(rtbNumeros);
            panel.Controls.Add(btnNuevo);
            panel.Controls.Add(btnAgregar);
            panel.Controls.Add(lblContador);
            panel.Controls.Add(txtNumero);
            panel.Controls.Add(lblTitulo);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Padding = new Padding(30);
            panel.Size = new Size(720, 680);
            panel.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 15, 30);
            ClientSize = new Size(720, 680);
            Controls.Add(panel);
            Font = new Font("Segoe UI", 11F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 14 - Media de 100 Números";
            Load += Form1_Load;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        private TextBox txtNumero;
        private Button btnAgregar;
        private Button btnNuevo;
        private RichTextBox rtbNumeros;
        private Label lblTitulo;
        private Label lblContador;
        private Label lblSumaActual;
        private Label lblMedia;
        private Panel panel;
    }
}