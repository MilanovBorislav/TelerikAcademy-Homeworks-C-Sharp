using System;

namespace PetsShop
{
    class Parrot : Animal
    {
        //call Animal constructor
        public Parrot(string name, int age, Sex sex, string color, int speed, decimal price, string breed, short count)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
            this.Color = color;
            this.Speed = speed;
            this.Price = price;
            this.Breed = breed;
            this.Count = count;
        }

        //implement abstract interface methods 
        public override string MakeSound()
        {
            return "says different words";
        }

        public override string MakeMovement()
        {
            return "fly";
        }
    }
}
