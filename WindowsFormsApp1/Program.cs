using System;
using System.Windows.Forms;
using WindowsFormsApp1.DataAccssesLayer;
using WindowsFormsApp1.Views;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Models;
using static Models.User;
using WindowsFormsApp1.Model;
using static Model.OrderCustomer;
using System.Collections.Generic;
using Model;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //DataSeeding();
            Isexist();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginScreen());
            
        }
        public static bool Isexist()
        {
            try
            {
                using (var context = new ClothingStoreDB())
                {
                    if (!context.Database.CanConnect())
                    {
                        context.Database.Migrate();
                        DataSeeding();

                    }
                    return true;
                }

            }
            catch (Exception ex)
            {
                string.Format(ex.Message);
                return false;
            }
        }

        // Data seeding for Preliminary initial data to database
        public static void DataSeeding()
        {
            using (var dbcontext = new ClothingStoreDB()) // add 8 users 10 Orders  10 customers  12 products 
            {
                if (dbcontext.Users.Any() && dbcontext.Orders.Any() && dbcontext.Products.Any() && dbcontext.Customers.Any())
                {
                    return;
                }

                var user1 = new User { UserType = EnumUserType.Director, Password = "Avi123", UserName = "AviCohen", Email = "Avi12@gmail.com" };
                var user2 = new User { UserType = EnumUserType.Director, Password = "dani321", UserName = "DanLevi", Email = "Daniel33@gmail.com" };
                var user3 = new User { UserType = EnumUserType.Official, Password = "R966655", UserName = "RubiKats", Email = "Rubi664@gmail.com" };
                var user4 = new User { UserType = EnumUserType.Director, Password = "Yo123456", UserName = "YossiLam", Email = "Yolam12@gamil.com" };
                var user5 = new User { UserType = EnumUserType.Official, Password = "S123963", UserName = "MeirTwito", Email = "Meirt20@gamil.com" };
                var user6 = new User { UserType = EnumUserType.Official, Password = "EliSi102", UserName = "SimaEliam", Email = "Sima102@gamil.com" };
                var user7 = new User { UserType = EnumUserType.Official, Password = "NoBar9876", UserName = "NoamBarLev", Email = "Noambl321@gamil.com" };
                var user8 = new User { UserType = EnumUserType.Official, Password = "Tami5466", UserName = "TamarEli", Email = "Tami525@gamil.com" };
                dbcontext.AddRange(user1,user2,user3,user4,user5,user6,user6,user7,user8);
                dbcontext.SaveChanges();

                var order1 = new Order { EmployeeID = user1.UserID, OrderDate = new DateTime(2021, 11, 15), SendeingOrderDate = new DateTime(2021, 11, 24), CustomerID = 1, Category = Order.ProductCategory.Men , TotalPrice = 125, Quantity = 5, ProductsQuantity = new Dictionary<int, int>() { { 4, 5 } } };
                var order2 = new Order { EmployeeID = user2.UserID, OrderDate = new DateTime(2021, 11, 17), SendeingOrderDate = new DateTime(2021, 11, 20), CustomerID = 2, Category = Order.ProductCategory.Men, TotalPrice = 175, Quantity = 4, ProductsQuantity = new Dictionary<int, int>() { { 3, 1 }, { 7, 1 }, { 1, 2 } } };
                var order3 = new Order { EmployeeID = user3.UserID, OrderDate = new DateTime(2021, 11, 13), SendeingOrderDate = new DateTime(2021, 11, 18), CustomerID = 3, Category = Order.ProductCategory.Women, TotalPrice = 80, Quantity = 1, ProductsQuantity = new Dictionary<int, int>() { { 2, 1 } } };
                var order4 = new Order { EmployeeID = user4.UserID, OrderDate = new DateTime(2021, 11, 19), SendeingOrderDate = new DateTime(2021, 11, 23), CustomerID = 4, Category = Order.ProductCategory.Children, TotalPrice = 100, Quantity = 3, ProductsQuantity = new Dictionary<int, int>() { { 4, 1 }, { 1, 2 } } };
                var order5 = new Order { EmployeeID = user4.UserID, OrderDate = new DateTime(2021, 11, 15), SendeingOrderDate = new DateTime(2021, 11, 20), CustomerID = 5, Category = Order.ProductCategory.Men, TotalPrice = 350, Quantity = 6, ProductsQuantity = new Dictionary<int, int>() { { 5, 3 } } };
                var order6 = new Order { EmployeeID = user5.UserID, OrderDate = new DateTime(2021, 11, 21), SendeingOrderDate = new DateTime(2021, 11, 26), CustomerID = 6, Category = Order.ProductCategory.Men, TotalPrice = 195, Quantity = 4, ProductsQuantity = new Dictionary<int, int>() { { 6, 2 }, { 2, 1 }, { 8, 1 } } };
                var order7 = new Order { EmployeeID = user6.UserID, OrderDate = new DateTime(2021, 12, 10), SendeingOrderDate = new DateTime(2021, 12, 15), CustomerID = 7, Category = Order.ProductCategory.Men, TotalPrice = 25, Quantity = 1, ProductsQuantity = new Dictionary<int, int>() { { 7, 1 } } };
                var order8 = new Order { EmployeeID = user7.UserID, OrderDate = new DateTime(2021, 12, 01), SendeingOrderDate = new DateTime(2021, 12, 05), CustomerID = 8, Category = Order.ProductCategory.Women, TotalPrice = 100, Quantity = 2, ProductsQuantity = new Dictionary<int, int>() { { 8, 2 } } };
                var order9 = new Order { EmployeeID = user8.UserID, OrderDate = new DateTime(2021, 12, 15), SendeingOrderDate = new DateTime(2021, 12, 18), CustomerID = 9, Category = Order.ProductCategory.Men, TotalPrice = 125, Quantity = 3, ProductsQuantity = new Dictionary<int, int>() { { 9, 2 }, { 10, 1 } } };
                var order10 = new Order { EmployeeID = user1.UserID, OrderDate = new DateTime(2021, 12, 13), SendeingOrderDate = new DateTime(2021, 12, 17), CustomerID = 10, Category = Order.ProductCategory.Children, TotalPrice = 135, Quantity = 5, ProductsQuantity = new Dictionary<int, int>() { { 10, 1 }, { 2, 1 }, { 6, 2 }, { 12, 1 } } };
                dbcontext.AddRange(order1, order2, order3, order4, order5, order6, order7, order8, order9, order10);
                dbcontext.SaveChanges();

                var customer1 = new Customer() { OrderID = order1.OrderID, City = "Tel Aviv", Address = "David Ha Melech", No_House = 23, FirstName = "Shimon", LastName = "Lam", PostalCode = 426349, PhoneNumber = "0580124556", FullName = "Shimon Lam", };
                var customer2 = new Customer() { OrderID = order2.OrderID, City = "Haifa", Address = "Machal", No_House = 10, FirstName = "Meny", LastName = "Yaakov", PostalCode = 46331, PhoneNumber = "0580124556", FullName = "Meny Yaacov", };
                var customer4 = new Customer() { OrderID = order3.OrderID, City = "Rehovot", Address = "Moshe Sharet", No_House = 8, FirstName = "Nimrod", LastName = "Eshel", PostalCode = 165996, PhoneNumber = "0506475669", FullName = "Nimrod Eshel", };
                var customer3 = new Customer() { OrderID = order4.OrderID, City = "Ashkelon", Address = "Herzel", No_House = 99, FirstName = "Avihai", LastName = "Zaken", PostalCode = 96485, PhoneNumber = "0549634834", FullName = "Avihai Zaken", };
                var customer5 = new Customer() { OrderID = order5.OrderID, City = "bat Yam", Address = "Lisin", No_House = 45, FirstName = "Mazal", LastName = "Cohen", PostalCode = 752664, PhoneNumber = "0569663122", FullName = "Mazal Cohen", };
                var customer6 = new Customer() { OrderID = order6.OrderID, City = "Ako", Address = "Arlozorov", No_House = 102, FirstName = "Maayan", LastName = "Levy", PostalCode = 166948, PhoneNumber = "0506485202", FullName = "Maayan Levy", };
                var customer7 = new Customer() { OrderID = order7.OrderID, City = "Yafo", Address = "Rabbi Akiva", No_House = 80, FirstName = "Moti", LastName = "Ganot", PostalCode = 648557, PhoneNumber = "0580124556", FullName = "Moti Ganot", };
                var customer8 = new Customer() { OrderID = order8.OrderID, City = "Jerusalem", Address = "Yefet", No_House = 17, FirstName = "Meital", LastName = "Selinger", PostalCode = 963146, PhoneNumber = "0549648556", FullName = "Meital Selinger", };
                var customer9 = new Customer() { OrderID = order9.OrderID, City = "Nahariya", Address = "Ha Melech", No_House = 55, FirstName = "Marina", LastName = "Perlov", PostalCode = 233364, PhoneNumber = "059663486", FullName = "Marina Perlov", };
                var customer10 = new Customer() { OrderID = order10.OrderID, City = "Eilat", Address = "Vizman", No_House = 94, FirstName = "Ben", LastName = "Haim", PostalCode = 780036, PhoneNumber = "0503697455", FullName = "Ben Haim", };
                dbcontext.AddRange(customer1, customer2, customer3, customer4, customer5, customer6, customer7, customer8, customer9, customer10);
                dbcontext.SaveChanges();


                var product1 = new Product() { ProductType = "TShirt", Color = "Black", Size = Product.ProductSize.M, QuanitityInInventory = 350, UnitPrice = 25 };
                var product2 = new Product() {ProductType = "Jacket", Color = "Blue", Size = Product.ProductSize.S, QuanitityInInventory = 100, UnitPrice = 80 };
                var product3 = new Product() { ProductType = "Hat", Color = "Red", Size = Product.ProductSize.L, QuanitityInInventory = 155, UnitPrice = 100 };
                var product4 = new Product() {ProductType = "LongShirt", Color = "white", Size = Product.ProductSize.XXL, QuanitityInInventory = 300, UnitPrice = 50 };
                var product5 = new Product() {ProductType = "Coat", Color = "Yellow", Size = Product.ProductSize.M, QuanitityInInventory = 98, UnitPrice = 150 };
                var product6 = new Product() {ProductType = "LongPants", Color = "Black", Size = Product.ProductSize.M, QuanitityInInventory = 115, UnitPrice = 60 };
                var product7 = new Product() { ProductType = "TShirt", Color = "Gray", Size = Product.ProductSize.XS, QuanitityInInventory = 221, UnitPrice = 25 };
                var product8 = new Product() { ProductType = "LongShirt", Color = "Black", Size = Product.ProductSize.XXL, QuanitityInInventory = 110, UnitPrice = 50 };
                var product9 = new Product() {ProductType = "Dress", Color = "Pink", Size = Product.ProductSize.XL, QuanitityInInventory = 158, UnitPrice = 100 };
                var product10 = new Product() { ProductType = "TShirt", Color = "Black", Size = Product.ProductSize.L, QuanitityInInventory = 9, UnitPrice = 25 };
                var product11 = new Product() {ProductType = "Hat", Color = "Yellow", Size = Product.ProductSize.S, QuanitityInInventory = 88, UnitPrice = 100 };
                var product12 = new Product() {ProductType = "TShirt", Color = "Blue", Size = Product.ProductSize.XS, QuanitityInInventory = 321, UnitPrice = 25 };
                dbcontext.AddRange(product1, product2, product3, product4, product5, product6, product7, product8, product9, product10, product11, product12);
                dbcontext.SaveChanges();

               


            }
           


            

        }
        
           

    }
}













