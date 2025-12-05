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
    public partial class RealizaOrdenDeCompra : Form
    {
        public RealizaOrdenDeCompra()
        {
            InitializeComponent();
            ListarOrdenDeCompra();
            CargarCombosprovee();
            CargarCombosrequiri();
        }
        public void ListarOrdenDeCompra()
        {
            try
            {
                // Asumiendo que tu DataGridView se llama dgvOrdenesDeCompra
                dgvOrdenesDeCompra.DataSource = logOrdenDeCompra.Instancia.ListarOrdenDeCompra();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de órdenes de compra: " + ex.Message);
            }
        }
        public void CargarCombosprovee()
        {
            try
            {
                // Cargar Proveedores
                cmbProveedor.DataSource = logProveedor.Instancia.ListarProveedor();
                cmbProveedor.DisplayMember = "NombreProveedor"; // Lo que se muestra al usuario
                cmbProveedor.ValueMember = "ProveedorID";       // El ID que se guarda
                cmbProveedor.SelectedIndex = -1; // Opcional: deja el combo sin selección inicial
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los listados de Proveedores/Requerimientos: " + ex.Message, "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CargarCombosrequiri()
        {
            try
            {
                // Cargar Proveedores
                cmbRequerimiento.DataSource = logRequerimiento.Instancia.ListarRequerimiento();
                cmbRequerimiento.DisplayMember = "Descripcion";
                cmbRequerimiento.ValueMember = "RequerimientoID";
                cmbRequerimiento.SelectedIndex = -1; // Opcional: deja el combo sin selección inicial
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los listados de Proveedores/Requerimientos: " + ex.Message, "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                // 1. Validación de selección en ComboBoxes
                if (cmbProveedor.SelectedValue == null || cmbRequerimiento.SelectedValue == null || cmbProveedor.SelectedIndex == -1 || cmbRequerimiento.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un Proveedor y un Requerimiento válidos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                entOrdenDeCompra oc = new entOrdenDeCompra();

                // 2. Mapeo de campos del formulario a la entidad
                // OBTENER IDs DE LOS VALUEMEMBERS:
                oc.ProveedorID = (int)cmbProveedor.SelectedValue;
                oc.RequerimientoID = (int)cmbRequerimiento.SelectedValue;

                // ELIMINAMOS: oc.Fecha = dtpFechaOC.Value.Date;

                // 3. Llama al método de la Capa Lógica
                logOrdenDeCompra.Instancia.InsertaOrdenDeCompra(oc);

                MessageBox.Show("Orden de Compra registrada exitosamente con la fecha actual del servidor y estado PENDIENTE.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar Orden de Compra: " + ex.Message, "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ListarOrdenDeCompra();
        }
    }
}
