using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entidades
{
    public class Bomba
    {
        private int id;
        private string nombre;
        private bool activa;

        public Bomba()
        {
        }

        public Bomba(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
            activa = false;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public bool Activa
        {
            get { return activa; }
            set { activa = value; }
        }
    }
}
