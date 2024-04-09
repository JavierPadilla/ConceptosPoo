using ConceptosPoo;
using System;

public class EmpleadoPorHora: Empleado
{
    public int Hours { get; set; }
    public decimal HourValue { get; set; }

    public override decimal GetValueToPay()
    {
        return (decimal)HourValue * Hours;
    }
    public override string ToString()
    {
        return $"{base.ToString()} " +
        $"\n\tHoras.................:{$"{Hours:N2}",18}" +
        $"\n\tValor por Hora........:{$"{HourValue:C2}",18} +
        $"\n\tValue to Pay..........:{$"{GetValueToPay():C2}",18};
    }
}
