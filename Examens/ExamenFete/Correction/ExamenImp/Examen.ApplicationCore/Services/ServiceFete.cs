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
    public class ServiceFete : Service<Fete>, IServiceFete
    {
        public ServiceFete(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public int MaxDuree()
        {
            return GetMany(p => p.TypeFete.Equals(TypeFete.Mariage)).Max(p => p.Duree);
        }

        public int NbrFete(Salle s, TypeFete T)
        {
            return GetMany(p => p.Salle.Equals(s) && p.TypeFete.Equals(T)).Count();
        }

        public Salle SalleUtilise()
        {
            return GetMany(p => (DateTime.Now - p.DateFete).TotalDays < 365)
                  .GroupBy(p => p.Salle)
                  .OrderByDescending(p => p.Count())
                  .FirstOrDefault().Key;                
        }
    }
}
