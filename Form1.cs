using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropiedadesCondominio
{
    public partial class Form1 : Form
    {
        List<clsPropietario> lstPropietarios = new List<clsPropietario>();
        List<clsPropiedades> lstPropiedades = new List<clsPropiedades>();
        List<clsIntermedia> lstIntermedia = new List<clsIntermedia>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //llamado a la funcion que carga los datos al programa
            loadData();
        }
        public void loadData() {
            /*Leer los archivos de texto y asignar los valores a las listas
              para poder utilizarlos/mostrarlos en el programa*/
            FileStream stream = new FileStream("Propietarios.txt", FileMode.Open, FileAccess.Read);
            FileStream stream2 = new FileStream("Propiedades.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            StreamReader reader2 = new StreamReader(stream2);
            //limpiar las listas para el caso de actualización
            lstPropiedades.Clear();
            lstPropietarios.Clear();
            lstIntermedia.Clear();
            //llenado de la lista de propietario
            while (reader.Peek() > -1) {
                clsPropietario propietarioTemp = new clsPropietario();
                propietarioTemp.Dpi = Convert.ToInt32(reader.ReadLine());
                propietarioTemp.Nombre = reader.ReadLine();
                propietarioTemp.Apellido = reader.ReadLine();
                lstPropietarios.Add(propietarioTemp);
            }
            reader.Close();
            //Llenado de la lista de propiedades
            while (reader2.Peek() > -1)
            {
                clsPropiedades propiedadTemp = new clsPropiedades();
                propiedadTemp.No_deCasa = Convert.ToInt32(reader2.ReadLine());
                propiedadTemp.DpiDueño = Convert.ToInt32(reader2.ReadLine());
                propiedadTemp.CuotaMantenimiento = Convert.ToDouble(reader2.ReadLine());
                lstPropiedades.Add(propiedadTemp);
            }
            reader2.Close();
            //llenado de la lista de datos intermedios
            foreach (var p in lstPropiedades) {
                clsIntermedia intermediaTemp = new clsIntermedia();
                //buscar los datos de un propietario en base al DPI y asignarlos a la lista intermedia
                clsPropietario propietarioTemp = lstPropietarios.Find(n => n.Dpi == p.DpiDueño);
                intermediaTemp.No_deCasa = p.No_deCasa;
                intermediaTemp.CuotaMantenimiento = p.CuotaMantenimiento;
                intermediaTemp.Nombre = propietarioTemp.Nombre;
                intermediaTemp.Apellido = propietarioTemp.Apellido;
            }
            dtgPropiedades.DataSource = null;
            dtgPropiedades.DataSource = lstPropiedades;
            dtgPropiedades.Refresh();
            dtgPropietarios.DataSource = null;
            dtgPropietarios.DataSource = lstPropietarios;
            dtgPropietarios.Refresh();
            dtgIntermedia.DataSource = null;
            dtgIntermedia.DataSource = lstIntermedia;
            dtgIntermedia.Refresh();
        }
        private void registrarPropiedadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstPropietarios.Count > 0)
            {
                frmPropiedades formulario = new frmPropiedades();
                formulario.lstPropietarios = this.lstPropietarios;
                formulario.lstPropiedades = this.lstPropiedades;
                formulario.ShowDialog();
            }
            else MessageBox.Show("Antes de registrar una propiedad, debe registrar un propietario.");
        }

        private void registrarPropietarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPropietarios formulario = new frmPropietarios();
            formulario.lstPropietarios = this.lstPropietarios;
            formulario.ShowDialog();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamado a la función de cargar datos para 'actualizar' los datos
            loadData();
        }
    }
}
