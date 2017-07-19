using System;
using System.Collections.Generic;
using Forests.Animals;


namespace Forests
{
    public class Forest
    {
        public string Name { get; set; }

        public string Location { get; set; }

        List<Animal> Animals { get; set; } = new List<Animal>();

        public Forest(string name, string location)
        {
            Name = name;
            Location = location;
        }
        public void PlaceAnimal(Animal newAnimal)
        {
            Animals.Add(newAnimal);
        }

        // public void ListAnimals() 
        // {
        //     foreach (var animal in Animals)
        //     {
        //         Console.WriteLine($"{animal.Name} in {Name} has {animal.NumberOfLegs} legs with {animal.Fur} for fur type.");
        //     }
        // }
        public void ListAnimals()
        {
            foreach (var animal in Animals)
            {
                if (animal is IFurryAnimal) {
                    Console.WriteLine($"{animal.Name} of {Name} in {Location} "+
                                      $"with {((IFurryAnimal)animal).TypeOfFur} fur!");                
                }
                else {
                    Console.WriteLine($"{animal.Name} of {Name} in {Location}!");
                }

                var walkingAnimal = animal as IWalkingAnimal;
                if (walkingAnimal != null)
                {
                    walkingAnimal.Walk(7);
                }

            }
        }

    }
}