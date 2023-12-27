
using Exam.CoreApplication.Domain;
using Exam.CoreApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.CoreApplication.Services
{
    public class ServicePatient : Service<Patient>, IServicePatient

    {
        public ServicePatient(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
