using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public class Reservation
    {
        [DataType(DataType.DateTime)]
        public DateTime DateReservation { get; set; }
       
        [Range(1,4)]
        public int NbPersonnes { get; set; }
       // [ForeignKey("Client")]
        public int ClientFK { get; set; }

       // [ForeignKey("Pack")]
        public int PackFK { get; set; }

        [ForeignKey("ClientFK")]
        public virtual Client Client { get; set; }
        [ForeignKey("PackFK")]
        public virtual Pack Pack { get; set; }
    }
}
