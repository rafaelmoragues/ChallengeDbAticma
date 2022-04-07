using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChallengeDbAticma.Models;

namespace ChallengeDbAticma.Models
{
    public class Alumno
    {
        public int IDAlumno { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set;}
        public string Telefono { get; set; }
        public string Email { get; set; }
        public List<AlumnoUniversidad> AlumnoUniversidades { get; set; }
        public List<Nota> Notas { get; set; }

    }
}
