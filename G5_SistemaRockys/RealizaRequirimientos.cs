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
    public partial class RealizaRequirimientos : Form
    {
        public RealizaRequirimientos()
        {
            InitializeComponent();
            ListarRequerimiento();
        }
        int RequerimientoIDSeleccionado = 0;
        public void ListarRequerimiento()
        {
            try
            {
                dgvRequerimientos.DataSource = logRequerimiento.Instancia.ListarRequerimiento();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de requerimientos: " + ex.Message);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("Debe ingresar la descripción del requerimiento.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDescripcion.Focus();
                    return;
                }

                entRequerimiento req = new entRequerimiento();

                req.Descripcion = txtDescripcion.Text.Trim();

                logRequerimiento.Instancia.InsertaRequerimiento(req);

                MessageBox.Show("Requerimiento registrado exitosamente con estado PENDIENTE.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar requerimiento: " + ex.Message, "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtDescripcion.Text = "";
            ListarRequerimiento();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (RequerimientoIDSeleccionado == 0)
            {
                MessageBox.Show("Debe seleccionar un requerimiento de la tabla (usando doble click) para eliminarlo.", "Error de Selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. Confirmación CRÍTICA para la eliminación permanente
            DialogResult resultado = MessageBox.Show(
                "ADVERTENCIA: ¿Está seguro que desea ELIMINAR permanentemente al Requerimiento ID: " + RequerimientoIDSeleccionado + "?\n\nEsta acción no se puede deshacer y fallará si existen Órdenes de Compra asociadas.",
                "CONFIRMAR ELIMINACIÓN PERMANENTE",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    entRequerimiento req = new entRequerimiento();
                    req.RequerimientoID = RequerimientoIDSeleccionado;

                    // Llama a la Capa Lógica
                    logRequerimiento.Instancia.EliminarRequerimiento(req);

                    MessageBox.Show("Requerimiento eliminado permanentemente de la base de datos.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Manejo del error de integridad referencial (llave foránea)
                    if (ex.Message.Contains("FK_Orden_Requerimiento"))
                    {
                        MessageBox.Show("ERROR: No se puede eliminar el requerimiento porque tiene Órdenes de Compra asociadas.", "Error de Integridad Referencial", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar requerimiento: " + ex.Message, "Error General", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // 2. Limpia el ID y refresca la lista
                RequerimientoIDSeleccionado = 0;
                ListarRequerimiento();
            }
        }

        private void dgvRequerimientos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow filaActual = dgvRequerimientos.Rows[e.RowIndex];

            RequerimientoIDSeleccionado = Convert.ToInt32(filaActual.Cells["RequerimientoID"].Value);

            MessageBox.Show("Requerimiento ID: " + RequerimientoIDSeleccionado + " seleccionado para eliminación.", "Listo para borrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}   
