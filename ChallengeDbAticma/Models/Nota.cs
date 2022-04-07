using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeDbAticma.Models
{
    public class Nota
    {
        public int IDAlumno { get; set; }
        public int IDMateria { get; set; }
        public int Calificacion { get; set; }
        public Alumno Alumno { get; set; }
        public Materia Materia { get; set; }
    }
}
