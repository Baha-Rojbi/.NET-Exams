using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Exam.CoreApplication.Domain
{
    [Owned]
    public class Zone
    {
        public String Ville { get; set; }
        public String Pays { get; set; }
    }
}
