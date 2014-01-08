using System;

namespace PetsShop
{
    public abstract class Animal : ISound, IComparable<Animal>, IMovementSpecific
    {
        public string Name { get; protected set; }

        public double Age { get; protected set; }

        public Sex Sex { get; protected set; }

        public string Color { get; protected set; }

        public int Speed { get; protected set; }

        public decimal Price { get; protected set; }

        public string Breed { get; protected set; }

        public short Count { get; protected set; }
        
        //// constructor
              
        // override ToString method
        public override string ToString()
        {
            return string.Format("Type Of Animal: {7}\n" + "----------------------" + "\nName: {0}; Age: {3}; Sex: {5}; Color: {1}; Speed: {2}; Price: {4}; InStock: {6}\n",
                this.Name, this.Color, this.Speed, this.Age, this.Price, this.Sex, this.Count, this.Breed);
        }

        // implement interface method
        public int CompareTo(Animal otherAnimal)
        {
            return this.Speed.CompareTo(otherAnimal.Speed);
        }

        // abstract methods to be implemented in child classes
        public abstract string MakeSound();

        public abstract string MakeMovement();
        //public abstract bool IsSellableAnimal(); - this is for concrete instance of Animal
    }
}