using Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IProductRepository : IDisposable
    {
        
       
        Task<Product> InsertNewProductAsync(string productType, string color, Product.ProductSize productSize, int quntityInInventory, double unitPrice);
        Task<Product> DeleteProdcutAsync(int productid, string productType, string color, Product.ProductSize productSize, int quntityInInventory, double unitPrice);
        Product EditProduct(int productid, string productType, string color, Product.ProductSize productSize, int quntityInInventory, double unitPrice);


    }
}
