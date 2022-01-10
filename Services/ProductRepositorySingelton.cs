using Model;
using Services.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DataAccssesLayer;
using WindowsFormsApp1.Model;

namespace Services
{
    public class ProductRepositorySingelton : IProductRepository, IDisposable
    {

        private bool disposed = false;
        readonly private ClothingStoreDB db = new ClothingStoreDB();
         private static ProductRepositorySingelton instance;

        // Singelton Implemention
        private ProductRepositorySingelton()
        {

        }
        public static ProductRepositorySingelton GetSingelton()
        {
            if (instance == null)
            {
                instance = new ProductRepositorySingelton();
            }
            return instance;
        }

        // To Add New Product To Inventory
        public async Task<Product> InsertNewProductAsync(string productType, string color, Product.ProductSize productSize, int quntityInInventory, double unitPrice)
        {
            var newProduct = new Product()
            {
                ProductType = productType,
                Color = color,
                QuanitityInInventory = quntityInInventory,
                Size = productSize,
                UnitPrice = unitPrice
                
            };
            await db.Products.AddAsync(newProduct);
            await db.SaveChangesAsync();
            return newProduct;
        }

        // To Delete Product
        public async Task<Product> DeleteProdcutAsync(int prodctId, string productType, string color, Product.ProductSize productSize, int quntityInInventory, double unitPrice)
        {

            var deleteProductr = new Product()
            {
                ProductID = prodctId,
                ProductType = productType,
                Color = color,
                QuanitityInInventory = quntityInInventory,
                Size = productSize,
                UnitPrice = unitPrice
                
            };
            db.Products.Remove(deleteProductr);
            await db.SaveChangesAsync();
            return deleteProductr;

        }

        // Edit Product Detalis

        public Product EditProduct(int productid, string productType, string color, Product.ProductSize productSize, int quntityInInventory, double unitPrice)
        {
            Product product = db.Products.Where(p => p.ProductID == productid).FirstOrDefault();
            product.ProductType = productType;
            product.QuanitityInInventory = quntityInInventory;
            product.Size = productSize;
            product.Color = color;
            product.UnitPrice = unitPrice;

             db.SaveChanges();
            return product;
        }

        ////To Get All Product List
        //public List<Product> GetAllProducts()
        //{
        //    var allProducts = db.Products.Select(p => p).ToList();
        //    return allProducts;
            
        //}

        // Get Details Product By IdOrder
        public List<Product> GetProductById(int orderId)
        {
            var order = db.Orders.Where(o => o.OrderID == orderId).FirstOrDefault();
            List<int> list = new List<int>();
            foreach (var item in order.ProductsQuantity)
            {
                list.Add(item.Key);
            }

            var p = db.Products.Where(b =>list.Contains(b.ProductID));
            return p.ToList();
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
