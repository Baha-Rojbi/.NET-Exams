using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Services;
using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Services
{
    public class ServiceInvite : Service<Invite>, IServiceInvite
    {
        public ServiceInvite(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
