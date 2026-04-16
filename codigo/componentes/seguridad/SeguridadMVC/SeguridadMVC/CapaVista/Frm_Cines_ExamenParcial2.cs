using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Seguridad
{
    public partial class Frm_Cines_ExamenParcial2 : Form
    {
        public Frm_Cines_ExamenParcial2()
        {
            InitializeComponent();
            //Mantenimiento Cines Kenph Luna 9959-22-6326 
            //16/04/2026
            // Configuración del DataGridView
            Capa_Controlador_Navegador.Cls_ConfiguracionDataGridView config =
            new Capa_Controlador_Navegador.Cls_ConfiguracionDataGridView
            {
                Ancho = 1100,
                Alto = 200,
                PosX = 10,
                PosY = 300,
                ColorFondo = Color.AliceBlue,
                TipoScrollBars = ScrollBars.Both,
                Nombre = "dgv_cines"
            };

            // Columnas (tabla + campos)
            string[] columnas = {
                    "cines",
                    "id_cines",
                    "nombre",
                    "Direccion"
                };

            // Etiquetas visibles
            string[] sEtiquetas = {
                    "ID_Cine",
                    "Nombres",
                    "Direccion"
                };

            // ID de aplicación
            int id_aplicacion = 711;
            int id_modulo = 4;
            navegador1.IPkId_Aplicacion = id_aplicacion;
            navegador1.IPkId_Modulo = id_modulo;
            navegador1.configurarDataGridView(config);
            navegador1.SNombreTabla = columnas[0];
            navegador1.SAlias = columnas;
            navegador1.SEtiquetas = sEtiquetas;
            navegador1.mostrarDatos();
        }
    }
}
