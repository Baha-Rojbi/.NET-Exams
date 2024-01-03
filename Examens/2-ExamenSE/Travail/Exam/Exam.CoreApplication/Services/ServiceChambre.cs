using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.CoreApplication.Domain;
using Exam.CoreApplication.Interfaces;

namespace Exam.CoreApplication.Services
{
    public class ServiceChambre:Service<Chambre>,IChambreService

    {
        public ServiceChambre(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public double PoucentageChambreSimple(Clinique clinique)
        {
            double nbreSimple= GetMany(ch => ch.CliniqueFk == clinique.CliniqueId).Where(ch => ch.TypeChambre == TypeChambre.Simple).Count();
            double nbreChambre = GetMany(ch => ch.CliniqueFk == clinique.CliniqueId).Count();
            return nbreSimple / nbreChambre * 100;
        }
    }
}
