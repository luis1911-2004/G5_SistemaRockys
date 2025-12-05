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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Mproveedor_Click(object sender, EventArgs e)
        {
            // 1. Crear una nueva instancia del formulario de destino
            MantenedorProveedor nuevoForm = new MantenedorProveedor();

            // 2. Mostrar el nuevo formulario
            nuevoForm.Show();
        }

        private void btn_Mtipoinsumos_Click(object sender, EventArgs e)
        {
            MantenedorTipoInsumos nuevoForm = new MantenedorTipoInsumos();

            // 2. Mostrar el nuevo formulario
            nuevoForm.Show();
        }

        private void btn_Mmotivoreclamo_Click(object sender, EventArgs e)
        {
            MantenedorMotivoReclamo nuevoForm = new MantenedorMotivoReclamo();

            // 2. Mostrar el nuevo formulario
            nuevoForm.Show();
        }

        private void btn_Mformapago_Click(object sender, EventArgs e)
        {
            MantenedorFormasDePago nuevoForm = new MantenedorFormasDePago();

            // 2. Mostrar el nuevo formulario
            nuevoForm.Show();
        }

        private void btn_Mestadopreparacion_Click(object sender, EventArgs e)
        {
            MantenedorEstadoPreparación nuevoForm = new MantenedorEstadoPreparación();

            // 2. Mostrar el nuevo formulario
            nuevoForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RealizaPedidoyIngresoVenta nuevoForm = new RealizaPedidoyIngresoVenta();

            // 2. Mostrar el nuevo formulario
            nuevoForm.Show();
        }

        private void btnfallamantenimiento_Click(object sender, EventArgs e)
        {
            FallaMantenimiento nuevoForm = new FallaMantenimiento();

            // 2. Mostrar el nuevo formulario
            nuevoForm.Show();
        }

        private void btnmonitoreopedidos_Click(object sender, EventArgs e)
        {
            MonitoreoPedidos nuevoForm = new MonitoreoPedidos();

            // 2. Mostrar el nuevo formulario
            nuevoForm.Show();
        }

        private void btnrecepcioncomanda_Click(object sender, EventArgs e)
        {
            RecepcionComanda nuevoForm = new RecepcionComanda();

            // 2. Mostrar el nuevo formulario
            nuevoForm.Show();
        }

        private void btnregnoconformidadinsumos_Click(object sender, EventArgs e)
        {
            RegNoConformidadInsumos nuevoForm = new RegNoConformidadInsumos();

            // 2. Mostrar el nuevo formulario
            nuevoForm.Show();
        }

        private void btn_ordencompra_Click(object sender, EventArgs e)
        {
            OrdenCompra nuevoForm = new OrdenCompra();

            // 2. Mostrar el nuevo formulario
            nuevoForm.Show();
        }

        private void btn_regretiroinsumo_Click(object sender, EventArgs e)
        {
            RegRetiroInsumos nuevoForm = new RegRetiroInsumos();

            // 2. Mostrar el nuevo formulario
            nuevoForm.Show();
        }

        private void btn_realizanotaingresoinsumo_Click(object sender, EventArgs e)
        {
            RealizarNotaIngreso nuevoForm = new RealizarNotaIngreso();

            // 2. Mostrar el nuevo formulario
            nuevoForm.Show();
        }

        private void btn_requirimientos_Click(object sender, EventArgs e)
        {
            RealizaRequirimientos nuevoForm = new RealizaRequirimientos();

            // 2. Mostrar el nuevo formulario
            nuevoForm.Show();
        }

    }
}
