using System;
using System.Windows.Forms;

namespace InterfacePoo
{
    public partial class FrmFechaNac : Form
    {
        public FrmFechaNac()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (TxtDay.Text == "")
            {
                errorProvider1.SetError(TxtDay, "Debe ingresar un DIA VALIDO");
                TxtDay.Focus();

            }
            errorProvider1.SetError(TxtDay, "");
            if (TxtMonth.Text == "")
            {
                errorProvider1.SetError(TxtMonth, "Debe ingresar un MES VALIDO !");
                TxtMonth.Focus();

            }
            errorProvider1.SetError(TxtMonth, "");
            if (TxtYear.Text == "")
            {
                errorProvider1.SetError(TxtYear, "Debe ingresar un ANO VALIDO !");
                TxtYear.Focus();

            }
            errorProvider1.SetError(TxtYear, "");
            try
            {
                var f1 = new Date(11,2,2014);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
