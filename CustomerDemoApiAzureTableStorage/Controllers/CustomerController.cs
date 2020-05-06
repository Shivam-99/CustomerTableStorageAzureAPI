using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerDemoApiAzureTableStorage.Models;
using CustomerDemoApiAzureTableStorage.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerDemoApiAzureTableStorage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        ICustomer customer = new CustomerTableStorageDbHandler();

        // GET: api/Customer
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return customer.GetAllCustomers();
        }

        // POST: api/Customer
        [HttpPost]
        public void Post(Customer c)
        {
            customer.InsertCustomer(c);
        }
    }
}
