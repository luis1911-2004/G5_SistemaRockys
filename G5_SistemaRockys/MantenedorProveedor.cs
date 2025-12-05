using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G5_SistemaRockys
{
    public partial class MantenedorProveedor : Form
    {
        public MantenedorProveedor()
        {
            InitializeComponent();
            ListarProveedor();
        }
        private int ProveedorIDSeleccionado = 0;
        private bool ModoEdicionActivo = false;
        private bool ModoEliminacionActivo = false;

        public void ListarProveedor()
        {
            dgvProveedores.DataSource = logProveedor.Instancia.ListarProveedor();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            if (txtRUC.Text.Trim().Length != 11)
            {
                MessageBox.Show("El RUC debe contener exactamente 11 números.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRUC.Focus();
                return;
            }

            if (txtTelefono.Text.Trim().Length != 9)
            {
                MessageBox.Show("El Número de Teléfono debe contener exactamente 9 números.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefono.Focus();
                return;
            }

            try
            {
                entProveedor p = new entProveedor();

                p.NombreProveedor = txtNombreProveedor.Text.Trim();
                p.RUC = txtRUC.Text.Trim();
                p.TelefonoProvee = txtTelefono.Text.Trim();
                p.CiudadProvee = txtCiudad.Text.Trim();
                p.DireccionProvee = txtDireccion.Text.Trim();
                p.Rubro = txtrubro.Text.Trim();

                logProveedor.Instancia.InsertaProveedor(p);

                MessageBox.Show("Proveedor registrado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar proveedor: " + ex.Message, "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LimpiarVariables();
            ListarProveedor();
        }
        private void LimpiarVariables()
        {
            txtNombreProveedor.Text = "";
            txtRUC.Text = "";
            txtTelefono.Text = "";
            txtCiudad.Text = "";
            txtDireccion.Text = "";
            txtrubro.Text = "";
            ProveedorIDSeleccionado = 0;
            ModoEdicionActivo = false;
            ModoEliminacionActivo = false;
        }

        private void dgvProveedores_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;


            if (!ModoEdicionActivo && !ModoEliminacionActivo)
            {
                MessageBox.Show("Debe presionar el botón 'Modificar' o 'Eliminar' primero para seleccionar un registro.", "Modo No Activo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow filaActual = dgvProveedores.Rows[e.RowIndex];

            ProveedorIDSeleccionado = Convert.ToInt32(filaActual.Cells["ProveedorID"].Value);


            txtNombreProveedor.Text = filaActual.Cells["NombreProveedor"].Value.ToString();
            txtRUC.Text = filaActual.Cells["RUC"].Value.ToString();
            txtTelefono.Text = filaActual.Cells["TelefonoProvee"].Value.ToString();
            txtCiudad.Text = filaActual.Cells["CiudadProvee"].Value.ToString();
            txtDireccion.Text = filaActual.Cells["DireccionProvee"].Value.ToString();
            txtrubro.Text = filaActual.Cells["Rubro"].Value.ToString();

            if (ModoEdicionActivo)
            {
                MessageBox.Show("Datos cargados. Modifique los campos y presione 'Confirmar Edición'.", "Listo para editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ModoEliminacionActivo)
            {
                MessageBox.Show("Proveedor seleccionado. Presione 'Confirmar Eliminación' para borrar.", "Listo para eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seleccione una fila en el DataGridView inferior para cargar los datos del proveedor.", "Instrucción", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btn_registrar.Visible = false;
            btn_eliminar.Visible = false;
            btnConfirmarEdicion.Visible = true;
            ModoEdicionActivo = true;
        }

        private void btnConfirmarEdicion_Click(object sender, EventArgs e)
        {
            if (ProveedorIDSeleccionado == 0)
            {
                MessageBox.Show("Debe seleccionar un proveedor de la tabla para modificar. Use doble click después de iniciar la edición.",
                                "Error de Edición", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtRUC.Text.Trim().Length != 11)
            {
                MessageBox.Show("El RUC debe contener exactamente 11 números.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRUC.Focus();
                return;
            }

            if (txtTelefono.Text.Trim().Length != 9)
            {
                MessageBox.Show("El Número de Teléfono debe contener exactamente 9 números.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefono.Focus();
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Está seguro que desea guardar los cambios en este proveedor?", "Confirmar Modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    entProveedor p = new entProveedor();

                    p.ProveedorID = ProveedorIDSeleccionado;

                    p.NombreProveedor = txtNombreProveedor.Text.Trim();
                    p.RUC = txtRUC.Text.Trim();
                    p.TelefonoProvee = txtTelefono.Text.Trim();
                    p.CiudadProvee = txtCiudad.Text.Trim();
                    p.DireccionProvee = txtDireccion.Text.Trim();
                    p.Rubro = txtrubro.Text.Trim();

                    logProveedor.Instancia.EditaProveedor(p);

                    MessageBox.Show("Proveedor modificado y cambios guardados exitosamente.", "Modificación Exitosa");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar proveedor: " + ex.Message, "Error de Edición", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            LimpiarVariables();

            btn_registrar.Visible = true;
            btnConfirmarEdicion.Visible = false;
            btn_eliminar.Visible = true;
            ListarProveedor();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

            LimpiarVariables();

            MessageBox.Show("Seleccione el proveedor que desea ELIMINAR permanentemente haciendo doble click en la tabla inferior.",
                            "Instrucción de Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            btn_registrar.Visible = false;
            btn_modificar.Visible = false;
            btnConfirmarEdicion.Visible = false;
            btnConfirmarEliminacion.Visible = true;

            ModoEliminacionActivo = true;
        }

        private void btnConfirmarEliminacion_Click(object sender, EventArgs e)
        {
            if (ProveedorIDSeleccionado == 0)
            {
                MessageBox.Show("Primero debe seleccionar un proveedor de la tabla usando doble click.", "Error de Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "ADVERTENCIA CRÍTICA: ¿Está seguro que desea ELIMINAR permanentemente (BORRADO FÍSICO) al proveedor ID: " + ProveedorIDSeleccionado + "?\n\nEsta acción es irreversible y fallará si tiene Órdenes de Compra asociadas.",
                "CONFIRMAR ELIMINACIÓN PERMANENTE",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    entProveedor p = new entProveedor();
                    p.ProveedorID = ProveedorIDSeleccionado;

                    logProveedor.Instancia.EliminarProveedor(p);

                    MessageBox.Show("Proveedor eliminado permanentemente de la base de datos.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("FK_Orden_Proveedor"))
                    {
                        MessageBox.Show("ERROR: No se puede eliminar el proveedor. Tiene Órdenes de Compra registradas.",
                                        "Error de Integridad Referencial", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar proveedor: " + ex.Message, "Error General", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            LimpiarVariables();
            btn_registrar.Visible = true;
            btn_modificar.Visible = true;
            btnConfirmarEliminacion.Visible = false;
            ListarProveedor();
        }
    }
}
