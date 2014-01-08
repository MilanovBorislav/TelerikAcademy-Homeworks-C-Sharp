using System;

namespace PetsShop
{
    interface ISellable
    {
        bool IsSellableAnimal(); // true - sellable;  false - already sold
    }
}
