using Microsoft.EntityFrameworkCore;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DataAccssesLayer;
using WindowsFormsApp1.Model;

namespace Services
{
    public class CustomerRepositorySingelton : ICustomerRepository, IDisposable
    {
        readonly private ClothingStoreDB  db = new ClothingStoreDB();
        private bool disposed = false;

        //Singleton Implemntion
        private static CustomerRepositorySingelton instance;
        private CustomerRepositorySingelton()
        {

        }
        public static CustomerRepositorySingelton GetSingelton()
        {
            if (instance == null)
            {
                instance = new CustomerRepositorySingelton();
            }
            return instance;
        }
      

        // Add new Customer  
        public async Task<Customer> InsertNewCustomerAsync(int orderId, string firstName, string lastName, string address,
                                             string city, int noHouse, int postalCode, string phoneNumber)
        {
            var newCustomer = new Customer()
            {
                
                OrderID = orderId,
                FirstName = firstName,
                LastName = lastName,
                Address = address,
                City = city,
                No_House = noHouse,
                PostalCode = postalCode,
                PhoneNumber = phoneNumber
                 
            };
            await db.Customers.AddAsync(newCustomer);
            await db.SaveChangesAsync();
            return newCustomer;
        }

        // Delete Record

        public async Task<Customer> DeleteCustomerAsync(int customerId, string firstName, string lastName, string address,
                                             string city, int noHouse, int postalCode, string phoneNumber)
        {
            var customer = db.Customers.Where(c => c.CustomerID == customerId).FirstOrDefault();
           
            db.Customers.Remove(customer);
            await db.SaveChangesAsync();
            return customer;

        }


        //Edit Customer Details
        public async Task<Customer> EditCustomerAsync(int customerId, string firstName, string lastName, string address,
                                             string city, int noHouse, int postalCode, string phoneNumber, int orderId)
        {
            Customer customer = db.Customers.Where(c => c.CustomerID == customerId).FirstOrDefault();
            customer.Address = address;
            customer.City = city;
            customer.CustomerID = customerId;
            customer.FirstName = firstName;
            customer.LastName = lastName;
            customer.No_House = noHouse;
            customer.PostalCode = postalCode;
            customer.PhoneNumber = phoneNumber;
            customer.OrderID = orderId;

            await db.SaveChangesAsync();
            return customer;
        }

        //update Details  // למחוק
        public async Task<Customer> UpdateCustomerAsync(int id, string firstName, string lastName, string address,
                                             string city, int noHouse, int postalCode, string phoneNumber)
        {
            var updateCustomer = new Customer()
            {
                CustomerID = id,
                FirstName = firstName,
                LastName = lastName,
                Address = address,
                City = city,
                No_House = noHouse,
                PostalCode = postalCode,
                PhoneNumber = phoneNumber
            };

            var entityEntry = db.Update(updateCustomer);
            db.Entry(updateCustomer).State = EntityState.Modified;
            await db.SaveChangesAsync();
            return updateCustomer;

       
        }
       
        // Get All Records
        public List<Customer> GetAllCustomersAsync()
        {
            
            var customerList = db.Customers.Select(x => x)
                .Include(o => o)
                .ToList();
            return customerList;
        }

        // Sort By ID Customer
        
        public async Task<Customer> SortByIDCustomer(int idcustomer)
        {
           
            var sortIdCus = db.Customers.Where(c => c.CustomerID == idcustomer).FirstOrDefaultAsync();
            return await sortIdCus;
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

