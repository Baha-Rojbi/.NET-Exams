using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.CoreApplication.Domain
{
    public class Reservation
    {
        [DataType(DataType.Date)]
        public DateTime DateReservation { get; set; }
        [Range(1,4)]
        public int NbPersonnes { get; set; }
        public virtual Pack pack { get; set; }
        public virtual Client Client { get; set; }
        [ForeignKey("Client")]
        public int ClientFk { get; set; }
        [ForeignKey("Pack")]
        public int PackFk { get; set; }

    }
}
