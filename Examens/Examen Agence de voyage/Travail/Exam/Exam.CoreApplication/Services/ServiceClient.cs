using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.CoreApplication.Domain;
using Exam.CoreApplication.Interfaces;

namespace Exam.CoreApplication.Services
{
    public class ServiceClient : Service<Client>,IServiceClient

    {
        public ServiceClient(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
