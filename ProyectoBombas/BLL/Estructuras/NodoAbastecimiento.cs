using BLL.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Estructuras
{
    public class NodoAbastecimiento
    {
        private Abastecimiento dato;

        private NodoAbastecimiento siguiente;

        public NodoAbastecimiento()
        {
        }

        public NodoAbastecimiento(Abastecimiento dato)
        {
            this.dato = dato;
            siguiente = null;
        }

        public Abastecimiento Dato
        {
            get { return dato; }
            set { dato = value; }
        }

        public NodoAbastecimiento Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
    }
}
