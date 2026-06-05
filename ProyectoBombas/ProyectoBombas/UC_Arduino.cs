using BLL.Servicios;
using BLL.Servicios.BLL.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBombas
{
    public partial class UC_Arduino : UserControl
    {
        private GestorArduino gestorArduino;
        public UC_Arduino()
        {
            InitializeComponent();
            gestorArduino = new GestorArduino();
        }
        private void CargarPuertos()
        {
            string[] puertos =
                gestorArduino.ObtenerPuertos();

            cmbPuertoArduino1.Items.Clear();
            cmbPuertoArduino2.Items.Clear();

            foreach (string puerto in puertos)
            {
                cmbPuertoArduino1.Items.Add(puerto);
                cmbPuertoArduino2.Items.Add(puerto);
            }

            rtbEventos.AppendText(
                "Puertos actualizados\n"
            );
        }

        private void btnActualizarPuertos_Click(object sender, EventArgs e)
        {
            CargarPuertos();
        }
    }
}
