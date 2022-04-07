using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeDbAticma.Models
{
    public class Materia
    {
        public int IDMateria { get; set; }
        public string Nombre { get; set; }    
        public List<Nota> Notas { get; set; }
    }
}
