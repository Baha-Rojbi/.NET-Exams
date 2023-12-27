using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.CoreApplication.Domain;
using Exam.CoreApplication.Interfaces;

namespace Exam.CoreApplication.Services
{
    public class ServiceExpert:Service<Expert>,IServiceExpert
    {
        public ServiceExpert(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
