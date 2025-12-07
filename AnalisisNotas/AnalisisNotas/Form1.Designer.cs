namespace AnalisisNotas
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
            txtNota = new TextBox();
            btnAgregarNota = new Button();
            btnFinalizar = new Button();
            btnNuevo = new Button();
            rtbNotas = new RichTextBox();
            lblTitulo = new Label();
            lblInstruccion = new Label();
            grupoResultados = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lblContAprobadas = new Label();
            lblContDesaprobadas = new Label();
            lblTotalNotas = new Label();
            lblPromAprobadas = new Label();
            lblPromDesaprobadas = new Label();
            lblPromedioFinal = new Label();
            panel = new Panel();
            grupoResultados.SuspendLayout();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // txtNota
            // 
            txtNota.BackColor = Color.FromArgb(50, 55, 80);
            txtNota.BorderStyle = BorderStyle.FixedSingle;
            txtNota.Font = new Font("Segoe UI", 18F);
            txtNota.ForeColor = Color.White;
            txtNota.Location = new Point(30, 130);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(420, 55);
            txtNota.TabIndex = 5;
            txtNota.TextAlign = HorizontalAlignment.Center;
            txtNota.KeyPress += txtNota_KeyPress;
            // 
            // btnAgregarNota
            // 
            btnAgregarNota.BackColor = Color.FromArgb(0, 160, 120);
            btnAgregarNota.FlatAppearance.BorderSize = 0;
            btnAgregarNota.FlatStyle = FlatStyle.Flat;
            btnAgregarNota.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAgregarNota.ForeColor = Color.White;
            btnAgregarNota.Location = new Point(470, 130);
            btnAgregarNota.Name = "btnAgregarNota";
            btnAgregarNota.Size = new Size(150, 45);
            btnAgregarNota.TabIndex = 4;
            btnAgregarNota.Text = "AGREGAR";
            btnAgregarNota.UseVisualStyleBackColor = false;
            btnAgregarNota.Click += btnAgregarNota_Click;
            // 
            // btnFinalizar
            // 
            btnFinalizar.BackColor = Color.FromArgb(0, 120, 215);
            btnFinalizar.FlatStyle = FlatStyle.Flat;
            btnFinalizar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnFinalizar.ForeColor = Color.White;
            btnFinalizar.Location = new Point(30, 190);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(300, 55);
            btnFinalizar.TabIndex = 3;
            btnFinalizar.Text = "FINALIZAR Y VER RESULTADOS";
            btnFinalizar.UseVisualStyleBackColor = false;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(180, 60, 60);
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(350, 190);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(270, 55);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "NUEVO ANÁLISIS";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // rtbNotas
            // 
            rtbNotas.BackColor = Color.FromArgb(40, 45, 65);
            rtbNotas.Font = new Font("Consolas", 12F);
            rtbNotas.ForeColor = Color.LightCyan;
            rtbNotas.Location = new Point(30, 260);
            rtbNotas.Name = "rtbNotas";
            rtbNotas.ReadOnly = true;
            rtbNotas.Size = new Size(675, 140);
            rtbNotas.TabIndex = 1;
            rtbNotas.Text = "";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(100, 200, 255);
            lblTitulo.Location = new Point(33, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(483, 74);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "Análisis de Notas";
            // 
            // lblInstruccion
            // 
            lblInstruccion.Font = new Font("Segoe UI", 12F);
            lblInstruccion.Location = new Point(33, 92);
            lblInstruccion.Name = "lblInstruccion";
            lblInstruccion.Size = new Size(105, 35);
            lblInstruccion.TabIndex = 6;
            lblInstruccion.Text = "Ingrese las notas del estudiante (0 a 20):";
            // 
            // grupoResultados
            // 
            grupoResultados.Controls.Add(label2);
            grupoResultados.Controls.Add(label3);
            grupoResultados.Controls.Add(label4);
            grupoResultados.Controls.Add(label5);
            grupoResultados.Controls.Add(label6);
            grupoResultados.Controls.Add(label7);
            grupoResultados.Controls.Add(lblContAprobadas);
            grupoResultados.Controls.Add(lblContDesaprobadas);
            grupoResultados.Controls.Add(lblTotalNotas);
            grupoResultados.Controls.Add(lblPromAprobadas);
            grupoResultados.Controls.Add(lblPromDesaprobadas);
            grupoResultados.Controls.Add(lblPromedioFinal);
            grupoResultados.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grupoResultados.ForeColor = Color.Cyan;
            grupoResultados.Location = new Point(30, 420);
            grupoResultados.Name = "grupoResultados";
            grupoResultados.Size = new Size(801, 200);
            grupoResultados.TabIndex = 0;
            grupoResultados.TabStop = false;
            grupoResultados.Text = "RESULTADOS";
            grupoResultados.Enter += grupoResultados_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 40);
            label2.Name = "label2";
            label2.Size = new Size(215, 32);
            label2.TabIndex = 0;
            label2.Text = "Notas aprobadas:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 70);
            label3.Name = "label3";
            label3.Size = new Size(254, 32);
            label3.TabIndex = 1;
            label3.Text = "Notas desaprobadas:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 100);
            label4.Name = "label4";
            label4.Size = new Size(182, 32);
            label4.TabIndex = 2;
            label4.Text = "Total de notas:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(406, 28);
            label5.Name = "label5";
            label5.Size = new Size(217, 32);
            label5.TabIndex = 3;
            label5.Text = "Prom. aprobadas:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(377, 78);
            label6.Name = "label6";
            label6.Size = new Size(256, 32);
            label6.TabIndex = 4;
            label6.Text = "Prom. desaprobadas:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label7.Location = new Point(353, 126);
            label7.Name = "label7";
            label7.Size = new Size(252, 45);
            label7.TabIndex = 5;
            label7.Text = "Promedio final:";
            // 
            // lblContAprobadas
            // 
            lblContAprobadas.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblContAprobadas.ForeColor = Color.LimeGreen;
            lblContAprobadas.Location = new Point(263, 35);
            lblContAprobadas.Name = "lblContAprobadas";
            lblContAprobadas.Size = new Size(108, 50);
            lblContAprobadas.TabIndex = 6;
            lblContAprobadas.Text = "0";
            // 
            // lblContDesaprobadas
            // 
            lblContDesaprobadas.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblContDesaprobadas.ForeColor = Color.IndianRed;
            lblContDesaprobadas.Location = new Point(280, 74);
            lblContDesaprobadas.Name = "lblContDesaprobadas";
            lblContDesaprobadas.Size = new Size(72, 40);
            lblContDesaprobadas.TabIndex = 7;
            lblContDesaprobadas.Text = "0";
            // 
            // lblTotalNotas
            // 
            lblTotalNotas.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotalNotas.Location = new Point(200, 97);
            lblTotalNotas.Name = "lblTotalNotas";
            lblTotalNotas.Size = new Size(100, 58);
            lblTotalNotas.TabIndex = 8;
            lblTotalNotas.Text = "0";
            // 
            // lblPromAprobadas
            // 
            lblPromAprobadas.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblPromAprobadas.ForeColor = Color.LimeGreen;
            lblPromAprobadas.Location = new Point(650, 28);
            lblPromAprobadas.Name = "lblPromAprobadas";
            lblPromAprobadas.Size = new Size(98, 43);
            lblPromAprobadas.TabIndex = 9;
            lblPromAprobadas.Text = "0.0";
            // 
            // lblPromDesaprobadas
            // 
            lblPromDesaprobadas.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblPromDesaprobadas.ForeColor = Color.IndianRed;
            lblPromDesaprobadas.Location = new Point(639, 68);
            lblPromDesaprobadas.Name = "lblPromDesaprobadas";
            lblPromDesaprobadas.Size = new Size(100, 46);
            lblPromDesaprobadas.TabIndex = 10;
            lblPromDesaprobadas.Text = "0.0";
            // 
            // lblPromedioFinal
            // 
            lblPromedioFinal.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblPromedioFinal.Location = new Point(611, 114);
            lblPromedioFinal.Name = "lblPromedioFinal";
            lblPromedioFinal.Size = new Size(153, 83);
            lblPromedioFinal.TabIndex = 11;
            lblPromedioFinal.Text = "0.0";
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(25, 30, 50);
            panel.Controls.Add(grupoResultados);
            panel.Controls.Add(rtbNotas);
            panel.Controls.Add(btnNuevo);
            panel.Controls.Add(btnFinalizar);
            panel.Controls.Add(btnAgregarNota);
            panel.Controls.Add(txtNota);
            panel.Controls.Add(lblInstruccion);
            panel.Controls.Add(lblTitulo);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Padding = new Padding(30);
            panel.Size = new Size(995, 653);
            panel.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 20, 35);
            ClientSize = new Size(995, 653);
            Controls.Add(panel);
            Font = new Font("Segoe UI", 11F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 09 - Análisis de Notas";
            Load += Form1_Load;
            grupoResultados.ResumeLayout(false);
            grupoResultados.PerformLayout();
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        private TextBox txtNota;
        private Button btnAgregarNota;
        private Button btnFinalizar;
        private Button btnNuevo;
        private RichTextBox rtbNotas;
        private Label lblTitulo;
        private Label lblInstruccion;
        private GroupBox grupoResultados;
        private Label lblContAprobadas;
        private Label lblContDesaprobadas;
        private Label lblTotalNotas;
        private Label lblPromAprobadas;
        private Label lblPromDesaprobadas;
        private Label lblPromedioFinal;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel;
    }
}
