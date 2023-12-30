using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public enum TypeFete
    {
        Anniversaire , Mariage , Autre
    }
    public class Fete
    {

        public int FeteId { get; set; }
        public int Duree { get; set; }
        [Range(1,250)]
        public int NbInviteMax { get; set; }
        [Required(ErrorMessage = " Description Fete Obligatoire")]
        public string Description { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateFete { get; set; }
        public TypeFete TypeFete { get; set; }
        public virtual IList<Invitation> Invitations { get; set; }
        public virtual Salle Salle { get; set; }
    }
}
