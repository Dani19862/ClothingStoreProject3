using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class UserOrder
    {
        public  int EmployeeId { get; set; }

        public  string UserName { get; set; }

        public  int Quantity { get; set; }

        public double TotalPrice { get; set; }
    }
}
