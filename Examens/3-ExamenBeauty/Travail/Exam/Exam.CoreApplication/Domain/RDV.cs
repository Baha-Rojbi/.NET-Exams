using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.CoreApplication.Domain
{
    public class RDV
    {
        public bool Confirmation { get; set; }
        public DateTime DateRDV { get; set; }
        public virtual Client Client { get; set; }
        public virtual Prestation Prestation { get; set; }
        [ForeignKey("Client")]
        public int ClientFk { get; set; }
        [ForeignKey("Prestation")]
        public int PrestationFk { get; set; }
    }
}
