using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iLotery
{

    public static class Utilitarios
    {

        public static int ToInt(string texto)
        {
            int valor = 0;

            int.TryParse(texto, out valor);

            return valor;
        }

        public static bool ValidarTextBoxVacio(TextBox TextoValidar, ErrorProvider ErrProvider, string MensajedeError)
        {
            bool valido = true;

            if (TextoValidar.Text.Trim().Length == 0)
            {
                ErrProvider.SetError(TextoValidar, MensajedeError);
                TextoValidar.Focus();
                valido = false;
            }

            return valido;
        }

    }
}