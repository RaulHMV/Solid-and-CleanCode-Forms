using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workspace
{
    public class Profesor1a10 : Profesor
    {
        public override double CalcularAumento()
        {
            return Salario * 1.10; // 10%
        }
    }

}
