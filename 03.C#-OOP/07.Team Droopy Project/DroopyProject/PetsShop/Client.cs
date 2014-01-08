using System;

namespace PetsShop
{
    class Client : Human
    {
        // fields and properties 
        private bool isCompany;

        public bool IsCompany
        {
            get { return isCompany; }
            set { isCompany = value; }
        }

        public Sex Sex { get; private set; }

        public Client(string firstName, string lastName, Sex sex, bool isCompany)
            : base(firstName, lastName)
        {
            this.Sex = sex;
            this.IsCompany = isCompany;
        }

        public override string ToString()
        {
            return base.ToString() + " Sex: " + this.Sex;
        }
    }
}
