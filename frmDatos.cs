using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropiedadesCondominio
{
    public partial class frmDatos : Form
    {
        public List<clsPropietario> lstPropietarios = new List<clsPropietario>();
        public List<clsPropiedades> lstPropiedades = new List<clsPropiedades>();
        public List<clsIntermedia> lstIntermedia = new List<clsIntermedia>();
        public List<clsCantidadPropiedades> lstDatosCantidadPropiedades = new List<clsCantidadPropiedades>();
        public frmDatos()
        {
            InitializeComponent();
        }
        public void actualizar() {
            foreach (var pd in lstPropiedades) {
                clsPropietario propietarioTemp = lstPropietarios.Find(pt=>pt.Dpi == pd.Dpi_Dueño);
                clsCantidadPropiedades datosCantidadPropiedades = lstDatosCantidadPropiedades.Find(cp => cp.Dpi == pd.Dpi_Dueño);
                if (datosCantidadPropiedades == null)
                {
                    datosCantidadPropiedades = new clsCantidadPropiedades();
                    datosCantidadPropiedades.CantidadPropiedades = 1;
                    datosCantidadPropiedades.CuotaMantenimientoTotal = pd.CuotaMantenimiento;
                    datosCantidadPropiedades.Dpi = pd.Dpi_Dueño;
                    datosCantidadPropiedades.NombreApellido = propietarioTemp.Nombre + " " + propietarioTemp.Apellido;
                    lstDatosCantidadPropiedades.Add(datosCantidadPropiedades);
                }
                else {
                    foreach (var dato in lstDatosCantidadPropiedades) {
                        if (dato.Dpi.Equals(datosCantidadPropiedades.Dpi)) {
                            dato.CantidadPropiedades++;
                            dato.CuotaMantenimientoTotal += pd.CuotaMantenimiento;
                        }
                    }
                }
            }
            propietarioConMasPropiedades();
            propietarioConCuotaAlta();
            cuotasAltas();
            cuotasBajas();

        }
        private void propietarioConMasPropiedades() {
            //Alumno mayor = alumnos.OrderByDescending(al => al.Promedio).First();
            clsCantidadPropiedades datoTemp = lstDatosCantidadPropiedades.OrderByDescending(dato => dato.CantidadPropiedades).First();
            lblPropietarioMasPropiedades.Text = "DPI: " + datoTemp.Dpi + "\nNombre: " + datoTemp.NombreApellido + "\nCantidad de propiedades: " + datoTemp.CantidadPropiedades;
        }
        private void propietarioConCuotaAlta()
        {
            //Alumno mayor = alumnos.OrderByDescending(al => al.Promedio).First();
            clsCantidadPropiedades datoTemp = lstDatosCantidadPropiedades.OrderByDescending(dato => dato.CuotaMantenimientoTotal).First();
            lblCuotaAlta.Text = "DPI: " + datoTemp.Dpi + "\nNombre: " + datoTemp.NombreApellido + "\nCuota a pagar: " + datoTemp.CuotaMantenimientoTotal;
        }
        private void cuotasAltas()
        {
            List<clsPropiedades> datoTemp = lstPropiedades.OrderByDescending(dato => dato.CuotaMantenimiento).ToList();
            if (datoTemp.Count > 2)
            {
                for (int x = 0; x < 3; x++)
                    lbCuotasAltas.Items.Add((x + 1) + ") Cuota: " + datoTemp[x].CuotaMantenimiento + " - DPI: " + datoTemp[x].Dpi_Dueño);
            }
            else { 
                for (int x = 0; x < datoTemp.Count; x++)
                    lbCuotasAltas.Items.Add((x + 1) + ") Cuota: " + datoTemp[x].CuotaMantenimiento + " - DPI: " + datoTemp[x].Dpi_Dueño);
                for (int x = datoTemp.Count; x < 3; x++)
                    lbCuotasAltas.Items.Add((x + 1) + ") Cuota: ------ - DPI: ------");
            }
        }
        private void cuotasBajas() {
            List<clsPropiedades> datoTemp = lstPropiedades.OrderBy(dato => dato.CuotaMantenimiento).ToList();
            if (datoTemp.Count > 2)
            {
                for (int x = 0; x < 3; x++)
                    lbCuotasBajas.Items.Add((x + 1) + ") Cuota: " + datoTemp[x].CuotaMantenimiento + " - DPI: " + datoTemp[x].Dpi_Dueño);
            }
            else
            {
                for (int x = 0; x < datoTemp.Count; x++)
                    lbCuotasBajas.Items.Add((x + 1) + ") Cuota: " + datoTemp[x].CuotaMantenimiento + " - DPI: " + datoTemp[x].Dpi_Dueño);
                for (int x = datoTemp.Count; x < 3; x++)
                    lbCuotasBajas.Items.Add((x + 1) + ") Cuota: ------ - DPI: ------");
            }
        }
        private void frmDatos_Load(object sender, EventArgs e)
        {
            actualizar();
        }
    }
}
