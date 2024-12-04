namespace ConceptsPoo
{
    public abstract class Employee
    {
        private string? _firstName;
        private string? _lastName;
        private int? _Id;
        private Date? _birthDate;
        private Date? _hiringDate;
        private bool? _isActivity;

        public int Id{ get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Date BirthDate { get; set; }
        public Date HiringDate { get; set; }
        public bool IsActivity { get; set; }


        public abstract decimal GetValueToPay();
        public override string ToString()
        {
            return $" {Id} - {FirstName}  {LastName} " +
                $"\n Fecha de nacimiento   : {BirthDate}" +
                $"\n Fecha de contratacion : {HiringDate}" +
                $"\n Is Activity?          : {IsActivity}";
        }


    }
}
