using SubscriptionEngine.Data;
using SubscriptionEngine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubscriptionEngine.Repo
{
    public class Customerrepo : Icustomerdetails
    {
        private readonly Datacontext _context;
        public Customerrepo(Datacontext _Context)
        {
            _context = _Context;

        }
        public bool CreateCustomer(Customerdetails c)
        {
            try
            {
                _context.Customerdetails.Add(c);
                _context.SaveChanges();

                //add basic plan for customer defaultly
                Plandetails p = new Plandetails();
                p.Email = c.Email;
                p.Plan = "Basic";
                _context.Plandetails.Add(p);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }




        }

        public bool Deletecustomer(string Email)
        {
            Customerdetails b = _context.Customerdetails.FirstOrDefault(c => c.Email == Email);
            if(b==null)
            {
                return false;
            }
            _context.Customerdetails.Remove(b);
            _context.SaveChanges();
            return true;

           
        }

        public List<Customerdetails> Getallcustomerdetails()
        {
            return _context.Customerdetails.ToList();
        }

        public Customerdetails Getcustomer(string Email)
        {
            Customerdetails b = _context.Customerdetails.FirstOrDefault(b => b.Email == Email);
            if(b==null)
            {
                return null;
            }
            return b;
            
        }

        public string Getcustomerplan(string Email)
        {
            Plandetails e = _context.Plandetails.FirstOrDefault(a => a.Email == Email);
            if(e==null)
            {
                return null;
            }
            return e.Plan;

           
        }

        public bool Updatecustomer(Customerdetails c)
        {

            Customerdetails e = _context.Customerdetails.FirstOrDefault(f => f.Email ==c.Email);
            if(e==null)
            {
                return false;
            }
            e.MobileNumber = c.MobileNumber;
            e.Name = c.Name;
            _context.Customerdetails.Update(e);
            _context.SaveChanges();
            return true;
            
        }
        public bool Updatecustomerplan(Plandetails p)
        {
            Plandetails e = _context.Plandetails.FirstOrDefault(f => f.Email ==p.Email);
            if(e==null)
            {
                return false;
            }
            e.Plan = p.Plan;
            _context.Plandetails.Update(e);
            _context.SaveChanges();
            return true;

        }
    }
}
