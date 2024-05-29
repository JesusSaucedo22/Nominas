using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomina.Model
{
    public class Empleado
    {
        public string Nombre { get; set; }

        public string Apellidos { get; set; }

        public string Rfc { get; set; }

        public DateTime FechaDeIngreso { get; set; }

        public string NombreCompleto => $"{Nombre} {Apellidos}";

        public Empleado(string nombre, string apellidos, string rfc, DateTime fechaDeIngreso)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Rfc = rfc;
            FechaDeIngreso = fechaDeIngreso;
        }

        public decimal CalcularSalario()
        {
            return 0.0M;
        }
    }
}
