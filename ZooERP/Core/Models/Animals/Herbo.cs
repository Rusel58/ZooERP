using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooERP.Core.Models.Animals
{
    public class Herbo : Animal
    {
        public int Kindness { get; set; } // Уровень доброты (0 - 10) для травоядных. 

        public Herbo(int food, int number, int kindness) : base(food, number)
        {
            Kindness = kindness;
        }
    }
}
