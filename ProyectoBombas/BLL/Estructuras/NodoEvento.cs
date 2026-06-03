using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Estructuras
{
    public class NodoEvento
    {
        private string evento;

        private NodoEvento siguiente;

        public NodoEvento(string evento)
        {
            this.evento = evento;
            siguiente = null;
        }

        public string Evento
        {
            get { return evento; }
            set { evento = value; }
        }

        public NodoEvento Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
    }
}
