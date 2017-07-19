using System;
using Forests.Animals;

namespace Forests
{
    class Program
    {
        static void Main(string[] args)
        {
            Forest HauntedForest = new Forest("GoT Haunted Forest", "North of the Wall");

            Forest Qohor = new Forest("GoT Forest of Qohor", "Eastern Essos");
            
            var squirrel = new Squirrel ("Thumper","Patchy") {TailLength = 17};
            var bear = new Bear("Yogi","Blue") { TailLength = 1, PicnicBasketAmount=2 };
            var seal = new Seal ("Sammy");

            var deer = new Animal 
            { 
                // Fur = "What?", 
                // NumberOfLegs = 4, 
                Name = "Bambi" 
            };
            var chipmunk = new Animal 
            { 
                // Fur = "short", 
                // NumberOfLegs = 4, 
                Name = "Alvin" 
            };
            // var bear = new Bear
            // { 
            //     TypeOfFur = "thick black", 
            //     NumberOfLegs = 4, 
            //     Name = "Charlotte" 
            // };
            var owl = new Animal 
            { 
                // Fur = "Feathers", 
                // NumberOfLegs = 2, 
                Name = "Hedwig" 
            };
            var direwolf = new Animal 
            { 
                // Fur = "thick", 
                // NumberOfLegs = 4, 
                Name = "Ghost" 
            };

            HauntedForest.PlaceAnimal(owl);
            HauntedForest.PlaceAnimal(chipmunk);
            HauntedForest.PlaceAnimal(direwolf);
            HauntedForest.PlaceAnimal(bear);
            HauntedForest.PlaceAnimal(squirrel);
            HauntedForest.PlaceAnimal(seal);
            Qohor.PlaceAnimal(deer);
            // Qohor.PlaceAnimal(pig);
            Qohor.PlaceAnimal(new Animal {Name="Steve"});

            HauntedForest.ListAnimals();
            Qohor.ListAnimals();
        }
    }
}
