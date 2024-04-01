using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPoo
{
    public class EmpleadoComission:Empleado
    {
        public float ComissionPorcentaje { get; set; }
        public decimal Sales { get; set; }

        public override decimal GetValueToPay()
        {
            return Sales * (decimal)ComissionPorcentaje;
        }
        public override string ToString()
        {
            return $"{base.ToString()} " +
                $"\n\tPorcentaje de Comision ........:{$"{ComissionPorcentaje:P2}", 18}" +
                $"\n\tVentas.........................:{$"{GetValueToPay():C2}", 18}";

        }
    }
}
