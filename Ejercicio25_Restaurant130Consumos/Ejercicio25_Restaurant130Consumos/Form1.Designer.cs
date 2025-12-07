namespace Ejercicio25_Restaurant130Consumos
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
            txtConsumo = new TextBox();
            btnIngresar = new Button();
            btnReiniciar = new Button();
            rtbHistorial = new RichTextBox();
            lblTitulo = new Label();
            lblContador = new Label();
            lblTotalParcial = new Label();
            panel = new Panel();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // txtConsumo
            // 
            txtConsumo.BackColor = Color.FromArgb(40, 45, 70);
            txtConsumo.Font = new Font("Segoe UI", 32F);
            txtConsumo.ForeColor = Color.White;
            txtConsumo.Location = new Point(25, 140);
            txtConsumo.Name = "txtConsumo";
            txtConsumo.Size = new Size(620, 93);
            txtConsumo.TabIndex = 5;
            txtConsumo.TextAlign = HorizontalAlignment.Center;
            txtConsumo.KeyPress += txtConsumo_KeyPress;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(0, 170, 120);
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(665, 140);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(220, 80);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnReiniciar
            // 
            btnReiniciar.BackColor = Color.FromArgb(200, 60, 60);
            btnReiniciar.FlatAppearance.BorderSize = 0;
            btnReiniciar.FlatStyle = FlatStyle.Flat;
            btnReiniciar.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnReiniciar.ForeColor = Color.White;
            btnReiniciar.Location = new Point(700, 630);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(185, 60);
            btnReiniciar.TabIndex = 3;
            btnReiniciar.Text = "REINICIAR";
            btnReiniciar.UseVisualStyleBackColor = false;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // rtbHistorial
            // 
            rtbHistorial.BackColor = Color.FromArgb(30, 35, 60);
            rtbHistorial.BorderStyle = BorderStyle.FixedSingle;
            rtbHistorial.Font = new Font("Consolas", 13F);
            rtbHistorial.ForeColor = Color.LightCyan;
            rtbHistorial.Location = new Point(25, 240);
            rtbHistorial.Name = "rtbHistorial";
            rtbHistorial.ReadOnly = true;
            rtbHistorial.Size = new Size(860, 380);
            rtbHistorial.TabIndex = 2;
            rtbHistorial.Text = "";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(100, 200, 255);
            lblTitulo.Location = new Point(28, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(620, 70);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "Ejercicio 25 - Restaurant";
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblContador.ForeColor = Color.Cyan;
            lblContador.Location = new Point(28, 79);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(429, 54);
            lblContador.TabIndex = 1;
            lblContador.Text = "Consumo N° 1 de 130";
            // 
            // lblTotalParcial
            // 
            lblTotalParcial.AutoSize = true;
            lblTotalParcial.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTotalParcial.ForeColor = Color.White;
            lblTotalParcial.Location = new Point(25, 640);
            lblTotalParcial.Name = "lblTotalParcial";
            lblTotalParcial.Size = new Size(506, 60);
            lblTotalParcial.TabIndex = 0;
            lblTotalParcial.Text = "Total acumulado: $0.00";
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(15, 20, 40);
            panel.Controls.Add(lblTotalParcial);
            panel.Controls.Add(lblContador);
            panel.Controls.Add(rtbHistorial);
            panel.Controls.Add(btnReiniciar);
            panel.Controls.Add(btnIngresar);
            panel.Controls.Add(txtConsumo);
            panel.Controls.Add(lblTitulo);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Padding = new Padding(25);
            panel.Size = new Size(1003, 720);
            panel.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 30);
            ClientSize = new Size(1003, 720);
            Controls.Add(panel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 25 - Restaurant 130 Consumos";
            Load += Form1_Load;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.RichTextBox rtbHistorial;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Label lblTotalParcial;
        private System.Windows.Forms.Panel panel;
    }
}