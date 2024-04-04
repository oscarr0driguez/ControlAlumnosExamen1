using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAlumnos
{
    class Inscripciones
    {
        int dpiEstudiante;
        int codTaller;
        DateTime feInscripcion;

        public int DpiEstudiante { get => dpiEstudiante; set => dpiEstudiante = value; }
        public int CodTaller { get => codTaller; set => codTaller = value; }
        public DateTime FeInscripcion { get => feInscripcion; set => feInscripcion = value; }
    }
}
