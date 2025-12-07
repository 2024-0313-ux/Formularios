namespace SumaSalariosTrabajadores
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
            txtCantidad = new TextBox();
            btnIniciar = new Button();
            grupoDatos = new GroupBox();
            lblTrabajadorActual = new Label();
            lblTarifa = new Label();
            txtTarifa = new TextBox();
            lblHoras = new Label();
            txtHoras = new TextBox();
            btnAgregar = new Button();
            rtbDetalle = new RichTextBox();
            btnLimpiar = new Button();
            lblResultado = new Label();
            lblSumaFinal = new Label();
            lblTitulo = new Label();
            panel = new Panel();
            grupoDatos.SuspendLayout();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = Color.FromArgb(50, 50, 80);
            txtCantidad.Font = new Font("Segoe UI", 16F);
            txtCantidad.ForeColor = Color.White;
            txtCantidad.Location = new Point(30, 110);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(300, 50);
            txtCantidad.TabIndex = 6;
            txtCantidad.TextAlign = HorizontalAlignment.Center;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.FromArgb(0, 170, 100);
            btnIniciar.FlatAppearance.BorderSize = 0;
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnIniciar.ForeColor = Color.White;
            btnIniciar.Location = new Point(350, 110);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(150, 45);
            btnIniciar.TabIndex = 5;
            btnIniciar.Text = "INICIAR";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // grupoDatos
            // 
            grupoDatos.Controls.Add(lblTrabajadorActual);
            grupoDatos.Controls.Add(lblTarifa);
            grupoDatos.Controls.Add(txtTarifa);
            grupoDatos.Controls.Add(lblHoras);
            grupoDatos.Controls.Add(txtHoras);
            grupoDatos.Controls.Add(btnAgregar);
            grupoDatos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grupoDatos.ForeColor = Color.Cyan;
            grupoDatos.Location = new Point(30, 180);
            grupoDatos.Name = "grupoDatos";
            grupoDatos.Size = new Size(767, 180);
            grupoDatos.TabIndex = 4;
            grupoDatos.TabStop = false;
            grupoDatos.Text = "Datos del trabajador";
            // 
            // lblTrabajadorActual
            // 
            lblTrabajadorActual.AutoSize = true;
            lblTrabajadorActual.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTrabajadorActual.Location = new Point(20, 30);
            lblTrabajadorActual.Name = "lblTrabajadorActual";
            lblTrabajadorActual.Size = new Size(298, 38);
            lblTrabajadorActual.TabIndex = 0;
            lblTrabajadorActual.Text = "Esperando cantidad...";
            // 
            // lblTarifa
            // 
            lblTarifa.AutoSize = true;
            lblTarifa.Location = new Point(20, 130);
            lblTarifa.Name = "lblTarifa";
            lblTarifa.Size = new Size(191, 32);
            lblTarifa.TabIndex = 1;
            lblTarifa.Text = "Tarifa por hora:";
            // 
            // txtTarifa
            // 
            txtTarifa.BackColor = Color.FromArgb(60, 60, 90);
            txtTarifa.Font = new Font("Segoe UI", 14F);
            txtTarifa.Location = new Point(270, 130);
            txtTarifa.Name = "txtTarifa";
            txtTarifa.Size = new Size(200, 45);
            txtTarifa.TabIndex = 2;
            txtTarifa.KeyPress += txtTarifa_KeyPress;
            // 
            // lblHoras
            // 
            lblHoras.AutoSize = true;
            lblHoras.Location = new Point(20, 80);
            lblHoras.Name = "lblHoras";
            lblHoras.Size = new Size(214, 32);
            lblHoras.TabIndex = 3;
            lblHoras.Text = "Horas trabajadas:";
            // 
            // txtHoras
            // 
            txtHoras.BackColor = Color.FromArgb(60, 60, 90);
            txtHoras.Font = new Font("Segoe UI", 14F);
            txtHoras.Location = new Point(270, 74);
            txtHoras.Name = "txtHoras";
            txtHoras.Size = new Size(200, 45);
            txtHoras.TabIndex = 4;
            txtHoras.KeyPress += txtHoras_KeyPress;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(0, 120, 215);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(517, 102);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(200, 60);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // rtbDetalle
            // 
            rtbDetalle.BackColor = Color.FromArgb(40, 40, 60);
            rtbDetalle.Font = new Font("Consolas", 11F);
            rtbDetalle.ForeColor = Color.LightGreen;
            rtbDetalle.Location = new Point(30, 380);
            rtbDetalle.Name = "rtbDetalle";
            rtbDetalle.ReadOnly = true;
            rtbDetalle.Size = new Size(650, 160);
            rtbDetalle.TabIndex = 3;
            rtbDetalle.Text = "";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(200, 60, 60);
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(530, 110);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(150, 45);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblResultado.Location = new Point(30, 560);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(547, 45);
            lblResultado.TabIndex = 1;
            lblResultado.Text = "Ingrese la cantidad de trabajadores";
            // 
            // lblSumaFinal
            // 
            lblSumaFinal.AutoSize = true;
            lblSumaFinal.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            lblSumaFinal.ForeColor = Color.Gold;
            lblSumaFinal.Location = new Point(636, 543);
            lblSumaFinal.Name = "lblSumaFinal";
            lblSumaFinal.Size = new Size(202, 86);
            lblSumaFinal.TabIndex = 0;
            lblSumaFinal.Text = "$0.00";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(100, 200, 255);
            lblTitulo.Location = new Point(30, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(445, 70);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "Suma de Salarios";
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(25, 25, 45);
            panel.Controls.Add(lblSumaFinal);
            panel.Controls.Add(lblResultado);
            panel.Controls.Add(btnLimpiar);
            panel.Controls.Add(rtbDetalle);
            panel.Controls.Add(grupoDatos);
            panel.Controls.Add(btnIniciar);
            panel.Controls.Add(txtCantidad);
            panel.Controls.Add(lblTitulo);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Padding = new Padding(30);
            panel.Size = new Size(1032, 647);
            panel.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 30);
            ClientSize = new Size(1032, 647);
            Controls.Add(panel);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 07 - Suma de Salarios de Trabajadores";
            Load += Form1_Load;
            grupoDatos.ResumeLayout(false);
            grupoDatos.PerformLayout();
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        private TextBox txtCantidad;
        private Button btnIniciar;
        private GroupBox grupoDatos;
        private Label lblTrabajadorActual;
        private Label lblHoras;
        private TextBox txtHoras;
        private Label lblTarifa;
        private TextBox txtTarifa;
        private Button btnAgregar;
        private RichTextBox rtbDetalle;
        private Button btnLimpiar;
        private Label lblResultado;
        private Label lblSumaFinal;
        private Label lblTitulo;
        private Panel panel;
    }
}