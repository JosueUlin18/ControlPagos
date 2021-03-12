using System;
using System.Collections.Generic;
using System.Text;

namespace ControlPagos
{
    class Cliente
    {
        string dpi;
        string nombre;
        string apellido;

        public string Dpi { get => dpi; set => dpi = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
    }
}
