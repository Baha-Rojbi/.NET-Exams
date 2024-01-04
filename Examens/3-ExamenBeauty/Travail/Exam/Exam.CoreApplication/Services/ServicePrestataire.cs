using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.CoreApplication.Domain;
using Exam.CoreApplication.Interfaces;

namespace Exam.CoreApplication.Services
{
    public class ServicePrestataire:Service<Prestataire>,IServicePrestataire
    {
        public ServicePrestataire(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IEnumerable<Prestataire> meilleurPrestataires()
        {
            return GetMany(p => p.Zone == Zone.Raoued).OrderByDescending(p => p.Note).Take(3);
        }
    }
}
