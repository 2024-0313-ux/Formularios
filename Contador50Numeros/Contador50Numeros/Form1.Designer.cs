namespace Contador50Numeros
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
            grupoResultados = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblPares = new Label();
            lblImpares = new Label();
            lblPositivos = new Label();
            lblNegativos = new Label();
            panel = new Panel();
            grupoResultados.SuspendLayout();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // txtNumero
            // 
            txtNumero.BackColor = Color.FromArgb(50, 55, 80);
            txtNumero.BorderStyle = BorderStyle.FixedSingle;
            txtNumero.Font = new Font("Segoe UI", 20F);
            txtNumero.ForeColor = Color.White;
            txtNumero.Location = new Point(30, 140);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(500, 61);
            txtNumero.TabIndex = 5;
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
            btnAgregar.Size = new Size(130, 50);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "AGRADAR";
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
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "NUEVO CONTEO";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // rtbNumeros
            // 
            rtbNumeros.BackColor = Color.FromArgb(40, 45, 65);
            rtbNumeros.Font = new Font("Consolas", 11F);
            rtbNumeros.ForeColor = Color.LightCyan;
            rtbNumeros.Location = new Point(30, 290);
            rtbNumeros.Name = "rtbNumeros";
            rtbNumeros.ReadOnly = true;
            rtbNumeros.Size = new Size(650, 200);
            rtbNumeros.TabIndex = 1;
            rtbNumeros.Text = "";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(100, 200, 255);
            lblTitulo.Location = new Point(33, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(619, 74);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "50 Números Naturales";
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblContador.ForeColor = Color.Cyan;
            lblContador.Location = new Point(30, 92);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(261, 45);
            lblContador.TabIndex = 4;
            lblContador.Text = "Número 1 de 50";
            // 
            // grupoResultados
            // 
            grupoResultados.Controls.Add(label1);
            grupoResultados.Controls.Add(label2);
            grupoResultados.Controls.Add(label3);
            grupoResultados.Controls.Add(label4);
            grupoResultados.Controls.Add(lblPares);
            grupoResultados.Controls.Add(lblImpares);
            grupoResultados.Controls.Add(lblPositivos);
            grupoResultados.Controls.Add(lblNegativos);
            grupoResultados.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grupoResultados.ForeColor = Color.Cyan;
            grupoResultados.Location = new Point(30, 510);
            grupoResultados.Name = "grupoResultados";
            grupoResultados.Size = new Size(650, 120);
            grupoResultados.TabIndex = 0;
            grupoResultados.TabStop = false;
            grupoResultados.Text = "RESULTADOS FINALES";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 35);
            label1.Name = "label1";
            label1.Size = new Size(82, 32);
            label1.TabIndex = 0;
            label1.Text = "Pares:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 75);
            label2.Name = "label2";
            label2.Size = new Size(113, 32);
            label2.TabIndex = 1;
            label2.Text = "Impares:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(330, 30);
            label3.Name = "label3";
            label3.Size = new Size(123, 32);
            label3.TabIndex = 2;
            label3.Text = "Positivos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(330, 78);
            label4.Name = "label4";
            label4.Size = new Size(136, 32);
            label4.TabIndex = 3;
            label4.Text = "Negativos:";
            // 
            // lblPares
            // 
            lblPares.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblPares.ForeColor = Color.LimeGreen;
            lblPares.Location = new Point(118, 27);
            lblPares.Name = "lblPares";
            lblPares.Size = new Size(100, 48);
            lblPares.TabIndex = 4;
            lblPares.Text = "0";
            lblPares.Click += lblPares_Click;
            // 
            // lblImpares
            // 
            lblImpares.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblImpares.ForeColor = Color.Orange;
            lblImpares.Location = new Point(120, 71);
            lblImpares.Name = "lblImpares";
            lblImpares.Size = new Size(100, 43);
            lblImpares.TabIndex = 5;
            lblImpares.Text = "0";
            // 
            // lblPositivos
            // 
            lblPositivos.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblPositivos.ForeColor = Color.Cyan;
            lblPositivos.Location = new Point(450, 22);
            lblPositivos.Name = "lblPositivos";
            lblPositivos.Size = new Size(100, 50);
            lblPositivos.TabIndex = 6;
            lblPositivos.Text = "0";
            // 
            // lblNegativos
            // 
            lblNegativos.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblNegativos.ForeColor = Color.IndianRed;
            lblNegativos.Location = new Point(464, 71);
            lblNegativos.Name = "lblNegativos";
            lblNegativos.Size = new Size(101, 46);
            lblNegativos.TabIndex = 7;
            lblNegativos.Text = "0";
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(25, 30, 50);
            panel.Controls.Add(grupoResultados);
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
            panel.Size = new Size(720, 660);
            panel.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 20, 35);
            ClientSize = new Size(720, 660);
            Controls.Add(panel);
            Font = new Font("Segoe UI", 11F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 12 - Contador de 50 Números";
            Load += Form1_Load;
            grupoResultados.ResumeLayout(false);
            grupoResultados.PerformLayout();
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
        private GroupBox grupoResultados;
        private Label lblPares;
        private Label lblImpares;
        private Label lblPositivos;
        private Label lblNegativos;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel;
    }
}