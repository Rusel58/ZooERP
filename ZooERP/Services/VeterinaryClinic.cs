using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooERP.Core.Models.Animals;

namespace ZooERP.Services
{
    public class VeterinaryClinic
    {
        public bool CheckHealth(Animal animal) 
        {
            return new Random().Next(0, 2) == 1; // 50% шанс здоровья
        }
    }
}
