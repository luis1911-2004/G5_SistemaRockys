namespace G5_SistemaRockys
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Mproveedor = new System.Windows.Forms.Button();
            this.btn_Mtipoinsumos = new System.Windows.Forms.Button();
            this.btn_Mmotivoreclamo = new System.Windows.Forms.Button();
            this.btn_Mformapago = new System.Windows.Forms.Button();
            this.btn_Mestadopreparacion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Mproveedor
            // 
            this.btn_Mproveedor.Location = new System.Drawing.Point(504, 69);
            this.btn_Mproveedor.Name = "btn_Mproveedor";
            this.btn_Mproveedor.Size = new System.Drawing.Size(151, 38);
            this.btn_Mproveedor.TabIndex = 0;
            this.btn_Mproveedor.Text = "Mantenedor Proveedor";
            this.btn_Mproveedor.UseVisualStyleBackColor = true;
            this.btn_Mproveedor.Click += new System.EventHandler(this.btn_Mproveedor_Click);
            // 
            // btn_Mtipoinsumos
            // 
            this.btn_Mtipoinsumos.Location = new System.Drawing.Point(504, 128);
            this.btn_Mtipoinsumos.Name = "btn_Mtipoinsumos";
            this.btn_Mtipoinsumos.Size = new System.Drawing.Size(151, 38);
            this.btn_Mtipoinsumos.TabIndex = 1;
            this.btn_Mtipoinsumos.Text = "Mantenedor Tipo Insumos";
            this.btn_Mtipoinsumos.UseVisualStyleBackColor = true;
            this.btn_Mtipoinsumos.Click += new System.EventHandler(this.btn_Mtipoinsumos_Click);
            // 
            // btn_Mmotivoreclamo
            // 
            this.btn_Mmotivoreclamo.Location = new System.Drawing.Point(504, 260);
            this.btn_Mmotivoreclamo.Name = "btn_Mmotivoreclamo";
            this.btn_Mmotivoreclamo.Size = new System.Drawing.Size(151, 38);
            this.btn_Mmotivoreclamo.TabIndex = 2;
            this.btn_Mmotivoreclamo.Text = "Mantenedor Motivo Reclamo";
            this.btn_Mmotivoreclamo.UseVisualStyleBackColor = true;
            this.btn_Mmotivoreclamo.Click += new System.EventHandler(this.btn_Mmotivoreclamo_Click);
            // 
            // btn_Mformapago
            // 
            this.btn_Mformapago.Location = new System.Drawing.Point(504, 321);
            this.btn_Mformapago.Name = "btn_Mformapago";
            this.btn_Mformapago.Size = new System.Drawing.Size(151, 38);
            this.btn_Mformapago.TabIndex = 3;
            this.btn_Mformapago.Text = "Mantenedor Forma Pago";
            this.btn_Mformapago.UseVisualStyleBackColor = true;
            this.btn_Mformapago.Click += new System.EventHandler(this.btn_Mformapago_Click);
            // 
            // btn_Mestadopreparacion
            // 
            this.btn_Mestadopreparacion.Location = new System.Drawing.Point(504, 195);
            this.btn_Mestadopreparacion.Name = "btn_Mestadopreparacion";
            this.btn_Mestadopreparacion.Size = new System.Drawing.Size(151, 38);
            this.btn_Mestadopreparacion.TabIndex = 4;
            this.btn_Mestadopreparacion.Text = "Mantenedor Estado Preparación";
            this.btn_Mestadopreparacion.UseVisualStyleBackColor = true;
            this.btn_Mestadopreparacion.Click += new System.EventHandler(this.btn_Mestadopreparacion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(521, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sección Mantenedores";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Mestadopreparacion);
            this.Controls.Add(this.btn_Mformapago);
            this.Controls.Add(this.btn_Mmotivoreclamo);
            this.Controls.Add(this.btn_Mtipoinsumos);
            this.Controls.Add(this.btn_Mproveedor);
            this.Name = "Form1";
            this.Text = "MenúPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Mproveedor;
        private System.Windows.Forms.Button btn_Mtipoinsumos;
        private System.Windows.Forms.Button btn_Mmotivoreclamo;
        private System.Windows.Forms.Button btn_Mformapago;
        private System.Windows.Forms.Button btn_Mestadopreparacion;
        private System.Windows.Forms.Label label1;
    }
}

