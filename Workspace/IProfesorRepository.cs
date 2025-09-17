using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workspace
{
    public interface IProfesorRepository
    {
        void AgregarProfesor(Profesor profesor);
        List<Profesor> ObtenerProfesores();
    }

}
