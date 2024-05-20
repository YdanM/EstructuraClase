using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraClase
{
    public class Empleado : MiembrosDeLaComunidad
    {
       private string empresa {  get; set; }
       private string cargo { get; set; }
       private decimal salario { get; set; }
    }
}
