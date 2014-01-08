using System;

namespace PetsShop
{
    class Cat : Animal
    {
        #region constructor
        
        public Cat(string name, double age, Sex sex, string color, int speed, decimal price, string breed, short count)
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
        
        #endregion

        //implement abstract interface methods 
        public override string MakeSound()
        {
            return "says miauuuuu.";
        }
        
        public override string MakeMovement()
        {
            return "walks and runs";
        }
    }
}