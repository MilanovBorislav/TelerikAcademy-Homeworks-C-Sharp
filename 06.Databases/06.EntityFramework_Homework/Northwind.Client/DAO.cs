using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northtwind.Data;

namespace Northwind.Client
{
    public static class DAO
    {
        public static void InsertCustomer(string customerID, string companyName, string contactName = null, string contactTitle = null,
                                     string address = null, string city = null, string region = null, string postalCode = null,
                                     string country = null, string phone = null, string fax = null)
        {
            using (NortwindEntities db = new NortwindEntities())
            {
                Customer customer = new Customer
                {
                    CustomerID = customerID,
                    CompanyName = companyName,
                    ContactName = contactName,
                    ContactTitle = contactTitle,
                    Address = address,
                    City = city,
                    Region = region,
                    PostalCode = postalCode,
                    Country = country,
                    Phone = phone,
                    Fax = fax
                };

                db.Customers.Add(customer);

                db.SaveChanges();
                Console.WriteLine("Row is inserted.");
            }
        }

        public static void UpdateCustomer(string customerID, string companyName, string contactName = null, string contactTitle = null,
                                          string address = null, string city = null, string region = null, string postalCode = null,
                                          string country = null, string phone = null, string fax = null)
        {
            using (NortwindEntities db = new NortwindEntities())
            {
                Customer customerToUpdate = db.Customers.First(x => x.CustomerID == customerID);

                customerToUpdate.CompanyName = companyName ?? customerToUpdate.CompanyName;
                customerToUpdate.ContactName = contactName ?? customerToUpdate.ContactName;
                customerToUpdate.ContactTitle = contactTitle ?? customerToUpdate.ContactTitle;
                customerToUpdate.Address = address ?? customerToUpdate.Address;
                customerToUpdate.City = city ?? customerToUpdate.City;
                customerToUpdate.Region = region ?? customerToUpdate.Region;
                customerToUpdate.PostalCode = postalCode ?? customerToUpdate.PostalCode;
                customerToUpdate.Country = country ?? customerToUpdate.Country;
                customerToUpdate.Phone = phone ?? customerToUpdate.Phone;
                customerToUpdate.Fax = fax ?? customerToUpdate.Fax;

                db.SaveChanges();
                Console.WriteLine("Row is updated.");
            }
        }

        public static void DeleteCustomer(string customerID)
        {
            using (NortwindEntities db = new NortwindEntities())
            {
                Customer customer = db.Customers.First(x => x.CustomerID == customerID);

                db.Customers.Remove(customer);
                db.SaveChanges();
                Console.WriteLine("Row is deleted.");
            }
        }

        public static void CustomersWithOrdersIn1997FromCanada()
        {
            using (NortwindEntities db = new NortwindEntities())
            {

                var customers = db.Orders
                .Where(o => o.OrderDate.Value.Year == 1997 && o.ShipCountry == "Canada")
                .GroupBy(o => o.Customer.CompanyName)
                .ToList();
                db.SaveChanges();

                foreach (var customer in customers)
                {
                    Console.WriteLine(customer.Key);
                }
            }
        }

        public static void CustomersWithOrdersIn1997FromCanada_SQLQuery()
        {
            using (NortwindEntities db = new NortwindEntities())
            {

                var customers = db.Database.SqlQuery<string>(@"SELECT c.CompanyName FROM Orders o 
	                                                                         JOIN Customers c ON o.CustomerID = c.CustomerID
                                                                          WHERE YEAR(o.OrderDate) = 1997 AND o.ShipCountry = 'Canada'
                                                                          GROUP BY c.CompanyName");
                db.SaveChanges();

                foreach (var customer in customers)
                {
                    Console.WriteLine(customer);
                }
            }
        }

        public static void FindSalesBySpecifiedRegionAndPeriod(string region = null, string startDate = null, string endDate = null)
        {
            using (NortwindEntities db = new NortwindEntities())
            {
                DateTime startDateParsed = DateTime.Parse(startDate);
                DateTime endDateParsed = DateTime.Parse(endDate);

                var customers = db.Orders
                                                   .Where(o => (o.OrderDate > startDateParsed && o.OrderDate < endDateParsed) || o.ShipCountry == region)
                                                   .GroupBy(o => o.ShipName);
                db.SaveChanges();

                foreach (var customer in customers)
                {
                    Console.WriteLine(customer.Key);
                }
            }
        }
    }
}
