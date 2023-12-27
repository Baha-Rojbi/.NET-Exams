using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Test.ApplicationCore.Domain
{
    [Owned]
    public class Zone
    {
        public String Ville { get; set; }
        public String Pays { get; set; }
    }
}
