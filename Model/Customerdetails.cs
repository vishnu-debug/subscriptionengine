using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SubscriptionEngine.Model
{
    public class Customerdetails
    {
        [Key]
        public int ID { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public string Name { get; set; }

    }
}
