using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooERP.Core.Interfaces
{
    public interface IAlive
    {
        int Food { get; set; } // Количество киллограмм еды потребляемый в сутки.
    }
}
