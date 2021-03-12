using System;
using System.Collections.Generic;
using System.Text;

namespace ControlPagos
{
    class Propiedad
    {
        string dpi;
        int cuota;
        int numero_casa;

        public string Dpi { get => dpi; set => dpi = value; }
        public int Cuota { get => cuota; set => cuota = value; }
        public int Numero_casa { get => numero_casa; set => numero_casa = value; }
    }
}
