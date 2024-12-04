using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsPoo
{
    public class Valida
    {
        public static int  Entero(string s)
        {
			try
			{
				int x= Convert.ToInt32(s);
				return x;
				
			}
			catch (Exception)
			{

				throw new CovertException("Igrese solo valores numericos enteros !");
			}
        }
    }
}
