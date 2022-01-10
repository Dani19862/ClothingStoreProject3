using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Product
    {
        [Key, Required]
        public int ProductID { get; set; }
        [Required, Column("Product Type")]
        public string ProductType { get; set; }
        [Required, Column("Quanitity In Inventory")]
        public int QuanitityInInventory { get; set; }

        [Required]
        public string Color { get;  set; }
        [Required, Column("Unit Price")]
        public double UnitPrice { get; set; }

        public enum ProductSize
        {
            XS =0,
            S =1,
            M =2,
            L =3,
            XL =4,
            XXL =5
        };
        [Required]
        public ProductSize Size { get; set; }

    }
}

