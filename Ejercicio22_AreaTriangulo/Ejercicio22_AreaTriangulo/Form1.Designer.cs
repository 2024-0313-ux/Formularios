namespace Ejercicio22_AreaTriangulo
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
            txtLadoA = new TextBox();
            txtLadoB = new TextBox();
            txtLadoC = new TextBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            rtbResultado = new RichTextBox();
            lblTitulo = new Label();
            lblEstado = new Label();
            panel = new Panel();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // txtLadoA
            // 
            txtLadoA.BackColor = Color.FromArgb(40, 45, 70);
            txtLadoA.Font = new Font("Segoe UI", 24F);
            txtLadoA.ForeColor = Color.White;
            txtLadoA.Location = new Point(40, 140);
            txtLadoA.Name = "txtLadoA";
            txtLadoA.Size = new Size(680, 71);
            txtLadoA.TabIndex = 6;
            txtLadoA.TextAlign = HorizontalAlignment.Center;
            txtLadoA.KeyPress += txtLado_KeyPress;
            // 
            // txtLadoB
            // 
            txtLadoB.BackColor = Color.FromArgb(40, 45, 70);
            txtLadoB.Font = new Font("Segoe UI", 24F);
            txtLadoB.ForeColor = Color.White;
            txtLadoB.Location = new Point(40, 230);
            txtLadoB.Name = "txtLadoB";
            txtLadoB.Size = new Size(680, 71);
            txtLadoB.TabIndex = 5;
            txtLadoB.TextAlign = HorizontalAlignment.Center;
            txtLadoB.KeyPress += txtLado_KeyPress;
            // 
            // txtLadoC
            // 
            txtLadoC.BackColor = Color.FromArgb(40, 45, 70);
            txtLadoC.Font = new Font("Segoe UI", 24F);
            txtLadoC.ForeColor = Color.White;
            txtLadoC.Location = new Point(40, 320);
            txtLadoC.Name = "txtLadoC";
            txtLadoC.Size = new Size(680, 71);
            txtLadoC.TabIndex = 4;
            txtLadoC.TextAlign = HorizontalAlignment.Center;
            txtLadoC.KeyPress += txtLado_KeyPress;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(0, 170, 120);
            btnCalcular.FlatAppearance.BorderSize = 0;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            btnCalcular.ForeColor = Color.White;
            btnCalcular.Location = new Point(40, 410);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(520, 90);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "CALCULAR ÁREA";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(200, 60, 60);
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(580, 410);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(140, 90);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // rtbResultado
            // 
            rtbResultado.BackColor = Color.FromArgb(30, 35, 60);
            rtbResultado.BorderStyle = BorderStyle.FixedSingle;
            rtbResultado.Font = new Font("Consolas", 14F);
            rtbResultado.ForeColor = Color.LightCyan;
            rtbResultado.Location = new Point(40, 520);
            rtbResultado.Name = "rtbResultado";
            rtbResultado.ReadOnly = true;
            rtbResultado.Size = new Size(680, 120);
            rtbResultado.TabIndex = 1;
            rtbResultado.Text = "";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(100, 200, 255);
            lblTitulo.Location = new Point(40, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(790, 70);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "Ejercicio 22 - Área de Triángulo";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            lblEstado.ForeColor = Color.Gray;
            lblEstado.Location = new Point(40, 650);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(203, 32);
            lblEstado.TabIndex = 0;
            lblEstado.Text = "Listo para calcular";
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(20, 25, 45);
            panel.Controls.Add(lblEstado);
            panel.Controls.Add(rtbResultado);
            panel.Controls.Add(btnLimpiar);
            panel.Controls.Add(btnCalcular);
            panel.Controls.Add(txtLadoC);
            panel.Controls.Add(txtLadoB);
            panel.Controls.Add(txtLadoA);
            panel.Controls.Add(lblTitulo);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Padding = new Padding(40);
            panel.Size = new Size(953, 680);
            panel.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 15, 35);
            ClientSize = new Size(953, 680);
            Controls.Add(panel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 22 - Área de Triángulo (Fórmula de Herón)";
            Load += Form1_Load;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox txtLadoA;
        private System.Windows.Forms.TextBox txtLadoB;
        private System.Windows.Forms.TextBox txtLadoC;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.RichTextBox rtbResultado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Panel panel;
    }
}