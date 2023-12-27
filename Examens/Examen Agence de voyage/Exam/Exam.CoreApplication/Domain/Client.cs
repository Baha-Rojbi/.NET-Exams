using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.CoreApplication.Domain
{
    public class Client
    {
        [Key]
        public int Identifiant { get; set; }
        [Required(ErrorMessage = "Le login est obligatoire")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Le Mot de passe est obligatoire")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string Photo { get; set; }
        public virtual List<Reservation> Reservations { get; set; }
        public virtual Conseiller Conseiller { get; set; }
        [ForeignKey("Conseiller")]
        public int ConseillerFk { get; set; }

        }
}
