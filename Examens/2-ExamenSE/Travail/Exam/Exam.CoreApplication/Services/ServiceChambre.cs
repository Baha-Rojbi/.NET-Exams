using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.CoreApplication.Domain;
using Exam.CoreApplication.Interfaces;

namespace Exam.CoreApplication.Services
{
    public class ServiceChambre:Service<Chambre>,IServiceChambre
    {
        public ServiceChambre(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public double Pourcentage(Clinique clinique)
        {
            double chambreSimple = clinique.Chambres.Where(c => c.TypeChambre == TypeChambre.Simple).Count();
            double chambres = clinique.Chambres.Count();
            return (chambreSimple * 100) / chambres;
        }
    }
}
