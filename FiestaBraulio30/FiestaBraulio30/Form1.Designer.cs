namespace FiestaBraulio30
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
            txtClave = new TextBox();
            btnVerificar = new Button();
            btnReiniciar = new Button();
            lblPregunta = new Label();
            lblResultado = new Label();
            panel = new Panel();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // txtClave
            // 
            txtClave.BackColor = Color.FromArgb(40, 45, 70);
            txtClave.BorderStyle = BorderStyle.FixedSingle;
            txtClave.Font = new Font("Segoe UI", 24F);
            txtClave.ForeColor = Color.White;
            txtClave.Location = new Point(50, 170);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(650, 71);
            txtClave.TabIndex = 3;
            txtClave.TextAlign = HorizontalAlignment.Center;
            txtClave.KeyPress += txtClave_KeyPress;
            // 
            // btnVerificar
            // 
            btnVerificar.BackColor = Color.FromArgb(0, 170, 120);
            btnVerificar.FlatAppearance.BorderSize = 0;
            btnVerificar.FlatStyle = FlatStyle.Flat;
            btnVerificar.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnVerificar.ForeColor = Color.White;
            btnVerificar.Location = new Point(50, 260);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(650, 90);
            btnVerificar.TabIndex = 2;
            btnVerificar.Text = "VERIFICAR";
            btnVerificar.UseVisualStyleBackColor = false;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // btnReiniciar
            // 
            btnReiniciar.BackColor = Color.FromArgb(200, 60, 60);
            btnReiniciar.FlatAppearance.BorderSize = 0;
            btnReiniciar.FlatStyle = FlatStyle.Flat;
            btnReiniciar.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnReiniciar.ForeColor = Color.White;
            btnReiniciar.Location = new Point(50, 380);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(650, 70);
            btnReiniciar.TabIndex = 1;
            btnReiniciar.Text = "VOLVER A INTENTAR";
            btnReiniciar.UseVisualStyleBackColor = false;
            btnReiniciar.Visible = false;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // lblPregunta
            // 
            lblPregunta.AutoSize = true;
            lblPregunta.Font = new Font("Segoe UI", 22F);
            lblPregunta.ForeColor = Color.LightCyan;
            lblPregunta.Location = new Point(50, 100);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(272, 60);
            lblPregunta.TabIndex = 4;
            lblPregunta.Text = "Clave 1 de 5:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblResultado.ForeColor = Color.Gray;
            lblResultado.Location = new Point(50, 480);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 96);
            lblResultado.TabIndex = 0;
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(15, 20, 40);
            panel.Controls.Add(lblResultado);
            panel.Controls.Add(btnReiniciar);
            panel.Controls.Add(btnVerificar);
            panel.Controls.Add(txtClave);
            panel.Controls.Add(lblPregunta);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Padding = new Padding(50);
            panel.Size = new Size(1099, 604);
            panel.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 15, 30);
            ClientSize = new Size(1099, 604);
            Controls.Add(panel);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 30 - Fiesta de Braulio";
            Load += Form1_Load;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        private TextBox txtClave;
        private Button btnVerificar;
        private Button btnReiniciar;
        private Label lblPregunta;
        private Label lblResultado;
        private Panel panel;
    }
}