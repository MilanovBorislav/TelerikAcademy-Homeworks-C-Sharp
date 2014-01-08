using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northtwind.Data;

namespace Northwind.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            NortwindEntities db = new NortwindEntities();
            using (db)
            {

                //DAO.InsertCustomer("ABVWW", "Test", "Test");
                //DAO.DeleteCustomer("ABVWW");
                //DAO.UpdateCustomer("ALFKI","New Company Name");
                // DAO.CustomersWithOrdersIn1997FromCanada();
                //DAO.CustomersWithOrdersIn1997FromCanada_SQLQuery();
                //DAO.FindSalesBySpecifiedRegionAndPeriod(null, "01.05.1995", "01.08.1996");
            }
        }
    }
}
