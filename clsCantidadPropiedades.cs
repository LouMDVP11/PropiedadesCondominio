using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropiedadesCondominio
{
    public class clsCantidadPropiedades
    {
        int cantidadPropiedades, dpi;
        double cuotaMantenimientoTotal;
        string nombre_pellido;

        public int Dpi { get => dpi; set => dpi = value; }
        public string NombreApellido { get => nombre_pellido; set => nombre_pellido = value; }
        public int CantidadPropiedades { get => cantidadPropiedades; set => cantidadPropiedades = value; }
        public double CuotaMantenimientoTotal { get => cuotaMantenimientoTotal; set => cuotaMantenimientoTotal = value; }
    }
}
