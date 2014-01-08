using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy.Common
{
    public abstract class Animal:ISound
    {
        private byte age;
        private string name;
        private string sex;

        public byte Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }
        
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public string Sex
        {
            get
            {
                return this.sex;
            }
            set
            {
                this.sex = value;
            }
        }

                                                                                          
        public Animal(string name , byte age, string sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }

        public Animal(string name, byte age)
        {
            this.Name = name;
            this.Age = age;
        }

        public abstract void MakeSoud();


      
    }
}
