using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class OrderCustomer
    {
        public int OrderID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime SendeingOrderDate { get; set; }
        public int CustomerID { get; set; }


        [Column("Quntity Product")]
        public int Quantity { get; set; }

        public double TotalPrice { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }
        public string City { get; set; }
        public int No_House { get; set; }
        public int PostalCode { get; set; }
        public enum ProductCategory
        {
            Men,
            Women,
            Children
        }
        public string PhoneNumber { get; set; }

        public Dictionary<int, int> ProductsQuantity { get; set; } = new Dictionary<int, int>();


    }
}
