using System;

namespace PetsShop
{
    class Deliverer : Human
    {
        public Sex Sex { get; private set; }
        public string Company { get; private set; }

        public Deliverer(string firstName, string lastName, Sex sex, string company)
            : base(firstName, lastName)
        {
            this.Sex = sex;
            this.Company = company;
        }

        public override string ToString()
        {
            return base.ToString() + " Sex: " + this.Sex + ", from Company: " + this.Company;
        }
    }
}
