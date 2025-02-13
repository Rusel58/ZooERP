using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooERP.Core.Interfaces;

namespace ZooERP.Core.Models.Inventory
{
    public abstract class Thing : IInventory
    {
        public int Number {  get; set; }
        public Thing(int number) {
            Number = number;
        }
    }
}
