using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model;

namespace Services.Interfaces
{
    // Interfce to impliment CRUD on Customers 
    public interface ICustomerRepository
    {
        Task<Customer> InsertNewCustomerAsync(int orderId, string firstName, string lastName, string address,
                                              string city, int noHouse, int postalCode, string phoneNumber);
        Task<Customer> DeleteCustomerAsync(int id, string firstName, string lastName, string address,
                                             string city, int noHouse, int postalCode, string phoneNumber);

        Task<Customer> EditCustomerAsync(int customerId, string firstName, string lastName, string address,
                                             string city, int noHouse, int postalCode, string phoneNumber, int orderId);
      
    }
}
