using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrain
{
    enum AnimalSize
    {
        Small = 1,
        Medium = 3,
        Large = 5
    }

    enum AnimalType
    {
        Herbivore,
        Carnivore
    }

    internal class Animal(string name, AnimalSize size, AnimalType type)
    {
        public string Name { get; } = name;
        public AnimalSize Size { get; } = size;
        public AnimalType Type { get; } = type;

        public bool IsCompatible(Animal other)
        {
            if(Type == AnimalType.Carnivore && other.Type == AnimalType.Carnivore)
                return false;
            if (Type == AnimalType.Herbivore && other.Type == AnimalType.Carnivore)
                if (Size <= other.Size)
                    return false;
            if (Type == AnimalType.Carnivore && other.Type == AnimalType.Herbivore)
                if (Size >= other.Size)
                    return false;
            return true;
        }
    }
}
