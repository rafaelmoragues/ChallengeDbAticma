using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeDbAticma.Models
{
    public class UniMateria
    {
        public int IDUniversidad { get; set; }
        public int IDMateria { get; set; }
        public Materia Materia { get; set; }
        public Universidad Universidad { get; set; }
    }
}
