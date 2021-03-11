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
    public partial class frmPropietarios : Form
    {
        public List<clsPropietario> lstPropietarios = new List<clsPropietario>();
        public frmPropietarios()
        {
            InitializeComponent();
        }
        public void actualizar() {
            this.dtgPropietarios.DataSource = null;
            this.dtgPropietarios.DataSource = this.lstPropietarios;
            this.dtgPropietarios.Refresh();
        }
        private void frmPropietarios_Load(object sender, EventArgs e)
        {
            actualizar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsPropietario propietarioTemp = lstPropietarios.Find(p => p.Dpi == Convert.ToInt32(txtDPI.Text));
            if (txtNombre.Text.Trim().Length > 0 && txtApellido.Text.Trim().Length > 0 && txtDPI.Text.Trim().Length > 0) {
                if (propietarioTemp == null && Convert.ToInt32(txtDPI.Text) > 0)
                {
                    FileStream stream = new FileStream("Propietarios.txt", FileMode.Append, FileAccess.Write);
                    StreamWriter writer = new StreamWriter(stream);
                    clsPropietario nuevoPropietario = new clsPropietario();
                    nuevoPropietario.Dpi = Convert.ToInt32(txtDPI.Text);
                    nuevoPropietario.Nombre = txtNombre.Text.Trim();
                    nuevoPropietario.Apellido = txtApellido.Text.Trim();
                    writer.WriteLine(nuevoPropietario.Dpi);
                    writer.WriteLine(nuevoPropietario.Nombre);
                    writer.WriteLine(nuevoPropietario.Apellido);
                    writer.Close();
                    this.lstPropietarios.Add(nuevoPropietario);
                    MessageBox.Show("Propietario agregado exitosamente.\n Presione actualizar en el formulario general para visualizar los cambios.");
                    this.Close();
                }
                else MessageBox.Show("El DPI ya ha sido registrado o tiene un valor nulo.");
            }
            else MessageBox.Show("Debe llenar todos los campos");
        }

        private void txtDPI_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
