using System;

namespace Forests.Animals
{
    public class Bear : Animal, IFurryAnimal, IWalkingAnimal
    {
        public int NumberOfLegs => 2;
        public string TypeOfFur {get; set;}
        public int TailLength {get; set;}
        public int PicnicBasketAmount {get;set;}

        public Bear(string name, string typeOfFur)
        {
            Name = name;
            TypeOfFur = typeOfFur;
        }

        public void Walk(int paceCount)
        {
            Console.WriteLine($"{Name} took {paceCount} strolls with his {PicnicBasketAmount} picnic baskets");
        }
    }
}