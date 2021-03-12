using System;
using System.Collections.Generic;
using System.Text;

namespace ControlPagos
{
    class PropiedadesClientes
    {
        string dpi;
        int cuota;
        int numero_casa;
        string nombre;
        string apellido;

        public string Dpi { get => dpi; set => dpi = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Cuota { get => cuota; set => cuota = value; }
        public int Numero_casa { get => numero_casa; set => numero_casa = value; }
    }
}
