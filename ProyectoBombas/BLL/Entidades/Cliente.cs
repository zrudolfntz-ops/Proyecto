using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entidades
{
    public class Cliente
    {
        private string nombre;

        public Cliente()
        {
        }

        public Cliente(string nombre)
        {
            this.nombre = nombre;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }
}
