using SubscriptionEngine.Model;
using SubscriptionEngine.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubscriptionEngine.Provider
{
    public class providercustomerdetails:Iprocustomerdetails
    {
        private readonly Icustomerdetails _context;
        public providercustomerdetails(Icustomerdetails _Context)
        {
            _context = _Context;

        }

        public bool CreateCustomer(Customerdetails c)
        {
            return _context.CreateCustomer(c);
        }

        public bool Deletecustomer(string Email)
        {
            return _context.Deletecustomer(Email);
        }

        public List<Customerdetails> Getallcustomerdetails()
        {
            return _context.Getallcustomerdetails();
        }

        public Customerdetails Getcustomer(string Email)
        {
            return _context.Getcustomer(Email) ;
        }

        public string Getcustomerplan(string Email)
        {
            return _context.Getcustomerplan(Email);
        }

        public bool Updatecustomer(Customerdetails c)
        {
            return _context.Updatecustomer(c);
        }

        public bool Updatecustomerplan(Plandetails p)
        {
            return _context.Updatecustomerplan(p);
        }
    }
}
