using SubscriptionEngine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubscriptionEngine.Provider
{
     public interface Iprocustomerdetails
    {
        public List<Customerdetails> Getallcustomerdetails();
        public bool CreateCustomer(Customerdetails c);
        public Customerdetails Getcustomer(string Email);
        public bool Deletecustomer(string Email);
        public bool Updatecustomer(Customerdetails c);
        public string Getcustomerplan(string Email);
        public bool Updatecustomerplan(Plandetails p);
    }
}
