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

        }
    }
}
