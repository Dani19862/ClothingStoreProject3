using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model;

namespace Services.Interfaces
{
    // Interfce to impliment CRUD on Orders
    public interface IOrderRepository: IDisposable
    {
        
        Task<List<OrderCustomer>> GetAllOrdersAsync();
        Task<Order> InsertNewOrderAsync( int quantity,DateTime orderdate,
                                               DateTime sendingOrder, int employee, Order.ProductCategory productCategory, double totalPrice,
                                            Dictionary<int, int> orderProduct);
        Task<Order> DeleteOrderAsync(int id, int quantity,DateTime? orderdate,
                                               DateTime? sendingOrder, int employee, Order.ProductCategory productCategory, double totalPrice,
                                              int customrtID, Dictionary<int, int> orderProduct);
      
        Task<Order> EditOrderAsync(int orderId, int quantity, DateTime orderdate,
                                                DateTime sendingOrder, int employeeId, Order.ProductCategory productCategory, double totalPrice,
                                               int customrtID, Dictionary<int, int> orderProduct);




    }
}
