using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.CoreApplication.Domain
{
    public class Client
    {
        [Key]
        public int Identifiant { get; set; }
        [Required(ErrorMessage = "Login Required")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Password required")]
        public string Password { get; set; }
        public string Photo { get; set; }
        public virtual IList<Reservation> Reservations { get; set; }
        public virtual Conseiller Conseiller { get; set; }
        public int ConseillerFk { get; set; }
    }
}
