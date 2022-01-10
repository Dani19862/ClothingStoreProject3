using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class Order
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Required]
        public int OrderID { get; set; }
        public int EmployeeID { get; set; }
        [Column("Order Date")]
        public DateTime OrderDate { get; set; }
        [Column("Sending Order Date")]
        public DateTime SendeingOrderDate { get; set; }

        public int CustomerID { get; set; }
        [NotMapped]
        public Customer Customer { get; set; }

        /// <summary>
        /// Represent the total number Product in each order
        /// </summary>
        [Column("Quantity Products")]
        public int Quantity { get; set; }

        public double TotalPrice { get; set; }
        public enum ProductCategory
        {
            Men =0,
            Women=1,
            Children=2
        }
        public ProductCategory Category { get; set; }

        /// <summary>
        /// Represent the relationship between orderd and products.
        /// stord as Json in the Database.
        /// instead of onather table.
        /// </summary>
        public Dictionary<int, int> ProductsQuantity { get; set; } = new Dictionary<int, int>();

    }

}
