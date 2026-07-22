using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Online.Modules.Garage.Models
{
    public class CustomerModel
    {
        public int CustomerId { get; set; }

        public string Code { get; set; } = "";

        public string Name { get; set; } = "";

        public string Phone { get; set; } = "";
    }
}
