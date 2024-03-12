using CircusTrain;

var animals = ReadAnimals();

var train = new Train();

train.AddAnimals(animals);

PrintTrain(train);

static void PrintTrain(Train train) {
    Console.WriteLine($"Train consists of {train.Carriages.Count} carriages");
    foreach (var carriage in train.Carriages)
    {
        Console.WriteLine($"\tCarriage has {carriage.Animals.Count} animals:");
        foreach (var animal in carriage.Animals)
        {
            Console.WriteLine($"\t\t- {animal.Name} ({animal.Size}, {animal.Type})");
        }
    }
}

static List<Animal> ReadAnimals()
{
    List<Animal> animals = [
            new Animal("Rat", AnimalSize.Small, AnimalType.Carnivore),
            new Animal("Rat", AnimalSize.Small, AnimalType.Carnivore),
            new Animal("Rat", AnimalSize.Small, AnimalType.Carnivore),
            new Animal("Elephant", AnimalSize.Large, AnimalType.Herbivore),
            new Animal("Elephant", AnimalSize.Large, AnimalType.Herbivore),
            new Animal("Fox", AnimalSize.Medium, AnimalType.Carnivore),
            new Animal("Sheep", AnimalSize.Medium, AnimalType.Herbivore),
            new Animal("Sheep", AnimalSize.Medium, AnimalType.Herbivore),
            new Animal("Sheep", AnimalSize.Medium, AnimalType.Herbivore),
            new Animal("Snake", AnimalSize.Small, AnimalType.Carnivore),
            new Animal("Snake", AnimalSize.Small, AnimalType.Carnivore),
            new Animal("Mouse", AnimalSize.Small, AnimalType.Herbivore),
            new Animal("Mouse", AnimalSize.Small, AnimalType.Herbivore),
            new Animal("Monkey", AnimalSize.Medium, AnimalType.Herbivore),
            new Animal("Monkey", AnimalSize.Medium, AnimalType.Herbivore),
            new Animal("Lion", AnimalSize.Large, AnimalType.Carnivore),
            new Animal("Lion", AnimalSize.Large, AnimalType.Carnivore),
            new Animal("Ocelot", AnimalSize.Medium, AnimalType.Carnivore),
            new Animal("Ocelot", AnimalSize.Medium, AnimalType.Carnivore),
            new Animal("Giraffe", AnimalSize.Large, AnimalType.Herbivore),
            new Animal("Giraffe", AnimalSize.Large, AnimalType.Herbivore),
            new Animal("Giraffe", AnimalSize.Large, AnimalType.Herbivore),
        ];
    return animals.OrderBy(x => Random.Shared.Next()).ToList();
}