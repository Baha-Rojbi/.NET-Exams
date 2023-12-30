using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using Examen.Interfaces;
using Examen.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Services
{
    public class ServicePrestation : Service<Prestation>, IServicePrestation
    {
        public ServicePrestation(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        //public IEnumerable<Prestataire> Get3Prestataire()
        //{
        //    return GetAll().Select(p=>p.Prestataire)
        //        .Where(p => p.Zone == Zone.Raoued)
        //        .OrderBy(p => p.Note)
        //        .Take(3);
        //}

        public double PrixMoyen()
        {
            return GetMany(p => p.Type.Equals(type.Coiffure)).Average(p => p.Prix);
        }
    }

}
