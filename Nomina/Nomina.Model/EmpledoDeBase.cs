using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomina.Model
{
    public class EmpleadoDeBase: Empleado
    {
        public decimal SalarioDiario { get; set; }
        public EmpleadoDeBase(string nombre, string apellidos, string rfc, DateTime fechaDeIngreso, decimal salarioDiario) : base(nombre, apellidos, rfc, fechaDeIngreso)
        {
            SalarioDiario = salarioDiario;
        }

        public decimal CalcularSalarioFijoDelPeriodo(int numeroDeDiasTrabajados)
        {
            return SalarioDiario * numeroDeDiasTrabajados;
        }

        /*
        public decimal CalcularEstimuloPorAntiguedad()
        {
            int aniosLaborados = 0;
            decimal estimulo = 0.0M;
            
            if(FechaDeIngreso < DateTime.Now)
            {

            }
        }
        */
    }
}
