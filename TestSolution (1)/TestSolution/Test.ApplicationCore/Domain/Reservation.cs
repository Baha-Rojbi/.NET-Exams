    using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.ApplicationCore.Domain
{
    public class Reservation
    {
        [DataType(DataType.Date)]
        public DateTime DateReservation { get; set; }
        [Range(1,4)]
        public int NbPersonnes { get; set; }
        public virtual Client client { get; set; }
        public virtual Pack Pack { get; set; }
        [ForeignKey("Client")]
        public int ClientFk { get; set; }
        [ForeignKey("Pack")]
        public int PackFk { get; set; }
    }
}
