using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northtwind.Data;
using Northwind.Client;

namespace CreateNewNorthwindDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            NortwindEntities context = new NortwindEntities();
            context.Database.CreateIfNotExists();
        }
    }
}
