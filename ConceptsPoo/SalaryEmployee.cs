namespace ConceptsPoo
{
    public class SalaryEmployee : Employee
    {
        private decimal _salaryPerDay;
        private int _dias;
        public decimal Salary
        {
            get
            {
                return _salaryPerDay;
            }
            set
            {
                if (value < 180)
                {
                    throw new ArgumentException("El salario de ser mayor al salario minimo \n por dia $180.00 ");

                }
                else
                {
                    _salaryPerDay = value;
                }

            }
        }
        public int Dias { get; set; }

        public override decimal GetValueToPay()
        {
            return _salaryPerDay * Dias;
        }
        public override string ToString()
        {
            return base.ToString() +$"\n Valor a pagar : ${GetValueToPay():N2}";
        }
    }
}
