using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.CoreApplication.Domain;
using Exam.CoreApplication.Interfaces;

namespace Exam.CoreApplication.Services
{
    internal class ServicePatient:Service<Patient>,IServicePatient
    {
        public ServicePatient(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
