using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.CoreApplication.Domain;
using Exam.CoreApplication.Interfaces;

namespace Exam.CoreApplication.Services
{
    internal class ServiceChambre : Service<Chambre>,IServiceChambre

    {
        public ServiceChambre(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public float PourcentageChambre(Clinique clinique)
        {
            return (float)GetMany(ch => ch.CLiniqueFk == clinique.CliniqueId && ch.TypeChambre == TypeChambre.Simple)
                .Count() / GetMany(ch => ch.CLiniqueFk == clinique.CliniqueId).Count() * 100;
        }
    }
}
