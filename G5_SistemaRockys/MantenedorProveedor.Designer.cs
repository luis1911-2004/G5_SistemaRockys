namespace G5_SistemaRockys
{
    partial class MantenedorProveedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenedorProveedor));
            this.btnConfirmarEliminacion = new System.Windows.Forms.Button();
            this.txtrubro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmarEdicion = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtRUC = new System.Windows.Forms.TextBox();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirmarEliminacion
            // 
            this.btnConfirmarEliminacion.BackColor = System.Drawing.Color.Orange;
            this.btnConfirmarEliminacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmarEliminacion.Location = new System.Drawing.Point(607, 232);
            this.btnConfirmarEliminacion.Name = "btnConfirmarEliminacion";
            this.btnConfirmarEliminacion.Size = new System.Drawing.Size(129, 39);
            this.btnConfirmarEliminacion.TabIndex = 67;
            this.btnConfirmarEliminacion.Text = "CONFIRMAR";
            this.btnConfirmarEliminacion.UseVisualStyleBackColor = false;
            this.btnConfirmarEliminacion.Visible = false;
            this.btnConfirmarEliminacion.Click += new System.EventHandler(this.btnConfirmarEliminacion_Click);
            // 
            // txtrubro
            // 
            this.txtrubro.Location = new System.Drawing.Point(218, 277);
            this.txtrubro.Margin = new System.Windows.Forms.Padding(4);
            this.txtrubro.Name = "txtrubro";
            this.txtrubro.Size = new System.Drawing.Size(175, 30);
            this.txtrubro.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 41);
            this.label1.TabIndex = 65;
            this.label1.Text = "MANTENEDOR PROVEEDOR";
            // 
            // btnConfirmarEdicion
            // 
            this.btnConfirmarEdicion.BackColor = System.Drawing.Color.Orange;
            this.btnConfirmarEdicion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmarEdicion.Location = new System.Drawing.Point(607, 168);
            this.btnConfirmarEdicion.Name = "btnConfirmarEdicion";
            this.btnConfirmarEdicion.Size = new System.Drawing.Size(129, 39);
            this.btnConfirmarEdicion.TabIndex = 64;
            this.btnConfirmarEdicion.Text = "CONFIRMAR";
            this.btnConfirmarEdicion.UseVisualStyleBackColor = false;
            this.btnConfirmarEdicion.Visible = false;
            this.btnConfirmarEdicion.Click += new System.EventHandler(this.btnConfirmarEdicion_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 25);
            this.label7.TabIndex = 63;
            this.label7.Text = "RUC:";
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Location = new System.Drawing.Point(37, 327);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.RowHeadersWidth = 51;
            this.dgvProveedores.Size = new System.Drawing.Size(699, 161);
            this.dgvProveedores.TabIndex = 62;
            this.dgvProveedores.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProveedores_CellMouseDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 61;
            this.label6.Text = "Dirección:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 25);
            this.label5.TabIndex = 60;
            this.label5.Text = "Ciudad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 25);
            this.label4.TabIndex = 59;
            this.label4.Text = "N° Teléfono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 58;
            this.label3.Text = "Rubro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 25);
            this.label2.TabIndex = 57;
            this.label2.Text = "Nombre Proveedor:";
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.Orange;
            this.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_modificar.Location = new System.Drawing.Point(454, 168);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(129, 39);
            this.btn_modificar.TabIndex = 56;
            this.btn_modificar.Text = "MODIFICAR";
            this.btn_modificar.UseVisualStyleBackColor = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.Orange;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_eliminar.Location = new System.Drawing.Point(454, 232);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(129, 39);
            this.btn_eliminar.TabIndex = 55;
            this.btn_eliminar.Text = "ELIMINAR";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_registrar
            // 
            this.btn_registrar.BackColor = System.Drawing.Color.Orange;
            this.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_registrar.Location = new System.Drawing.Point(454, 102);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(129, 39);
            this.btn_registrar.TabIndex = 54;
            this.btn_registrar.Text = "REGISTRAR";
            this.btn_registrar.UseVisualStyleBackColor = false;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(218, 237);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(175, 30);
            this.txtDireccion.TabIndex = 53;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(218, 197);
            this.txtCiudad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(175, 30);
            this.txtCiudad.TabIndex = 52;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(218, 153);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(175, 30);
            this.txtTelefono.TabIndex = 51;
            // 
            // txtRUC
            // 
            this.txtRUC.Location = new System.Drawing.Point(218, 113);
            this.txtRUC.Margin = new System.Windows.Forms.Padding(4);
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.Size = new System.Drawing.Size(175, 30);
            this.txtRUC.TabIndex = 50;
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Location = new System.Drawing.Point(218, 72);
            this.txtNombreProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(175, 30);
            this.txtNombreProveedor.TabIndex = 49;
            // 
            // MantenedorProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(785, 510);
            this.Controls.Add(this.btnConfirmarEliminacion);
            this.Controls.Add(this.txtrubro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfirmarEdicion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvProveedores);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtRUC);
            this.Controls.Add(this.txtNombreProveedor);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MantenedorProveedor";
            this.Text = "MantenedorProveedor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmarEliminacion;
        private System.Windows.Forms.TextBox txtrubro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmarEdicion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtRUC;
        private System.Windows.Forms.TextBox txtNombreProveedor;
    }
}