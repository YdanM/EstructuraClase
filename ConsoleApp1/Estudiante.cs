using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraClase
{
    public class Estudiante : MiembrosDeLaComunidad
    {
        private string curso {  get; set; }
        private string horario { get; set; }
        private int calificaciones { get; set; }
    }
}
