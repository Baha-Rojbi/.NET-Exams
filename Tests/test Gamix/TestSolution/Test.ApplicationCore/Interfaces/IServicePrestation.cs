using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.ApplicationCore.Domain;

namespace Test.ApplicationCore.Interfaces
{
    public interface IServicePrestation:IService<Prestation>
    {
        public double PrixMoyen();
    }
}
