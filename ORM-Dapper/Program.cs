using System;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;
using Org.BouncyCastle.Security;

namespace ORM_Dapper
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Configuration
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            
            string connString = config.GetConnectionString("DefaultConnection");
            //Console.WriteLine(connString);
            #endregion

            IDbConnection conn = new MySqlConnection(connString);

            #region Exercise 1
            //    DapperDepartmentRepository repo = new DapperDepartmentRepository(conn);

            //    Console.WriteLine("Hello user. Here are the current departments.");
            //    Console.WriteLine("Please press enter . . .");
            //    Console.ReadLine();

            //    var depos = repo.GetAllDepartments();
            //    Print(depos);

            //    Console.WriteLine("Do you want to add a department? (Yes or No)");
            //    string userResponse = Console.ReadLine();

            //    if (userResponse.ToLower() == "yes")
            //    {
            //        Console.WriteLine("What is the name of your new department?");
            //        userResponse = Console.ReadLine();

            //        repo.InsertDepartment(userResponse);
            //        Print(repo.GetAllDepartments());
            //    }

            //    Console.WriteLine("Thank you. Have a great day.");
            //}

            //private static void Print(IEnumerable<Department> depos)
            //{
            //    foreach (var depo in depos)
            //    {
            //        Console.WriteLine($"ID: {depo.DepartmentID} Name: {depo.Name}");
            //    }
            #endregion

            #region Exercise 2
            //DapperProductRepository repo = new DapperProductRepository(conn);

            //repo.CreateProduct("HP", 1350, 1);

            //var products = repo.GetAllProducts();

            //foreach (var product in products)
            //{
            //    Console.WriteLine($"{product.ProductID} {product.Name} {product.Price} {product.CategoryID}");
            //}
            #endregion

            #region Bonus
            //DapperProductRepository repo = new DapperProductRepository(conn);

            //repo.UpdateProductName(4, "Mac");

            //var products = repo.GetAllProducts();

            //foreach (var product in products)
            //{
            //    Console.WriteLine($"{product.ProductID} {product.Name} {product.Price} {product.CategoryID}");
            //}
            #endregion

            #region Extra Bonus
            //DapperProductRepository repo = new DapperProductRepository(conn);

            //repo.DeleteProduct(950);

            //var products = repo.GetAllProducts();

            //foreach (var product in products)
            //{
            //    Console.WriteLine($"{product.ProductID} {product.Name} {product.Price} {product.CategoryID}");
            //}
            #endregion
        }
    }
}
