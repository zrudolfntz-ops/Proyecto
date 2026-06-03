using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Estructuras
{
    public class PilaComandos
    {
        private NodoComando cima;

        public void Push(string comando)
        {
            NodoComando nuevo =
                new NodoComando(comando);

            nuevo.Siguiente = cima;

            cima = nuevo;
        }

        public string Pop()
        {
            if (cima == null)
            {
                return null;
            }

            string dato = cima.Comando;

            cima = cima.Siguiente;

            return dato;
        }
    }

}
