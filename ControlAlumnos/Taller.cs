using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAlumnos
{
    class Taller
    {
        int codTaller;
        string nomTaller;
        decimal costo;

        public int CodTaller { get => codTaller; set => codTaller = value; }
        public string NomTaller { get => nomTaller; set => nomTaller = value; }
        public decimal Costo { get => costo; set => costo = value; }
    }
}
