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
    public class ServiceClient : Service<Client>, IServiceClient
    {
        public ServiceClient(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public int NbReservationsAnnee(Client c)
        {
            return c.Reservations.Where(r => (DateTime.Now-r.DateReservation).TotalDays<365).Count();   
        }

        public double PayementsClient(Client c)
        {
            double s = 0;
            foreach (var activites in c.Reservations.Select(r => r.Pack.Activites))
            {
                foreach (var a in activites)
                    s += a.Prix;
            }
            return s;

        }
    }
}
