using BLL.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Estructuras
{
    public class ListaAbastecimientos
    {
        private NodoAbastecimiento cabeza;

        public ListaAbastecimientos()
        {
            cabeza = null;
        }
        public void Agregar(Abastecimiento abastecimiento)
        {
            NodoAbastecimiento nuevo =
                new NodoAbastecimiento(abastecimiento);

            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                NodoAbastecimiento actual = cabeza;

                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }

                actual.Siguiente = nuevo;
            }
        }

        public void Mostrar()
        {
            NodoAbastecimiento actual = cabeza;

            while (actual != null)
            {
                Console.WriteLine(
                    actual.Dato.Id
                );

                actual = actual.Siguiente;
            }
        }

        public Abastecimiento Buscar(int id)
        {
            NodoAbastecimiento actual = cabeza;

            while (actual != null)
            {
                if (actual.Dato.Id == id)
                {
                    return actual.Dato;
                }

                actual = actual.Siguiente;
            }

            return null;
        }



    }
}
