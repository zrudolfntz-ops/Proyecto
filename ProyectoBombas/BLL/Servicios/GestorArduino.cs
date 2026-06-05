using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using BLL.Servicios.BLL.Servicios;

namespace BLL.Servicios
{
        public class GestorArduino
        {
            private ConexionArduino arduino1;
            private ConexionArduino arduino2;

            public GestorArduino()
            {
                arduino1 = new ConexionArduino();
                arduino2 = new ConexionArduino();
            }

            public ConexionArduino Arduino1
            {
                get { return arduino1; }
            }

            public ConexionArduino Arduino2
            {
                get { return arduino2; }
            }

            public string[] ObtenerPuertos()
            {
                return SerialPort.GetPortNames();
            }
        }
}

