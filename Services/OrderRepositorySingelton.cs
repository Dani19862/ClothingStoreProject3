using Microsoft.EntityFrameworkCore;
using Model;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WindowsFormsApp1.DataAccssesLayer;
using WindowsFormsApp1.Model;



namespace Services
{
    public class OrderRepositorySingelton : IOrderRepository, IDisposable
    {

        readonly private ClothingStoreDB db = new ClothingStoreDB();
        private bool disposed = false;
        private static OrderRepositorySingelton instance;
       
        //Singelton implementaion
        private OrderRepositorySingelton()
        {
           
        }
        public static OrderRepositorySingelton GetSingelton()
        {
            if (instance == null)
            {
                instance = new OrderRepositorySingelton();
            }
            return instance;
        }


       
        //Add record  
        public async Task<Order> InsertNewOrderAsync( int quantity, DateTime orderdate,
                                               DateTime sendingOrder, int employee, Order.ProductCategory productCategory, double totalPrice,
                                            Dictionary<int, int> orderProduct)
        {
            var customerId = GetMaXCustomerId();
            var newOrder = new Order()
            {
                Category = productCategory,
                EmployeeID = employee,
                Quantity = quantity,
                OrderDate = orderdate,
                SendeingOrderDate = sendingOrder,
                TotalPrice = totalPrice,
                CustomerID = customerId,
                ProductsQuantity = orderProduct

            };
            await db.Orders.AddAsync(newOrder);

            // Checks if the product is in inventory and updates accordingly
            foreach (var item in orderProduct)
            {
                var a = db.Products.Where(o => o.ProductID == item.Key).FirstOrDefault();
                a.QuanitityInInventory -= item.Value;

                if (a.QuanitityInInventory <= 0)
                {
                    return null;
                }
            }
            await db.SaveChangesAsync();
            return newOrder;


        }

        // Delete Record
        public async Task<Order> DeleteOrderAsync(int id, int quantity, DateTime? orderdate,
                                               DateTime? sendingOrder, int employee, Order.ProductCategory productCategory, double totalPrice,
                                              int customrtID, Dictionary<int, int> orderProduct)
        {
            var deleteOrder = new Order()
            {
                Category = productCategory,
                OrderID = id,
                EmployeeID = employee,
                Quantity = quantity,
                OrderDate = orderdate.Value,
                SendeingOrderDate = sendingOrder.Value,
                TotalPrice = totalPrice,
                CustomerID = customrtID,
                ProductsQuantity = orderProduct

            };
            db.Orders.Remove(deleteOrder);
            await db.SaveChangesAsync();
            return deleteOrder;


        }

        //get max id from orders table 
        public int GetMaxIdFromOrders()
        {
            return db.Orders.OrderByDescending(o => o.OrderID).FirstOrDefault().OrderID;
        }

        //get max customer Id

        public int GetMaXCustomerId()
        {
            var maxIdCust = db.Customers.OrderByDescending(c => c.CustomerID).FirstOrDefault().CustomerID;
            var b= maxIdCust + 1;
            return b;
        }

        // Edit Record

        public async Task<Order> EditOrderAsync(int orderId, int quantity, DateTime orderdate,
                                               DateTime sendingOrder, int employeeId, Order.ProductCategory productCategory, double totalPrice,
                                              int customrtID, Dictionary<int, int> orderProduct)
        {
            Order order = db.Orders.Where(o => o.OrderID == orderId).FirstOrDefault();
            order.Category = productCategory;
            order.CustomerID = customrtID;
            order.EmployeeID = employeeId;
            order.OrderDate = orderdate;
            order.SendeingOrderDate = sendingOrder;
            order.Quantity = quantity;
            order.TotalPrice = totalPrice;
            order.ProductsQuantity = orderProduct;

            await db.SaveChangesAsync();
            return order;
        }




        // Get The most Sales By User
        public List<UserOrder> GetUserWithMaxSells()
        {
            var a = (from o in db.Orders
                     join c in db.Users on o.EmployeeID equals c.UserID
                     select new
                     {
                         EmployeeID = o.EmployeeID,
                         Quantity = o.Quantity,
                         TotalPrice = o.TotalPrice,
                         UserName = c.UserName

                     }).ToList();

            var a2 = a.GroupBy(x => new { x.UserName, x.EmployeeID }).OrderByDescending(o => o.Count()).Select(o => new UserOrder
            {
                UserName = o.Key.UserName,
                EmployeeId = o.Key.EmployeeID,
                TotalPrice = o.Sum(c => c.TotalPrice),
                Quantity = o.Sum(q=>q.Quantity)

            });
            return a2.ToList();
        }

        //Get All Records
        public async Task <List<OrderCustomer>> GetAllOrdersAsync()
        {

            var a = (from o in db.Orders
                     join c in db.Customers on o.CustomerID equals c.CustomerID
                    
                     select new OrderCustomer()
                     {
                         OrderID = o.OrderID,
                         CustomerID = o.CustomerID,
                         EmployeeID = o.EmployeeID,
                         OrderDate = o.OrderDate,
                         Quantity = o.Quantity,
                         TotalPrice = o.TotalPrice,
                         SendeingOrderDate = o.SendeingOrderDate,
                         FirstName = c.FirstName,
                         LastName = c.LastName,
                         Address = c.Address,
                         City = c.City,
                         No_House = c.No_House,
                         PhoneNumber = c.PhoneNumber,
                         PostalCode = c.PostalCode,
                         ProductsQuantity = o.ProductsQuantity,
                                                     

                     }).ToListAsync();

            return await a;
        }

        // sort rows by OrderId 
        public static List<Order> SortByOrderIDAsync(int id)
        {
            var db = new ClothingStoreDB();

            var sortByIDOrder = db.Orders
                .Where(o => o.OrderID == id);
            return sortByIDOrder.ToList();

        }
        // sort rows by EmployeeID
        public static List<Order> SortByEmployeeID(int emID)
        {
            var db = new ClothingStoreDB();

            var sortByEmployee = db.Orders
                .Where(o => o.EmployeeID == emID);
            return sortByEmployee.ToList();

        }


        // sort rows by CustomerID
        public static List<Order> SortByCustomerID(int custID)
        {
            var db = new ClothingStoreDB();

            var sortByCustomer = db.Orders.
                Where(o => o.CustomerID == custID);
            return sortByCustomer.ToList();
        }

        //sort rows by Category
        public static List<Order> SortByCategory(Order.ProductCategory category)
        {
            var db = new ClothingStoreDB();

            var sortByIDOrder = db.Orders
                .Where(o => o.Category == category);
            return sortByIDOrder.ToList();
        }


        // sort rows by date to date 
        public static List<Order> OrderByDate(DateTime fromDate, DateTime toDate)
        {
            var db = new ClothingStoreDB();

            var sortDate = db.Orders
                .Where(o => o.OrderDate >= fromDate && o.OrderDate <= toDate);

            return sortDate.ToList();
        }

        // sort rows by Quantity
        public static List<Order> SortByQuantity(int quntity)
        {
            var db = new ClothingStoreDB();

            var quntSort = db.Orders
                .Where(o => o.Quantity == quntity);
            return quntSort.ToList();
        }

        //Sort By Total Price
        public static List<Order> FromTotalPrice(double fromPrice, double toTprice)
        {
            var db = new ClothingStoreDB();

            var sortPrice = db.Orders
                .Where(o => o.TotalPrice >= fromPrice && o.TotalPrice < toTprice);
            if (sortPrice == null)
            {
                return null;
            }
            return sortPrice.ToList();

        }
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }
        void IDisposable.Dispose()
        {

            Dispose(true);
            GC.SuppressFinalize(this);
        }


    }


}
