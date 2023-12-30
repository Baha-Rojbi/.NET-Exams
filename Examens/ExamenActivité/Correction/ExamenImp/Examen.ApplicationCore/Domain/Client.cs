using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace Examen.ApplicationCore.Domain
{
      public class Client
    {
        [Key]
        public int Identifiant { get; set; }

        [Required(ErrorMessage ="Login invalid!")]
        public string Login { get; set; }
        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }
        public string Photo { get; set; }
        public int ConseillerFk { get; set; }
       
        public virtual Conseiller Conseiller { get; set; }
        public virtual IList<Reservation> Reservations { get; set; }

    }
}
