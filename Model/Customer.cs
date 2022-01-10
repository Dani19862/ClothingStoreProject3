using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsFormsApp1.Model
{
   
    public class Customer
    {
        private string fullName;
       
        [Key]
        public int CustomerID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        [NotMapped]
        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public string Address { get; set; }
        public string City { get; set; }
        public int No_House { get; set; }
        public int PostalCode { get; set; }
        public string PhoneNumber { get; set; }

        [ForeignKey("OrderID")]
        public int OrderID { get; set; }


        
    }
}
