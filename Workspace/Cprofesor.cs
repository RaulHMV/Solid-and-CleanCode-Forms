using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workspace
{
    public abstract class Profesor
    {
        public string Nombre { get; set; }
        public double Salario { get; set; }
        public int AniosTrabajando { get; set; }

        public abstract double CalcularAumento();
    }
}
