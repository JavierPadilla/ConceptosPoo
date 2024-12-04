using ConceptsPoo;

namespace InterfaceNewPoo
{
    public partial class FrmNewSalaryEmployee : Form
    {
        public FrmNewSalaryEmployee()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)

        {
            int fnacdia = 0, fnacmes = 0, fnacyear = 0, fhirdia = 0, fhirmes = 0, fhiryear = 0;
            if (ValidaEspacio())
            {
                #region Creacion de objetos
                try
                {


                    SalaryEmployee empSalary = new SalaryEmployee()
                    {
                        Id = Valida.Entero(TxtId.Text),
                        FirstName = TxtNombres.Text,
                        LastName = TxtApellidos.Text,
                        BirthDate = new Date(fnacdia, fnacmes, fnacyear),
                        HiringDate = new Date(fhirdia, fhirmes, fhiryear),
                        IsActivity = true,
                        Salary = Valida.Entero(TxtSalaryPorDay.Text),
                        Dias = Valida.Entero(TxtNDias.Text)

                    };
                    MessageBox.Show(empSalary.ToString(), "Informacion");
                }
                catch (Exception error)
                {

                    MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK);
                }
                #endregion






            }

            bool ValidaEspacio()
            {
                if (TxtId.Text == "" || Valida.Entero(TxtId.Text) <= 0)
                {
                    errorProvider1.SetError(TxtId, "Debe ingresar un ID valido !");
                    TxtId.Focus();
                    return false;
                }
                errorProvider1.SetError(TxtId, "");
                if (TxtNombres.Text == "")
                {
                    errorProvider1.SetError(TxtNombres, "Falta ingresar un nombre de empleado !");
                    TxtNombres.Focus();
                    return false;
                }
                errorProvider1.SetError(TxtNombres, "");
                if (TxtApellidos.Text == "")
                {
                    errorProvider1.SetError(TxtApellidos, "Falta ingresar los apellidos del empleado !");
                    TxtApellidos.Focus();
                    return false;
                }
                errorProvider1.SetError(TxtApellidos, "");
                if (TxtFNacDia.Text == "" || Valida.Entero(TxtFNacDia.Text) <= 0)
                {
                    errorProvider1.SetError(TxtFNacDia, "Debe ingresar el dia de nacimiento !");
                    TxtFNacDia.Focus();
                    return false;
                }
                fnacdia = Valida.Entero(TxtFNacDia.Text);
                errorProvider1.SetError(TxtFNacDia, "");
                if (TxtFNacMes.Text == "" || Valida.Entero(TxtFNacMes.Text) <= 0)
                {
                    errorProvider1.SetError(TxtFNacMes, "Falta ingresar el mes de nacimiento !");
                    TxtFNacMes.Focus();
                    return false;
                }
                fnacmes = Valida.Entero(TxtFNacMes.Text);
                errorProvider1.SetError(TxtFNacMes, "");

                if (TxtFNacYear.Text == "" || Valida.Entero(TxtFNacYear.Text) <= 0)
                {
                    errorProvider1.SetError(TxtFNacYear, "Falta ingresar el an'io de nacimiento !");
                    TxtFNacYear.Focus();
                    return false;
                }
                errorProvider1.SetError(TxtFNacYear, "");
                fnacyear = Valida.Entero(TxtFNacYear.Text);
      
             int x =DateTime.Now.Year;
               
                
                if (fnacyear > x)
                {
                    
                    errorProvider1.SetError(TxtFNacYear, "El an'io de nacimiento no es valido!");
                    TxtFNacYear.Focus();
                    return false;

                }
                errorProvider1.SetError(TxtFNacYear, "");

                if (TxtFHirinDay.Text == "" || Valida.Entero(TxtFHirinDay.Text) <= 0)
                {
                    errorProvider1.SetError(TxtFHirinDay, "Debe ingresar el dia de Contratacion !");
                    TxtFHirinDay.Focus();
                    return false;
                }
                fhirdia = Valida.Entero(TxtFHirinDay.Text);
                errorProvider1.SetError(TxtFHirinDay, "");
                if (TxtFHirinMes.Text == "" || Valida.Entero(TxtFHirinMes.Text) <= 0)
                {
                    errorProvider1.SetError(TxtFHirinMes, "Falta ingresar el mes de Contratacion !");
                    TxtFHirinMes.Focus();
                    return false;
                }
                fhirmes = Valida.Entero(TxtFHirinMes.Text);
                errorProvider1.SetError(TxtFHirinMes, "");

                if (TxtFHirinYear.Text == "" || Valida.Entero(TxtFHirinYear.Text) <= 0)
                {
                    errorProvider1.SetError(TxtFHirinYear, "Falta ingresar el an'io de Contratacion !");
                    TxtFHirinYear.Focus();
                    return false;
                }
                errorProvider1.SetError(TxtFHirinYear, "");
                fhiryear = Valida.Entero(TxtFHirinYear.Text);
                if (fhiryear > x)
                {
                    errorProvider1.SetError(TxtFHirinYear, "El an'io de contratacion no es valido!");
                    TxtFHirinYear.Focus();
                    return false;

                }
                errorProvider1.SetError(TxtFHirinYear, "");
                if (x - fnacyear < 18 )
                {
                    errorProvider1.SetError(TxtFHirinYear, "Error en el an'io de contratacion\n Debes tener mas de 18 an'ios para trabajar");
                    TxtFHirinYear.Focus();
                    return false;
                }
                errorProvider1.SetError(TxtFHirinYear, "");
                if (TxtSalaryPorDay.Text == "" || Valida.Entero(TxtSalaryPorDay.Text) <= 0)
                {
                    errorProvider1.SetError(TxtSalaryPorDay, "Falta ingresar el salario por dia del empleado !");
                    TxtSalaryPorDay.Focus();
                    return false;
                }

                errorProvider1.SetError(TxtSalaryPorDay, "");
                if (TxtNDias.Text == "" || Valida.Entero(TxtNDias.Text) <= 0)
                {
                    errorProvider1.SetError(TxtNDias, "Falta ingresar el numero de dias trabajados !");
                    TxtNDias.Focus();
                    return false;
                }
                errorProvider1.SetError(TxtNDias, "");
                return true;
            }


        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
