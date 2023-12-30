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
    public class ServiceRDV : Service<RDV>, IServiceRDV
    {
        public ServiceRDV(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IEnumerable<IGrouping<DateTime, RDV>> RDvConfirmes(Client client)
        {

            return   client.RDVs.Where(p => p.Confirmation).GroupBy(r => r.DateRDV);
            //return GetMany(p => p.ClientFk == client.Id && p.Confirmation)
            //    .GroupBy(r => r.DateRDV);
                

        }
    }
}
