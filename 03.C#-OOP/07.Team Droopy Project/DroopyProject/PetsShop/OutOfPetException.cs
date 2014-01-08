using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetsShop
{
    class OutOfPetException : ApplicationException
    {
        public OutOfPetException(string message)
            : base(message)
        {
            Console.WriteLine(this.Message);
        }

        public override string Message
        {
            get { return "Pet is missing in shop!" + base.Message; }
        }
    }
}
