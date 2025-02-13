using ZooERP.Core.Interfaces;

namespace ZooERP.Core.Models.Animals
{
    public abstract class Animal : IAlive, IInventory
    {
        public int Food { get; set; }
        public int Number { get; set; }

        public Animal(int food, int number)
        {
            Food = food;
            Number = number;
        }
    }
}
