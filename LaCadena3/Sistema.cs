using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCadena3
{
    public class Sistema
    {
        public void MenuPrincipal()
        {
            string cadena;
 
            cadena = Validador.ValidarString("\n Ingrese una frase");

            Validador.ToUpper(cadena);

            Validador.Despedida();
        }

        public void Iniciar()
        {
            MenuPrincipal();
        }
    }
}
