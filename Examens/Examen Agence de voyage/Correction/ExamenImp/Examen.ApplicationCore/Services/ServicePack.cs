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
    public class ServicePack : Service<Pack>, IServicePack
    {
        public ServicePack(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public double PourcentagePack()
        {
            return GetMany(p => p.Duree > 7).Count() / GetMany().Count();
        }

        public double PrixPack(Pack pack)
        {
            return pack.Activites.Sum(a => a.Prix);
        }
    }
}
