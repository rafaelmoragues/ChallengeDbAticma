using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChallengeDbAticma.Models;

namespace ChallengeDbAticma.Models
{
    public class Universidad
    {
        [Key]
        public string IDUniversidad { get; set; }
        public string Nombre { get; set; }
        public string Provincia { get; set; }
        public string Localidad { get; set; }
        public List<AlumnoUniversidad> AlumnoUniversidades { get; set; }

    }
}
