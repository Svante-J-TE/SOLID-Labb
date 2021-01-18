using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Labb
{
    class Human
    {
        public Human(string _name)
        {
            string name = _name;
        }

        public List<Animal> _animalsList = new List<Animal>();

        public void gainAnimalOwnership(Animal animal)
        {
            _animalsList.Add(animal);
        }
    }
}
