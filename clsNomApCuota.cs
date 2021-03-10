using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropiedadesCondominio
{
    public class clsNomApCuota
    {
        int no_deCasa;
        double cuotaMantenimiento;
        string nombre, apellido;
        public int No_deCasa { get => no_deCasa; set => no_deCasa = value; }
        public double CuotaMantenimiento { get => cuotaMantenimiento; set => cuotaMantenimiento = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
    }
}
