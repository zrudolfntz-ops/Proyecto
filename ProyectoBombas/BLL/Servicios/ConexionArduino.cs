using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Servicios
{
    using System.IO.Ports;

    namespace BLL.Servicios
    {
        public class ConexionArduino
        {
            private SerialPort puertoSerial;
            private string puertoCOM;
            private bool conectado;

            public ConexionArduino()
            {
                puertoCOM = "";
                conectado = false;
            }

            public string PuertoCOM
            {
                get { return puertoCOM; }
                set { puertoCOM = value; }
            }

            public bool Conectado
            {
                get { return conectado; }
            }

            public bool Conectar()
            {
                try
                {
                    puertoSerial = new SerialPort(puertoCOM, 9600);

                    puertoSerial.Open();

                    conectado = true;

                    return true;
                }
                catch
                {
                    conectado = false;

                    return false;
                }
            }

            public void Desconectar()
            {
                if (puertoSerial != null &&
                    puertoSerial.IsOpen)
                {
                    puertoSerial.Close();
                }

                conectado = false;
            }

            public void Enviar(string mensaje)
            {
                if (puertoSerial != null &&
                    puertoSerial.IsOpen)
                {
                    puertoSerial.WriteLine(mensaje);
                }
            }

            public string Recibir()
            {
                if (puertoSerial != null &&
                    puertoSerial.IsOpen)
                {
                    return puertoSerial.ReadLine();
                }

                return "";
            }
        }
    }
}
