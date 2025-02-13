using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooERP.Core.Models.Animals;

namespace ZooERP.Services
{
    public class ZooService
    {
        private List<Animal> animals = new();

        public void AddAnimal(Animal animal, VeterinaryClinic vetClinic) 
        {
            if (vetClinic.CheckHealth(animal))
            {
                animals.Add(animal);
                Console.WriteLine($"Животное {animal.GetType().Name} принято.");
            }
            else
            {
                Console.WriteLine($"Животное {animal.GetType().Name} не прошло проверку.");
            }
        }

        public int GetTotalFood()
        {
            return animals.Sum(animal => animal.Food);
        }

        public List<Herbo> GetInteractiveAnimals()
        {
            return animals.OfType<Herbo>().Where(animal => animal.Kindness > 5).ToList();
        }
    }
}
