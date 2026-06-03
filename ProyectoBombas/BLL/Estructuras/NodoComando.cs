using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Estructuras
{
    public class NodoComando
    {
        private string comando;

        private NodoComando siguiente;

        public NodoComando(string comando)
        {
            this.comando = comando;
        }

        public string Comando
        {
            get { return comando; }
            set { comando = value; }
        }

        public NodoComando Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
    }
}
