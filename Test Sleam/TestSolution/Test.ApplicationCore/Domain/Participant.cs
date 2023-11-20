using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.ApplicationCore.Domain
{
    public class Participant
    {
        public int Id { get; set; }
        [MaxLength(50, ErrorMessage = "Longueur maximale est 50")]
        public String Nom { get; set; }
        [MaxLength(50, ErrorMessage = "Longueur maximale est 50")]
        public String Prenom { get; set; }
        [Display(Name = "Adresse")]
        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }
        public int NumeroTelephone { get; set; }
        public virtual IList<Inscription> Inscriptions { get; set; }
    }
}
