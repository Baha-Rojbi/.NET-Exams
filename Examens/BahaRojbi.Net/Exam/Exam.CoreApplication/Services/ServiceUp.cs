using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.CoreApplication.Domain;
using Exam.CoreApplication.Interfaces;

namespace Exam.CoreApplication.Services
{
    public class ServiceUp:Service<UP>,IServiceUp
    {
        public ServiceUp(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
