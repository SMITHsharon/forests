using System;

namespace Forests.Animals
{
    public class Squirrel : Animal, IFurryAnimal, IWalkingAnimal
    {
        public int NumberOfLegs => 4;
        public string TypeOfFur {get; set;}
        public int TailLength {get; set;}

        public Squirrel(string name, string typeOfFur)
        {
            Name = name;
            TypeOfFur = typeOfFur;
        }

        public void Walk(int paceCount)
        {
            for (int i = 0; i < paceCount; i++)
            {
                var typeOfStep = "";
                var direction = "";
                if (i % 2 == 0) 
                {
                    typeOfStep = "scampered";
                    direction = "left";
                }
                else
                {
                    typeOfStep = "scurried";
                    direction = "right";
                }
                Console.WriteLine($"{Name} the squirrel {typeOfStep} {direction}");
            }
        }
    }
}