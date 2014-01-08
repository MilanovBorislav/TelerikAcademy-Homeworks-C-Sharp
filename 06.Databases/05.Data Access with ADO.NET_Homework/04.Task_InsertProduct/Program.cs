using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Task_InsertProduct
{
    class Program
    {
        public static void AddProduct(
            string productName, int suplierId, int categoryId,
            string QuantityPerUnit, decimal UnitPrice, int UnitsInStock,
            int UnitsOnOrder, int ReorderLevel)
        {
            SqlConnection connect = new SqlConnection(connection.Default.dbConnectionStr);
            connect.Open();
            using (connect)
            {
                SqlCommand cmdInsertProduct = new SqlCommand(
                        @"
                          INSERT INTO Products(ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder,ReorderLevel,Discontinued)
                          VALUES(@ProductName,@SupplierID,@CategoryID,@QuantityPerUnit,@UnitPrice,@UnitsInStock,@UnitsOnOrder,@ReorderLevel,@Discontinued)
                        "
                ,connect);
                cmdInsertProduct.Parameters.AddWithValue("@ProductName", productName);
                cmdInsertProduct.Parameters.AddWithValue("@SupplierID", suplierId);
                cmdInsertProduct.Parameters.AddWithValue("@CategoryID", categoryId);
                cmdInsertProduct.Parameters.AddWithValue("@QuantityPerUnit", QuantityPerUnit);
                cmdInsertProduct.Parameters.AddWithValue("@UnitPrice", UnitPrice);
                cmdInsertProduct.Parameters.AddWithValue("@UnitsInStock", UnitsInStock);
                cmdInsertProduct.Parameters.AddWithValue("@UnitsOnOrder", UnitsOnOrder);
                cmdInsertProduct.Parameters.AddWithValue("@ReorderLevel", ReorderLevel);
                cmdInsertProduct.Parameters.AddWithValue("@Discontinued", 0 );
                cmdInsertProduct.ExecuteNonQuery();
            }
        }

        static void Main(string[] args)
        {
            //AddProduct("Product", 1, 2, "fsdklfjasdl", 15, 0, 39, 0);
            //AddProduct("Test", 1, 2, "Test", 15, 0, 39, 0);
        }
    }
}
