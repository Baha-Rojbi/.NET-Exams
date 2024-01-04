using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.CoreApplication.Domain;
using Exam.CoreApplication.Interfaces;
using Type = Exam.CoreApplication.Domain.Type;

namespace Exam.CoreApplication.Services
{
    public class ServicePrestation : Service<Prestation>,IServicePrestation

    {
        public ServicePrestation(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public double prixMoyen()
        {
            return GetMany(p => p.PrestationType == Type.Coiffure).Select(p => p.Prix).Average();
        }
    }
}
