using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.CoreApplication.Domain;
using Exam.CoreApplication.Interfaces;

namespace Exam.CoreApplication.Services
{
    public class ServiceRdv:Service<RDV>,IServiceRdv
    {
        public ServiceRdv(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IEnumerable<IGrouping<DateTime, RDV>> listeDesRendezVous(Client client)
        {
            return client.RDVs.Where(p=>p.Confirmation).GroupBy(p => p.DateRDV);
        }
    }
}
