using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrain
{
    internal class Carriage
    {
        public IReadOnlyList<Animal> Animals => animals;
        private readonly List<Animal> animals = [];
        const int maxSpace = 10;

        public bool TryAddAnimal(Animal animal)
        {
            int availableSpace = maxSpace - animals.Sum(a => (int)a.Size);
            if (availableSpace < (int)animal.Size)
                return false;
            if (!animals.All(a => a.IsCompatible(animal)))
                return false;
            animals.Add(animal);
            return true;
        }
    }
}
