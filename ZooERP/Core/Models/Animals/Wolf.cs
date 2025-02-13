using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooERP.Core.Models.Animals
{
    public class Wolf : Predator
    {
        public Wolf(int food, int number) : base(food, number) { }
    }
}
