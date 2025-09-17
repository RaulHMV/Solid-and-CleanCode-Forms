using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workspace
{
    public class ProfesorRepository : IProfesorRepository
    {
        private List<Profesor> profesores = new List<Profesor>();

        public void AgregarProfesor(Profesor profesor)
        {
            profesores.Add(profesor);
        }

        public List<Profesor> ObtenerProfesores()
        {
            return profesores;
        }
    }
}
