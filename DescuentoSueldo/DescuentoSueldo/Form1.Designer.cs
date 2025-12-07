namespace DescuentoSueldo
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
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblDescuentoTitulo = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblSueldoNetoTitulo = new System.Windows.Forms.Label();
            this.lblSueldoNeto = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 40);
            this.ClientSize = new System.Drawing.Size(460, 380);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Sueldo Neto";
            this.Load += new System.EventHandler(this.Form1_Load);

            // panel1
            this.panel1.BackColor = System.Drawing.Color.FromArgb(40, 40, 55);
            this.panel1.Controls.Add(this.lblSueldoNetoTitulo);
            this.panel1.Controls.Add(this.lblSueldoNeto);
            this.panel1.Controls.Add(this.lblDescuentoTitulo);
            this.panel1.Controls.Add(this.lblDescuento);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.btnCalcular);
            this.panel1.Controls.Add(this.lblSueldo);
            this.panel1.Controls.Add(this.txtSueldo);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Padding = new System.Windows.Forms.Padding(30);
            this.panel1.Size = new System.Drawing.Size(460, 380);

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(100, 180, 255);
            this.lblTitulo.Location = new System.Drawing.Point(30, 30);
            this.lblTitulo.Size = new System.Drawing.Size(350, 41);
            this.lblTitulo.Text = "Cálculo de Sueldo Neto";

            // lblSueldo
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSueldo.Location = new System.Drawing.Point(30, 100);
            this.lblSueldo.Size = new System.Drawing.Size(140, 25);
            this.lblSueldo.Text = "Sueldo bruto:";

            // txtSueldo
            this.txtSueldo.BackColor = System.Drawing.Color.FromArgb(55, 55, 70);
            this.txtSueldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSueldo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSueldo.ForeColor = System.Drawing.Color.White;
            this.txtSueldo.Location = new System.Drawing.Point(30, 130);
            this.txtSueldo.Size = new System.Drawing.Size(380, 34);
            this.txtSueldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSueldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSueldo_KeyPress);

            // btnCalcular
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(30, 190);
            this.btnCalcular.Size = new System.Drawing.Size(180, 50);
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            // btnLimpiar
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(100, 100, 120);
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(230, 190);
            this.btnLimpiar.Size = new System.Drawing.Size(180, 50);
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            // lblDescuentoTitulo
            this.lblDescuentoTitulo.AutoSize = true;
            this.lblDescuentoTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDescuentoTitulo.Location = new System.Drawing.Point(30, 270);
            this.lblDescuentoTitulo.Size = new System.Drawing.Size(120, 28);
            this.lblDescuentoTitulo.Text = "Descuento:";

            // lblDescuento
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblDescuento.ForeColor = System.Drawing.Color.IndianRed;
            this.lblDescuento.Location = new System.Drawing.Point(180, 265);
            this.lblDescuento.Size = new System.Drawing.Size(80, 32);
            this.lblDescuento.Text = "$0.00";

            // lblSueldoNetoTitulo
            this.lblSueldoNetoTitulo.AutoSize = true;
            this.lblSueldoNetoTitulo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblSueldoNetoTitulo.Location = new System.Drawing.Point(30, 310);
            this.lblSueldoNetoTitulo.Size = new System.Drawing.Size(160, 30);
            this.lblSueldoNetoTitulo.Text = "Sueldo Neto:";

            // lblSueldoNeto
            this.lblSueldoNeto.AutoSize = true;
            this.lblSueldoNeto.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblSueldoNeto.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblSueldoNeto.Location = new System.Drawing.Point(200, 305);
            this.lblSueldoNeto.Size = new System.Drawing.Size(100, 41);
            this.lblSueldoNeto.Text = "$0.00";

            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblDescuentoTitulo;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblSueldoNetoTitulo;
        private System.Windows.Forms.Label lblSueldoNeto;
        private System.Windows.Forms.Panel panel1;
    }
}