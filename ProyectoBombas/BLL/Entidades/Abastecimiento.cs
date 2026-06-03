using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entidades
{
    public class Abastecimiento
    {
        private int id;
        private Cliente cliente;
        private Bomba bomba;
        private decimal litros;
        private decimal total;
        private DateTime fechaHora;
        private string tipo;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public Bomba Bomba
        {
            get { return bomba; }
            set { bomba = value; }
        }

        public decimal Litros
        {
            get { return litros; }
            set { litros = value; }
        }

        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }

        public DateTime FechaHora
        {
            get { return fechaHora; }
            set { fechaHora = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
    }
}
