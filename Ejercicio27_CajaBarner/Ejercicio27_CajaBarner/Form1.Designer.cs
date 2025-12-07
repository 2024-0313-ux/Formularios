namespace Ejercicio27_CajaBarner
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
            txtEgreso = new TextBox();
            btnIngresar = new Button();
            btnReiniciar = new Button();
            rtbHistorial = new RichTextBox();
            lblTitulo = new Label();
            lblContador = new Label();
            lblSaldo = new Label();
            panel = new Panel();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // txtEgreso
            // 
            txtEgreso.BackColor = Color.FromArgb(40, 45, 70);
            txtEgreso.Font = new Font("Segoe UI", 36F);
            txtEgreso.ForeColor = Color.White;
            txtEgreso.Location = new Point(25, 180);
            txtEgreso.Name = "txtEgreso";
            txtEgreso.Size = new Size(620, 103);
            txtEgreso.TabIndex = 5;
            txtEgreso.TextAlign = HorizontalAlignment.Center;
            txtEgreso.KeyPress += txtEgreso_KeyPress;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(0, 170, 120);
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(665, 180);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(230, 90);
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
            btnReiniciar.Location = new Point(700, 650);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(195, 60);
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
            rtbHistorial.Location = new Point(25, 290);
            rtbHistorial.Name = "rtbHistorial";
            rtbHistorial.ReadOnly = true;
            rtbHistorial.Size = new Size(870, 340);
            rtbHistorial.TabIndex = 2;
            rtbHistorial.Text = "";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(100, 200, 255);
            lblTitulo.Location = new Point(25, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(636, 70);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "Ejercicio 27 - Caja Barner";
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblContador.ForeColor = Color.Cyan;
            lblContador.Location = new Point(28, 79);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(387, 48);
            lblContador.TabIndex = 1;
            lblContador.Text = "Egresos registrados: 0";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblSaldo.ForeColor = Color.LimeGreen;
            lblSaldo.Location = new Point(25, 123);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(423, 54);
            lblSaldo.TabIndex = 0;
            lblSaldo.Text = "Saldo actual: $371.00";
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(15, 20, 40);
            panel.Controls.Add(lblSaldo);
            panel.Controls.Add(lblContador);
            panel.Controls.Add(rtbHistorial);
            panel.Controls.Add(btnReiniciar);
            panel.Controls.Add(btnIngresar);
            panel.Controls.Add(txtEgreso);
            panel.Controls.Add(lblTitulo);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Padding = new Padding(25);
            panel.Size = new Size(920, 720);
            panel.TabIndex = 0;
            panel.Paint += panel_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 30);
            ClientSize = new Size(920, 720);
            Controls.Add(panel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 27 - Caja Barner ($371 iniciales)";
            Load += Form1_Load;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox txtEgreso;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.RichTextBox rtbHistorial;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Panel panel;
    }
}