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
        List<clsNomApCuota> lstIntermedia = new List<clsNomApCuota>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void loadData() {
            FileStream stream = new FileStream("Propietarios.txt", FileMode.Open, FileAccess.Read);
            FileStream stream2 = new FileStream("Propiedades.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            StreamReader reader2 = new StreamReader(stream2);

            while (reader.Peek() > -1) {
                clsPropietario propietarioTemp = new clsPropietario();
                propietarioTemp.Dpi = Convert.ToInt32(reader.ReadLine());
                propietarioTemp.Nombre = reader.ReadLine();
                propietarioTemp.Apellido = reader.ReadLine();
                lstPropietarios.Add(propietarioTemp);
            }
            reader.Close();
        }
        private void registrarPropiedadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPropiedades formulario = new frmPropiedades();
            formulario.lstPropietarios = this.lstPropietarios;
            formulario.lstPropiedades = this.lstPropiedades;
            formulario.ShowDialog();
        }

        private void registrarPropietarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPropietarios formulario = new frmPropietarios();
            formulario.lstPropietarios = this.lstPropietarios;
            formulario.ShowDialog();
        }
    }
}
