using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.CoreApplication.Domain;

namespace Exam.CoreApplication.Interfaces
{
    public interface IServiceExpertise:IService<Expertise>
    {
        public double RecetteExpert(DateTime date);
    }
}
