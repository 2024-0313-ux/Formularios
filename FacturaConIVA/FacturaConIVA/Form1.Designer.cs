namespace FacturaConIVA
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
            txtPrecio = new TextBox();
            txtCantidad = new TextBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            lblTitulo = new Label();
            lblPrecio = new Label();
            lblCantidad = new Label();
            grupoFactura = new GroupBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            lblPrecioVenta = new Label();
            lblIVA = new Label();
            lblPrecioBruto = new Label();
            lblDescuento = new Label();
            lblTotalPagar = new Label();
            panel = new Panel();
            grupoFactura.SuspendLayout();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.FromArgb(50, 55, 80);
            txtPrecio.BorderStyle = BorderStyle.FixedSingle;
            txtPrecio.Font = new Font("Segoe UI", 16F);
            txtPrecio.ForeColor = Color.White;
            txtPrecio.Location = new Point(30, 140);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(500, 50);
            txtPrecio.TabIndex = 5;
            txtPrecio.TextAlign = HorizontalAlignment.Right;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = Color.FromArgb(50, 55, 80);
            txtCantidad.BorderStyle = BorderStyle.FixedSingle;
            txtCantidad.Font = new Font("Segoe UI", 16F);
            txtCantidad.ForeColor = Color.White;
            txtCantidad.Location = new Point(30, 230);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(500, 50);
            txtCantidad.TabIndex = 3;
            txtCantidad.TextAlign = HorizontalAlignment.Center;
            txtCantidad.KeyPress += txtCantidad_KeyPress;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(0, 170, 120);
            btnCalcular.FlatAppearance.BorderSize = 0;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnCalcular.ForeColor = Color.White;
            btnCalcular.Location = new Point(30, 300);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(240, 70);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "CALCULAR FACTURA";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(200, 60, 60);
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(290, 300);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(240, 70);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "NUEVA FACTURA";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(100, 200, 255);
            lblTitulo.Location = new Point(30, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(489, 70);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "Factura de Compra";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 12F);
            lblPrecio.Location = new Point(30, 110);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(207, 32);
            lblPrecio.TabIndex = 6;
            lblPrecio.Text = "Precio unitario ($):";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 12F);
            lblCantidad.Location = new Point(30, 200);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(244, 32);
            lblCantidad.TabIndex = 4;
            lblCantidad.Text = "Cantidad de artículos:";
            // 
            // grupoFactura
            // 
            grupoFactura.Controls.Add(label6);
            grupoFactura.Controls.Add(label7);
            grupoFactura.Controls.Add(label8);
            grupoFactura.Controls.Add(label9);
            grupoFactura.Controls.Add(label10);
            grupoFactura.Controls.Add(lblPrecioVenta);
            grupoFactura.Controls.Add(lblIVA);
            grupoFactura.Controls.Add(lblPrecioBruto);
            grupoFactura.Controls.Add(lblDescuento);
            grupoFactura.Controls.Add(lblTotalPagar);
            grupoFactura.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grupoFactura.ForeColor = Color.Cyan;
            grupoFactura.Location = new Point(30, 390);
            grupoFactura.Name = "grupoFactura";
            grupoFactura.Size = new Size(517, 230);
            grupoFactura.TabIndex = 0;
            grupoFactura.TabStop = false;
            grupoFactura.Text = "DETALLE DE LA FACTURA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 35);
            label6.Name = "label6";
            label6.Size = new Size(198, 32);
            label6.TabIndex = 0;
            label6.Text = "Precio de venta:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 65);
            label7.Name = "label7";
            label7.Size = new Size(135, 32);
            label7.TabIndex = 1;
            label7.Text = "IVA (15%):";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 95);
            label8.Name = "label8";
            label8.Size = new Size(164, 32);
            label8.TabIndex = 2;
            label8.Text = "Precio bruto:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(20, 125);
            label9.Name = "label9";
            label9.Size = new Size(300, 32);
            label9.TabIndex = 3;
            label9.Text = "Descuento (5% si ≥ $50):";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label10.Location = new Point(20, 160);
            label10.Name = "label10";
            label10.Size = new Size(275, 45);
            label10.TabIndex = 4;
            label10.Text = "TOTAL A PAGAR:";
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.Font = new Font("Segoe UI", 14F);
            lblPrecioVenta.Location = new Point(300, 32);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(100, 35);
            lblPrecioVenta.TabIndex = 5;
            lblPrecioVenta.Text = "$0.00";
            // 
            // lblIVA
            // 
            lblIVA.Font = new Font("Segoe UI", 14F);
            lblIVA.Location = new Point(300, 62);
            lblIVA.Name = "lblIVA";
            lblIVA.Size = new Size(100, 35);
            lblIVA.TabIndex = 6;
            lblIVA.Text = "$0.00";
            // 
            // lblPrecioBruto
            // 
            lblPrecioBruto.Font = new Font("Segoe UI", 14F);
            lblPrecioBruto.Location = new Point(300, 92);
            lblPrecioBruto.Name = "lblPrecioBruto";
            lblPrecioBruto.Size = new Size(100, 35);
            lblPrecioBruto.TabIndex = 7;
            lblPrecioBruto.Text = "$0.00";
            // 
            // lblDescuento
            // 
            lblDescuento.Font = new Font("Segoe UI", 14F);
            lblDescuento.Location = new Point(300, 122);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(100, 38);
            lblDescuento.TabIndex = 8;
            lblDescuento.Text = "$0.00 (sin descuento)";
            // 
            // lblTotalPagar
            // 
            lblTotalPagar.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTotalPagar.ForeColor = Color.Gold;
            lblTotalPagar.Location = new Point(300, 160);
            lblTotalPagar.Name = "lblTotalPagar";
            lblTotalPagar.Size = new Size(200, 61);
            lblTotalPagar.TabIndex = 9;
            lblTotalPagar.Text = "$0.00";
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(30, 35, 55);
            panel.Controls.Add(grupoFactura);
            panel.Controls.Add(btnLimpiar);
            panel.Controls.Add(btnCalcular);
            panel.Controls.Add(txtCantidad);
            panel.Controls.Add(lblCantidad);
            panel.Controls.Add(txtPrecio);
            panel.Controls.Add(lblPrecio);
            panel.Controls.Add(lblTitulo);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Padding = new Padding(30);
            panel.Size = new Size(580, 620);
            panel.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 25, 40);
            ClientSize = new Size(580, 620);
            Controls.Add(panel);
            Font = new Font("Segoe UI", 11F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 11 - Factura con IVA y Descuento";
            Load += Form1_Load;
            grupoFactura.ResumeLayout(false);
            grupoFactura.PerformLayout();
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        private TextBox txtPrecio;
        private TextBox txtCantidad;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Label lblTitulo;
        private Label lblPrecio;
        private Label lblCantidad;
        private GroupBox grupoFactura;
        private Label lblPrecioVenta;
        private Label lblIVA;
        private Label lblPrecioBruto;
        private Label lblDescuento;
        private Label lblTotalPagar;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Panel panel;
    }
}