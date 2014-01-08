using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsShop
{
	class Dog : Animal
	{
		//call Animal constructor
		public Dog(string name, double age, Sex sex, string color, int speed, decimal price, string breed, short count)
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
			return "barks";
		}

		public override string MakeMovement()
		{
			return "walks and runs";
		}
	}
}
