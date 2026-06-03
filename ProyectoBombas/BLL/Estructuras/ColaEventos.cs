using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Estructuras
{
    public class ColaEventos
    {
        private NodoEvento frente;

        private NodoEvento final;

        public void Encolar(string evento)
        {
            NodoEvento nuevo =
                new NodoEvento(evento);

            if (frente == null)
            {
                frente = nuevo;
                final = nuevo;
            }
            else
            {
                final.Siguiente = nuevo;
                final = nuevo;
            }
        }

        public string Desencolar()
        {
            if (frente == null)
            {
                return null;
            }

            string dato = frente.Evento;

            frente = frente.Siguiente;

            return dato;
        }



    }
}
