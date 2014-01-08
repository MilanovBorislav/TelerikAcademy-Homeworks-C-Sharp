using System;

namespace PetsShop
{
    class Fish : Animal
    {
        //call Animal constructor
        public Fish(string name, double age, Sex sex, string color, int speed, decimal price, string breed, short count)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
            this.Color = color;
            this.Price = price;
            this.Speed = speed;
            this.Breed = breed;
            this.Count = count;
        }

        //implement abstract interface methods 
        public override string MakeSound()
        {
            return "silent sound";
        }

        public override string MakeMovement()
        {
            return "swims";
        }
    }
}