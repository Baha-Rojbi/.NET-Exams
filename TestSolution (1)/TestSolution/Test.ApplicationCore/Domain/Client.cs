using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.ApplicationCore.Domain
{
    public class Client
    {
        [Key]
        public int Identifiant { get; set; }
        [Required(ErrorMessage = "Needed Login")]
        public String Login { get; set; }
        [DataType(DataType.Password)]
        [Required]
        public String Password { get; set; }

        public String Photo { get; set; }
        public virtual Conseiller Conseiller { get; set; }
        public virtual IList<Reservation> Reservations { get; set; }
        [ForeignKey("Conseiller")]
        public int ConseillerFk { get; set; }
    }
}
