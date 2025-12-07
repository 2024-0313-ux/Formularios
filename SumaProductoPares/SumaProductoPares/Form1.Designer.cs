namespace SumaProductoPares
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
            rtbProceso = new RichTextBox();
            lblTitulo = new Label();
            lblSuma = new Label();
            lblProducto = new Label();
            lblCantidad = new Label();
            btnRecalcular = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel = new Panel();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // rtbProceso
            // 
            rtbProceso.BackColor = Color.FromArgb(35, 40, 65);
            rtbProceso.BorderStyle = BorderStyle.FixedSingle;
            rtbProceso.Font = new Font("Consolas", 16F, FontStyle.Bold);
            rtbProceso.ForeColor = Color.LightGreen;
            rtbProceso.Location = new Point(30, 110);
            rtbProceso.Name = "rtbProceso";
            rtbProceso.ReadOnly = true;
            rtbProceso.Size = new Size(545, 145);
            rtbProceso.TabIndex = 7;
            rtbProceso.Text = "";
            rtbProceso.WordWrap = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(100, 200, 255);
            lblTitulo.Location = new Point(30, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(444, 81);
            lblTitulo.TabIndex = 8;
            lblTitulo.Text = "Pares: 20 → 30";
            // 
            // lblSuma
            // 
            lblSuma.AutoSize = true;
            lblSuma.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblSuma.ForeColor = Color.LimeGreen;
            lblSuma.Location = new Point(183, 315);
            lblSuma.Name = "lblSuma";
            lblSuma.Size = new Size(163, 96);
            lblSuma.TabIndex = 6;
            lblSuma.Text = "150";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblProducto.ForeColor = Color.Gold;
            lblProducto.Location = new Point(220, 401);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(286, 74);
            lblProducto.TabIndex = 5;
            lblProducto.Text = "5,933,760";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblCantidad.ForeColor = Color.Cyan;
            lblCantidad.Location = new Point(323, 277);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(46, 54);
            lblCantidad.TabIndex = 4;
            lblCantidad.Text = "6";
            // 
            // btnRecalcular
            // 
            btnRecalcular.BackColor = Color.FromArgb(0, 140, 200);
            btnRecalcular.FlatAppearance.BorderSize = 0;
            btnRecalcular.FlatStyle = FlatStyle.Flat;
            btnRecalcular.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnRecalcular.ForeColor = Color.White;
            btnRecalcular.Location = new Point(30, 490);
            btnRecalcular.Name = "btnRecalcular";
            btnRecalcular.Size = new Size(620, 60);
            btnRecalcular.TabIndex = 0;
            btnRecalcular.Text = "RECALCULAR";
            btnRecalcular.UseVisualStyleBackColor = false;
            btnRecalcular.Click += btnRecalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(12, 277);
            label1.Name = "label1";
            label1.Size = new Size(305, 38);
            label1.TabIndex = 3;
            label1.Text = "Cantidad de números:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.Location = new Point(30, 333);
            label2.Name = "label2";
            label2.Size = new Size(147, 45);
            label2.TabIndex = 2;
            label2.Text = "SUMA =";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label3.Location = new Point(0, 411);
            label3.Name = "label3";
            label3.Size = new Size(226, 45);
            label3.TabIndex = 1;
            label3.Text = "PRODUCTO =";
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(25, 30, 50);
            panel.Controls.Add(btnRecalcular);
            panel.Controls.Add(label3);
            panel.Controls.Add(label2);
            panel.Controls.Add(label1);
            panel.Controls.Add(lblCantidad);
            panel.Controls.Add(lblProducto);
            panel.Controls.Add(lblSuma);
            panel.Controls.Add(rtbProceso);
            panel.Controls.Add(lblTitulo);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Padding = new Padding(30);
            panel.Size = new Size(716, 571);
            panel.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 20, 35);
            ClientSize = new Size(716, 571);
            Controls.Add(panel);
            Font = new Font("Segoe UI", 11F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 15 - Pares del 20 al 30";
            Load += Form1_Load;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        private RichTextBox rtbProceso;
        private Label lblTitulo;
        private Label lblSuma;
        private Label lblProducto;
        private Label lblCantidad;
        private Button btnRecalcular;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel;
    }
}
