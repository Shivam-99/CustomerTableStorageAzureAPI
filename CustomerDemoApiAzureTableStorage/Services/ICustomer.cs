using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerDemoApiAzureTableStorage.Models;

namespace CustomerDemoApiAzureTableStorage.Services
{
    interface ICustomer
    {
        IEnumerable<CustomerEntity> GetAllCustomers();
        void InsertCustomer(Customer c);
    }
}
