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
    public partial class frmPropiedades : Form
    {
        public List<clsPropietario> lstPropietarios = new List<clsPropietario>();
        public List<clsPropiedades> lstPropiedades = new List<clsPropiedades>();
        public frmPropiedades()
        {
            InitializeComponent();
        }

        private void frmPropiedades_Load(object sender, EventArgs e)
        {
            actualizar();
        }
        public void actualizar() {
            this.dtgPropiedades.DataSource = null;
            this.dtgPropiedades.DataSource = this.lstPropiedades;
            this.dtgPropiedades.Refresh();
            cmbDPI.DataSource = null;
            cmbDPI.DisplayMember = "Dpi";
            cmbDPI.ValueMember = "Dpi";
            cmbDPI.DataSource = this.lstPropietarios;
            cmbDPI.Refresh();

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int contPuntos = 0;
            string cadena = txtNumeroCasa.Text;
            char letra;
            for (int x = 0; x < cadena.Length; x++)
            {
                letra = cadena[x];
                if (letra.Equals('.')) contPuntos++;
            }
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                //permitir teclas de control como retroceso
                e.Handled = false;
            else if (contPuntos == 0 && e.KeyChar == '.')
                //permitir un punto si no han ingresado uno anteriormente
                e.Handled = false;
            else
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsPropiedades propiedadTemp = lstPropiedades.Find(p => p.No_deCasa == Convert.ToInt32(txtNumeroCasa.Text));
            if (txtCuota.Text.Trim().Length > 0  && txtNumeroCasa.Text.Trim().Length > 0)
            {
                if (propiedadTemp == null && Convert.ToInt32(txtNumeroCasa.Text) > 0 && Convert.ToDouble(txtCuota.Text) > 0.0)
                {
                    FileStream stream = new FileStream("Propiedades.txt", FileMode.Append, FileAccess.Write);
                    StreamWriter writer = new StreamWriter(stream);
                    clsPropiedades nuevaPropiedad = new clsPropiedades();
                    nuevaPropiedad.Dpi_Dueño = Convert.ToInt32(cmbDPI.SelectedValue);
                    nuevaPropiedad.CuotaMantenimiento = Convert.ToDouble(txtCuota.Text);
                    nuevaPropiedad.No_deCasa = Convert.ToInt32(txtNumeroCasa.Text);
                    writer.WriteLine(nuevaPropiedad.No_deCasa);
                    writer.WriteLine(nuevaPropiedad.Dpi_Dueño);
                    writer.WriteLine(nuevaPropiedad.CuotaMantenimiento);
                    writer.Close();
                    this.lstPropiedades.Add(nuevaPropiedad);
                    MessageBox.Show("Propiedad agregada exitosamente.\n Presione actualizar en el formulario general para visualizar los cambios.");
                    this.Close();
                }
                else MessageBox.Show("El número de casa ya ha sido registrado o se ha ingresado un valor cero en algún campo.");
            }
            else MessageBox.Show("Debe llenar todos los campos");
        }

        private void txtNumeroCasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                //permitir teclas de control como retroceso
                e.Handled = false;
            else
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
        }

        private void cmbDPI_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDPI.Items.Count > 0)
            {
                clsPropietario propietarioTemp = lstPropietarios.Find(p => p.Dpi == Convert.ToInt32(cmbDPI.SelectedValue));
                txtNombre.Text = propietarioTemp.Nombre + " " + propietarioTemp.Apellido;
            }
        }
    }
}
