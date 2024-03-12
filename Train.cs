using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrain
{
    internal class Train
    {
        public List<Carriage> Carriages { get; } = new List<Carriage>();

        public void AddAnimals(List<Animal> animals)
        {
            animals = animals.OrderByDescending(a => a.Type).ThenByDescending(a => a.Size).ToList();
            foreach (var animal in animals)
                AddAnimal(animal);
        }

        public void AddAnimal(Animal animal)
        {
            var addedToExistingCarriage = Carriages.Any(c => c.TryAddAnimal(animal));
            if (addedToExistingCarriage)
                return;

            var newCarriage = new Carriage();
            if (!newCarriage.TryAddAnimal(animal))
                throw new Exception("Animal is too large for a single carriage");
            Carriages.Add(newCarriage);
        }
    }
}
