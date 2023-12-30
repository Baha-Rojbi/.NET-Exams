using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Invitation
    {
        public DateTime  DateInvitation { get; set; }
        public bool  ConfirmInvitation { get; set; }
        public virtual Invite Invite { get; set; }
        public virtual Fete Fete { get; set; }
        public  int FeteFk { get; set; }
        public  string InviteFk { get; set; }
    }
}
