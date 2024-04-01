using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPoo
{
    public class EmpleadoAsalariado: Empleado
    {
        public Decimal Salario { get; set; }

        public override decimal GetValueToPay()
        {
            return Salario;
        }
        public override string ToString()
        {
            return $"{base.ToString()} " +
                $"\n\tValue to Pay....................: {$"{GetValueToPay():c2}", 18}";
        }
    }
}
