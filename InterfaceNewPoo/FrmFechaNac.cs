using ConceptsPoo;
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
                return;

            }
            errorProvider1.SetError(TxtDay, "");
            if (TxtMonth.Text == "")
            {
                errorProvider1.SetError(TxtMonth, "Debe ingresar un MES VALIDO !");
                TxtMonth.Focus();
                return;

            }
            errorProvider1.SetError(TxtMonth, "");
            if (TxtYear.Text == "")
            {
                errorProvider1.SetError(TxtYear, "Debe ingresar un ANO VALIDO !");
                TxtYear.Focus();
                return;

            }
            errorProvider1.SetError(TxtYear, "");
            try
            {

                //Date f1 = new Date(Valida.Entero(TxtDay.Text), Valida.Entero(TxtMonth.Text), Valida.Entero(TxtYear.Text));
                //MessageBox.Show(f1.ToString(),"Fecha Correcta !",MessageBoxButtons.OK,MessageBoxIcon.Information);
                
                
                //if ((2024-f1) > 18)
                //{
                    
                    //MessageBox.Show("Eres mayor de edad","Enhorabuena",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                   /*Aqui vamos a determinar si es myor de edad  validando mes y dia en caso de que en este ano cumpliera la mayoria.
                   /de edad.
                   /
                   /
                   /                   if ((2024 - f1.Year) ==18)
                    {
                        DateTime dt = new DateTime();
                        
                    }
                   /
                   /
                   /
                   /
                   /
                   /                
                    */




                //}
                //else
                //{
                //    MessageBox.Show("Patada en la nuca, aun eres un menor :(","Prohivido",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                //}

            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message,"Error de datos :(",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
