using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public class Client
    {
        [Key]
        public int Identifiant { get; set; }

        [Required(ErrorMessage ="Login is required")]
        public string Login { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string Photo { get; set; }
        public int ConseillerFK { get; set; }
        public virtual Conseiller Conseiller { get; set; }
        public virtual IList<Reservation> Reservations { get; set; }
    }
}
