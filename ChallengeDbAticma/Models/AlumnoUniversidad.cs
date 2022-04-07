using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeDbAticma.Models
{
    public class AlumnoUniversidad
    {
        public int IDAlumno { get; set; }
        public int IDUniversidad { get; set; }
        public Alumno Alumno { get; set; }
        public Universidad Universidad { get; set; }

    }
}
