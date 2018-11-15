using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Practica_Telefonos
{
    class ValidarCls
    {
        public static void Solonumeros(KeyPressEventArgs pE)

        {
            if (char.IsDigit(pE.KeyChar))
            {
                pE.Handled = false;
            }

            else if (char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }

            else
            {
                pE.Handled = true;
            }

           }

        public static void Sololetras(KeyPressEventArgs pE)
        {
            if (char.IsLetter(pE.KeyChar))
            {
                pE.Handled = false;
            }

            else if (char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }

            else if (char.IsSeparator(pE.KeyChar))
            {
                pE.Handled = false;
            }

            else
            {
                pE.Handled = true;
            }
        }
    }
}
