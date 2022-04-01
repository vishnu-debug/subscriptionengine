using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SubscriptionEngine.Model;
using SubscriptionEngine.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubscriptionEngine.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SubscriptionController : ControllerBase
    {
        public readonly Iprocustomerdetails _context;
        public SubscriptionController(Iprocustomerdetails _Context)
        {
            _context = _Context;

        }

        [HttpGet]
        public IActionResult Getallcustomer()
        {
            var result = _context.Getallcustomerdetails();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Createcustomer(Customerdetails c)
        {
            var result=_context.CreateCustomer(c);
            if (result == true)
            {
                return StatusCode(StatusCodes.Status201Created);
            }
            else
                return BadRequest("server not responding");

        }
        [HttpGet("{Email}")]
        public IActionResult Getcustomer(string Email)
        {
            var result = _context.Getcustomer(Email);
            if (result == null)
            {
                return BadRequest("No user found in this email");
            }
            else
                return Ok(result);
            
        }


        [HttpDelete("{Email}")]
        public IActionResult Deletecustomer(string Email)
        {
            var result = _context.Deletecustomer(Email);
            if (result == false)
            {
                return BadRequest("No user found in this email");
            }
            return Ok();

        }


        [HttpPut]
        public IActionResult Updatecustomer(Customerdetails c)
        {
            var result = _context.Updatecustomer(c);
            if(result==false)
            {
                return BadRequest("No user found");
            }
            return Ok();

        }


        [HttpGet("{Email}")]
        public IActionResult Getcustomerplan(string Email)
        {
            var result = _context.Getcustomerplan(Email);
            if (result == null)
            {
                return BadRequest(" user not found");
            }
            else
                return Ok(result);

        }

        [HttpPut]
        public IActionResult Updatecustomerplan(Plandetails p)
        {
            var result = _context.Updatecustomerplan(p);
            if (result == false)
            {
                return BadRequest("user not found");
            }
            else
                return Ok();
        }

    }
}
