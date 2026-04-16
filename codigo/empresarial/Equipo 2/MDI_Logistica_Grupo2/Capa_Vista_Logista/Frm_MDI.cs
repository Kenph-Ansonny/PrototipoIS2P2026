using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Vista_LineaProd;
using Capa_Vista_Reporteador;
using Capa_Vista_Seguridad;
using Capa_Vista_Mov_Inv;

using Capa_Vista_OrdenProduccion;

namespace Capa_Vista_Logista
{
    public partial class Frm_MDI : Form
    {
        public Frm_MDI()
        {
            InitializeComponent();
        }
        

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
  

        }

        private void cuentaPorCobrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Mantenimiento_Tipo_Op_CXC CXC = new Frm_Mantenimiento_Tipo_Op_CXC();
            CXC.ShowDialog();
        }

        private void lineaDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Mantenimiento_LineaProducto LineaProducto = new Frm_Mantenimiento_LineaProducto();
            LineaProducto.ShowDialog();
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Frm_MDI_Load(object sender, EventArgs e)
        {

        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            
        }

        private void empresaTransporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void reporteadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Reportes Reporteador = new Frm_Reportes();
            Reporteador.ShowDialog();
        }

        private void seguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Seguridad MDI_seguridad = new Frm_Seguridad();
            MDI_seguridad.ShowDialog();
        }

        private void bodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
      
        }

        private void movimientoOperacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
     
        }

        private void cuentasPorPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void pagosVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void movimientoDeInventariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void ordenDeProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_OrdenProduccion_Encabezado Orden = new Frm_OrdenProduccion_Encabezado();
            Orden.ShowDialog();
        }
    }
}
