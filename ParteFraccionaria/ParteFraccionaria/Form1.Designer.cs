namespace ParteFraccionaria
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtNumero = new TextBox();
            btnVerificar = new Button();
            btnLimpiar = new Button();
            rtbDetalle = new RichTextBox();
            lblTitulo = new Label();
            lblInstruccion = new Label();
            lblNumeroIngresado = new Label();
            lblResultado = new Label();
            picIcono = new PictureBox();
            panel = new Panel();
            ((System.ComponentModel.ISupportInitialize)picIcono).BeginInit();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // txtNumero
            // 
            txtNumero.BackColor = Color.FromArgb(50, 55, 80);
            txtNumero.BorderStyle = BorderStyle.FixedSingle;
            txtNumero.Font = new Font("Segoe UI", 24F);
            txtNumero.ForeColor = Color.White;
            txtNumero.Location = new Point(40, 140);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(480, 71);
            txtNumero.TabIndex = 0;
            txtNumero.TextAlign = HorizontalAlignment.Center;
            txtNumero.KeyPress += txtNumero_KeyPress;
            // 
            // btnVerificar
            // 
            btnVerificar.BackColor = Color.FromArgb(0, 170, 120);
            btnVerificar.FlatAppearance.BorderSize = 0;
            btnVerificar.FlatStyle = FlatStyle.Flat;
            btnVerificar.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnVerificar.ForeColor = Color.White;
            btnVerificar.Location = new Point(40, 220);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(230, 80);
            btnVerificar.TabIndex = 1;
            btnVerificar.Text = "VERIFICAR";
            btnVerificar.UseVisualStyleBackColor = false;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(200, 60, 60);
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(290, 220);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(230, 80);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // rtbDetalle
            // 
            rtbDetalle.BackColor = Color.FromArgb(35, 40, 65);
            rtbDetalle.BorderStyle = BorderStyle.FixedSingle;
            rtbDetalle.Font = new Font("Consolas", 14F);
            rtbDetalle.ForeColor = Color.LightCyan;
            rtbDetalle.Location = new Point(40, 330);
            rtbDetalle.Name = "rtbDetalle";
            rtbDetalle.ReadOnly = true;
            rtbDetalle.Size = new Size(480, 120);
            rtbDetalle.TabIndex = 3;
            rtbDetalle.Text = "";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(100, 200, 255);
            lblTitulo.Location = new Point(40, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(630, 86);
            lblTitulo.TabIndex = 12;
            lblTitulo.Text = "¿Parte Fraccionaria?";
            // 
            // lblInstruccion
            // 
            lblInstruccion.AutoSize = true;
            lblInstruccion.Font = new Font("Segoe UI", 13F);
            lblInstruccion.Location = new Point(40, 100);
            lblInstruccion.Name = "lblInstruccion";
            lblInstruccion.Size = new Size(456, 36);
            lblInstruccion.TabIndex = 11;
            lblInstruccion.Text = "Ingrese un número (entero o decimal):";
            // 
            // lblNumeroIngresado
            // 
            lblNumeroIngresado.AutoSize = true;
            lblNumeroIngresado.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblNumeroIngresado.Location = new Point(62, 455);
            lblNumeroIngresado.Name = "lblNumeroIngresado";
            lblNumeroIngresado.Size = new Size(271, 74);
            lblNumeroIngresado.TabIndex = 10;
            lblNumeroIngresado.Text = "0.000000";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblResultado.ForeColor = Color.Gray;
            lblResultado.Location = new Point(40, 529);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(452, 60);
            lblResultado.TabIndex = 9;
            lblResultado.Text = "Esperando número...";
            // 
            // picIcono
            // 
            picIcono.Location = new Point(536, 470);
            picIcono.Name = "picIcono";
            picIcono.Size = new Size(100, 100);
            picIcono.SizeMode = PictureBoxSizeMode.Zoom;
            picIcono.TabIndex = 8;
            picIcono.TabStop = false;
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(20, 25, 45);
            panel.Controls.Add(picIcono);
            panel.Controls.Add(lblResultado);
            panel.Controls.Add(lblNumeroIngresado);
            panel.Controls.Add(rtbDetalle);
            panel.Controls.Add(btnLimpiar);
            panel.Controls.Add(btnVerificar);
            panel.Controls.Add(txtNumero);
            panel.Controls.Add(lblInstruccion);
            panel.Controls.Add(lblTitulo);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Padding = new Padding(40);
            panel.Size = new Size(766, 598);
            panel.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 15, 30);
            ClientSize = new Size(766, 598);
            Controls.Add(panel);
            Font = new Font("Segoe UI", 11F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 17 - Parte Fraccionaria";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picIcono).EndInit();
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.RichTextBox rtbDetalle;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblInstruccion;
        private System.Windows.Forms.Label lblNumeroIngresado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.PictureBox picIcono;
        private System.Windows.Forms.Panel panel;
    }
}