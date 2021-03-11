using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropiedadesCondominio
{
    public class clsPropiedades
    {
        int no_deCasa, dpiDueño;
        double cuotaMantenimiento;
        public int No_deCasa { get => no_deCasa; set => no_deCasa = value; }
        public int Dpi_Dueño { get => dpiDueño; set => dpiDueño = value; }
        public double CuotaMantenimiento { get => cuotaMantenimiento; set => cuotaMantenimiento = value; }
    }
}
