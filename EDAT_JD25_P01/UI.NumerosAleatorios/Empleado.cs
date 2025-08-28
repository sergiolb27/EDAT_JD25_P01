using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.NumerosAleatorios
{
    public class Empleado
    {
        public int Numero { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public DateTime FechaNacimiento { get; set; }
        public string Sexo { get; set; } = string.Empty;
        public string Grupo { get; set; } = string.Empty;
        public decimal Sueldo { get; set; }
        public bool SeguroMedico { get; set; }
    }
}
