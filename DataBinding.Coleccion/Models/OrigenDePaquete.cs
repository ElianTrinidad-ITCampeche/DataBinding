using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBinding.Coleccion.Models
{
    internal class OrigenDePaquete
    {
        public string Nombre { get; set; } = string.Empty;
        public string Origen { get; set; } = string.Empty;
        public bool EstaHabilitado { get; set; } = false;

        public override string ToString()
        {
            return $"{Nombre} - ({Origen})";
        }
    }
}
